using ElgamalEncryption.Algorithm;
using ElgamalEncryption.Algorithm.misc;
//using ElgamalEncryption.Algorithm.misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElgamalEncryption
{
    public partial class Main : Form
    {
        private bool showMore = false;
        public Main()
        {
            InitializeComponent();
        }

        private void ResizeWindow(bool showMore)
        {
            if (showMore)
            {
                this.Height = 688;
                btnInfo.Text = "Show Less";
            }
            else
            {
                this.Height = 314;
                btnInfo.Text = "Show More";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.Default.GetBytes(txtInput.Text);
            byte[] x_plaintext = md5.ComputeHash(inputBytes);
            txtMessageDigest.Text = BitConverter.ToString(x_plaintext).Replace("-", " ");


            // Create an instance of the algorithm and generate some keys
            ElGamal x_alg = new ElGamalManaged();
            // set the key size - keep is small to speed up the tests
            x_alg.KeySize = 384;
            // extract and print the xml string (this will cause
            // a new key pair to be generated)
            string x_xml_string = x_alg.ToXmlString(true);
            Console.WriteLine("\n{0}\n", x_xml_string);

            // create a signature for the plaintext
            ElGamal x_sign_alg = new ElGamalManaged();
            // set the keys - note that we export with the
            // private parameters since we are signing data
            x_sign_alg.FromXmlString(x_alg.ToXmlString(true));
            byte[] x_signature = x_sign_alg.Sign(x_plaintext);

            //txtOutput.Text = string.Join(" ", x_signature.Select(x => Convert.ToHexString(x, 2).PadLeft(8, '0')));
            txtOutput.Text = BitConverter.ToString(x_signature).Replace("-", " ");

            btnInfo.Visible = true;
            showMore = true;
            ResizeWindow(showMore);

            ElGamalManaged signed = (ElGamalManaged)x_sign_alg;
            txtPublicP.Text = signed.GetKeys().P.ToString();
            txtPublicG.Text = signed.GetKeys().G.ToString();
            txtPublicY.Text = signed.GetKeys().Y.ToString();
            txtPrivateKey.Text = signed.GetKeys().X.ToString();

        }


        private void btnMSign_Click(object sender, EventArgs e)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.Default.GetBytes(txtMMessage.Text);
            byte[] x_plaintext = md5.ComputeHash(inputBytes);
            txtMMessageHash.Text = BitConverter.ToString(x_plaintext).Replace("-", " ");

            // Create an instance of the algorithm and generate some keys
            ElGamalKeyStruct keys = new ElGamalKeyStruct();

            keys.P = new BigInteger(txtPublicMP.Text, 10);
            keys.X = new BigInteger(txtMPrivateKey.Text, 10);
            keys.Y = new BigInteger(txtPublicMY.Text, 10);
            keys.G = new BigInteger(txtPublicMG.Text, 10);

            // create a signature for the plaintext
            ElGamal x_sign_alg = new ElGamalManaged();
            // set the keys - note that we export with the
            // private parameters since we are signing data

            x_sign_alg.ImportParameters(keys);
            txtPublicP.Text = ((ElGamalManaged)x_sign_alg).GetKeys().P.ToString();
            txtPublicG.Text = ((ElGamalManaged)x_sign_alg).GetKeys().G.ToString();
            txtPublicY.Text = ((ElGamalManaged)x_sign_alg).GetKeys().Y.ToString();
            txtPrivateKey.Text = ((ElGamalManaged)x_sign_alg).GetKeys().X.ToString();
            byte[] x_signature = x_sign_alg.Sign(x_plaintext);

            txtMSignature.Text = BitConverter.ToString(x_signature).Replace("-", " ");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ResizeWindow(btnInfo.Text == "Show More");
        }

        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            if (txtPrivateKey.UseSystemPasswordChar)
            {
                txtPrivateKey.UseSystemPasswordChar = false;
                btnPrivateKey.Text = "Hide";
            }
            else
            {
                txtPrivateKey.UseSystemPasswordChar = true;
                btnPrivateKey.Text = "Show";
            }
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            pnlAutomatic.Visible = rbAuto.Checked;

            pnlManual.Visible = rbManual.Checked;
            ResizeWindow(rbManual.Checked);
        }

        private void btnMHashCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMMessageHash.Text);
        }

        private void btnMSignatureCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMSignature.Text);
        }


        private void btnPublicP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPublicP.Text);
        }

        private void btnSignature_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMessageDigest.Text);
        }
    }
}
