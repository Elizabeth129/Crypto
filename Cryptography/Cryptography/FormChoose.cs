using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class FormChoose : Form
    {
        public FormChoose()
        {
            InitializeComponent();
        }

        private void FormChoose_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.login.Show();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (!Program.encryption.IsDisposed)
            {
                Program.encryption.Show();
            }
            else
            {
                Program.encryption = new Encryption();
                Program.encryption.Show();
            }
            this.Hide();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (!Program.decryption.IsDisposed)
            {
                Program.decryption.Show();
            }
            else
            {
                Program.decryption = new Decryption();
                Program.decryption.Show();
            }
            this.Hide();
        }
    }
}
