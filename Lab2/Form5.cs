using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            string inputString = rtbData.Text;
            byte[] inputData = System.Text.Encoding.UTF8.GetBytes(inputString);


            using (FileStream zipFile = new FileStream("output5.zip", FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(zipFile, ZipArchiveMode.Create))
                {
                    ZipArchiveEntry entry = archive.CreateEntry("data.txt");
                    using (Stream entryStream = entry.Open())
                    {
                        entryStream.Write(inputData, 0, inputData.Length);
                    }
                }
            }


        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            using (ZipArchive archive = ZipFile.OpenRead("output5.zip"))
            {
                ZipArchiveEntry entry = archive.GetEntry("data.txt");
                using (Stream entryStream = entry.Open())
                {
                    using (FileStream output = new FileStream("output5.txt", FileMode.Create))
                    {
                        entryStream.CopyTo(output);
                    }
                }
            }
        }
    }
}
