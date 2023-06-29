namespace Lab5
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            btnSendMail = new Button();
            btnLog_in = new Button();
            lbPassword = new Label();
            lbAccount = new Label();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            groupBox2 = new GroupBox();
            tbSMTP = new TextBox();
            tbIMAP = new TextBox();
            label1 = new Label();
            tbSMTP_Port = new TextBox();
            label2 = new Label();
            tbIMAP_Port = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(15, 173);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 265);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "From";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Subject";
            columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Datetime";
            columnHeader4.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSendMail);
            groupBox1.Controls.Add(btnLog_in);
            groupBox1.Controls.Add(lbPassword);
            groupBox1.Controls.Add(lbAccount);
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Controls.Add(tbUsername);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(85, 96);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Visible = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSendMail
            // 
            btnSendMail.Location = new Point(2, 96);
            btnSendMail.Name = "btnSendMail";
            btnSendMail.Size = new Size(75, 23);
            btnSendMail.TabIndex = 12;
            btnSendMail.Text = "Gửi mail";
            btnSendMail.UseVisualStyleBackColor = true;
            btnSendMail.Visible = false;
            btnSendMail.Click += btnSendMail_Click;
            // 
            // btnLog_in
            // 
            btnLog_in.Location = new Point(166, 96);
            btnLog_in.Name = "btnLog_in";
            btnLog_in.Size = new Size(92, 23);
            btnLog_in.TabIndex = 11;
            btnLog_in.Text = "Đăng nhập";
            btnLog_in.UseVisualStyleBackColor = true;
            btnLog_in.Click += btnLog_in_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(15, 70);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 10;
            lbPassword.Text = "Mật khẩu";
            // 
            // lbAccount
            // 
            lbAccount.AutoSize = true;
            lbAccount.Location = new Point(15, 25);
            lbAccount.Name = "lbAccount";
            lbAccount.Size = new Size(57, 15);
            lbAccount.TabIndex = 9;
            lbAccount.Text = "Tài khoản";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(85, 67);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(149, 23);
            tbPassword.TabIndex = 8;
            tbPassword.Text = "fqxsmndiswhdvnow";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(85, 22);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(149, 23);
            tbUsername.TabIndex = 7;
            tbUsername.Text = "hieumdg@gmail.com";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbSMTP);
            groupBox2.Controls.Add(tbIMAP);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tbSMTP_Port);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbIMAP_Port);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(292, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 125);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cài đặt";
            // 
            // tbSMTP
            // 
            tbSMTP.Location = new Point(324, 25);
            tbSMTP.Name = "tbSMTP";
            tbSMTP.Size = new Size(153, 23);
            tbSMTP.TabIndex = 15;
            tbSMTP.Text = "smtp.gmail.com";
            tbSMTP.TextAlign = HorizontalAlignment.Center;
            // 
            // tbIMAP
            // 
            tbIMAP.Location = new Point(60, 25);
            tbIMAP.Name = "tbIMAP";
            tbIMAP.Size = new Size(166, 23);
            tbIMAP.TabIndex = 14;
            tbIMAP.Text = "imap.gmail.com";
            tbIMAP.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 8;
            label1.Text = "IMAP";
            // 
            // tbSMTP_Port
            // 
            tbSMTP_Port.Location = new Point(324, 72);
            tbSMTP_Port.Name = "tbSMTP_Port";
            tbSMTP_Port.Size = new Size(100, 23);
            tbSMTP_Port.TabIndex = 13;
            tbSMTP_Port.Text = "465";
            tbSMTP_Port.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 9;
            label2.Text = "Port";
            // 
            // tbIMAP_Port
            // 
            tbIMAP_Port.Location = new Point(60, 72);
            tbIMAP_Port.Name = "tbIMAP_Port";
            tbIMAP_Port.Size = new Size(100, 23);
            tbIMAP_Port.TabIndex = 12;
            tbIMAP_Port.Text = "993";
            tbIMAP_Port.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 25);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 10;
            label4.Text = "SMTP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 75);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 11;
            label3.Text = "Port";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnRefresh;
        private Button btnSendMail;
        private Button btnLog_in;
        private Label lbPassword;
        private Label lbAccount;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private TextBox tbSMTP;
        private TextBox tbIMAP;
        private Label label1;
        private TextBox tbSMTP_Port;
        private Label label2;
        private TextBox tbIMAP_Port;
        private Label label4;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}