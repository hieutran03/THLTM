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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            tbURL.Text = "https://google.com";
        }

        private string GetHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri(tbURL.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var html = GetHTML(tbURL.Text);

            ViewSource viewSource = new ViewSource(html);
            viewSource.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var html = GetHTML(tbURL.Text);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "|*.html||*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(html);
                sw.Close();
                fs.Close();
            }
        }


    }
}
