
namespace ElgamalEncryption
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.lblSignature = new System.Windows.Forms.Label();
            this.lblDigest = new System.Windows.Forms.Label();
            this.txtMessageDigest = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblPrime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrime = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.btnPrivateKey = new System.Windows.Forms.Button();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.pnlAutomatic = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMPrivateKey = new System.Windows.Forms.Label();
            this.txtMMessage = new System.Windows.Forms.TextBox();
            this.lblMPublicKey = new System.Windows.Forms.Label();
            this.btnMSign = new System.Windows.Forms.Button();
            this.txtMPrime = new System.Windows.Forms.TextBox();
            this.txtMPrivateKey = new System.Windows.Forms.TextBox();
            this.lblMMessage = new System.Windows.Forms.Label();
            this.lblMMessageHash = new System.Windows.Forms.Label();
            this.txtMPublicKey = new System.Windows.Forms.TextBox();
            this.txtMSignature = new System.Windows.Forms.TextBox();
            this.btnMSignatureCopy = new System.Windows.Forms.Button();
            this.txtMMessageHash = new System.Windows.Forms.TextBox();
            this.lblMSignature = new System.Windows.Forms.Label();
            this.btnMHashCopy = new System.Windows.Forms.Button();
            this.pnlOutput.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlAutomatic.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(3, 25);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(653, 115);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.LightGray;
            this.txtOutput.Location = new System.Drawing.Point(3, 76);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(554, 107);
            this.txtOutput.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(1, 2);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(67, 20);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(479, 148);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(177, 51);
            this.btnSign.TabIndex = 2;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(3, 53);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(121, 20);
            this.lblSignature.TabIndex = 1;
            this.lblSignature.Text = "Digital Signature";
            // 
            // lblDigest
            // 
            this.lblDigest.AutoSize = true;
            this.lblDigest.Location = new System.Drawing.Point(3, 0);
            this.lblDigest.Name = "lblDigest";
            this.lblDigest.Size = new System.Drawing.Size(114, 20);
            this.lblDigest.TabIndex = 4;
            this.lblDigest.Text = "Message Digest";
            // 
            // txtMessageDigest
            // 
            this.txtMessageDigest.BackColor = System.Drawing.Color.LightGray;
            this.txtMessageDigest.Location = new System.Drawing.Point(5, 23);
            this.txtMessageDigest.Name = "txtMessageDigest";
            this.txtMessageDigest.ReadOnly = true;
            this.txtMessageDigest.Size = new System.Drawing.Size(552, 27);
            this.txtMessageDigest.TabIndex = 3;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(562, 20);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 33);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // pnlOutput
            // 
            this.pnlOutput.Controls.Add(this.btnInfo);
            this.pnlOutput.Controls.Add(this.txtInput);
            this.pnlOutput.Controls.Add(this.lblMessage);
            this.pnlOutput.Controls.Add(this.btnSign);
            this.pnlOutput.Location = new System.Drawing.Point(0, 0);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(670, 204);
            this.pnlOutput.TabIndex = 5;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(3, 169);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(173, 29);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Show Less";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Visible = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblPrime);
            this.pnlInput.Controls.Add(this.label2);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.txtPrime);
            this.pnlInput.Controls.Add(this.txtPrivateKey);
            this.pnlInput.Controls.Add(this.btnPrivateKey);
            this.pnlInput.Controls.Add(this.txtPublicKey);
            this.pnlInput.Controls.Add(this.button1);
            this.pnlInput.Controls.Add(this.lblDigest);
            this.pnlInput.Controls.Add(this.txtOutput);
            this.pnlInput.Controls.Add(this.lblSignature);
            this.pnlInput.Controls.Add(this.txtMessageDigest);
            this.pnlInput.Controls.Add(this.button2);
            this.pnlInput.Controls.Add(this.btnCopy);
            this.pnlInput.Location = new System.Drawing.Point(3, 206);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(667, 361);
            this.pnlInput.TabIndex = 6;
            // 
            // lblPrime
            // 
            this.lblPrime.AutoSize = true;
            this.lblPrime.Location = new System.Drawing.Point(3, 244);
            this.lblPrime.Name = "lblPrime";
            this.lblPrime.Size = new System.Drawing.Size(105, 20);
            this.lblPrime.TabIndex = 7;
            this.lblPrime.Text = "Prime Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Private Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Public Key";
            // 
            // txtPrime
            // 
            this.txtPrime.BackColor = System.Drawing.Color.LightGray;
            this.txtPrime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrime.Location = new System.Drawing.Point(5, 267);
            this.txtPrime.Name = "txtPrime";
            this.txtPrime.ReadOnly = true;
            this.txtPrime.Size = new System.Drawing.Size(657, 27);
            this.txtPrime.TabIndex = 6;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.BackColor = System.Drawing.Color.LightGray;
            this.txtPrivateKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrivateKey.Location = new System.Drawing.Point(5, 325);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(552, 27);
            this.txtPrivateKey.TabIndex = 6;
            this.txtPrivateKey.UseSystemPasswordChar = true;
            // 
            // btnPrivateKey
            // 
            this.btnPrivateKey.Location = new System.Drawing.Point(562, 322);
            this.btnPrivateKey.Name = "btnPrivateKey";
            this.btnPrivateKey.Size = new System.Drawing.Size(100, 33);
            this.btnPrivateKey.TabIndex = 5;
            this.btnPrivateKey.Text = "Show";
            this.btnPrivateKey.UseVisualStyleBackColor = true;
            this.btnPrivateKey.Click += new System.EventHandler(this.btnPrivateKey_Click);
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.BackColor = System.Drawing.Color.LightGray;
            this.txtPublicKey.Location = new System.Drawing.Point(5, 213);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.Size = new System.Drawing.Size(552, 27);
            this.txtPublicKey.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(15, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Mode";
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Checked = true;
            this.rbAuto.Location = new System.Drawing.Point(18, 32);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(99, 24);
            this.rbAuto.TabIndex = 7;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Automatic";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(141, 32);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(79, 24);
            this.rbManual.TabIndex = 8;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // pnlAutomatic
            // 
            this.pnlAutomatic.Controls.Add(this.pnlInput);
            this.pnlAutomatic.Controls.Add(this.pnlOutput);
            this.pnlAutomatic.Location = new System.Drawing.Point(10, 62);
            this.pnlAutomatic.Name = "pnlAutomatic";
            this.pnlAutomatic.Size = new System.Drawing.Size(675, 588);
            this.pnlAutomatic.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMPrivateKey);
            this.panel1.Controls.Add(this.txtMMessage);
            this.panel1.Controls.Add(this.lblMPublicKey);
            this.panel1.Controls.Add(this.btnMSign);
            this.panel1.Controls.Add(this.txtMPrime);
            this.panel1.Controls.Add(this.txtMPrivateKey);
            this.panel1.Controls.Add(this.lblMMessage);
            this.panel1.Controls.Add(this.lblMMessageHash);
            this.panel1.Controls.Add(this.txtMPublicKey);
            this.panel1.Controls.Add(this.txtMSignature);
            this.panel1.Controls.Add(this.btnMSignatureCopy);
            this.panel1.Controls.Add(this.txtMMessageHash);
            this.panel1.Controls.Add(this.lblMSignature);
            this.panel1.Controls.Add(this.btnMHashCopy);
            this.panel1.Location = new System.Drawing.Point(691, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 567);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prime Number";
            // 
            // lblMPrivateKey
            // 
            this.lblMPrivateKey.AutoSize = true;
            this.lblMPrivateKey.Location = new System.Drawing.Point(3, 203);
            this.lblMPrivateKey.Name = "lblMPrivateKey";
            this.lblMPrivateKey.Size = new System.Drawing.Size(82, 20);
            this.lblMPrivateKey.TabIndex = 7;
            this.lblMPrivateKey.Text = "Private Key";
            // 
            // txtMMessage
            // 
            this.txtMMessage.Location = new System.Drawing.Point(3, 25);
            this.txtMMessage.Multiline = true;
            this.txtMMessage.Name = "txtMMessage";
            this.txtMMessage.Size = new System.Drawing.Size(653, 115);
            this.txtMMessage.TabIndex = 0;
            // 
            // lblMPublicKey
            // 
            this.lblMPublicKey.AutoSize = true;
            this.lblMPublicKey.Location = new System.Drawing.Point(3, 146);
            this.lblMPublicKey.Name = "lblMPublicKey";
            this.lblMPublicKey.Size = new System.Drawing.Size(77, 20);
            this.lblMPublicKey.TabIndex = 7;
            this.lblMPublicKey.Text = "Public Key";
            // 
            // btnMSign
            // 
            this.btnMSign.Location = new System.Drawing.Point(479, 315);
            this.btnMSign.Name = "btnMSign";
            this.btnMSign.Size = new System.Drawing.Size(177, 51);
            this.btnMSign.TabIndex = 2;
            this.btnMSign.Text = "Sign";
            this.btnMSign.UseVisualStyleBackColor = true;
            this.btnMSign.Click += new System.EventHandler(this.btnMSign_Click);
            // 
            // txtMPrime
            // 
            this.txtMPrime.BackColor = System.Drawing.SystemColors.Window;
            this.txtMPrime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMPrime.Location = new System.Drawing.Point(5, 282);
            this.txtMPrime.Name = "txtMPrime";
            this.txtMPrime.Size = new System.Drawing.Size(651, 27);
            this.txtMPrime.TabIndex = 6;
            // 
            // txtMPrivateKey
            // 
            this.txtMPrivateKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtMPrivateKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMPrivateKey.Location = new System.Drawing.Point(5, 226);
            this.txtMPrivateKey.Name = "txtMPrivateKey";
            this.txtMPrivateKey.Size = new System.Drawing.Size(651, 27);
            this.txtMPrivateKey.TabIndex = 6;
            // 
            // lblMMessage
            // 
            this.lblMMessage.AutoSize = true;
            this.lblMMessage.Location = new System.Drawing.Point(1, 2);
            this.lblMMessage.Name = "lblMMessage";
            this.lblMMessage.Size = new System.Drawing.Size(67, 20);
            this.lblMMessage.TabIndex = 1;
            this.lblMMessage.Text = "Message";
            // 
            // lblMMessageHash
            // 
            this.lblMMessageHash.AutoSize = true;
            this.lblMMessageHash.Location = new System.Drawing.Point(3, 378);
            this.lblMMessageHash.Name = "lblMMessageHash";
            this.lblMMessageHash.Size = new System.Drawing.Size(114, 20);
            this.lblMMessageHash.TabIndex = 4;
            this.lblMMessageHash.Text = "Message Digest";
            // 
            // txtMPublicKey
            // 
            this.txtMPublicKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtMPublicKey.Location = new System.Drawing.Point(5, 169);
            this.txtMPublicKey.Name = "txtMPublicKey";
            this.txtMPublicKey.Size = new System.Drawing.Size(651, 27);
            this.txtMPublicKey.TabIndex = 6;
            // 
            // txtMSignature
            // 
            this.txtMSignature.BackColor = System.Drawing.Color.LightGray;
            this.txtMSignature.Location = new System.Drawing.Point(5, 454);
            this.txtMSignature.Multiline = true;
            this.txtMSignature.Name = "txtMSignature";
            this.txtMSignature.ReadOnly = true;
            this.txtMSignature.Size = new System.Drawing.Size(554, 107);
            this.txtMSignature.TabIndex = 0;
            // 
            // btnMSignatureCopy
            // 
            this.btnMSignatureCopy.Location = new System.Drawing.Point(564, 528);
            this.btnMSignatureCopy.Name = "btnMSignatureCopy";
            this.btnMSignatureCopy.Size = new System.Drawing.Size(100, 33);
            this.btnMSignatureCopy.TabIndex = 2;
            this.btnMSignatureCopy.Text = "Copy";
            this.btnMSignatureCopy.UseVisualStyleBackColor = true;
            // 
            // txtMMessageHash
            // 
            this.txtMMessageHash.BackColor = System.Drawing.Color.LightGray;
            this.txtMMessageHash.Location = new System.Drawing.Point(5, 401);
            this.txtMMessageHash.Name = "txtMMessageHash";
            this.txtMMessageHash.ReadOnly = true;
            this.txtMMessageHash.Size = new System.Drawing.Size(552, 27);
            this.txtMMessageHash.TabIndex = 3;
            // 
            // lblMSignature
            // 
            this.lblMSignature.AutoSize = true;
            this.lblMSignature.Location = new System.Drawing.Point(5, 431);
            this.lblMSignature.Name = "lblMSignature";
            this.lblMSignature.Size = new System.Drawing.Size(121, 20);
            this.lblMSignature.TabIndex = 1;
            this.lblMSignature.Text = "Digital Signature";
            // 
            // btnMHashCopy
            // 
            this.btnMHashCopy.Location = new System.Drawing.Point(562, 398);
            this.btnMHashCopy.Name = "btnMHashCopy";
            this.btnMHashCopy.Size = new System.Drawing.Size(100, 33);
            this.btnMHashCopy.TabIndex = 2;
            this.btnMHashCopy.Text = "Copy";
            this.btnMHashCopy.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAutomatic);
            this.Controls.Add(this.rbManual);
            this.Controls.Add(this.rbAuto);
            this.Controls.Add(this.lblType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Elgamal Encryption";
            this.pnlOutput.ResumeLayout(false);
            this.pnlOutput.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlAutomatic.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Label lblDigest;
        private System.Windows.Forms.TextBox txtMessageDigest;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel pnlOutput;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Button btnPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Panel pnlAutomatic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMPrivateKey;
        private System.Windows.Forms.TextBox txtMMessage;
        private System.Windows.Forms.Label lblMPublicKey;
        private System.Windows.Forms.Button btnMSign;
        private System.Windows.Forms.TextBox txtMPrivateKey;
        private System.Windows.Forms.Label lblMMessage;
        private System.Windows.Forms.Label lblMMessageHash;
        private System.Windows.Forms.TextBox txtMPublicKey;
        private System.Windows.Forms.TextBox txtMSignature;
        private System.Windows.Forms.Button btnMSignatureCopy;
        private System.Windows.Forms.TextBox txtMMessageHash;
        private System.Windows.Forms.Label lblMSignature;
        private System.Windows.Forms.Button btnMHashCopy;
        private System.Windows.Forms.Label lblPrime;
        private System.Windows.Forms.TextBox txtPrime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMPrime;
    }
}

