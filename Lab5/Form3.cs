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
using MailKit.Net.Pop3;

namespace Lab5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pop3Client pop3Client = new Pop3Client();
            pop3Client.Connect("pop.gmail.com", 995, true);
            pop3Client.Authenticate(tbUsername.Text, tbPassword.Text);
            
            var messageCount = Convert.ToInt32(pop3Client.GetMessageCount());



            for (int i = messageCount - 1; i >= messageCount - 1 - 10; i--)
            {
                var message = pop3Client.GetMessage(i);
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
