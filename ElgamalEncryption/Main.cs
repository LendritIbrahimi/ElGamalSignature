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
            // this will resize the window based on the users preference
            if (showMore)
            {
                this.Height = pnlAutomatic.Height + pnlAutomatic.Location.Y + 30;
                btnInfo.Text = "Show Less";
            }
            else
            {
                this.Height = pnlOutput.Height + pnlAutomatic.Location.Y + 50;
                btnInfo.Text = "Show More";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            // hash digest for the input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.Default.GetBytes(txtInput.Text);
            byte[] x_plaintext = md5.ComputeHash(inputBytes);
            txtMessageDigest.Text = BitConverter.ToString(x_plaintext).Replace("-", " ");


            // create a signature for the plaintext
            ElGamal x_sign_alg = new ElGamalManaged();
            x_sign_alg.KeySize = 384;
            ((ElGamalManaged)x_sign_alg).CreateKeyPair(x_sign_alg.KeySize);

            byte[] x_signature = x_sign_alg.Sign(x_plaintext);

            // this will output the signature in a HEX format which is better for the eye
            txtOutput.Text = BitConverter.ToString(x_signature).Replace("-", " ");

            // if Sign is clicked show the "Show Less" button
            btnInfo.Visible = true;
            showMore = true;
            ResizeWindow(showMore);

            //output the keys in the respective fields
            ElGamalManaged signed = (ElGamalManaged)x_sign_alg;
            txtPublicP.Text = signed.ExportParameters().P.ToString();
            txtPublicG.Text = signed.ExportParameters().G.ToString();
            txtPublicY.Text = signed.ExportParameters().Y.ToString();
            txtPrivateKey.Text = signed.ExportParameters().X.ToString();

        }


        private void btnMSign_Click(object sender, EventArgs e)
        {
            if (txtPublicMP.Text == string.Empty || txtMPrivateKey.Text == string.Empty
                || txtPublicMY.Text == string.Empty || txtPublicMG.Text == string.Empty)
            {
                return;
            }
            // hash digest for the input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.Default.GetBytes(txtMMessage.Text);
            byte[] x_plaintext = md5.ComputeHash(inputBytes);
            txtMMessageHash.Text = BitConverter.ToString(x_plaintext).Replace("-", " ");

            // create an instance of the algorithm and generate some keys
            ElGamalKeyStruct keys = new ElGamalKeyStruct();
            try
            {
                keys.P = new BigInteger(txtPublicMP.Text, 10);
                keys.X = new BigInteger(txtMPrivateKey.Text, 10);
                keys.Y = new BigInteger(txtPublicMY.Text, 10);
                keys.G = new BigInteger(txtPublicMG.Text, 10);
            }
            catch (Exception ex)
            {
                return;
            }

            // create a signature for the plaintext
            ElGamal x_sign_alg = new ElGamalManaged();
            // set the keys - note that we export with the
            // private parameters since we are signing data

            x_sign_alg.ImportParameters(keys);
            byte[] x_signature = x_sign_alg.Sign(x_plaintext);

            txtMSignature.Text = BitConverter.ToString(x_signature).Replace("-", " ");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ResizeWindow(btnInfo.Text == "Show More");
        }

        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            // simpe condition to hide or show the private key
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

        // check what mode we are using
        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            pnlAutomatic.Visible = rbAuto.Checked;

            pnlManual.Visible = rbManual.Checked;
            ResizeWindow(rbManual.Checked);
        }

        // this part handles all the copy buttons
        private void btnMHashCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtMMessageHash.Text);

            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnMSignatureCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtMSignature.Text);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        private void btnPublicP_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtPublicP.Text);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnSignature_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtOutput.Text);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtMessageDigest.Text);
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
