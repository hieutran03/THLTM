namespace Lab2
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
            tbFileName = new TextBox();
            tbSize = new TextBox();
            tbWordsCount = new TextBox();
            tbURL = new TextBox();
            tbLinesCount = new TextBox();
            tbCharectersCount = new TextBox();
            rtbInput = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tbFileName
            // 
            tbFileName.Location = new Point(115, 89);
            tbFileName.Name = "tbFileName";
            tbFileName.ReadOnly = true;
            tbFileName.Size = new Size(100, 23);
            tbFileName.TabIndex = 0;
            // 
            // tbSize
            // 
            tbSize.Location = new Point(115, 131);
            tbSize.Name = "tbSize";
            tbSize.ReadOnly = true;
            tbSize.Size = new Size(100, 23);
            tbSize.TabIndex = 1;
            // 
            // tbWordsCount
            // 
            tbWordsCount.Location = new Point(115, 262);
            tbWordsCount.Name = "tbWordsCount";
            tbWordsCount.ReadOnly = true;
            tbWordsCount.Size = new Size(100, 23);
            tbWordsCount.TabIndex = 2;
            // 
            // tbURL
            // 
            tbURL.Location = new Point(115, 176);
            tbURL.Name = "tbURL";
            tbURL.ReadOnly = true;
            tbURL.Size = new Size(100, 23);
            tbURL.TabIndex = 3;
            // 
            // tbLinesCount
            // 
            tbLinesCount.Location = new Point(115, 220);
            tbLinesCount.Name = "tbLinesCount";
            tbLinesCount.ReadOnly = true;
            tbLinesCount.Size = new Size(100, 23);
            tbLinesCount.TabIndex = 4;
            // 
            // tbCharectersCount
            // 
            tbCharectersCount.Location = new Point(115, 305);
            tbCharectersCount.Name = "tbCharectersCount";
            tbCharectersCount.ReadOnly = true;
            tbCharectersCount.Size = new Size(100, 23);
            tbCharectersCount.TabIndex = 5;
            // 
            // rtbInput
            // 
            rtbInput.Location = new Point(241, 31);
            rtbInput.Name = "rtbInput";
            rtbInput.ReadOnly = true;
            rtbInput.Size = new Size(340, 333);
            rtbInput.TabIndex = 6;
            rtbInput.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 92);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "File name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 134);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 8;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 176);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 9;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 220);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "Lines Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 265);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 11;
            label5.Text = "Words Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 308);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 12;
            label6.Text = "Charecters Count";
            // 
            // button1
            // 
            button1.Location = new Point(42, 19);
            button1.Name = "button1";
            button1.Size = new Size(173, 47);
            button1.TabIndex = 13;
            button1.Text = "Read From File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(42, 356);
            button2.Name = "button2";
            button2.Size = new Size(173, 42);
            button2.TabIndex = 14;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 439);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbInput);
            Controls.Add(tbCharectersCount);
            Controls.Add(tbLinesCount);
            Controls.Add(tbURL);
            Controls.Add(tbWordsCount);
            Controls.Add(tbSize);
            Controls.Add(tbFileName);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFileName;
        private TextBox tbSize;
        private TextBox tbWordsCount;
        private TextBox tbURL;
        private TextBox tbLinesCount;
        private TextBox tbCharectersCount;
        private RichTextBox rtbInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}