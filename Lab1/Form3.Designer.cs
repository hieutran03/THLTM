namespace Lab1
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
            label1 = new Label();
            tbNum = new TextBox();
            tbString = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 94);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào một số nguyên từ 0-9";
            label1.Click += label1_Click;
            // 
            // tbNum
            // 
            tbNum.Location = new Point(288, 91);
            tbNum.Name = "tbNum";
            tbNum.Size = new Size(100, 23);
            tbNum.TabIndex = 1;
            tbNum.TextChanged += tbNum_TextChanged;
            // 
            // tbString
            // 
            tbString.Location = new Point(84, 231);
            tbString.Name = "tbString";
            tbString.ReadOnly = true;
            tbString.Size = new Size(100, 23);
            tbString.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(505, 110);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(505, 161);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(505, 215);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 196);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 6;
            label2.Text = "Kết quả";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbString);
            Controls.Add(tbNum);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNum;
        private TextBox tbString;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}