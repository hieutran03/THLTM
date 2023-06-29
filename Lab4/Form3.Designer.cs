namespace Lab4
{
    partial class Form3
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
            btnDownload = new Button();
            richTextBox1 = new RichTextBox();
            tbFileURL = new TextBox();
            tbURL = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDownload);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(tbFileURL);
            groupBox1.Controls.Add(tbURL);
            groupBox1.Location = new Point(33, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 377);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(444, 16);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 29);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(23, 107);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(496, 253);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // tbFileURL
            // 
            tbFileURL.Location = new Point(23, 58);
            tbFileURL.Name = "tbFileURL";
            tbFileURL.Size = new Size(396, 23);
            tbFileURL.TabIndex = 1;
            tbFileURL.Text = "D:/uit.html";
            // 
            // tbURL
            // 
            tbURL.Location = new Point(24, 20);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(395, 23);
            tbURL.TabIndex = 0;
            tbURL.Text = "https://uit.edu.vn/";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 431);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDownload;
        private RichTextBox richTextBox1;
        private TextBox tbFileURL;
        private TextBox tbURL;
    }
}