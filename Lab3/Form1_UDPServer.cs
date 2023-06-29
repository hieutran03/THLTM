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
using System.Threading;

namespace Lab3
{
    public partial class Form1_UDPServer : Form
    {
        public Form1_UDPServer()
        {
            InitializeComponent();
        }
        public void serverThread()
        {
            int Port = int.Parse(tbPort.Text);
            UdpClient udpClient = new UdpClient(Port);
            while (true)
            {
                IPEndPoint RemoteIpEndpoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndpoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string mess = RemoteIpEndpoint.Address.ToString() + ": " + returnData.ToString();
                rtbMess.Text += mess + "\n";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread ThdUdpServer = new Thread(new ThreadStart(serverThread));
            ThdUdpServer.Start();
        }

        private void Form1_UDPServer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
