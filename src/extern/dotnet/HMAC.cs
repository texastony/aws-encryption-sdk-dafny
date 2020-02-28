using System;
using System.Numerics;

using byteseq = Dafny.Sequence<byte>;

namespace HMAC {

    public class UnsupportedDigestException : Exception
    {
        public UnsupportedDigestException(Digests digest)
            : base(String.Format("Unsupported digest: {0}", digest.ToString()))
        {
        }
    }

    public partial class HMac {

        private Org.BouncyCastle.Crypto.Macs.HMac hmac;

        public HMac(Digests digest) {
            Org.BouncyCastle.Crypto.IDigest bouncyCastleDigest;
            if(digest.is_SHA__256) {
                bouncyCastleDigest = new Org.BouncyCastle.Crypto.Digests.Sha256Digest();
            } else if(digest.is_SHA__384) {
                bouncyCastleDigest = new Org.BouncyCastle.Crypto.Digests.Sha384Digest();
            } else {
                throw new UnsupportedDigestException(digest);
            }
            hmac = new Org.BouncyCastle.Crypto.Macs.HMac(bouncyCastleDigest);
        }

        public void Init(byteseq input) {
            // KeyParameter/ Init should not mutate input, but this is safer than using input.Elements directly
            byte[] elemCopy = (byte[]) input.Elements.Clone();
            var keyParams = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(elemCopy);
            hmac.Init(keyParams);
        }

        public void BlockUpdate(byteseq input) {
            // BlockUpdate should not mutate input, but this is safer than using input.Elements directly
            byte[] elemCopy = (byte[]) input.Elements.Clone();
            hmac.BlockUpdate(elemCopy, 0, elemCopy.Length);
        }

        public byteseq GetResult() {
            byte[] output = new byte[hmac.GetMacSize()];
            hmac.DoFinal(output, 0);
            return byteseq.FromArray(output);
        }
    }
}