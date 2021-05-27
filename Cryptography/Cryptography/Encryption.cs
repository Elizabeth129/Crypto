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
    public partial class Encryption : Form
    {
        private int bufHeight = 128;
        private int bufWidth = 16;
        private int countThreads = 4;            
        private int countSteps = 80000;

        public Encryption()
        {
            InitializeComponent();
        }

        private void Encryption_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formChoose.Show();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (this.openFileToEncrypt.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileToEncrypt.FileName;
            this.textBoxOpenFile.Text = fileName;
        }

        private void buttonOpenFolderEncrypt_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialogEncrypt.ShowDialog() == DialogResult.Cancel)
                return;
            string folderName = folderBrowserDialogEncrypt.SelectedPath;
            this.textBoxFolderEncrypt.Text = folderName;
        }

        private void buttonFolderKey_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialogKey.ShowDialog() == DialogResult.Cancel)
                return;
            string folderName = folderBrowserDialogKey.SelectedPath;
            this.textBoxFolderKey.Text = folderName;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (!(textBoxOpenFile.Text != string.Empty && textBoxFolderEncrypt.Text != string.Empty &&
                  textBoxFileEncryptName.Text != string.Empty && textBoxFolderKey.Text != string.Empty &&
                  textBoxFileKeyName.Text != string.Empty))
            {
                MessageBox.Show("Заповніть усі поля!");
                return;
            }
            if (!File.Exists(this.textBoxOpenFile.Text))
            {
                MessageBox.Show("Файл, що має бути зашфрований, обрано невірно!");
                return;
            }
            if (File.Exists(this.textBoxFolderEncrypt.Text + "\\" + this.textBoxFileEncryptName.Text))
            {
                MessageBox.Show("Такий файл уже існує!");
                return;
            }
            if (File.Exists(this.textBoxFolderKey.Text + "\\" + this.textBoxFileKeyName.Text + ".txt"))
            {
                MessageBox.Show("Такий файл-ключ уже існує!");
                return;
            }
            Encrypt();
        }

        struct Key
        {
            public int antX;
            public int antY;
            public int orientation;
        }

        private void Encrypt()
        {
            FileInfo fileInfo = new FileInfo(this.textBoxOpenFile.Text);
            long fileSize = fileInfo.Length;
            char[,] buf = new char[bufHeight, bufWidth*countThreads];
            List<Key> keys = new List<Key>();
            //StreamWriter sw = new StreamWriter((this.textBoxFolderEncrypt.Text + "\\" + this.textBoxFileEncryptName.Text), false, System.Text.Encoding.Default);
            BinaryWriter writer = new BinaryWriter(File.Open((this.textBoxFolderEncrypt.Text + "\\" + this.textBoxFileEncryptName.Text), FileMode.OpenOrCreate), Encoding.ASCII);
            StreamWriter swk = new StreamWriter((this.textBoxFolderKey.Text + "\\" + this.textBoxFileKeyName.Text + ".txt"), false, System.Text.Encoding.Default);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            using (BinaryReader reader = new BinaryReader(File.Open(this.textBoxOpenFile.Text, FileMode.Open), Encoding.ASCII))
            {
                while (reader.PeekChar() > -1)
                {
                    for (int k = 0; k < countThreads; k++)
                    {
                        for (int i = 0; i < bufHeight; i++)
                        {
                            for (int j = k*bufWidth; j < (k+1)*bufWidth; j++)
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
                        keys.Add(new Key { antX = 0, antY = 0, orientation = 0 });
                    }
                    Parallel.For(0, countThreads, k =>
                    { 
                        int antX = 64, antY = k*bufWidth*8 + 64;
                        int orientation = 0;
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
                                            if (antY == (k+1)*bufWidth * 8 - 1) antY = k*bufWidth*8-1;
                                            antY++;

                                        }
                                        else
                                        {
                                            buf[antX, antY / 8] = Convert.ToChar(buf[antX, antY / 8] | mask);
                                            orientation = 3;
                                            if (antY == k*bufWidth*8) antY = (k+1)*bufWidth * 8;
                                            antY--;
                                        }
                                        break;
                                    }
                                case 1:
                                    {
                                        int bitNum = antY % 8;
                                        int mask = Convert.ToInt32(Math.Pow(2, 8 - bitNum - 1));
                                        if ((mask & buf[antX,antY / 8]) != 0)
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
                        keys[k] = new Key { antX = antX, antY = antY, orientation = orientation};
                    });
                    for (int k = 0; k < countThreads; k++)
                    {
                        for (int i = 0; i < bufHeight; i++)
                        {
                            for (int j = k * bufWidth; j < (k + 1) * bufWidth; j++)
                            {
                                byte b = Convert.ToByte(buf[i, j]);
                                writer.Write(b);
                            }
                        }
                    }
                    for (int i = 0; i < countThreads; i++)
                    {
                        swk.Write(keys[i].antX.ToString() + "\r\n");
                        swk.Write(keys[i].antY.ToString() + "\r\n");
                        swk.Write(keys[i].orientation.ToString() + "\r\n");
                        swk.Write(fileSize.ToString() + "\r\n");
                    }
                }
            }
            writer.Close();
            swk.Close();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            MessageBox.Show("Файл успішно закодовано!");
            //MessageBox.Show("RunTime " + elapsedTime);
        }
    }
}
