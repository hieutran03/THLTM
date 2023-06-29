namespace Lab6
{
    partial class Form1
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
            nbShift = new NumericUpDown();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            rtbCiphertext = new RichTextBox();
            rtbPlaintext = new RichTextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nbShift).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nbShift
            // 
            nbShift.Location = new Point(72, 32);
            nbShift.Name = "nbShift";
            nbShift.Size = new Size(120, 23);
            nbShift.TabIndex = 12;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDecrypt.Location = new Point(392, 173);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(89, 23);
            btnDecrypt.TabIndex = 10;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEncrypt.Location = new Point(268, 173);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(89, 23);
            btnEncrypt.TabIndex = 11;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(-1, 229);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "Ciphertext";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(25, 40);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 8;
            label3.Text = "Shift";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 109);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 9;
            label1.Text = "Plaintext";
            // 
            // rtbCiphertext
            // 
            rtbCiphertext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbCiphertext.Location = new Point(62, 229);
            rtbCiphertext.Name = "rtbCiphertext";
            rtbCiphertext.Size = new Size(715, 96);
            rtbCiphertext.TabIndex = 5;
            rtbCiphertext.Text = "";
            // 
            // rtbPlaintext
            // 
            rtbPlaintext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbPlaintext.Location = new Point(62, 85);
            rtbPlaintext.Name = "rtbPlaintext";
            rtbPlaintext.Size = new Size(715, 82);
            rtbPlaintext.TabIndex = 6;
            rtbPlaintext.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbCiphertext);
            groupBox1.Controls.Add(nbShift);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rtbPlaintext);
            groupBox1.Controls.Add(btnDecrypt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnEncrypt);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(796, 331);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Casesar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nbShift).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown nbShift;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Label label2;
        private Label label3;
        private Label label1;
        private RichTextBox rtbCiphertext;
        private RichTextBox rtbPlaintext;
        private GroupBox groupBox1;
    }
}