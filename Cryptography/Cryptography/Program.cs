using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    static class Program
    {
        static public Form1 form1;
        static public Login login;
        static public Registration registration;
        static public FormChoose formChoose;
        static public Encryption encryption;
        static public Decryption decryption;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            login = new Login();
            registration = new Registration();
            formChoose = new FormChoose();
            encryption = new Encryption();
            decryption = new Decryption();
            Application.Run(form1);
        }
    }
}
