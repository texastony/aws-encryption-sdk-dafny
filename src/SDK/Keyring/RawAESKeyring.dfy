include "../../StandardLibrary/StandardLibrary.dfy"
include "../../StandardLibrary/UInt.dfy"
include "../AlgorithmSuite.dfy"
include "./Defs.dfy"
include "../../Crypto/EncryptionSuites.dfy"
include "../../Crypto/Random.dfy"
include "../../Crypto/AESEncryption.dfy"
include "../Materials.dfy"
include "../../Util/UTF8.dfy"

module RawAESKeyring{
  import opened StandardLibrary
  import opened UInt = StandardLibrary.UInt
  import AESEncryption
  import EncryptionSuites
  import AlgorithmSuite
  import Random
  import KeyringDefs
  import Mat = Materials
  import UTF8

  const AUTH_TAG_LEN_LEN := 4;
  const IV_LEN_LEN       := 4;
  const VALID_ALGORITHMS := {EncryptionSuites.AES_GCM_128, EncryptionSuites.AES_GCM_192, EncryptionSuites.AES_GCM_256}

  class RawAESKeyring extends KeyringDefs.Keyring {
    const keyNamespace: UTF8.ValidUTF8Bytes
    const keyName: UTF8.ValidUTF8Bytes
    const wrappingKey: seq<uint8>
    const wrappingAlgorithm: EncryptionSuites.EncryptionSuite

    predicate Valid() reads this {
        Repr == {this} &&
        |wrappingKey| == wrappingAlgorithm.keyLen as int &&
        wrappingAlgorithm in VALID_ALGORITHMS &&
        wrappingAlgorithm.Valid()
    }

    constructor(namespace: UTF8.ValidUTF8Bytes, name: UTF8.ValidUTF8Bytes, key: seq<uint8>, wrappingAlg: EncryptionSuites.EncryptionSuite)
      requires wrappingAlg in VALID_ALGORITHMS
      requires wrappingAlg.Valid()
      requires |key| == wrappingAlg.keyLen as int
      ensures keyNamespace == namespace
      ensures keyName == name
      ensures wrappingKey == key
      ensures wrappingAlgorithm == wrappingAlg
      ensures Valid()
    {
      keyNamespace := namespace;
      keyName := name;
      wrappingKey := key;
      wrappingAlgorithm := wrappingAlg;
      Repr := {this};
    }

    function method SerializeProviderInto(iv: seq<uint8>): seq<uint8>
      requires Valid()
      requires |iv| == wrappingAlgorithm.ivLen as int
      reads this
    {
        keyName +
        [0, 0, 0, wrappingAlgorithm.tagLen * 8] + // tag length in bits
        [0, 0, 0, wrappingAlgorithm.ivLen] + // IV length in bytes
        iv
    }

    method OnEncrypt(encMat: Mat.EncryptionMaterials) returns (res: Result<Mat.EncryptionMaterials>)
      requires encMat.Valid()
      requires Valid()
      modifies encMat`plaintextDataKey
      modifies encMat`encryptedDataKeys
      ensures Valid()
      ensures res.Success? ==> res.value.Valid() && res.value == encMat
      ensures res.Success? && old(encMat.plaintextDataKey.Some?) ==> res.value.plaintextDataKey == old(encMat.plaintextDataKey)
      ensures res.Failure? ==> unchanged(encMat)
    {
      var dataKey: seq<uint8>;
      if encMat.plaintextDataKey.Some? {
        dataKey := encMat.plaintextDataKey.get;
      } else {
        dataKey := Random.GenerateBytes(encMat.algorithmSuiteID.KeyLength() as int32);
      }
      var iv := Random.GenerateBytes(wrappingAlgorithm.ivLen as int32);
      var aad := Mat.FlattenSortEncCtx(encMat.encryptionContext);
      var encryptResult :- AESEncryption.AESEncrypt(wrappingAlgorithm, iv, wrappingKey, dataKey, aad);
      var providerInfo := SerializeProviderInto(iv);
      var edk := Mat.EncryptedDataKey(keyNamespace, providerInfo, encryptResult.cipherText + encryptResult.authTag);
      if encMat.plaintextDataKey.None? {
        encMat.SetPlaintextDataKey(dataKey);
      }
      encMat.encryptedDataKeys := encMat.encryptedDataKeys + [edk];
      return Success(encMat);
    }

    predicate method ValidProviderInfo(info: seq<uint8>)
    {
      |info| == |keyName| + AUTH_TAG_LEN_LEN + IV_LEN_LEN + wrappingAlgorithm.ivLen as int &&
      info[0..|keyName|] == keyName &&
      SeqToUInt32(info[|keyName|..|keyName| + AUTH_TAG_LEN_LEN]) == wrappingAlgorithm.tagLen as uint32 &&
      SeqToUInt32(info[|keyName| + AUTH_TAG_LEN_LEN .. |keyName| + AUTH_TAG_LEN_LEN + IV_LEN_LEN]) == wrappingAlgorithm.ivLen as uint32
    }

    function method GetIvFromProvInfo(info: seq<uint8>): seq<uint8>
      requires ValidProviderInfo(info)
    {
      info[|keyName| + AUTH_TAG_LEN_LEN + IV_LEN_LEN ..]
    }

    method OnDecrypt(decMat: Mat.DecryptionMaterials, edks: seq<Mat.EncryptedDataKey>) returns (res: Result<Mat.DecryptionMaterials>)
      requires Valid() 
      requires decMat.Valid()
      modifies decMat`plaintextDataKey
      ensures Valid()
      ensures decMat.Valid()
      ensures |edks| == 0 ==> res.Success? && unchanged(decMat)
      ensures old(decMat.plaintextDataKey.Some?) ==> res.Success? && unchanged(decMat)
      ensures res.Success? ==> res.value == decMat
      ensures res.Failure? ==> unchanged(decMat)
    {
      if decMat.plaintextDataKey.Some? {
        return Success(decMat);
      }
      var i := 0;
      while i < |edks|
        invariant unchanged(decMat)
      {
        if edks[i].providerID == keyNamespace && ValidProviderInfo(edks[i].providerInfo) && wrappingAlgorithm.tagLen as int <= |edks[i].ciphertext| {
          var iv := GetIvFromProvInfo(edks[i].providerInfo);
          var flatEncCtx: seq<uint8> := Mat.FlattenSortEncCtx(decMat.encryptionContext);
          //TODO: #68
          var cipherText, authTag := edks[i].ciphertext[wrappingAlgorithm.tagLen ..], edks[i].ciphertext[.. wrappingAlgorithm.tagLen];
          var ptKey :- AESEncryption.AESDecrypt(wrappingAlgorithm, wrappingKey, cipherText, authTag, iv, flatEncCtx);
          if |ptKey| == decMat.algorithmSuiteID.KeyLength() { // check for correct key length
            decMat.setPlaintextDataKey(ptKey);
            return Success(decMat);
          } else {
            return Failure("Decryption failed: bad datakey length.");
          }
        }
        i := i + 1;
      }
      return Success(decMat);
    }
  }
}