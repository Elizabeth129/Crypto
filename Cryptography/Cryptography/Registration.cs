using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cryptography
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Program.form1.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.comboBoxDisks.Items.Clear();
            string[] drives = Directory.GetLogicalDrives();
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                this.comboBoxDisks.Items.Add(drive.Name);
            }

            this.comboBoxDisks2.Items.Clear();
            string[] drives2 = Directory.GetLogicalDrives();
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Fixed)
                    this.comboBoxDisks2.Items.Add(drive.Name);
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string upper_punct = "~`!@#$%^&*()-_+=";
            string digits = "1234567890";
            int totalChars = 0x7f - 0x20;
            int alphaChars = alpha.Length;
            int upperChars = upper.Length;
            int upper_punctChars = upper_punct.Length;
            int digitChars = digits.Length;
            int otherChars = totalChars - (alphaChars + upperChars + upper_punctChars + digitChars);
            string password = this.textBoxPassword.Text;

            int c_Bits = 0;
            bool ans = false;

            if (password.Length < 0)
            {
                c_Bits = 0;
            }
            else
            {
                bool fAlpha = false;
                bool fUpper = false;
                bool fUpperPunct = false;
                bool fDigit = false;
                bool fOther = false;
                int charset = 0;

                for (int i = 0; i < password.Length; i++)
                {
                    char s = password[i];

                    if (alpha.Contains(s))
                        fAlpha = true;
                    else if (upper.Contains(s))
                        fUpper = true;
                    else if (digits.Contains(s))
                        fDigit = true;
                    else if (upper_punct.Contains(s))
                        fUpperPunct = true;
                    else fOther = true;
                }
                if (fAlpha)
                    charset += alphaChars;
                if (fUpper)
                    charset += upperChars;
                if (fDigit)
                    charset += digitChars;
                if (fUpperPunct)
                    charset += upper_punctChars;
                if (fOther)
                    charset += otherChars;

                double bits = Math.Log(charset) * (password.Length / Math.Log(2));

                c_Bits = (int)Math.Floor(bits);
            }

            int iN;

            if (c_Bits >= 128)
            {
                iN = 4;
            }
            else if (c_Bits < 128 && c_Bits >= 64)
            {
                iN = 3;
            }
            else if (c_Bits < 64 && c_Bits >= 56)
            {
                iN = 2;
            }
            else if (c_Bits < 56)
            {
                iN = 1;
            }
            else
            {
                iN = 0;
            }

            this.progressBarPassword.Minimum = 0;
            this.progressBarPassword.Maximum = 4;
            this.progressBarPassword.Value = iN;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (!(this.comboBoxDisks.SelectedItem != null && this.comboBoxDisks2.SelectedItem != null &&
                  this.textBoxLogin.Text != string.Empty && this.textBoxPassword.Text != string.Empty))
            {
                MessageBox.Show("Заповніть усі поля!");
                return;
            }
            if (this.progressBarPassword.Value < 2)
            {
                MessageBox.Show("Пароль достатньо надійний!");
                return;
            }
            if (File.Exists(this.comboBoxDisks.SelectedItem.ToString() + "key.txt"))
            {
                MessageBox.Show("До цього USB-накопичувача вже прив'язаний акаунт!");
                return;
            }
            string key = string.Empty;
            do
            {
                key = GenerateKey();
                if (File.Exists(this.comboBoxDisks2.SelectedItem.ToString()+"lengton.txt"))
                {
                    bool flag = false;
                    using (StreamReader sr = new StreamReader(this.comboBoxDisks2.SelectedItem.ToString() + "lengton.txt", System.Text.Encoding.Default))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Equals(key))
                            {
                                flag = true;
                            }
                        }
                    }
                    if (flag)
                    {
                        continue;
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(this.comboBoxDisks2.SelectedItem.ToString() + "lengton.txt", true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine(key);
                        }
                        break;
                    }
                } 
                else
                {
                    using (StreamWriter sw = new StreamWriter(this.comboBoxDisks2.SelectedItem.ToString() + "lengton.txt", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(key);
                    }
                    break;
                }
            } while (true);
            using (StreamWriter sw = new StreamWriter(this.comboBoxDisks.SelectedItem.ToString() + "key.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(textBoxLogin.Text + " " + textBoxPassword.Text);
                sw.WriteLine(key);
            }
            MessageBox.Show("Реєстрація успішна!");
            this.Close();
        }

        private string GenerateKey()
        {
            string key = string.Empty;
            char[] mas = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B',
            'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q',
            'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f',
            'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*',
            '(', ')', '-', '_', '+', '='};
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                key += mas[0 + random.Next() % 77];
            }
            return key;
        }
    }
}
