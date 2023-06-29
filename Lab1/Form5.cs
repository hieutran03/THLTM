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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long giaiThuaA = 1;
            long giaiThuaB = 1;
            long S1 = 0;
            long S2 = 0;
            long S3 = 0;
            int A = int.Parse(tbA.Text);
            int B = int.Parse(tbB.Text);
            for (int i = 1; i <= A; i++)
            {
                giaiThuaA *= i;
                S1 += i;
            }
            for (int i = 1; i <= B; i++)
            {
                giaiThuaB *= i;
                S2 += i;
                S3 += (long)Math.Pow((double)A, (double)i);
            }
            string ketQua = "";
            ketQua += "A! = " + giaiThuaA + "\t\t";
            ketQua += "B! = " + giaiThuaB + "\r\n";
            ketQua += "S1 = 1 + 2 + ... + A = " + S1 + "\r\n";
            ketQua += "S2 = 1 + 2 + ... + B = " + S2 + "\r\n";
            ketQua += "S3 = A^1 + A^2 + ... + A^B = " + S3 + "\r\n";
            tbKq.Text = ketQua;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbA.Text = "";
            tbB.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool isInteger = Int32.TryParse(tbA.Text, out number);
            if (!isInteger && !string.IsNullOrEmpty(tbA.Text))
            {
                MessageBox.Show("Du lieu nhap khong phai la so nguyen", "Loi");
                tbA.Text = "";
            }
        }

        private void tbB_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool isInteger = Int32.TryParse(tbB.Text, out number);
            if (!isInteger && !string.IsNullOrEmpty(tbB.Text))
            {
                MessageBox.Show("Du lieu nhap khong phai la so nguyen", "Loi");
                tbB.Text = "";
            }
        }
    }
}
