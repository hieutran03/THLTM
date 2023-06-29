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

namespace Lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var imapClient = new ImapClient();
            imapClient.Connect("imap.gmail.com", 993, true);
            try
            {
                imapClient.Authenticate(tbUsername.Text, tbPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                return;
            }

            var inbox = imapClient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);



            for (int i = inbox.Count - 1; i >= inbox.Count - 1 - 10; i--)
            {
                var message = inbox.GetMessage(i);
                var subject = message.Subject;
                var date = message.Date;
                var from = message.From;
                ListViewItem listViewItem = new ListViewItem(Convert.ToString(from));
                listViewItem.SubItems.Add(subject);
                listViewItem.SubItems.Add(Convert.ToString(date));
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
