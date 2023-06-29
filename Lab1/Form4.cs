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
    public partial class Form4 : Form
    {
        string[] LoaiXang = { "Xăng RON 95-II", "Xăng E5 RON 92-II", "Dầu DO 0,5S-II" };
        public Form4()
        {
            InitializeComponent();
            List<LoaiXe> listItem = new List<LoaiXe>()
            {
                new LoaiXe(){Ten = "Wave Alpha", LuongXangToiDa = 3.7, HaoPhiXangCho100km = 1.6,LoaiXangSuDung = "01"},
                new LoaiXe(){Ten = "Sirius", LuongXangToiDa = 3.8, HaoPhiXangCho100km = 1.99,LoaiXangSuDung = "01"},
                new LoaiXe(){Ten = "Vision", LuongXangToiDa = 5.2, HaoPhiXangCho100km = 1.87,LoaiXangSuDung = "0"},
                new LoaiXe(){Ten = "Lead", LuongXangToiDa = 6, HaoPhiXangCho100km = 2.02,LoaiXangSuDung = "0"},
                new LoaiXe(){Ten = "Winner", LuongXangToiDa = 4.5, HaoPhiXangCho100km = 1.7,LoaiXangSuDung = "0"},
                new LoaiXe(){Ten = "AirBlade", LuongXangToiDa = 4.4, HaoPhiXangCho100km = 2.17,LoaiXangSuDung = "0"},
                new LoaiXe(){Ten = "Xe tải 9 tấn", LuongXangToiDa = 70, HaoPhiXangCho100km = 13,LoaiXangSuDung = "2"}
            };
            comboBox1.DataSource = listItem;
            comboBox1.DisplayMember = "Ten";
        }

        public class LoaiXe
        {
            public string Ten { get; set; }
            public double LuongXangToiDa { get; set; }
            public double HaoPhiXangCho100km { get; set; }
            public string LoaiXangSuDung { get; set; }
        };

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                tbSoKm.Text = "";
                tbSoTien.Text = "";
                LoaiXe Xe = cb.SelectedValue as LoaiXe;
                string[] LXang = new string[Xe.LoaiXangSuDung.Length];
                for (int i = 0; i < LXang.Length; i++)
                {
                    LXang[i] = LoaiXang[Xe.LoaiXangSuDung[i] - '0'];
                }
                comboBox2.DataSource = LXang;
            }
        }

        void GiaTien()
        {
            if (comboBox2.Text == LoaiXang[0])
            {
                tbGiaXang.Text = "26830";
            }
            else if (comboBox2.Text == LoaiXang[1])
            {
                tbGiaXang.Text = "26070";
            }
            else if (comboBox2.Text == LoaiXang[2])
            {
                tbGiaXang.Text = "21310";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoaiXe LXe = comboBox1.SelectedValue as LoaiXe;
            int GiaXang = int.Parse(tbGiaXang.Text);
            double GiaTien = LXe.LuongXangToiDa * GiaXang;
            double SoKm = LXe.LuongXangToiDa / LXe.HaoPhiXangCho100km * 100;
            tbSoTien.Text = Convert.ToString(GiaTien);
            tbSoKm.Text = Convert.ToString(SoKm);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSoKm.Text = "";
            tbSoTien.Text = "";
            GiaTien();
        }
    }
}
