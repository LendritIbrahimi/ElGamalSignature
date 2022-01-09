using System;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace ElgamalEncryption.Algorithm
{
    public abstract class ElGamal : AsymmetricAlgorithm
    {
        public abstract void ImportParameters(ElGamalKeyStruct keyStruct);
        public abstract byte[] Sign(byte[] p_hashcode);
    }
}