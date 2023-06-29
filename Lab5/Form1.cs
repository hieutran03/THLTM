using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 465, true);
            smtpClient.Authenticate(tbFrom.Text, tbPassword.Text);

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Tran Cao Hieu", tbFrom.Text));
            message.To.Add(new MailboxAddress("", tbTo.Text));
            message.Subject = tbSubject.Text;
            message.Body = new TextPart("plain")
            {
                Text = rtbBody.Text
            };

            smtpClient.Send(message);
        }
    }
}