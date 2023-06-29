using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            if (string.IsNullOrEmpty(tbNum.Text))
            {
                return;
            }
            int num = int.Parse(tbNum.Text);
            switch (num)
            {
                case 0:
                    str = "không"; break;
                case 1:
                    str = "một"; break;
                case 2:
                    str = "hai"; break;
                case 3:
                    str = "ba"; break;
                case 4:
                    str = "bốn"; break;
                case 5:
                    str = "năm"; break;
                case 6:
                    str = "sáu"; break;
                case 7:
                    str = "bảy"; break;
                case 8:
                    str = "tám"; break;
                case 9:
                    str = "chín"; break;
                default:
                    str = ""; break;
            }
            tbString.Text = str;
        }

        private void tbNum_TextChanged(object sender, EventArgs e)
        {
            int num;
            bool isInteger = Int32.TryParse(tbNum.Text, out num);
            if ((!isInteger || num > 9 || num < 0) && !string.IsNullOrEmpty(tbNum.Text))
            {
                MessageBox.Show("Du lieu loi!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbString.Text = "";
                tbNum.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbString.Text = "";
            tbNum.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
