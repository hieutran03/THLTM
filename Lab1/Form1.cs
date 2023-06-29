namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbSoA.Text) || string.IsNullOrEmpty(tbSoB.Text))
            {
                return;
            }
            int a = int.Parse(tbSoA.Text.Trim());
            int b = int.Parse(tbSoB.Text.Trim());
            int kq = a + b;
            tbTong.Text = kq.ToString();
        }

        private void tbSoA_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool isInteger = Int32.TryParse(tbSoA.Text, out number);
            if (!isInteger && !string.IsNullOrEmpty(tbSoA.Text))
            {
                MessageBox.Show("Du lieu nhap khong phai la so nguyen", "Loi");
                tbSoA.Text = "";
            }

        }

        private void tbSoA_Leave(object sender, EventArgs e)
        {

        }

        private void tbSoB_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool isInteger = Int32.TryParse(tbSoB.Text, out number);
            if (!isInteger && !string.IsNullOrEmpty(tbSoB.Text))
            {
                MessageBox.Show("Du lieu nhap khong phai la so nguyen", "Loi");
                tbSoB.Text = "";
            }
        }
    }
}