﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_UDPClient form = new Form1_UDPClient();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1_UDPServer form = new Form1_UDPServer();
            form.Show();
        }
    }
}
