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

namespace Lab6
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            socketManager = new SocketManager();

        }

        TcpClient tcpClient = new TcpClient();
        NetworkStream netStream;
        SocketManager socketManager;

        private void btnConnect_Click(object sender, EventArgs e)
        {

            if (btnConnect.Text == "Connect")
            {
                Connect();
            }
            else
            {
                Disconnect();
            }
            if (tcpClient.Connected)
            {
                Thread ListenThread = new Thread(() =>
                {
                    while (true)
                    {
                        try
                        {
                            byte[] data = new byte[1024];
                            netStream.Read(data, 0, data.Length);
                            string message = Convert.ToString(socketManager.DecryptData(data));
                            if (message == "Closed") 
                            {
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    Disconnect();
                                }));
                                Disconnect();
                                return;
                            }
                            this.Invoke((MethodInvoker)(() =>
                            {
                                lsvMessage.Items.Add(new ListViewItem { Text = message });
                            }));

                        }
                        catch
                        {

                        }
                    }

                });
                ListenThread.IsBackground = true;
                ListenThread.Start();

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (netStream != null && !string.IsNullOrEmpty(tbMessage.Text))
            {
                string message = tbName.Text + " : " + tbMessage.Text;
                byte[] data = socketManager.EncryptData(message);
                netStream.Write(data, 0, data.Length);
            }
        }
        private void Connect()
        {
            gbChat.Enabled = true;
            gbInfo.Enabled = false;
            btnConnect.Text = "Disconnect";
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(tbIP.Text), 8181);
            tcpClient = new TcpClient();
            tcpClient.Connect(ipEndPoint);
            netStream = tcpClient.GetStream();
        }
        private void Disconnect()
        {
            gbChat.Enabled = false;
            gbInfo.Enabled = true;
            lsvMessage.Clear();
            btnConnect.Text = "Connect";
            try
            {
                string message = "Disconnect";
                byte[] data = socketManager.EncryptData(message);
                netStream.Write(data, 0, data.Length);
            }
            catch{ }
            if (tcpClient != null && tcpClient.Connected)
            {
                tcpClient.Close();
            }
            if (netStream != null)
            {
                netStream.Close();
            }
            
        }
    }
}
