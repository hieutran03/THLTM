using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form5_Server : Form
    {
        public Form5_Server()
        {
            InitializeComponent();
        }
        Thread acceptConnection;
        Thread reciecveMessage;
        TcpListener tcpListener;
        IPEndPoint ipepServer;
        List<NetworkStream> networkStreams = new List<NetworkStream>();
        private void button1_Click(object sender, EventArgs e)
        {
            ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), (int)numericUpDown1.Value);
            tcpListener = new TcpListener(ipepServer);
            tcpListener.Start();

            StartUnsafeThread();
            //Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            //serverThread.Start();
        }

        private void AddConnectionDetail(string[] row)
        {
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
        }

        private void StartUnsafeThread()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            //AcceptConnection();
            acceptConnection = new Thread(new ThreadStart(AcceptConnection));
            acceptConnection.Start();
        }

        private void ReceiveMessage(Socket client, NetworkStream ns)
        {
            string[] clientInfo = { ((IPEndPoint)client.RemoteEndPoint).Address.ToString(), ((IPEndPoint)client.RemoteEndPoint).Port.ToString() };
            while (client.Connected)
            {
                byte[] recv = new byte[1024];
                client.Receive(recv);
                SendAll(Encoding.UTF8.GetString(recv).Replace("\0", ""));
                richTextBox1.Text += Encoding.UTF8.GetString(recv).Replace("\0", "") + "\n";
            }
            client.Close();
            //removeItem(clientInfo[0], clientInfo[1]);
            networkStreams.Remove(ns);
        }
        /*
        private void SendRoomInfo()
        {
            string message = "";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                message += listView1.Items[i].SubItems[0].Text + ":" + listView1.Items[i].SubItems[1].Text + "#";
            }
            SendAll(message);
            
        }
        */
        private void SendAll(string mess)
        {
            foreach (NetworkStream ns in networkStreams)
            {
                byte[] data = Encoding.UTF8.GetBytes(mess+"\n");
                ns.Flush();
                ns.Write(data, 0, data.Length);
            }
        }
        private void AcceptConnection()
        {
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                Socket client = tcpClient.Client;
                NetworkStream ns = tcpClient.GetStream();
                networkStreams.Add(ns);

                //string[] clientInfo = { ((IPEndPoint)client.RemoteEndPoint).Address.ToString(), ((IPEndPoint)client.RemoteEndPoint).Port.ToString() };
                //AddConnectionDetail(clientInfo);
                //SendRoomInfo();

                Thread receiveMessage = new Thread(() => ReceiveMessage(client, ns));
                receiveMessage.Start();

                if (!client.Connected)
                {                   
                    break;
                }
            }
        }

        private void Form5_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            //acceptConnection?.Abort();
            //reciecveMessage?.Abort();
        }
        /*
        private void removeItem(string ipAddress, string port)
        {
            ListViewItem itemToRemove = null;
            foreach (ListViewItem item in listView1.Items)
            {
                string itemIPAddress = item.SubItems[0].Text;
                string itemPort = item.SubItems[1].Text;

                if (itemIPAddress == ipAddress && itemPort == port)
                {
                    itemToRemove = item;
                    break;
                }
            }

            if (itemToRemove != null)
            {
                listView1.Items.Remove(itemToRemove);
            }
        }
        */
    }
}
