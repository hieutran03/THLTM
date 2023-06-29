using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1_UDPClient : Form
    {
        public Form1_UDPClient()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
             
            UdpClient udpClient = new UdpClient();
            string Message = rtbMess.Text;
            Byte[] sendBytes = Encoding.UTF8.GetBytes(Message);
            int Port = int.Parse(tbPort.Text);
            udpClient.Send(sendBytes,sendBytes.Length,tbIPRemote.Text, Port);
        }
    }
}
