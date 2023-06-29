using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Lab3
{
    public partial class Form2 : Form
    {
        private Thread serverThread;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serverThread = new Thread(StartServer);
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        void StartServer()
        {
            try
            {
                int bytesRecieved = 0;
                byte[] recv = new byte[1024];
                Socket clientSocket;
                Socket listenerSocket = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp
                );
                IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(10);
                clientSocket = listenerSocket.Accept();
                listView1.Invoke((MethodInvoker)(() => listView1.Items.Add(new ListViewItem("New client connected"))));
                while (clientSocket.Connected)
                {
                    string text = "";
                    do
                    {
                        bytesRecieved = clientSocket.Receive(recv);
                        text += Encoding.UTF8.GetString(recv);
                    } while (text[text.Length - 1] == '\n');
                    listView1.Invoke((MethodInvoker)(() => listView1.Items.Add(new ListViewItem(text))));
                }
                listenerSocket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void Form2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (serverThread != null && serverThread.IsAlive)
            {
                serverThread.Abort();
            }
        }
    }
}
