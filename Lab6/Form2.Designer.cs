namespace Lab6
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rtbCiphertext = new RichTextBox();
            label2 = new Label();
            rtbPlaintext = new RichTextBox();
            btnDecrypt = new Button();
            label1 = new Label();
            btnEncrypt = new Button();
            label3 = new Label();
            tbKeyword = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbKeyword);
            groupBox1.Controls.Add(rtbCiphertext);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rtbPlaintext);
            groupBox1.Controls.Add(btnDecrypt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnEncrypt);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vigenère";
            // 
            // rtbCiphertext
            // 
            rtbCiphertext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbCiphertext.Location = new Point(67, 233);
            rtbCiphertext.Name = "rtbCiphertext";
            rtbCiphertext.Size = new Size(715, 96);
            rtbCiphertext.TabIndex = 29;
            rtbCiphertext.Text = "";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(4, 233);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 31;
            label2.Text = "Ciphertext";
            // 
            // rtbPlaintext
            // 
            rtbPlaintext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbPlaintext.Location = new Point(67, 89);
            rtbPlaintext.Name = "rtbPlaintext";
            rtbPlaintext.Size = new Size(715, 82);
            rtbPlaintext.TabIndex = 30;
            rtbPlaintext.Text = "";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDecrypt.Location = new Point(397, 177);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(89, 23);
            btnDecrypt.TabIndex = 34;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(8, 113);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 33;
            label1.Text = "Plaintext";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEncrypt.Location = new Point(273, 177);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(89, 23);
            btnEncrypt.TabIndex = 35;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(30, 44);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 32;
            label3.Text = "Key";
            // 
            // tbKeyword
            // 
            tbKeyword.Location = new Point(67, 36);
            tbKeyword.Name = "tbKeyword";
            tbKeyword.Size = new Size(100, 23);
            tbKeyword.TabIndex = 36;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 386);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox rtbCiphertext;
        private Label label2;
        private RichTextBox rtbPlaintext;
        private Button btnDecrypt;
        private Label label1;
        private Button btnEncrypt;
        private Label label3;
        private TextBox tbKeyword;
    }
}