namespace Lab2
{
    partial class Form5
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
            rtbData = new RichTextBox();
            btnZip = new Button();
            btnExtract = new Button();
            SuspendLayout();
            // 
            // rtbData
            // 
            rtbData.Location = new Point(122, 12);
            rtbData.Name = "rtbData";
            rtbData.Size = new Size(380, 292);
            rtbData.TabIndex = 0;
            rtbData.Text = "";
            // 
            // btnZip
            // 
            btnZip.Location = new Point(12, 74);
            btnZip.Name = "btnZip";
            btnZip.Size = new Size(75, 46);
            btnZip.TabIndex = 1;
            btnZip.Text = "Nén file";
            btnZip.UseVisualStyleBackColor = true;
            btnZip.Click += btnZip_Click;
            // 
            // btnExtract
            // 
            btnExtract.Location = new Point(12, 165);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(75, 43);
            btnExtract.TabIndex = 2;
            btnExtract.Text = "Giải nén";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 375);
            Controls.Add(btnExtract);
            Controls.Add(btnZip);
            Controls.Add(rtbData);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbData;
        private Button btnZip;
        private Button btnExtract;
    }
}