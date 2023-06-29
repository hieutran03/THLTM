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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbInput.Text = "";
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                rtbInput.Text = sr.ReadToEnd();
                tbFileName.Text = ofd.SafeFileName.ToString();
                tbSize.Text = Convert.ToString(fs.Length) + " bytes";
                tbURL.Text = ofd.FileName;
                fs.Close();
                int line = 0;

                sr.Close();
                string[] input = rtbInput.Lines;
                tbLinesCount.Text = input.Count().ToString();
                int WordsCount = 0;
                foreach (string i in input)
                {
                    string[] items = i.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    WordsCount += items.Length;
                }
                tbWordsCount.Text = WordsCount.ToString();
                tbCharectersCount.Text = rtbInput.TextLength.ToString();
                fs.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
