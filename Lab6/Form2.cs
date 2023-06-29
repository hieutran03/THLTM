using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string StandardizeKeyWord(string keyWord, string target)
        {
            string res = "";
            string sample = "";
            int keyLen = keyWord.Length;
            int targetLen = target.Length;
            int n = targetLen/keyLen;

            for(int i = 0; i < keyLen; i++)
            {
                sample += char.ToUpper(keyWord[i]);
            }

            for(int i = 0; i < n; i++)
            {
                res += keyWord;
            }

            int div = targetLen % keyLen;
            for(int i = 0; i < div; i++)
            {
                res += sample[i];
            }    
            return res;
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = rtbPlaintext.Text;
            string cipherText = "";
            string standardizedKey = StandardizeKeyWord(tbKeyword.Text, rtbPlaintext.Text);

            for (int i = 0; i < plainText.Length; i++)
            {
                bool isLower = char.IsLower(plainText[i]);
                int indexTarget = alphabet.IndexOf(char.ToUpper(plainText[i]));
                int indexKey = alphabet.IndexOf(standardizedKey[i]);
                var newIndex = (indexTarget + indexKey) % alphabet.Length;
                cipherText += isLower ? char.ToLower(alphabet[newIndex]) : alphabet[newIndex];
            }
            rtbCiphertext.Text = cipherText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = rtbCiphertext.Text;
            string plainText = "";
            string standardizedKey = StandardizeKeyWord(tbKeyword.Text, rtbCiphertext.Text);

            for (int i = 0; i < cipherText.Length; i++)
            {
                bool isLower = char.IsLower(cipherText[i]);
                int indexTarget = alphabet.IndexOf(char.ToUpper(cipherText[i]));
                int indexKey = alphabet.IndexOf(standardizedKey[i]);
                var newIndex = indexTarget - indexKey >= 0 ? indexTarget - indexKey : alphabet.Length - (indexKey-indexTarget);
                plainText += isLower ? char.ToLower(alphabet[newIndex]) : alphabet[newIndex];
            }
            rtbPlaintext.Text = plainText;
        }
    }
}
