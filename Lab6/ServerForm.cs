using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class ServerForm : Form
    {
        TcpListener tcpListener;
        IPEndPoint ipepServer;
        SocketManager socketManager;
        List<TcpClient> clientList;

        public ServerForm()
        {
            InitializeComponent();
            socketManager = new SocketManager();
            clientList = new List<TcpClient>();
            if (string.IsNullOrEmpty(tbIP.Text))
            {
                tbIP.Text = socketManager.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }



        private void btnListen_Click(object sender, EventArgs e)
        {
            if(btnListen.Text == "Listen")
            {
                Listen();
            }
            else
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    CloseConnection();
                }));
                
            }
            
        }
        private void Listen()
        {
            btnListen.Text = "Close";
            ipepServer = new IPEndPoint(IPAddress.Parse(tbIP.Text), 8181);
            tcpListener = new TcpListener(ipepServer);
            tcpListener.Start();
            Thread threadConnection = new Thread(new ThreadStart(AcceptConnection));
            threadConnection.IsBackground = true;
            threadConnection.Start();
        }
        private void CloseConnection()
        {
            btnListen.Text = "Listen";
            byte[] msg = new byte[1024];
            string message = "Closed";
            msg = socketManager.EncryptData(message);
            foreach (TcpClient connectedClient in clientList)
            {
                NetworkStream ns = connectedClient.GetStream();
                ns.Write(msg);
            }
            try
            {
                tcpListener.Stop();
                foreach (TcpClient client in clientList)
                {
                    client.Close();

                }
                clientList.Clear();

            }
            catch { }
        }
        private void ReceiveMessage(Socket client)
        {
            while (client.Connected)
            {
                try
                {
                    
                    byte[] recv = new byte[1024];
                    client.Receive(recv);
                    string message = Convert.ToString(socketManager.DecryptData(recv));
                    if (message == "Disconnect")
                    {
                        TcpClient disconnectedClient = clientList.Find(element => element.Client == client);
                        clientList.Remove(disconnectedClient);
                        disconnectedClient.Close();
                        return;
                    }
                    this.Invoke((MethodInvoker)(() =>
                    {
                        lsvMessage.Items.Add(new ListViewItem() { Text = message });
                    }));
                    foreach (TcpClient connectedClient in clientList)
                    {
                        NetworkStream ns = connectedClient.GetStream();
                        ns.Write(recv);
                    }
                    

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
                    Socket client = tcpClient.Client;
                    clientList.Add(tcpClient);
                    IPEndPoint clientEndPoint = (IPEndPoint)tcpClient.Client.RemoteEndPoint;
                    string clientIPAddress = clientEndPoint.Address.ToString();
                    this.Invoke((MethodInvoker)(() =>
                    {
                        lsvMessage.Items.Add(new ListViewItem() { Text = clientIPAddress + " connected!\n" });
                    }));
                    

                    Thread acceptConnection = new Thread(() => ReceiveMessage(client));
                    acceptConnection.Start();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }

            }
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseConnection();
        }
    }
}
