using ElgamalEncryption.Algorithm.misc;
using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace ElgamalEncryption.Algorithm
{
    public class ElGamalManaged : ElGamal
    {

        public ElGamalKeyStruct o_key_struct;

        // The first part of the constructor initializes the BigIntegers contained in the ElGamalKeyStruct to 0;
        // this gives a known starting point, and you can assume the user has not imported a key if the public key parameter values are all set to 0:
        public ElGamalManaged()
        {
            // create the key struct
            o_key_struct = new ElGamalKeyStruct
            {
                // set all of the big integers to zero
                P = new BigInteger(0),
                G = new BigInteger(0),
                Y = new BigInteger(0),
                X = new BigInteger(0)
            };

            //The other task the constructor performs defines the range of key lengths that the implementation supports. We have selected 384 bits as the shortest key supported to conform to the .NET RSA implementation. We define 1088 bits as the largest value because of the size limitations when using the BigInteger class; even though we have doubled the largest value that this class can represent, we still exceed that limit when performing the encryption computation for larger key sizes. We set the default key size to be 1024 bits, which provides a key strength that is suitable for most projects:

            // set the default key size value
            KeySizeValue = 1024;
            // set the range of legal keys
            LegalKeySizesValue = new KeySizes[] { new KeySizes(384, 1088, 8) };
        }

        //The CreateKeyPair method follows the ElGamal key generation protocol to create a new key pair; the key parameter values are set using the ElGamalKeyStruct instance variable; the method accepts an integer argument that specifies the required key length:
        public void CreateKeyPair(int p_key_strength)
        {
            // create the random number generator
            Random x_random_generator = new Random();

            // create the large prime number, P
            o_key_struct.P = BigInteger.genPseudoPrime(p_key_strength,
                16, x_random_generator);

            // create the two random numbers, which are smaller than P
            o_key_struct.X = new BigInteger();
            o_key_struct.X.genRandomBits(p_key_strength - 1, x_random_generator);
            o_key_struct.G = new BigInteger();
            o_key_struct.G.genRandomBits(p_key_strength - 1, x_random_generator);

            // compute Y
            o_key_struct.Y = o_key_struct.G.modPow(o_key_struct.X, o_key_struct.P);
        }

        // The NeedToGenerateKey method tests the value of the public key parameters; if all of the values are 0, then we assume that the user has not imported a key and that we should create a new key pair before encrypting or decrypting data. The KeyStruct property simply gets or sets the ElGamalKeyStruct instance member:
        private bool NeedToGenerateKey()
        {
            return o_key_struct.P == 0 && o_key_struct.G == 0 && o_key_struct.Y == 0;
        }

        public override void ImportParameters(ElGamalKeyStruct keyStruct)
        {

            o_key_struct.P = keyStruct.P;
            o_key_struct.G = keyStruct.G;
            o_key_struct.Y = keyStruct.Y;
            if (keyStruct.X != 0)
            {
                o_key_struct.X = keyStruct.X;
            }
        }

        public ElGamalKeyStruct ExportParameters()
        {
            return o_key_struct;
        }

        // The Sign and VerifySignature methods support the creation and verification of digital signatures; although you have implemented these methods to comply with the abstractions of the ElGamal class
        public override byte[] Sign(byte[] p_hashcode)
        {
            if (NeedToGenerateKey())
            {
                // we need to create a new key before we can export 
                CreateKeyPair(KeySizeValue);
            }
            return ElGamalSignature.CreateSignature(p_hashcode, o_key_struct);
        }
    }
}