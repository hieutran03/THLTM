namespace Lab1
{
    partial class Form3_1
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
            tbNum = new TextBox();
            tbString = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // tbNum
            // 
            tbNum.Location = new Point(250, 82);
            tbNum.Name = "tbNum";
            tbNum.Size = new Size(100, 23);
            tbNum.TabIndex = 0;
            tbNum.TextChanged += tbNum_TextChanged;
            // 
            // tbString
            // 
            tbString.Location = new Point(104, 206);
            tbString.Name = "tbString";
            tbString.ReadOnly = true;
            tbString.Size = new Size(367, 23);
            tbString.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 85);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 2;
            label1.Text = "Nhập số nguyên(0-999)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 175);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Kết quả";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(488, 85);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(488, 149);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(488, 206);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbString);
            Controls.Add(tbNum);
            Name = "Form3_1";
            Text = "Form3_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNum;
        private TextBox tbString;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}