using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3_TCP_Client form = new Form3_TCP_Client();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3_TCP_Server form = new Form3_TCP_Server();
            form.Show();
        }
    }
}
