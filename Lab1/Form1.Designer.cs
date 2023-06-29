namespace Lab1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbSoA = new TextBox();
            tbSoB = new TextBox();
            label4 = new Label();
            tbTong = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(299, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 32);
            label1.TabIndex = 0;
            label1.Text = "Tính tổng 2 số nguyên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(124, 104);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Số A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(125, 155);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Số B";
            label3.Click += label3_Click;
            // 
            // tbSoA
            // 
            tbSoA.Location = new Point(213, 104);
            tbSoA.Name = "tbSoA";
            tbSoA.Size = new Size(100, 23);
            tbSoA.TabIndex = 3;
            tbSoA.TextChanged += tbSoA_TextChanged;
            // 
            // tbSoB
            // 
            tbSoB.Location = new Point(213, 152);
            tbSoB.Name = "tbSoB";
            tbSoB.Size = new Size(100, 23);
            tbSoB.TabIndex = 4;
            tbSoB.TextChanged += tbSoB_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(125, 203);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 5;
            label4.Text = "Tổng";
            label4.Click += label4_Click;
            // 
            // tbTong
            // 
            tbTong.Location = new Point(213, 200);
            tbTong.Name = "tbTong";
            tbTong.ReadOnly = true;
            tbTong.Size = new Size(100, 23);
            tbTong.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(440, 277);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tbTong);
            Controls.Add(label4);
            Controls.Add(tbSoB);
            Controls.Add(tbSoA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbSoA;
        private TextBox tbSoB;
        private Label label4;
        private TextBox tbTong;
        private Button button1;
    }
}