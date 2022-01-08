using ElgamalEncryption.Algorithm.misc;
using System;

namespace ElgamalEncryption.Algorithm
{
    public class ElGamalEncryptor : ElGamalAbstractCipher
    {
        Random o_random;

        public ElGamalEncryptor(ElGamalKeyStruct p_struct) : base(p_struct)
        {
            o_random = new Random();
        }
        protected override byte[] ProcessDataBlock(byte[] p_block)
        {
            // the random number, K
            BigInteger K;
            // create K, which is the random number        
            do
            {
                K = new BigInteger();
                K.genRandomBits(o_key_struct.P.bitCount() - 1, o_random);
            } while (K.gcd(o_key_struct.P - 1) != 1);

            // compute the values A and B
            BigInteger A = o_key_struct.G.modPow(K, o_key_struct.P);
            BigInteger B = o_key_struct.Y.modPow(K, o_key_struct.P)
                * new BigInteger(p_block) % o_key_struct.P;

            // create an array to contain the ciphertext
            byte[] x_result = new byte[o_ciphertext_blocksize];
            // copy the bytes from A and B into the result array
            byte[] x_a_bytes = A.getBytes();
            Array.Copy(x_a_bytes, 0, x_result, o_ciphertext_blocksize / 2
                - x_a_bytes.Length, x_a_bytes.Length);
            byte[] x_b_bytes = B.getBytes();
            Array.Copy(x_b_bytes, 0, x_result, o_ciphertext_blocksize
                - x_b_bytes.Length, x_b_bytes.Length);
            // return the result array
            return x_result;
        }
        protected override byte[] ProcessFinalDataBlock(byte[] p_final_block)
        {
            if (p_final_block.Length > 0)
            {
                if (p_final_block.Length < o_block_size)
                {
                    // create a fullsize block which contains the
                    // data to encrypt followed by trailing zeros
                    byte[] x_padded = new byte[o_block_size];
                    Array.Copy(p_final_block, 0, x_padded, 0, p_final_block.Length);
                    return ProcessDataBlock(x_padded);
                }
                else
                {
                    return ProcessDataBlock(p_final_block);
                }
            }
            else
            {
                return new byte[0];
            }
        }
    }
}