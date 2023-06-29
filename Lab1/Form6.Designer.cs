namespace Lab1
{
    partial class Form6
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
            daGridBangChia = new DataGridView();
            ColDiaChiMang = new DataGridViewTextBoxColumn();
            ColDiaChiDau = new DataGridViewTextBoxColumn();
            ColDiaChiCuoi = new DataGridViewTextBoxColumn();
            ColDiaChiBC = new DataGridViewTextBoxColumn();
            tbNetAddr = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbSoMangCon = new TextBox();
            butChiaMang = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)daGridBangChia).BeginInit();
            SuspendLayout();
            // 
            // daGridBangChia
            // 
            daGridBangChia.AllowUserToAddRows = false;
            daGridBangChia.AllowUserToDeleteRows = false;
            daGridBangChia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            daGridBangChia.Columns.AddRange(new DataGridViewColumn[] { ColDiaChiMang, ColDiaChiDau, ColDiaChiCuoi, ColDiaChiBC });
            daGridBangChia.Location = new Point(276, 42);
            daGridBangChia.Name = "daGridBangChia";
            daGridBangChia.ReadOnly = true;
            daGridBangChia.RowTemplate.Height = 25;
            daGridBangChia.Size = new Size(459, 396);
            daGridBangChia.TabIndex = 0;
            // 
            // ColDiaChiMang
            // 
            ColDiaChiMang.HeaderText = "Địa Chỉ Mạng";
            ColDiaChiMang.Name = "ColDiaChiMang";
            ColDiaChiMang.ReadOnly = true;
            // 
            // ColDiaChiDau
            // 
            ColDiaChiDau.HeaderText = "Địa Chỉ Đầu";
            ColDiaChiDau.Name = "ColDiaChiDau";
            ColDiaChiDau.ReadOnly = true;
            // 
            // ColDiaChiCuoi
            // 
            ColDiaChiCuoi.HeaderText = "Địa Chỉ Cuối";
            ColDiaChiCuoi.Name = "ColDiaChiCuoi";
            ColDiaChiCuoi.ReadOnly = true;
            // 
            // ColDiaChiBC
            // 
            ColDiaChiBC.HeaderText = "Địa Chỉ Broadcast";
            ColDiaChiBC.Name = "ColDiaChiBC";
            ColDiaChiBC.ReadOnly = true;
            // 
            // tbNetAddr
            // 
            tbNetAddr.Location = new Point(35, 71);
            tbNetAddr.Name = "tbNetAddr";
            tbNetAddr.Size = new Size(147, 23);
            tbNetAddr.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 2;
            label1.Text = "Địa chỉ mạng/ Subnet mask( x.x.x.x/x)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 106);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 3;
            label2.Text = "Số mạng con";
            // 
            // tbSoMangCon
            // 
            tbSoMangCon.Location = new Point(35, 135);
            tbSoMangCon.Name = "tbSoMangCon";
            tbSoMangCon.Size = new Size(147, 23);
            tbSoMangCon.TabIndex = 4;
            // 
            // butChiaMang
            // 
            butChiaMang.Location = new Point(67, 186);
            butChiaMang.Name = "butChiaMang";
            butChiaMang.Size = new Size(75, 23);
            butChiaMang.TabIndex = 5;
            butChiaMang.Text = "Chia mạng";
            butChiaMang.UseVisualStyleBackColor = true;
            butChiaMang.Click += butChiaMang_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 259);
            label3.Name = "label3";
            label3.Size = new Size(184, 15);
            label3.TabIndex = 6;
            label3.Text = "Em chưa làm test lỗi dữ liệu vào ạ";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(butChiaMang);
            Controls.Add(tbSoMangCon);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNetAddr);
            Controls.Add(daGridBangChia);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)daGridBangChia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView daGridBangChia;
        private TextBox tbNetAddr;
        private Label label1;
        private Label label2;
        private TextBox tbSoMangCon;
        private Button butChiaMang;
        private DataGridViewTextBoxColumn ColDiaChiMang;
        private DataGridViewTextBoxColumn ColDiaChiDau;
        private DataGridViewTextBoxColumn ColDiaChiCuoi;
        private DataGridViewTextBoxColumn ColDiaChiBC;
        private Label label3;
    }
}