using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form4 : Form
    {
        [Serializable]
        public class SinhVien
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string Phone { get; set; }
            public double Course1 { get; set; }
            public double Course2 { get; set; }
            public double Course3 { get; set; }
            public double Average { get; set; }
            public string GetInfo()
            {
                return Name + " | "
                    + ID + " | "
                    + Phone + " | "
                    + Course1.ToString() + " | "
                    + Course2.ToString() + " | "
                    + Course3.ToString() + " | "
                    + Average.ToString() + " | ";
            }
        }
        List<SinhVien> dssv = new List<SinhVien>();
        List<SinhVien> dssvOut = new List<SinhVien>();

        bool[] CheckCourseInput = { false, false, false };
        public Form4()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);

                dssvOut = data as List<SinhVien>;
                lbIndex.Text = "1";
                //PutInfoIntoListBox(dssvOut);
                PutInfoIntoOutput(dssvOut[0]);
                fs.Close();
            }
        }

        public void UpdateAverage()
        {
            if (CheckCourseInput[0] && CheckCourseInput[1] && CheckCourseInput[2])
            {
                double Average = (double.Parse(tbCourse1In.Text) + double.Parse(tbCourse2In.Text) + double.Parse(tbCourse3In.Text)) / 3;
                tbAverageIn.Text = Math.Round(Average, 2).ToString();
            }
        }
        private void tbCourse1In_TextChanged(object sender, EventArgs e)
        {
            tbAverageIn.Text = "";
            double item;
            if (!string.IsNullOrEmpty(tbCourse1In.Text))
            {
                bool check = double.TryParse(tbCourse1In.Text, out item);
                if (check && item >= 0 && item <= 10)
                {
                    CheckCourseInput[0] = true;
                    UpdateAverage();
                }
                else
                {
                    CheckCourseInput[0] = false;
                    MessageBox.Show("Invallid Input");
                    tbCourse1In.Text = string.Empty;
                }
            }
            else CheckCourseInput[0] = false;


        }

        private void tbCourse2In_TextChanged(object sender, EventArgs e)
        {
            tbAverageIn.Text = "";
            double item;
            if (!string.IsNullOrEmpty(tbCourse2In.Text))
            {
                bool check = double.TryParse(tbCourse2In.Text, out item);
                if (check && item >= 0 && item <= 10)
                {
                    CheckCourseInput[1] = true;
                    UpdateAverage();
                }
                else
                {
                    CheckCourseInput[1] = false;
                    MessageBox.Show("Invallid Input");
                    tbCourse2In.Text = string.Empty;
                }
            }else CheckCourseInput[1] = false;

        }

        private void tbCourse3In_TextChanged(object sender, EventArgs e)
        {
            tbAverageIn.Text = "";
            double item;
            if (!string.IsNullOrEmpty(tbCourse3In.Text))
            {
                bool check = double.TryParse(tbCourse3In.Text, out item);
                if (check && item >= 0 && item <= 10)
                {
                    CheckCourseInput[2] = true;
                    UpdateAverage();
                }
                else
                {
                    CheckCourseInput[2] = false;
                    MessageBox.Show("Invallid Input");
                    tbCourse3In.Text = string.Empty;
                }

            }
            else CheckCourseInput[2] = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Name = tbNameIn.Text;
            sv.ID = tbIDIn.Text;
            sv.Phone = tbPhoneIn.Text;
            sv.Course1 = double.Parse(tbCourse1In.Text);
            sv.Course2 = double.Parse(tbCourse2In.Text);
            sv.Course3 = double.Parse(tbCourse3In.Text);
            sv.Average = double.Parse(tbAverageIn.Text);
            dssv.Add(sv);
            PutInfoIntoListBox(dssv);
        }
        public void PutInfoIntoListBox(List<SinhVien> dssv)
        {
            listBox1.Items.Clear();
            foreach (SinhVien sv in dssv)
            {
                listBox1.Items.Add(sv.GetInfo());
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("Khong co du lieu de ghi");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dssv);
                fs.Close();
            }
        }
        private void PutInfoIntoOutput(SinhVien sv)
        {
            tbNameOut.Text = sv.Name;
            tbIDOut.Text = sv.ID;
            tbPhoneOut.Text = sv.Phone;
            tbCourse1Out.Text = sv.Course1.ToString();
            tbCourse2Out.Text = sv.Course2.ToString();
            tbCourse3Out.Text = sv.Course3.ToString();
            tbAverageOut.Text = sv.Average.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = int.Parse(lbIndex.Text) - 1;
            if (index < 1 || dssvOut.Count == 0)
            {
                MessageBox.Show("Dang o dau danh sach!");
                return;
            }
            index--;
            PutInfoIntoOutput(dssvOut[index]);
            lbIndex.Text = (index + 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = int.Parse(lbIndex.Text) - 1;
            if (index >= dssvOut.Count - 1 || dssvOut.Count == 0)
            {
                MessageBox.Show("Het roi ban oi!!!");
                return;
            }
            index++;
            PutInfoIntoOutput(dssvOut[index]);
            lbIndex.Text = (index + 1).ToString();
        }
    }
}
