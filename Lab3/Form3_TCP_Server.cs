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
using System.Threading;

namespace Lab3
{
    public partial class Form3_TCP_Server : Form
    {
        TcpListener tcpListener;
        IPEndPoint ipepServer;
        public Form3_TCP_Server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Server Started\n");

            ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5050);
            tcpListener = new TcpListener(ipepServer);
            tcpListener.Start();

            StartUnsafeThread();

            button1.Enabled = false;
        }
        private void StartUnsafeThread()
        {
            Thread threadConnection = new Thread(new ThreadStart(AcceptConnection));
            threadConnection.Start();
        }
        private void ReceiveMessage(Socket client)
        {
            while (client.Connected)
            {
                try
                {
                    byte[] recv = new byte[1024];
                    client.Receive(recv);
                    richTextBox1.Text += Encoding.UTF8.GetString(recv).Replace("\0", "") + "\n";
                }
                catch (Exception ex)
                {
                    client.Close();
                    break;
                }
            }
        }


        private void AcceptConnection()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    Socket client = tcpClient.Client; // QUAN TRỌNG: Chỗ này lấy socket nè

                    IPEndPoint clientEndPoint = (IPEndPoint)tcpClient.Client.RemoteEndPoint;
                    string clientIPAddress = clientEndPoint.Address.ToString();
                    richTextBox1.AppendText(clientIPAddress + " connected!\n");

                    Thread acceptConnection = new Thread(() => ReceiveMessage(client));// Đưa socket vô để lập trình nè
                    acceptConnection.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
        private void Form3_TCP_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpListener.Stop();
        }
    }
}
