using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void DownloadtHTMLFile(string url, string fileurl)
        {
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(url);
            myClient.DownloadFile(url, fileurl);
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadtHTMLFile(tbURL.Text, tbFileURL.Text);
            StreamReader sr = new StreamReader(tbFileURL.Text);
            richTextBox1.Text += sr.ReadToEnd();
        }
    }
}
