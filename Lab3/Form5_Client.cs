using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form5_Client : Form
    {
        Thread acceptConnection;
        TcpClient tcpClient = new TcpClient();
        NetworkStream ns;

        public Form5_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse(textBox1.Text);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, (int)numericUpDown1.Value);

            tcpClient.Connect(ipEndPoint);
            ns = tcpClient.GetStream();


            if (tcpClient.Connected)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }
            Socket client = tcpClient.Client;
            acceptConnection = new Thread(() => ReceiveMessage(client));
            acceptConnection.Start();
        }

        private void ReceiveMessage(Socket client)
        {
            while (client.Connected)
            {
                try
                {
                    byte[] recv = new byte[1024];
                    client.Receive(recv);
                    string message = Encoding.UTF8.GetString(recv).Replace("\0", "").Replace("\r", "").Replace("\n", "");
                    /*
                    for (int i = 0; i < message.Split('#').Length - 1; i++)
                    {
                        string[] clientInfo = { message.Split('#')[i].Split(':')[0], message.Split('#')[i].Split(':')[1] };
                        bool addItem = true;

                        for (int j = 0; j < listView1.Items.Count; j++)
                        {
                            if (listView1.Items[j].SubItems[0].Text == message.Split('#')[i].Split(':')[0] && listView1.Items[j].SubItems[1].Text == message.Split('#')[i].Split(':')[1])
                            {
                                addItem = false;
                            }
                        }
                        if (addItem)
                        {
                            var listViewItem = new ListViewItem(clientInfo);
                            listView1.Items.Add(listViewItem);
                            //richTextBox1.Text += ("Welcome " + message.Replace("#", " to the chat") + "\n");
                        }
                    }
                    */

                    richTextBox1.Text += message + "\n";
                }
                catch (Exception e)
                {
                    client.Close();
                    MessageBox.Show("Client:" + e.Message);
                }
            }
            client.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(tbName.Text + ":" + textBox2.Text);
            ns.Write(data, 0, data.Length);
        }


        private void Form5_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (acceptConnection != null && acceptConnection.IsAlive)
            {
                acceptConnection.Abort();
            }
            tcpClient.Close();
        }
    }
}
