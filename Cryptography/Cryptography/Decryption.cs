using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class Decryption : Form
    {
        private int bufHeight = 128;
        private int bufWidth = 16;
        private int countThreads = 4;
        private int countSteps = 80000;
        public Decryption()
        {
            InitializeComponent();
        }

        private void buttonOpenFileToDecrypt_Click(object sender, EventArgs e)
        {
            if (this.openFileToDecrypt.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileToDecrypt.FileName;
            this.textBoxOpenFileToDecrypt.Text = fileName;
        }

        private void buttonFolderDec_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialogDec.ShowDialog() == DialogResult.Cancel)
                return;
            string folderName = folderBrowserDialogDec.SelectedPath;
            this.textBoxFolderDec.Text = folderName;
        }

        private void buttonFileKey_Click(object sender, EventArgs e)
        {
            if (this.openFileDialogKey.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileDialogKey.FileName;
            this.textBoxFileKey.Text = fileName;
        }

        private void buttonDecryption_Click(object sender, EventArgs e)
        {
            if (!(textBoxOpenFileToDecrypt.Text != string.Empty && textBoxFolderDec.Text != string.Empty &&
                  textBoxFileDec.Text != string.Empty && textBoxFileKey.Text != string.Empty))
            {
                MessageBox.Show("Заповніть усі поля!");
                return;
            }
            if (!File.Exists(this.textBoxOpenFileToDecrypt.Text))
            {
                MessageBox.Show("Файл, що має бути розшифрований, обрано невірно!");
                return;
            }
            if (!File.Exists(this.textBoxFileKey.Text))
            {
                MessageBox.Show("Файл-ключ обрано невірно!");
                return;
            }
            if (File.Exists(this.textBoxFolderDec.Text + "\\" + this.textBoxFileDec.Text))
            {
                MessageBox.Show("Такий файл уже існує!");
                return;
            }
            Decrypt();
        }

        struct Key
        {
            public int antX;
            public int antY;
            public int orientation;
        }

        private void Decrypt()
        {
            
            List<Key> keys = new List<Key>();
            int l = 0;
            using (StreamReader sr = new StreamReader(textBoxFileKey.Text, System.Text.Encoding.Default))
            {
                string line;
                line = sr.ReadLine();
                line = sr.ReadLine();
                line = sr.ReadLine();
                line = sr.ReadLine();
                l = Convert.ToInt32(line);
            }
            StreamReader readKey = new StreamReader(textBoxFileKey.Text, System.Text.Encoding.Default);
            char[,] buf = new char[bufHeight, bufWidth * countThreads];
            BinaryWriter sw = new BinaryWriter(File.Open(this.textBoxFolderDec.Text + "\\" + this.textBoxFileDec.Text, FileMode.OpenOrCreate), System.Text.Encoding.ASCII);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            using (BinaryReader reader = new BinaryReader(File.Open(this.textBoxOpenFileToDecrypt.Text, FileMode.Open), Encoding.ASCII))
            {
                while (reader.PeekChar() > -1)
                {
                    for (int k = 0; k < countThreads; k++)
                    {
                        for (int i = 0; i < bufHeight; i++)
                        {
                            for (int j = k * bufWidth; j < (k + 1) * bufWidth; j++)
                            {
                                if (reader.PeekChar() > -1)
                                {
                                    buf[i, j] = Convert.ToChar(reader.ReadByte());
                                }
                                else
                                {
                                    buf[i, j] = ' ';
                                }

                            }
                        }
                    }
                    keys = new List<Key>();
                    for (int i = 0; i < countThreads; i++)
                    {
                        int antX = 0, antY = 0;
                        antX = Convert.ToInt32(readKey.ReadLine());
                        antY = Convert.ToInt32(readKey.ReadLine());
                        int orientation = 0;
                        int s = Convert.ToInt32(readKey.ReadLine());
                        if (s == 0) orientation = 2;
                        else
                            if (s == 1) orientation = 3;
                        else
                            if (s == 2) orientation = 0; else orientation = 1;
                        if (orientation == 0)
                        {
                            if (antX == 0) antX = bufHeight;
                            antX--;
                        }
                        if (orientation == 1)
                        {
                            if (antY == bufWidth * 8 - 1) antY = -1;
                            antY++;
                        }
                        if (orientation == 2)
                        {
                            if (antX == bufHeight - 1) antX = -1;
                            antX++;
                        }
                        if (orientation == 3)
                        {
                            if (antY == 0) antY = bufWidth * 8;
                            antY--;
                        }
                        s = Convert.ToInt32(readKey.ReadLine());
                        keys.Add(new Key { antX = antX, antY = antY, orientation = orientation});
                    }
                    Parallel.For(0, countThreads, k => 
                    {
                        int antX = keys[k].antX, antY = keys[k].antY;
                        int orientation = keys[k].orientation;
                        for (int i = 0; i < countSteps; i++)
                        {
                            switch (orientation)
                            {
                                case 0:
                                    {
                                        int bitNum = antY % 8;
                                        int mask = Convert.ToInt32(Math.Pow(2, 8 - bitNum - 1));
                                        if ((mask & buf[antX, antY / 8]) != 0)
                                        {
                                            buf[antX, antY / 8] = Convert.ToChar(buf[antX, antY / 8] & (~mask));
                                            orientation = 1;
                                            if (antY == (k + 1) * bufWidth * 8 - 1) antY = k * bufWidth * 8 - 1;
                                            antY++;

                                        }
                                        else
                                        {
                                            buf[antX, antY / 8] = Convert.ToChar(buf[antX, antY / 8] | mask);
                                            orientation = 3;
                                            if (antY == k * bufWidth * 8) antY = (k + 1) * bufWidth * 8;
                                            antY--;
                                        }
                                        break;
                                    }
                                case 1:
                                    {
                                        int bitNum = antY % 8;
                                        int mask = Convert.ToInt32(Math.Pow(2, 8 - bitNum - 1));
                                        if ((mask & buf[antX, antY / 8]) != 0)
                                        {
                                            buf[antX, antY / 8] = Convert.ToChar(buf[antX, antY / 8] & (~mask));
                                            orientation = 2;
                                            if (antX == bufHeight - 1) antX = -1;
                                            antX++;
                                        }
                                        else
                                        {
                                            buf[antX, antY / 8] = Convert.ToChar(buf[antX, antY / 8] | mask);
                                            orientation = 0;
                                            if (antX == 0) antX = bufHeight;
                                            antX--;
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        int bitNum = antY % 8;
                                        int mask = Convert.ToInt32(Math.Pow(2, 8 - bitNum - 1));
                                        if ((mask & buf[antX, antY / 8]) != 0)
                                        {
                                            buf[antX, antY / 8] = Convert.ToChar(buf[antX, antY / 8] & (~mask));
                                            orientation = 3;
                                            if (antY == k * bufWidth * 8) antY = (k + 1) * bufWidth * 8;
                                            antY--;
                                        }
                                        else
                                        {
                                            buf[antX, antY / 8] = Convert.ToChar(buf[antX, antY / 8] | mask);
                                            orientation = 1;
                                            if (antY == (k + 1) * bufWidth * 8 - 1) antY = k * bufWidth * 8 - 1;
                                            antY++;
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        int bitNum = antY % 8;
                                        int mask = Convert.ToInt32(Math.Pow(2, 8 - bitNum - 1));
                                        if ((mask & buf[antX, antY / 8]) != 0)
                                        {
                                            buf[antX, antY / 8] = Convert.ToChar(buf[antX, antY / 8] & (~mask));
                                            orientation = 0;
                                            if (antX == 0) antX = bufHeight;
                                            antX--;
                                        }
                                        else
                                        {
                                            buf[antX, antY / 8] = Convert.ToChar(buf[antX, antY / 8] | mask);
                                            orientation = 2;
                                            if (antX == bufHeight - 1) antX = -1;
                                            antX++;
                                        }
                                        break;
                                    }
                            }
                        }
                    });
                    for (int k = 0; k < countThreads; k++)
                    {
                        for (int i = 0; i < bufHeight; i++)
                        {
                            for (int j = k * bufWidth; j < (k + 1) * bufWidth; j++)
                            {
                                if (l > 0)
                                {
                                    byte b = Convert.ToByte(buf[i, j]);
                                    sw.Write(b);
                                }
                                l--;
                            }
                        }
                    }
                }
            }
            sw.Close();
            readKey.Close();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            MessageBox.Show("Файл успішно розкодовано!");
            //MessageBox.Show("RunTime " + elapsedTime);
        }

        private void Decryption_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formChoose.Show();
        }
    }
}
