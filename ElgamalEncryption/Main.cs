using ElgamalEncryption.Algorithm;
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
                this.Height = 470;
            }
            else
            {
                this.Height = 265;
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
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            showMore = !showMore;
            ResizeWindow(showMore);
            if (showMore)
            {
                btnInfo.Text = "Show Less";
            }
            else
            {
                btnInfo.Text = "Show More";
            }
        }
    }
}
