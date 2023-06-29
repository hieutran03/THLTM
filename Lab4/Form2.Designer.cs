namespace Lab4
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
            btnPOST = new Button();
            richTextBox1 = new RichTextBox();
            tbData = new TextBox();
            tbURL = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPOST);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(tbData);
            groupBox1.Controls.Add(tbURL);
            groupBox1.Location = new Point(0, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 381);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnPOST
            // 
            btnPOST.Location = new Point(444, 16);
            btnPOST.Name = "btnPOST";
            btnPOST.Size = new Size(75, 29);
            btnPOST.TabIndex = 3;
            btnPOST.Text = "POST";
            btnPOST.UseVisualStyleBackColor = true;
            btnPOST.Click += btnPOST_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(23, 107);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(496, 253);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // tbData
            // 
            tbData.Location = new Point(23, 58);
            tbData.Name = "tbData";
            tbData.Size = new Size(396, 23);
            tbData.TabIndex = 1;
            tbData.Text = "data";
            // 
            // tbURL
            // 
            tbURL.Location = new Point(24, 20);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(395, 23);
            tbURL.TabIndex = 0;
            tbURL.Text = "https://uit.edu.vn/";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 405);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnPOST;
        private RichTextBox richTextBox1;
        private TextBox tbData;
        private TextBox tbURL;
    }
}