namespace Lab1
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
            tbSoThuNhat = new TextBox();
            tbSoThuHai = new TextBox();
            tbSoThuBa = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tbSoLonNhat = new TextBox();
            tbSoNhoNhat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // tbSoThuNhat
            // 
            tbSoThuNhat.Location = new Point(115, 77);
            tbSoThuNhat.Name = "tbSoThuNhat";
            tbSoThuNhat.Size = new Size(100, 23);
            tbSoThuNhat.TabIndex = 0;
            tbSoThuNhat.TextChanged += tbSoThuNhat_TextChanged;
            // 
            // tbSoThuHai
            // 
            tbSoThuHai.Location = new Point(332, 77);
            tbSoThuHai.Name = "tbSoThuHai";
            tbSoThuHai.Size = new Size(100, 23);
            tbSoThuHai.TabIndex = 1;
            tbSoThuHai.TextChanged += tbSoThuHai_TextChanged;
            // 
            // tbSoThuBa
            // 
            tbSoThuBa.Location = new Point(541, 77);
            tbSoThuBa.Name = "tbSoThuBa";
            tbSoThuBa.Size = new Size(100, 23);
            tbSoThuBa.TabIndex = 2;
            tbSoThuBa.TextChanged += tbSoThuBa_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(140, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(332, 203);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(541, 203);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tbSoLonNhat
            // 
            tbSoLonNhat.Location = new Point(275, 346);
            tbSoLonNhat.Name = "tbSoLonNhat";
            tbSoLonNhat.ReadOnly = true;
            tbSoLonNhat.Size = new Size(100, 23);
            tbSoLonNhat.TabIndex = 6;
            tbSoLonNhat.TextChanged += textBox4_TextChanged;
            // 
            // tbSoNhoNhat
            // 
            tbSoNhoNhat.Location = new Point(483, 346);
            tbSoNhoNhat.Name = "tbSoNhoNhat";
            tbSoNhoNhat.ReadOnly = true;
            tbSoNhoNhat.Size = new Size(100, 23);
            tbSoNhoNhat.TabIndex = 7;
            tbSoNhoNhat.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 80);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 8;
            label1.Text = "Số thứ nhất";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 80);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Số thứ hai";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 80);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Số thứ ba";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 349);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Số lớn nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 349);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 12;
            label5.Text = "Số nhỏ nhất";
            label5.Click += label5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSoNhoNhat);
            Controls.Add(tbSoLonNhat);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbSoThuBa);
            Controls.Add(tbSoThuHai);
            Controls.Add(tbSoThuNhat);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSoThuNhat;
        private TextBox tbSoThuHai;
        private TextBox tbSoThuBa;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox tbSoLonNhat;
        private TextBox tbSoNhoNhat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}