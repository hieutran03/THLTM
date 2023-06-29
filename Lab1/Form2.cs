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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSoThuNhat.Text) || string.IsNullOrEmpty(tbSoThuHai.Text) || string.IsNullOrEmpty(tbSoThuBa.Text))
                return;
            double SoThuNhat = double.Parse(tbSoThuNhat.Text);
            double SoThuHai = double.Parse(tbSoThuHai.Text);
            double SoThuBa = double.Parse(tbSoThuBa.Text);
            double Max = SoThuNhat, Min = SoThuNhat;
            if (Max < SoThuHai)
            {
                Max = SoThuHai;
            }
            if (Max < SoThuBa)
            {
                Max = SoThuBa;
            }
            if (Min > SoThuHai)
            {
                Min = SoThuHai;
            }
            if (Min > SoThuBa)
            {
                Min = SoThuBa;
            }
            tbSoLonNhat.Text = Max.ToString();
            tbSoNhoNhat.Text = Min.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbSoThuNhat.Text = "";
            tbSoThuHai.Text = "";
            tbSoThuBa.Text = "";
            tbSoLonNhat.Text = "";
            tbSoNhoNhat.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tbSoThuNhat_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool isInteger = Int32.TryParse(tbSoThuNhat.Text, out number);
            if (!isInteger && !string.IsNullOrEmpty(tbSoThuNhat.Text))
            {
                MessageBox.Show("Du lieu nhap khong phai la so nguyen", "Loi");
                tbSoThuNhat.Text = "";
            }
        }

        private void tbSoThuHai_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool isInteger = Int32.TryParse(tbSoThuHai.Text, out number);
            if (!isInteger && !string.IsNullOrEmpty(tbSoThuHai.Text))
            {
                MessageBox.Show("Du lieu nhap khong phai la so nguyen", "Loi");
                tbSoThuHai.Text = "";
            }
        }

        private void tbSoThuBa_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool isInteger = Int32.TryParse(tbSoThuBa.Text, out number);
            if (!isInteger && !string.IsNullOrEmpty(tbSoThuBa.Text))
            {
                MessageBox.Show("Du lieu nhap khong phai la so nguyen", "Loi");
                tbSoThuBa.Text = "";
            }
        }
    }
}
