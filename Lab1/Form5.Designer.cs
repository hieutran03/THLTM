namespace Lab1
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
            label1 = new Label();
            label2 = new Label();
            tbA = new TextBox();
            tbB = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            tbKq = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 98);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 98);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập B";
            // 
            // tbA
            // 
            tbA.Location = new Point(189, 95);
            tbA.Name = "tbA";
            tbA.Size = new Size(100, 23);
            tbA.TabIndex = 2;
            tbA.TextChanged += tbA_TextChanged;
            // 
            // tbB
            // 
            tbB.Location = new Point(451, 95);
            tbB.Name = "tbB";
            tbB.Size = new Size(100, 23);
            tbB.TabIndex = 3;
            tbB.TextChanged += tbB_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(137, 178);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 4;
            button1.Text = "Tính các giá trị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(327, 178);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(476, 178);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(137, 238);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 7;
            label3.Text = "Kết quả";
            // 
            // tbKq
            // 
            tbKq.BackColor = SystemColors.Control;
            tbKq.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbKq.ForeColor = Color.DodgerBlue;
            tbKq.Location = new Point(137, 266);
            tbKq.Multiline = true;
            tbKq.Name = "tbKq";
            tbKq.ReadOnly = true;
            tbKq.Size = new Size(431, 101);
            tbKq.TabIndex = 8;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbB);
            Controls.Add(tbA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbKq);
            ForeColor = SystemColors.Desktop;
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbA;
        private TextBox tbB;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private TextBox tbKq;
    }
}