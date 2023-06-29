using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{

    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public class Subnet
        {

            public string DiaChiMang;
            public string DiaChiDau;
            public string DiaChiCuoi;
            public string DiaChiBc;

        }
        public void MyConvert(uint IpUint, out string Ip)
        {
            byte[] ipAddressBytes = BitConverter.GetBytes(IpUint);
            Array.Reverse(ipAddressBytes);
            IPAddress ipAddress = new IPAddress(ipAddressBytes);
            Ip = ipAddress.ToString();
        }
        private void butChiaMang_Click(object sender, EventArgs e)
        {

            bool check = true;
            daGridBangChia.Rows.Clear();

            string _Input = tbNetAddr.Text;

            int NumSubnets = int.Parse(tbSoMangCon.Text);
            string[] token = _Input.Split('/');
            string NetAddress = token[0];
            int NumBits = int.Parse(token[1]);

            IPAddress IpAddr = IPAddress.Parse(NetAddress);
            int NumBorrowedBits = (int)Math.Ceiling(Math.Log(NumSubnets, 2));
            int SubnetMask = NumBits + NumBorrowedBits;
            int HostBits = 32 - (SubnetMask);

            //uint SubnetMaskBits = 0xFFFFFFFF << (32 - HostBits);
            uint SubnetDistance = (uint)Math.Pow(2, HostBits);

            Byte[] IpAddrBytes = IpAddr.GetAddressBytes();
            List<Subnet> subnets = new List<Subnet>();
            uint IpAddressUInt = BitConverter.ToUInt32(IpAddrBytes.Reverse().ToArray(), 0);
            for (int i = 0; i < NumSubnets; i++)
            {
                Subnet subnet = new Subnet();
                IPAddress NewIP = new IPAddress(IpAddrBytes);


                uint IpFirst = IpAddressUInt + 1;
                uint IpFinal = IpAddressUInt + SubnetDistance - 2;
                uint IpBroadCast = IpAddressUInt + SubnetDistance - 1;

                string temp = "";
                MyConvert(IpAddressUInt, out temp);
                subnet.DiaChiMang = temp + "/" + Convert.ToString(SubnetMask);

                temp = "";
                MyConvert(IpFirst, out temp);
                subnet.DiaChiDau = temp;

                temp = "";
                MyConvert(IpFinal, out temp);
                subnet.DiaChiCuoi = temp;

                temp = "";
                MyConvert(IpBroadCast, out temp);
                subnet.DiaChiBc = temp;

                subnets.Add(subnet);
                IpAddressUInt += SubnetDistance;
            }
            foreach (Subnet item in subnets)
            {
                int index = daGridBangChia.Rows.Add();


                daGridBangChia.Rows[index].Cells[0].Value = item.DiaChiMang;
                daGridBangChia.Rows[index].Cells[1].Value = item.DiaChiDau;
                daGridBangChia.Rows[index].Cells[2].Value = item.DiaChiCuoi;
                daGridBangChia.Rows[index].Cells[3].Value = item.DiaChiBc;

            }

        }
    }
}
