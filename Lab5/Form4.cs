using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;

namespace Lab5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private ImapClient imapClient;
        private SmtpClient smtpClient;
        private void log_in()
        {
            imapClient = new ImapClient();
            smtpClient = new SmtpClient();
            try
            {
                imapClient.Connect(tbIMAP.Text, int.Parse(tbIMAP_Port.Text), true);
                smtpClient.Connect(tbSMTP.Text, int.Parse(tbSMTP_Port.Text), true);
            }
            catch
            {
                MessageBox.Show("Invallid IMAP or SMTP host");
                return;
            }
            try
            {
                imapClient.Authenticate(tbUsername.Text, tbPassword.Text);
                smtpClient.Authenticate(tbUsername.Text, tbPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                return;
            }
            groupBox2.Enabled = false;
            tbUsername.Enabled = false;
            btnRefresh.Enabled = true;
            btnRefresh.Visible = true;
            btnSendMail.Enabled = true;
            btnSendMail.Visible = true;
            btnLog_in.Enabled = true;
            btnLog_in.Text = "Đăng xuất";
            ShowMessage();
        }
        private void log_out()
        {
            imapClient = new ImapClient();
            smtpClient = new SmtpClient();
            listView1.Items.Clear();
            groupBox2.Enabled = true;
            btnLog_in.Text = "Đăng nhập";
            btnRefresh.Visible = false;
            btnSendMail.Visible = false;
        }
        private void ShowMessage()
        {
            var inbox = imapClient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            int index = 1;
            for (int i = inbox.Count - 1; i >= inbox.Count - 1 - 10; i--)
            {
                var message = inbox.GetMessage(i);
                var subject = message.Subject;
                var date = message.Date;
                var from = message.From;
                ListViewItem listViewItem = new ListViewItem(Convert.ToString(index));
                listViewItem.SubItems.Add(Convert.ToString(from));
                listViewItem.SubItems.Add(subject);
                listViewItem.SubItems.Add(Convert.ToString(date));
                listView1.Items.Add(listViewItem);
                index++;
            }
        }
        private void btnLog_in_Click(object sender, EventArgs e)
        {
            if (btnLog_in.Text == "Đăng nhập")
            {
                log_in();
            }
            else
            {
                log_out();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ShowMessage();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            Send_mail form = new Send_mail(smtpClient, username);
            form.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy chỉ mục của dòng được chọn
                int selectedIndex = listView1.SelectedIndices[0];

                // Lấy email tương ứng trong danh sách email
                var inbox = imapClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                int emailIndex = inbox.Count - 1 - selectedIndex;
                var email = inbox.GetMessage(emailIndex);

                // Hiển thị email
                MessageBox.Show($"Subject: {email.Subject}\nFrom: {email.From}\nDate: {email.Date}\n\n{email.TextBody}");
            }
        }

    }
}
