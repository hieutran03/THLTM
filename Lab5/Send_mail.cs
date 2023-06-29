using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab5
{
    public partial class Send_mail : Form
    {
        private SmtpClient smtpClient;
        private string username;
        public Send_mail(SmtpClient smtpClient, string username)
        {
            InitializeComponent();
            this.smtpClient = smtpClient;
            tbFrom.Text = username;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            string name = tbFrom.Text.Substring(0, tbFrom.Text.IndexOf('@'));

            message.From.Add(new MailboxAddress(name, tbFrom.Text));
            message.To.Add(new MailboxAddress("", tbTo.Text));
            message.Subject = tbSubject.Text;

            var builder = new BodyBuilder();
            if (cbHTML.Checked)
            {
                builder.HtmlBody = rtbBody.Text;
            }
            else
            {
                builder.TextBody = rtbBody.Text;
            }

            // Đính kèm file nếu đã được chọn
            if (!string.IsNullOrEmpty(tbAttachment.Text))
            {
                var attachment = new MimePart();
                byte[] fileBytes;
                using (var stream = File.OpenRead(tbAttachment.Text))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        stream.CopyTo(memoryStream);
                        fileBytes = memoryStream.ToArray();
                    }
                }
                attachment.Content = new MimeContent(new MemoryStream(fileBytes));
                attachment.ContentDisposition = new ContentDisposition(ContentDisposition.Attachment);
                attachment.ContentTransferEncoding = ContentEncoding.Base64;
                attachment.FileName = Path.GetFileName(tbAttachment.Text);
                builder.Attachments.Add(attachment);
            }


            message.Body = builder.ToMessageBody();

            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbAttachment.Text = openFileDialog.FileName;
                }
            }
        }

        private void Send_mail_Load(object sender, EventArgs e)
        {
            tbFrom.Text = username;
        }
    }
}
