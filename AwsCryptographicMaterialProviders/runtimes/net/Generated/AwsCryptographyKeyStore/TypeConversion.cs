// Copyright Amazon.com Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0
// Do not modify this file. This file is machine generated, and any changes to it will be overwritten.
using System.Linq; using System; namespace AWS.Cryptography.KeyStore {
 public static class TypeConversion {
 internal static AWS.Cryptography.KeyStore.CreateKeyInput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_CreateKeyInput (Dafny.Aws.Cryptography.KeyStore.Types._ICreateKeyInput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyInput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyInput)value; AWS.Cryptography.KeyStore.CreateKeyInput converted = new AWS.Cryptography.KeyStore.CreateKeyInput();  converted.AwsKmsKeyArn = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_CreateKeyInput__M12_awsKmsKeyArn(concrete._awsKmsKeyArn);
 if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_CreateKeyInput__M11_grantTokens(concrete._grantTokens); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._ICreateKeyInput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_CreateKeyInput (AWS.Cryptography.KeyStore.CreateKeyInput value) {
 System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>) null;
 return new Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyInput ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_CreateKeyInput__M12_awsKmsKeyArn(value.AwsKmsKeyArn) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_CreateKeyInput__M11_grantTokens(var_grantTokens) ) ;
}
 internal static AWS.Cryptography.KeyStore.CreateKeyOutput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S15_CreateKeyOutput (Dafny.Aws.Cryptography.KeyStore.Types._ICreateKeyOutput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyOutput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyOutput)value; AWS.Cryptography.KeyStore.CreateKeyOutput converted = new AWS.Cryptography.KeyStore.CreateKeyOutput();  converted.BranchKeyIdentifier = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S15_CreateKeyOutput__M19_branchKeyIdentifier(concrete._branchKeyIdentifier); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._ICreateKeyOutput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S15_CreateKeyOutput (AWS.Cryptography.KeyStore.CreateKeyOutput value) {

 return new Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyOutput ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S15_CreateKeyOutput__M19_branchKeyIdentifier(value.BranchKeyIdentifier) ) ;
}
 internal static AWS.Cryptography.KeyStore.CreateKeyStoreInput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S19_CreateKeyStoreInput (Dafny.Aws.Cryptography.KeyStore.Types._ICreateKeyStoreInput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyStoreInput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyStoreInput)value; AWS.Cryptography.KeyStore.CreateKeyStoreInput converted = new AWS.Cryptography.KeyStore.CreateKeyStoreInput();  return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._ICreateKeyStoreInput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S19_CreateKeyStoreInput (AWS.Cryptography.KeyStore.CreateKeyStoreInput value) {

 return new Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyStoreInput (  ) ;
}
 internal static AWS.Cryptography.KeyStore.CreateKeyStoreOutput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S20_CreateKeyStoreOutput (Dafny.Aws.Cryptography.KeyStore.Types._ICreateKeyStoreOutput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyStoreOutput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyStoreOutput)value; AWS.Cryptography.KeyStore.CreateKeyStoreOutput converted = new AWS.Cryptography.KeyStore.CreateKeyStoreOutput();  converted.TableArn = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S20_CreateKeyStoreOutput__M8_tableArn(concrete._tableArn); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._ICreateKeyStoreOutput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S20_CreateKeyStoreOutput (AWS.Cryptography.KeyStore.CreateKeyStoreOutput value) {

 return new Dafny.Aws.Cryptography.KeyStore.Types.CreateKeyStoreOutput ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S20_CreateKeyStoreOutput__M8_tableArn(value.TableArn) ) ;
}
 internal static AWS.Cryptography.KeyStore.GetActiveBranchKeyInput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput (Dafny.Aws.Cryptography.KeyStore.Types._IGetActiveBranchKeyInput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.GetActiveBranchKeyInput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.GetActiveBranchKeyInput)value; AWS.Cryptography.KeyStore.GetActiveBranchKeyInput converted = new AWS.Cryptography.KeyStore.GetActiveBranchKeyInput();  converted.BranchKeyIdentifier = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M19_branchKeyIdentifier(concrete._branchKeyIdentifier);
 if (concrete._awsKmsKeyArn.is_Some) converted.AwsKmsKeyArn = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M12_awsKmsKeyArn(concrete._awsKmsKeyArn);
 if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M11_grantTokens(concrete._grantTokens); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._IGetActiveBranchKeyInput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput (AWS.Cryptography.KeyStore.GetActiveBranchKeyInput value) {
 string var_awsKmsKeyArn = value.IsSetAwsKmsKeyArn() ? value.AwsKmsKeyArn : (string) null;
 System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>) null;
 return new Dafny.Aws.Cryptography.KeyStore.Types.GetActiveBranchKeyInput ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M19_branchKeyIdentifier(value.BranchKeyIdentifier) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M12_awsKmsKeyArn(var_awsKmsKeyArn) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M11_grantTokens(var_grantTokens) ) ;
}
 internal static AWS.Cryptography.KeyStore.GetActiveBranchKeyOutput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetActiveBranchKeyOutput (Dafny.Aws.Cryptography.KeyStore.Types._IGetActiveBranchKeyOutput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.GetActiveBranchKeyOutput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.GetActiveBranchKeyOutput)value; AWS.Cryptography.KeyStore.GetActiveBranchKeyOutput converted = new AWS.Cryptography.KeyStore.GetActiveBranchKeyOutput();  converted.BranchKeyMaterials = (AWS.Cryptography.MaterialProviders.BranchKeyMaterials) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetActiveBranchKeyOutput__M18_branchKeyMaterials(concrete._branchKeyMaterials); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._IGetActiveBranchKeyOutput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetActiveBranchKeyOutput (AWS.Cryptography.KeyStore.GetActiveBranchKeyOutput value) {

 return new Dafny.Aws.Cryptography.KeyStore.Types.GetActiveBranchKeyOutput ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetActiveBranchKeyOutput__M18_branchKeyMaterials(value.BranchKeyMaterials) ) ;
}
 internal static AWS.Cryptography.KeyStore.GetBeaconKeyInput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput (Dafny.Aws.Cryptography.KeyStore.Types._IGetBeaconKeyInput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.GetBeaconKeyInput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.GetBeaconKeyInput)value; AWS.Cryptography.KeyStore.GetBeaconKeyInput converted = new AWS.Cryptography.KeyStore.GetBeaconKeyInput();  converted.BranchKeyIdentifier = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M19_branchKeyIdentifier(concrete._branchKeyIdentifier);
 if (concrete._awsKmsKeyArn.is_Some) converted.AwsKmsKeyArn = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M12_awsKmsKeyArn(concrete._awsKmsKeyArn);
 if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M11_grantTokens(concrete._grantTokens); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._IGetBeaconKeyInput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput (AWS.Cryptography.KeyStore.GetBeaconKeyInput value) {
 string var_awsKmsKeyArn = value.IsSetAwsKmsKeyArn() ? value.AwsKmsKeyArn : (string) null;
 System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>) null;
 return new Dafny.Aws.Cryptography.KeyStore.Types.GetBeaconKeyInput ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M19_branchKeyIdentifier(value.BranchKeyIdentifier) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M12_awsKmsKeyArn(var_awsKmsKeyArn) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M11_grantTokens(var_grantTokens) ) ;
}
 internal static AWS.Cryptography.KeyStore.GetBeaconKeyOutput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S18_GetBeaconKeyOutput (Dafny.Aws.Cryptography.KeyStore.Types._IGetBeaconKeyOutput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.GetBeaconKeyOutput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.GetBeaconKeyOutput)value; AWS.Cryptography.KeyStore.GetBeaconKeyOutput converted = new AWS.Cryptography.KeyStore.GetBeaconKeyOutput();  converted.BeaconKeyMaterials = (AWS.Cryptography.MaterialProviders.BeaconKeyMaterials) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S18_GetBeaconKeyOutput__M18_beaconKeyMaterials(concrete._beaconKeyMaterials); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._IGetBeaconKeyOutput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S18_GetBeaconKeyOutput (AWS.Cryptography.KeyStore.GetBeaconKeyOutput value) {

 return new Dafny.Aws.Cryptography.KeyStore.Types.GetBeaconKeyOutput ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S18_GetBeaconKeyOutput__M18_beaconKeyMaterials(value.BeaconKeyMaterials) ) ;
}
 internal static AWS.Cryptography.KeyStore.GetBranchKeyVersionInput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput (Dafny.Aws.Cryptography.KeyStore.Types._IGetBranchKeyVersionInput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.GetBranchKeyVersionInput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.GetBranchKeyVersionInput)value; AWS.Cryptography.KeyStore.GetBranchKeyVersionInput converted = new AWS.Cryptography.KeyStore.GetBranchKeyVersionInput();  converted.BranchKeyIdentifier = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M19_branchKeyIdentifier(concrete._branchKeyIdentifier);
  converted.BranchKeyVersion = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M16_branchKeyVersion(concrete._branchKeyVersion);
 if (concrete._awsKmsKeyArn.is_Some) converted.AwsKmsKeyArn = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M12_awsKmsKeyArn(concrete._awsKmsKeyArn);
 if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M11_grantTokens(concrete._grantTokens); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._IGetBranchKeyVersionInput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput (AWS.Cryptography.KeyStore.GetBranchKeyVersionInput value) {
 string var_awsKmsKeyArn = value.IsSetAwsKmsKeyArn() ? value.AwsKmsKeyArn : (string) null;
 System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>) null;
 return new Dafny.Aws.Cryptography.KeyStore.Types.GetBranchKeyVersionInput ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M19_branchKeyIdentifier(value.BranchKeyIdentifier) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M16_branchKeyVersion(value.BranchKeyVersion) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M12_awsKmsKeyArn(var_awsKmsKeyArn) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M11_grantTokens(var_grantTokens) ) ;
}
 internal static AWS.Cryptography.KeyStore.GetBranchKeyVersionOutput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S25_GetBranchKeyVersionOutput (Dafny.Aws.Cryptography.KeyStore.Types._IGetBranchKeyVersionOutput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.GetBranchKeyVersionOutput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.GetBranchKeyVersionOutput)value; AWS.Cryptography.KeyStore.GetBranchKeyVersionOutput converted = new AWS.Cryptography.KeyStore.GetBranchKeyVersionOutput();  converted.BranchKeyMaterials = (AWS.Cryptography.MaterialProviders.BranchKeyMaterials) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S25_GetBranchKeyVersionOutput__M18_branchKeyMaterials(concrete._branchKeyMaterials); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._IGetBranchKeyVersionOutput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S25_GetBranchKeyVersionOutput (AWS.Cryptography.KeyStore.GetBranchKeyVersionOutput value) {

 return new Dafny.Aws.Cryptography.KeyStore.Types.GetBranchKeyVersionOutput ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S25_GetBranchKeyVersionOutput__M18_branchKeyMaterials(value.BranchKeyMaterials) ) ;
}
 internal static AWS.Cryptography.KeyStore.KeyStoreConfig FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig (Dafny.Aws.Cryptography.KeyStore.Types._IKeyStoreConfig value) {
 Dafny.Aws.Cryptography.KeyStore.Types.KeyStoreConfig concrete = (Dafny.Aws.Cryptography.KeyStore.Types.KeyStoreConfig)value; AWS.Cryptography.KeyStore.KeyStoreConfig converted = new AWS.Cryptography.KeyStore.KeyStoreConfig(); if (concrete._ddbTableName.is_Some) converted.DdbTableName = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M12_ddbTableName(concrete._ddbTableName);
 if (concrete._ddbClient.is_Some) converted.DdbClient = (Amazon.DynamoDBv2.IAmazonDynamoDB) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M9_ddbClient(concrete._ddbClient);
 if (concrete._kmsClient.is_Some) converted.KmsClient = (Amazon.KeyManagementService.IAmazonKeyManagementService) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M9_kmsClient(concrete._kmsClient); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._IKeyStoreConfig ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig (AWS.Cryptography.KeyStore.KeyStoreConfig value) {
 string var_ddbTableName = value.IsSetDdbTableName() ? value.DdbTableName : (string) null;
 Amazon.DynamoDBv2.IAmazonDynamoDB var_ddbClient = value.IsSetDdbClient() ? value.DdbClient : (Amazon.DynamoDBv2.IAmazonDynamoDB) null;
 Amazon.KeyManagementService.IAmazonKeyManagementService var_kmsClient = value.IsSetKmsClient() ? value.KmsClient : (Amazon.KeyManagementService.IAmazonKeyManagementService) null;
 return new Dafny.Aws.Cryptography.KeyStore.Types.KeyStoreConfig ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M12_ddbTableName(var_ddbTableName) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M9_ddbClient(var_ddbClient) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M9_kmsClient(var_kmsClient) ) ;
}
 internal static AWS.Cryptography.KeyStore.KeyStoreException FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_KeyStoreException (Dafny.Aws.Cryptography.KeyStore.Types.Error_KeyStoreException value) {
 return new AWS.Cryptography.KeyStore.KeyStoreException (
 FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_KeyStoreException__M7_message(value._message)
 ) ;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types.Error_KeyStoreException ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_KeyStoreException (AWS.Cryptography.KeyStore.KeyStoreException value) {

 return new Dafny.Aws.Cryptography.KeyStore.Types.Error_KeyStoreException (
 ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_KeyStoreException__M7_message(value.Message)
 ) ;
}
 internal static AWS.Cryptography.KeyStore.VersionKeyInput FromDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput (Dafny.Aws.Cryptography.KeyStore.Types._IVersionKeyInput value) {
 Dafny.Aws.Cryptography.KeyStore.Types.VersionKeyInput concrete = (Dafny.Aws.Cryptography.KeyStore.Types.VersionKeyInput)value; AWS.Cryptography.KeyStore.VersionKeyInput converted = new AWS.Cryptography.KeyStore.VersionKeyInput();  converted.BranchKeyIdentifier = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M19_branchKeyIdentifier(concrete._branchKeyIdentifier);
 if (concrete._awsKmsKeyArn.is_Some) converted.AwsKmsKeyArn = (string) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M12_awsKmsKeyArn(concrete._awsKmsKeyArn);
 if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>) FromDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M11_grantTokens(concrete._grantTokens); return converted;
}
 internal static Dafny.Aws.Cryptography.KeyStore.Types._IVersionKeyInput ToDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput (AWS.Cryptography.KeyStore.VersionKeyInput value) {
 string var_awsKmsKeyArn = value.IsSetAwsKmsKeyArn() ? value.AwsKmsKeyArn : (string) null;
 System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>) null;
 return new Dafny.Aws.Cryptography.KeyStore.Types.VersionKeyInput ( ToDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M19_branchKeyIdentifier(value.BranchKeyIdentifier) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M12_awsKmsKeyArn(var_awsKmsKeyArn) , ToDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M11_grantTokens(var_grantTokens) ) ;
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_CreateKeyInput__M12_awsKmsKeyArn (Dafny.ISequence<char> value) {
 return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_CreateKeyInput__M12_awsKmsKeyArn (string value) {
 return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
}
 internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_CreateKeyInput__M11_grantTokens (Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value) {
 return value.is_None ? (System.Collections.Generic.List<string>) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_CreateKeyInput__M11_grantTokens (System.Collections.Generic.List<string> value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>) value));
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S15_CreateKeyOutput__M19_branchKeyIdentifier (Dafny.ISequence<char> value) {
 return FromDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S15_CreateKeyOutput__M19_branchKeyIdentifier (string value) {
 return ToDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S20_CreateKeyStoreOutput__M8_tableArn (Dafny.ISequence<char> value) {
 return FromDafny_N3_com__N9_amazonaws__N8_dynamodb__S8_TableArn(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S20_CreateKeyStoreOutput__M8_tableArn (string value) {
 return ToDafny_N3_com__N9_amazonaws__N8_dynamodb__S8_TableArn(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M19_branchKeyIdentifier (Dafny.ISequence<char> value) {
 return FromDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M19_branchKeyIdentifier (string value) {
 return ToDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M12_awsKmsKeyArn (Wrappers_Compile._IOption<Dafny.ISequence<char>> value) {
 return value.is_None ? (string) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M12_awsKmsKeyArn (string value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<char>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<char>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId((string) value));
}
 internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M11_grantTokens (Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value) {
 return value.is_None ? (System.Collections.Generic.List<string>) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S23_GetActiveBranchKeyInput__M11_grantTokens (System.Collections.Generic.List<string> value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>) value));
}
 internal static AWS.Cryptography.MaterialProviders.BranchKeyMaterials FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetActiveBranchKeyOutput__M18_branchKeyMaterials (Dafny.Aws.Cryptography.MaterialProviders.Types._IBranchKeyMaterials value) {
 return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials(value);
}
 internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IBranchKeyMaterials ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetActiveBranchKeyOutput__M18_branchKeyMaterials (AWS.Cryptography.MaterialProviders.BranchKeyMaterials value) {
 return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M19_branchKeyIdentifier (Dafny.ISequence<char> value) {
 return FromDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M19_branchKeyIdentifier (string value) {
 return ToDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M12_awsKmsKeyArn (Wrappers_Compile._IOption<Dafny.ISequence<char>> value) {
 return value.is_None ? (string) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M12_awsKmsKeyArn (string value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<char>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<char>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId((string) value));
}
 internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M11_grantTokens (Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value) {
 return value.is_None ? (System.Collections.Generic.List<string>) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_GetBeaconKeyInput__M11_grantTokens (System.Collections.Generic.List<string> value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>) value));
}
 internal static AWS.Cryptography.MaterialProviders.BeaconKeyMaterials FromDafny_N3_aws__N12_cryptography__N8_keyStore__S18_GetBeaconKeyOutput__M18_beaconKeyMaterials (Dafny.Aws.Cryptography.MaterialProviders.Types._IBeaconKeyMaterials value) {
 return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials(value);
}
 internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IBeaconKeyMaterials ToDafny_N3_aws__N12_cryptography__N8_keyStore__S18_GetBeaconKeyOutput__M18_beaconKeyMaterials (AWS.Cryptography.MaterialProviders.BeaconKeyMaterials value) {
 return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M19_branchKeyIdentifier (Dafny.ISequence<char> value) {
 return FromDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M19_branchKeyIdentifier (string value) {
 return ToDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M16_branchKeyVersion (Dafny.ISequence<char> value) {
 return FromDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M16_branchKeyVersion (string value) {
 return ToDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M12_awsKmsKeyArn (Wrappers_Compile._IOption<Dafny.ISequence<char>> value) {
 return value.is_None ? (string) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M12_awsKmsKeyArn (string value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<char>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<char>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId((string) value));
}
 internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M11_grantTokens (Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value) {
 return value.is_None ? (System.Collections.Generic.List<string>) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S24_GetBranchKeyVersionInput__M11_grantTokens (System.Collections.Generic.List<string> value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>) value));
}
 internal static AWS.Cryptography.MaterialProviders.BranchKeyMaterials FromDafny_N3_aws__N12_cryptography__N8_keyStore__S25_GetBranchKeyVersionOutput__M18_branchKeyMaterials (Dafny.Aws.Cryptography.MaterialProviders.Types._IBranchKeyMaterials value) {
 return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials(value);
}
 internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IBranchKeyMaterials ToDafny_N3_aws__N12_cryptography__N8_keyStore__S25_GetBranchKeyVersionOutput__M18_branchKeyMaterials (AWS.Cryptography.MaterialProviders.BranchKeyMaterials value) {
 return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M12_ddbTableName (Wrappers_Compile._IOption<Dafny.ISequence<char>> value) {
 return value.is_None ? (string) null : FromDafny_N3_com__N9_amazonaws__N8_dynamodb__S9_TableName(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M12_ddbTableName (string value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<char>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<char>>.create_Some(ToDafny_N3_com__N9_amazonaws__N8_dynamodb__S9_TableName((string) value));
}
 internal static Amazon.DynamoDBv2.IAmazonDynamoDB FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M9_ddbClient (Wrappers_Compile._IOption<Dafny.Com.Amazonaws.Dynamodb.Types.IDynamoDBClient> value) {
 return value.is_None ? (Amazon.DynamoDBv2.IAmazonDynamoDB) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_DdbClientReference(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.Com.Amazonaws.Dynamodb.Types.IDynamoDBClient> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M9_ddbClient (Amazon.DynamoDBv2.IAmazonDynamoDB value) {
 return value == null ? Wrappers_Compile.Option<Dafny.Com.Amazonaws.Dynamodb.Types.IDynamoDBClient>.create_None() : Wrappers_Compile.Option<Dafny.Com.Amazonaws.Dynamodb.Types.IDynamoDBClient>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_DdbClientReference((Amazon.DynamoDBv2.IAmazonDynamoDB) value));
}
 internal static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M9_kmsClient (Wrappers_Compile._IOption<Dafny.Com.Amazonaws.Kms.Types.IKMSClient> value) {
 return value.is_None ? (Amazon.KeyManagementService.IAmazonKeyManagementService) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.Com.Amazonaws.Kms.Types.IKMSClient> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S14_KeyStoreConfig__M9_kmsClient (Amazon.KeyManagementService.IAmazonKeyManagementService value) {
 return value == null ? Wrappers_Compile.Option<Dafny.Com.Amazonaws.Kms.Types.IKMSClient>.create_None() : Wrappers_Compile.Option<Dafny.Com.Amazonaws.Kms.Types.IKMSClient>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference((Amazon.KeyManagementService.IAmazonKeyManagementService) value));
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_KeyStoreException__M7_message (Dafny.ISequence<char> value) {
 return FromDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_KeyStoreException__M7_message (string value) {
 return ToDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M19_branchKeyIdentifier (Dafny.ISequence<char> value) {
 return FromDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M19_branchKeyIdentifier (string value) {
 return ToDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M12_awsKmsKeyArn (Wrappers_Compile._IOption<Dafny.ISequence<char>> value) {
 return value.is_None ? (string) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M12_awsKmsKeyArn (string value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<char>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<char>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId((string) value));
}
 internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M11_grantTokens (Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value) {
 return value.is_None ? (System.Collections.Generic.List<string>) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N8_keyStore__S15_VersionKeyInput__M11_grantTokens (System.Collections.Generic.List<string> value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>) value));
}
 internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId (Dafny.ISequence<char> value) {
 return new string(value.Elements);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId (string value) {
 return Dafny.Sequence<char>.FromString(value);
}
 internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList (Dafny.ISequence<Dafny.ISequence<char>> value) {
 return new System.Collections.Generic.List<string>(value.Elements.Select(FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList__M6_member));
}
 internal static Dafny.ISequence<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList (System.Collections.Generic.List<string> value) {
 return Dafny.Sequence<Dafny.ISequence<char>>.FromArray(value.Select(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList__M6_member).ToArray());
}
 internal static string FromDafny_N6_smithy__N3_api__S6_String (Dafny.ISequence<char> value) {
 return new string(value.Elements);
}
 internal static Dafny.ISequence<char> ToDafny_N6_smithy__N3_api__S6_String (string value) {
 return Dafny.Sequence<char>.FromString(value);
}
 internal static string FromDafny_N3_com__N9_amazonaws__N8_dynamodb__S8_TableArn (Dafny.ISequence<char> value) {
 return new string(value.Elements);
}
 internal static Dafny.ISequence<char> ToDafny_N3_com__N9_amazonaws__N8_dynamodb__S8_TableArn (string value) {
 return Dafny.Sequence<char>.FromString(value);
}
 internal static AWS.Cryptography.MaterialProviders.BranchKeyMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials (Dafny.Aws.Cryptography.MaterialProviders.Types._IBranchKeyMaterials value) {
 Dafny.Aws.Cryptography.MaterialProviders.Types.BranchKeyMaterials concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.BranchKeyMaterials)value; AWS.Cryptography.MaterialProviders.BranchKeyMaterials converted = new AWS.Cryptography.MaterialProviders.BranchKeyMaterials();  converted.BranchKeyVersion = (string) FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials__M16_branchKeyVersion(concrete._branchKeyVersion);
  converted.BranchKey = (System.IO.MemoryStream) FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials__M9_branchKey(concrete._branchKey); return converted;
}
 internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IBranchKeyMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials (AWS.Cryptography.MaterialProviders.BranchKeyMaterials value) {

 return new Dafny.Aws.Cryptography.MaterialProviders.Types.BranchKeyMaterials ( ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials__M16_branchKeyVersion(value.BranchKeyVersion) , ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials__M9_branchKey(value.BranchKey) ) ;
}
 internal static AWS.Cryptography.MaterialProviders.BeaconKeyMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials (Dafny.Aws.Cryptography.MaterialProviders.Types._IBeaconKeyMaterials value) {
 Dafny.Aws.Cryptography.MaterialProviders.Types.BeaconKeyMaterials concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.BeaconKeyMaterials)value; AWS.Cryptography.MaterialProviders.BeaconKeyMaterials converted = new AWS.Cryptography.MaterialProviders.BeaconKeyMaterials();  converted.BeaconKeyIdentifier = (string) FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M19_beaconKeyIdentifier(concrete._beaconKeyIdentifier);
 if (concrete._beaconKey.is_Some) converted.BeaconKey = (System.IO.MemoryStream) FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M9_beaconKey(concrete._beaconKey);
 if (concrete._hmacKeys.is_Some) converted.HmacKeys = (System.Collections.Generic.List<System.IO.MemoryStream>) FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M8_hmacKeys(concrete._hmacKeys); return converted;
}
 internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IBeaconKeyMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials (AWS.Cryptography.MaterialProviders.BeaconKeyMaterials value) {
 System.IO.MemoryStream var_beaconKey = value.IsSetBeaconKey() ? value.BeaconKey : (System.IO.MemoryStream) null;
 System.Collections.Generic.List<System.IO.MemoryStream> var_hmacKeys = value.IsSetHmacKeys() ? value.HmacKeys : (System.Collections.Generic.List<System.IO.MemoryStream>) null;
 return new Dafny.Aws.Cryptography.MaterialProviders.Types.BeaconKeyMaterials ( ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M19_beaconKeyIdentifier(value.BeaconKeyIdentifier) , ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M9_beaconKey(var_beaconKey) , ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M8_hmacKeys(var_hmacKeys) ) ;
}
 internal static string FromDafny_N3_com__N9_amazonaws__N8_dynamodb__S9_TableName (Dafny.ISequence<char> value) {
 return new string(value.Elements);
}
 internal static Dafny.ISequence<char> ToDafny_N3_com__N9_amazonaws__N8_dynamodb__S9_TableName (string value) {
 return Dafny.Sequence<char>.FromString(value);
}
 internal static Amazon.DynamoDBv2.IAmazonDynamoDB FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_DdbClientReference (Dafny.Com.Amazonaws.Dynamodb.Types.IDynamoDBClient value) {
 // This is converting a reference type in a dependant module.
 // Therefore it defers to the dependant module for conversion
 return AWS.Cryptography.MaterialProviders.TypeConversion.FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_DdbClientReference(value);
}
 internal static Dafny.Com.Amazonaws.Dynamodb.Types.IDynamoDBClient ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_DdbClientReference (Amazon.DynamoDBv2.IAmazonDynamoDB value) {
 // This is converting a reference type in a dependant module.
 // Therefore it defers to the dependant module for conversion
 return AWS.Cryptography.MaterialProviders.TypeConversion.ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_DdbClientReference(value);
}
 internal static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference (Dafny.Com.Amazonaws.Kms.Types.IKMSClient value) {
 // This is converting a reference type in a dependant module.
 // Therefore it defers to the dependant module for conversion
 return AWS.Cryptography.MaterialProviders.TypeConversion.FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
}
 internal static Dafny.Com.Amazonaws.Kms.Types.IKMSClient ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference (Amazon.KeyManagementService.IAmazonKeyManagementService value) {
 // This is converting a reference type in a dependant module.
 // Therefore it defers to the dependant module for conversion
 return AWS.Cryptography.MaterialProviders.TypeConversion.ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList__M6_member (Dafny.ISequence<char> value) {
 return FromDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList__M6_member (string value) {
 return ToDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials__M16_branchKeyVersion (Dafny.ISequence<byte> value) {
 return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
}
 internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials__M16_branchKeyVersion (string value) {
 return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
}
 internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials__M9_branchKey (Dafny.ISequence<byte> value) {
 return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value);
}
 internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BranchKeyMaterials__M9_branchKey (System.IO.MemoryStream value) {
 return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value);
}
 internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M19_beaconKeyIdentifier (Dafny.ISequence<char> value) {
 return FromDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M19_beaconKeyIdentifier (string value) {
 return ToDafny_N6_smithy__N3_api__S6_String(value);
}
 internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M9_beaconKey (Wrappers_Compile._IOption<Dafny.ISequence<byte>> value) {
 return value.is_None ? (System.IO.MemoryStream) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M9_beaconKey (System.IO.MemoryStream value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret((System.IO.MemoryStream) value));
}
 internal static System.Collections.Generic.List<System.IO.MemoryStream> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M8_hmacKeys (Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<byte>>> value) {
 return value.is_None ? (System.Collections.Generic.List<System.IO.MemoryStream>) null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_HmacKeyList(value.Extract());
}
 internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<byte>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_BeaconKeyMaterials__M8_hmacKeys (System.Collections.Generic.List<System.IO.MemoryStream> value) {
 return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<byte>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<byte>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_HmacKeyList((System.Collections.Generic.List<System.IO.MemoryStream>) value));
}
 internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes (Dafny.ISequence<byte> value) {
 System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding(false, true);
return utf8.GetString(value.Elements);
}
 internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes (string value) {
 System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding(false, true);
return Dafny.Sequence<byte>.FromArray(utf8.GetBytes(value));
}
 internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret (Dafny.ISequence<byte> value) {
 return new System.IO.MemoryStream(value.Elements);
}
 internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret (System.IO.MemoryStream value) {
 return Dafny.Sequence<byte>.FromArray(value.ToArray());
}
 internal static System.Collections.Generic.List<System.IO.MemoryStream> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_HmacKeyList (Dafny.ISequence<Dafny.ISequence<byte>> value) {
 return new System.Collections.Generic.List<System.IO.MemoryStream>(value.Elements.Select(FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_HmacKeyList__M6_member));
}
 internal static Dafny.ISequence<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_HmacKeyList (System.Collections.Generic.List<System.IO.MemoryStream> value) {
 return Dafny.Sequence<Dafny.ISequence<byte>>.FromArray(value.Select(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_HmacKeyList__M6_member).ToArray());
}
 internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_HmacKeyList__M6_member (Dafny.ISequence<byte> value) {
 return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value);
}
 internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_HmacKeyList__M6_member (System.IO.MemoryStream value) {
 return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value);
}
 public static System.Exception FromDafny_CommonError(Dafny.Aws.Cryptography.KeyStore.Types._IError value) {
 switch(value)
 {
 case Dafny.Aws.Cryptography.KeyStore.Types.Error_AwsCryptographyMaterialProviders dafnyVal:
  return AWS.Cryptography.MaterialProviders.TypeConversion.FromDafny_CommonError(
    dafnyVal._AwsCryptographyMaterialProviders
  );
 case Dafny.Aws.Cryptography.KeyStore.Types.Error_KeyStoreException dafnyVal:
return FromDafny_N3_aws__N12_cryptography__N8_keyStore__S17_KeyStoreException(dafnyVal);
 case Dafny.Aws.Cryptography.KeyStore.Types.Error_CollectionOfErrors dafnyVal:
 return new CollectionOfErrors(new System.Collections.Generic.List<Exception>(dafnyVal._list.Elements.Select(x => TypeConversion.FromDafny_CommonError(x))));
 case Dafny.Aws.Cryptography.KeyStore.Types.Error_Opaque dafnyVal:
 return new OpaqueError(dafnyVal._obj);
 default:
 // The switch MUST be complete for _IError, so `value` MUST NOT be an _IError. (How did you get here?)
 return new OpaqueError();
}
}
 public static Dafny.Aws.Cryptography.KeyStore.Types._IError ToDafny_CommonError(System.Exception value) {
 switch (value.GetType().Namespace) {
 case "AWS.Cryptography.MaterialProviders":
  return Dafny.Aws.Cryptography.KeyStore.Types.Error.create_AwsCryptographyMaterialProviders(
    AWS.Cryptography.MaterialProviders.TypeConversion.ToDafny_CommonError(value)
  );
}
 switch (value)
 {
 case AWS.Cryptography.KeyStore.KeyStoreException exception:
 return ToDafny_N3_aws__N12_cryptography__N8_keyStore__S17_KeyStoreException(exception);
 case CollectionOfErrors collectionOfErrors:
 return new Dafny.Aws.Cryptography.KeyStore.Types.Error_CollectionOfErrors(
     Dafny.Sequence<Dafny.Aws.Cryptography.KeyStore.Types._IError>
     .FromArray(
         collectionOfErrors.list.Select
             (x => TypeConversion.ToDafny_CommonError(x))
         .ToArray()
     )
 );

 // OpaqueError is redundant, but listed for completeness.
 case OpaqueError exception:
 return new Dafny.Aws.Cryptography.KeyStore.Types.Error_Opaque(exception);
 case System.Exception exception:
 return new Dafny.Aws.Cryptography.KeyStore.Types.Error_Opaque(exception);
 default:
 // The switch MUST be complete for System.Exception, so `value` MUST NOT be an System.Exception. (How did you get here?)
 return new Dafny.Aws.Cryptography.KeyStore.Types.Error_Opaque(value);
}
}
}
}