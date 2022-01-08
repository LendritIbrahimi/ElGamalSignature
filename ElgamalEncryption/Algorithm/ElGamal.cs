using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public abstract class ElGamal : AsymmetricAlgorithm
{
    public abstract void ImportParameters(ElGamalParameters p_parameters);
    public abstract ElGamalParameters ExportParameters(bool
        p_include_private_params);
    public abstract byte[] EncryptData(byte[] p_data);
    public abstract byte[] DecryptData(byte[] p_data);
    public abstract byte[] Sign(byte[] p_hashcode);
    public abstract bool VerifySignature(byte[] p_hashcode, byte[] p_signature);

    public override string ToXmlString(bool p_include_private)
    {
        ElGamalParameters x_params = ExportParameters(p_include_private);
        // create a new string builder
        StringBuilder x_sb = new StringBuilder();
        // add the header
        x_sb.Append("<ElGamalKeyValue>");
        // add the public elements from the parameters
        x_sb.Append("<P>" + Convert.ToBase64String(x_params.P) + "</P>");
        x_sb.Append("<G>" + Convert.ToBase64String(x_params.G) + "</G>");
        x_sb.Append("<Y>" + Convert.ToBase64String(x_params.Y) + "</Y>");
        if (p_include_private)
        {
            // we need to include X, which is the part of private key
            x_sb.Append("<X>" + Convert.ToBase64String(x_params.X) + "</X>");
        }
        // add the final element
        x_sb.Append("</ElGamalKeyValue>");
        return x_sb.ToString();
    }


}
