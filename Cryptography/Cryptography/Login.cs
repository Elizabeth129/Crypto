using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin1_Click(object sender, EventArgs e)
        {
            if (!(this.comboBoxDisks.SelectedItem != null && this.comboBoxDisks2.SelectedItem != null &&
                  this.textBoxLogin.Text != string.Empty && this.textBoxPassword.Text != string.Empty))
            {
                MessageBox.Show("Заповніть усі поля!");
                return;
            }
            if (!File.Exists(this.comboBoxDisks.SelectedItem.ToString() + "key.txt"))
            {
                MessageBox.Show("До даного USB-накопичувача не прив'язано аккаунт!\n Оберіть інший, або зареєструйтеся.");
                return;
            }
            if (!File.Exists(this.comboBoxDisks2.SelectedItem.ToString() + "lengton.txt"))
            {
                MessageBox.Show("До даного жорсткого диску не прив'язано аккаунт!\n Оберіть інший, або зареєструйтеся.");
                return;
            }
            string key = string.Empty;
            using (StreamReader sr = new StreamReader(this.comboBoxDisks.SelectedItem.ToString() + "key.txt", System.Text.Encoding.Default))
            {
                string line;
                line = sr.ReadLine();
                if (!line.Equals(this.textBoxLogin.Text + " " + this.textBoxPassword.Text))
                {
                    MessageBox.Show("Логін або пароль введено невірно!");
                    return;
                }
                key = sr.ReadLine();
            }
            using (StreamReader sr = new StreamReader(this.comboBoxDisks2.SelectedItem.ToString() + "lengton.txt", System.Text.Encoding.Default))
            {
                bool flag = false;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Equals(key))
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Ключ на USB-накопичувачу та на жорсткому диску не співпадають!");
                    return;
                }
                else
                {
                    if (!Program.formChoose.IsDisposed)
                    {
                        Program.formChoose.Show();
                    }
                    else
                    {
                        Program.formChoose = new FormChoose();
                        Program.formChoose.Show();
                    }
                    this.Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.textBoxLogin.Clear();
            this.textBoxPassword.Clear();
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.form1.Show();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            this.textBoxLogin.Clear();
            this.textBoxPassword.Clear();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            this.textBoxLogin.Clear();
            this.textBoxPassword.Clear();
        }
    }
}
