using ElgamalEncryption.Algorithm.misc;

namespace ElgamalEncryption.Algorithm
{
    public struct ElGamalKeyStruct
    {
        //Those will be contained inside the public key
        public BigInteger P;
        public BigInteger G;
        public BigInteger Y;

        //This will be the private key
        public BigInteger X;
    }
}