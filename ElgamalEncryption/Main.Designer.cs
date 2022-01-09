
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.txtOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOutput.Location = new System.Drawing.Point(3, 76);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(653, 107);
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
            this.txtMessageDigest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.btnSign);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 204);
            this.panel1.TabIndex = 5;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDigest);
            this.panel2.Controls.Add(this.txtOutput);
            this.panel2.Controls.Add(this.lblSignature);
            this.panel2.Controls.Add(this.txtMessageDigest);
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Location = new System.Drawing.Point(11, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 193);
            this.panel2.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 218);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Elgamal Encryption";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInfo;
    }
}

