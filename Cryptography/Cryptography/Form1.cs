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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (!Program.login.IsDisposed)
            {
                Program.login.Show();
            } 
            else
            {
                Program.login = new Login();
                Program.login.Show();
            }
            
            this.Hide();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (!Program.registration.IsDisposed)
            {
                Program.registration.Show();
            }
            else
            {
                Program.registration = new Registration();
                Program.registration.Show();
            }
            this.Hide();
        }
    }
}
