using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_M9_BrunoPinheiro
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*StreamReader LerLogin = new StreamReader("Login.txt", Encoding.UTF8);
            while (!LerLogin.EndOfStream)
            {
                String linha = LerLogin.ReadLine();
                String loginfalse = linha.Substring(0, 5);
                String logintrue = linha.Substring(5, 4);
                if (loginfalse == "false")
                {
                    Application.Run(new frm_login());
                }
                if (logintrue == "true")
                {
                    Application.Run(new frm_menu());
                }
            }
            LerLogin.Dispose();*/
            Application.Run(new frm_1v1());
        }
    }
}
