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
    public partial class Form3_1 : Form
    {
        public Form3_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dic = new string[10];
            dic[0] = "không";
            dic[1] = "một";
            dic[2] = "hai";
            dic[3] = "ba";
            dic[4] = "bốn";
            dic[5] = "năm";
            dic[6] = "sáu";
            dic[7] = "bảy";
            dic[8] = "tám";
            dic[9] = "chín";
            string[] exceptDic = new string[10];
            exceptDic[0] = "";
            exceptDic[1] = "mốt";
            exceptDic[4] = "tư";
            exceptDic[5] = "lăm";
            string[] pos = new string[3];
            pos[2] = "trăm";
            pos[1] = "mươi";
            pos[0] = "";
            string str = tbNum.Text;
            int len = (int)str.Length;
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = (int)(str[i] - '0');
            }
            string res = "";
            if (len == 1) // trường hợp một chữ số
            {
                tbString.Text = dic[arr[0]];
                return;
            }
            if (arr[len - 2] == 1) // trường hợp x1x
            {
                dic[1] = "";
                pos[1] = "mười";
                exceptDic[1] = "một";
            }
            if (arr[len - 2] == 0) // trường hợp x0x
            {
                dic[0] = "lẻ";
                pos[1] = "";
                exceptDic[5] = "năm";
            }
            for (int i = 0; i < len - 1; i++)
            {
                res = res + dic[arr[i]] + " " + pos[len - i - 1] + " ";
            }
            if (arr[len - 1] == 0 || arr[len - 1] == 1 || arr[len - 1] == 4 || arr[len - 1] == 5)
            {
                res += exceptDic[arr[len - 1]];
            }
            else
            {
                res += dic[arr[len - 1]];
            }
            tbString.Text = res;
        }

        private void tbNum_TextChanged(object sender, EventArgs e)
        {
            int num;
            bool isInteger = Int32.TryParse(tbNum.Text, out num);
            if ((!isInteger || num > 999 || num < 0) && !string.IsNullOrEmpty(tbNum.Text))
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
