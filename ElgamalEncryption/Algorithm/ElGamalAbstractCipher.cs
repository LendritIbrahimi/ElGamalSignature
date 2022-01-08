using System;
using System.IO;

public abstract class ElGamalAbstractCipher {
    protected int o_block_size;
    protected int o_plaintext_blocksize;
    protected int o_ciphertext_blocksize;
    protected ElGamalKeyStruct o_key_struct;

        public ElGamalAbstractCipher(ElGamalKeyStruct p_key_struct) {
        // set the key details
        o_key_struct = p_key_struct;

        // calculate the blocksizes
        o_plaintext_blocksize = (p_key_struct.P.bitCount(  ) -1) / 8;
        o_ciphertext_blocksize = ((p_key_struct.P.bitCount(  ) + 7) / 8) * 2;

            // set the default block for plaintext, which is suitable for encryption
        o_block_size = o_plaintext_blocksize;
        }
