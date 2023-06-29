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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5_Server form = new Form5_Server();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5_Client form = new Form5_Client();
            form.Show();
        }
    }
}
