using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form3_TCP_Client : Form
    {
        public Form3_TCP_Client()
        {
            InitializeComponent();
        }
        TcpClient tcpClient = new TcpClient();
        NetworkStream netStream;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5050);

            tcpClient.Connect(ipEndPoint);
            netStream = tcpClient.GetStream();

            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (netStream != null)
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(richTextBox1.Text);
                netStream.Write(data, 0, data.Length);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            try
            {
                if (tcpClient != null && tcpClient.Connected)
                {
                    tcpClient.Close();
                }
                if (netStream != null)
                {
                    netStream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }

    }
}
