using ElgamalEncryption.Algorithm.misc;
using System.Numerics;

namespace ElgamalEncryption.Algorithm
{
    public struct ElGamalKeyStruct
    {
        public BigInteger P;
        public BigInteger G;
        public BigInteger Y;
        public BigInteger X;
    }
}