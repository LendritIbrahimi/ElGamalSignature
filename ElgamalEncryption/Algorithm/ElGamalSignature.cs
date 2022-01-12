using ElgamalEncryption.Algorithm.misc;
using System;

namespace ElgamalEncryption.Algorithm
{
    public class ElGamalSignature
    {
        public static BigInteger mod(BigInteger p_base, BigInteger p_val)
        {
            BigInteger x_result = p_base % p_val;
            if (x_result < 0)
            {
                x_result += p_val;
            }
            return x_result;
        }
        public static byte[] CreateSignature(byte[] p_data,
      ElGamalKeyStruct p_key_struct)
        {
            // define P -1
            BigInteger x_pminusone = p_key_struct.P - 1;
            // create K, which is the random number        
            BigInteger K;
            do
            {
                K = new BigInteger();
                K.genRandomBits(p_key_struct.P.bitCount() - 1, new Random());
            } while (K.gcd(x_pminusone) != 1);   // compute the values A and B

            BigInteger A = p_key_struct.G.modPow(K, p_key_struct.P);
            BigInteger B = mod(mod(K.modInverse(x_pminusone) * (new BigInteger(p_data) - p_key_struct.X * A), x_pminusone), x_pminusone); // copy the bytes from A and B into the result array

            byte[] x_a_bytes = A.getBytes();
            byte[] x_b_bytes = B.getBytes();

            // define the result size
            int x_result_size = (p_key_struct.P.bitCount() + 7) / 8 * 2;

            // create an array to contain the ciphertext
            byte[] x_result = new byte[x_result_size];
            // populate the arrays
            Array.Copy(x_a_bytes, 0, x_result, x_result_size / 2 - x_a_bytes.Length, x_a_bytes.Length);
            Array.Copy(x_b_bytes, 0, x_result, x_result_size - x_b_bytes.Length, x_b_bytes.Length);

            // return the result array
            return x_result;

        }
    }
}