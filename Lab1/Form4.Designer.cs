namespace Lab1
{
    partial class Form4
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            tbSoTien = new TextBox();
            tbSoKm = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbGiaXang = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(393, 43);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 46);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Loại xe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 3;
            label2.Text = "Loại xăng/dầu";
            // 
            // button1
            // 
            button1.Location = new Point(46, 143);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 4;
            button1.Text = "Đổ đầy bình";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbSoTien
            // 
            tbSoTien.Location = new Point(221, 173);
            tbSoTien.Name = "tbSoTien";
            tbSoTien.ReadOnly = true;
            tbSoTien.Size = new Size(100, 23);
            tbSoTien.TabIndex = 5;
            // 
            // tbSoKm
            // 
            tbSoKm.Location = new Point(221, 237);
            tbSoKm.Name = "tbSoKm";
            tbSoKm.ReadOnly = true;
            tbSoKm.Size = new Size(100, 23);
            tbSoKm.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 176);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 7;
            label3.Text = "Số tiền phải trả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 240);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 8;
            label4.Text = "Số km đi được";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 89);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 9;
            label5.Text = "Giá xăng";
            // 
            // tbGiaXang
            // 
            tbGiaXang.Location = new Point(393, 81);
            tbGiaXang.Name = "tbGiaXang";
            tbGiaXang.ReadOnly = true;
            tbGiaXang.Size = new Size(121, 23);
            tbGiaXang.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 176);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "(đồng)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(327, 240);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 12;
            label7.Text = "(km)";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tbGiaXang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbSoKm);
            Controls.Add(tbSoTien);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox tbSoTien;
        private TextBox tbSoKm;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbGiaXang;
        private Label label6;
        private Label label7;
    }
}