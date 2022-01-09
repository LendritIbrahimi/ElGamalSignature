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
            o_key_struct = new ElGamalKeyStruct();
            // set all of the big integers to zero
            o_key_struct.P = new BigInteger(0);
            o_key_struct.G = new BigInteger(0);
            o_key_struct.Y = new BigInteger(0);
            o_key_struct.X = new BigInteger(0);

            //The other task the constructor performs defines the range of key lengths that the implementation supports. We have selected 384 bits as the shortest key supported to conform to the .NET RSA implementation. We define 1088 bits as the largest value because of the size limitations when using the BigInteger class; even though we have doubled the largest value that this class can represent, we still exceed that limit when performing the encryption computation for larger key sizes. We set the default key size to be 1024 bits, which provides a key strength that is suitable for most projects:

            // set the default key size value
            KeySizeValue = 1024;
            // set the range of legal keys
            LegalKeySizesValue = new KeySizes[] { new KeySizes(384, 1088, 8) };
        }
        //The SignatureAlgorithm and KeyExchangeAlgorithm properties return a string value that indicates how the class performs encryption and creates digital signatures; we are implementing the "raw" ElGamal algorithm, and so both of these properties simply return ElGamal:
        //The CreateKeyPair method follows the ElGamal key generation protocol to create a new key pair; the key parameter values are set using the ElGamalKeyStruct instance variable; the method accepts an integer argument that specifies the required key length:
        private void CreateKeyPair(int p_key_strength)
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

        public ElGamalKeyStruct KeyStruct
        {
            get
            {
                if (NeedToGenerateKey())
                {
                    CreateKeyPair(KeySizeValue);
                }
                return o_key_struct;
            }
            set
            {
                o_key_struct = value;
            }
        }

        // The ImportParameters method accepts an instance of the ElGamalParameters structure and creates the BigIntegers that we will use to represent the key; this method allows users to import a previously created key and is used by the FromXmlString method in the abstract ElGamal class:
        public override void ImportParameters(ElGamalParameters p_parameters)
        {
            // obtain the  big integer values from the byte parameter values
            o_key_struct.P = new BigInteger(p_parameters.P);
            o_key_struct.G = new BigInteger(p_parameters.G);
            o_key_struct.Y = new BigInteger(p_parameters.Y);
            if (p_parameters.X != null && p_parameters.X.Length > 0)
            {
                o_key_struct.X = new BigInteger(p_parameters.X);
            }
            // set the length of the key based on the import
            KeySizeValue = o_key_struct.P.bitCount();
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

        // The ExportParameters method creates an ElGamalParameters structure using the key represented by the instance ElGamalKeyStruct member. Notice that we check to see if we need to create a new key pair before we export the key details to ensure that there is something to export. The Boolean argument determines whether to export the private parameters, in keeping with the model used by the RSA implementation classes:
        public override ElGamalParameters ExportParameters(bool p_include_private_params)
        {
            if (NeedToGenerateKey())
            {
                // we need to create a new key before we can export 
                CreateKeyPair(KeySizeValue);
            }

            // create the parameter set
            ElGamalParameters x_params = new ElGamalParameters();
            // set the public values of the parameters
            x_params.P = o_key_struct.P.getBytes();
            x_params.G = o_key_struct.G.getBytes();
            x_params.Y = o_key_struct.Y.getBytes();

            // if required, include the private value, X
            if (p_include_private_params)
            {
                x_params.X = o_key_struct.X.getBytes();
            }
            else
            {
                // ensure that we zero the value
                x_params.X = new byte[1];
            }
            // return the parameter set
            return x_params;
        }

        // The EncryptData and DecryptData methods provide access to the ElGamal encryption and decryption functions; create a new key pair if the user has not imported a key, and then pass the data to the specialized ElGamalEncryptor and ElGamalDecryptor classes, which we detail in the next sections:
        public override byte[] EncryptData(byte[] p_data)
        {
            if (NeedToGenerateKey())
            {
                // we need to create a new key before we can export 
                CreateKeyPair(KeySizeValue);
            }
            // encrypt the data
            ElGamalEncryptor x_enc = new ElGamalEncryptor(o_key_struct);
            return x_enc.ProcessData(p_data);
        }

        public override byte[] DecryptData(byte[] p_data)
        {
            if (NeedToGenerateKey())
            {
                // we need to create a new key before we can export 
                CreateKeyPair(KeySizeValue);
            }
            // encrypt the data
            ElGamalDecryptor x_enc = new(o_key_struct);
            return x_enc.ProcessData(p_data);
        }

        public ElGamalKeyStruct GetKeys()
        {
            return o_key_struct;
        }
        // The Dispose method is useful for releasing unmanaged resources, but you do not need to do anything in this method since the implementation is written entirely in managed code, but it is a requirement of extending from the AsymmetricAlgorithm class:
        protected override void Dispose(bool p_bool)
        {
            // do nothing - no unmanaged resources to release
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

        public override bool VerifySignature(byte[] p_hashcode, byte[] p_signature)
        {
            if (NeedToGenerateKey())
            {
                // we need to create a new key before we can export 
                CreateKeyPair(KeySizeValue);
            }
            return ElGamalSignature.VerifySignature(p_hashcode,
              p_signature, o_key_struct);
        }
    }
}