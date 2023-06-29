using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static double Evaluate(string expression)
        {
            //Tham khảo: https://stackoverflow.com/questions/333737/evaluating-string-342-yield-int-18#comment24792230_1417488
            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return Math.Round((double)(loDataTable.Rows[0]["Eval"]),2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string sample = @sr.ReadToEnd();
                string[] items = sample.Split('\n');
                richTextBox1.Text = "";
                foreach (string item in items)
                {
                    string res;
                    if (item[item.Length - 1] == '\r')
                        res = item.Substring(0, item.Length - 1);
                    else
                        res = item;
                    res += " = " + Evaluate(item).ToString() + "\r\n";
                    richTextBox1.Text += res;
                }
                fs.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                FileStream fs = new FileStream(filePath, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                fs.Close();
            }
        }
    }
}
