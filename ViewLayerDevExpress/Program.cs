using DevExpress.LookAndFeel;
using System;
using ViewLayerDevExpress.Login;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace ViewLayerDevExpress
{
    internal static class Program
    {
        public static string UsuarioActual;
        public static DateTime FechaHoy;


        public static frmMain mainfrm;
        public static frmSplash splashfrm;
        public static frmLogin loginfrm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainfrm = new frmMain();
            splashfrm = new frmSplash();
            loginfrm = new frmLogin();

            Application.Run(mainfrm);
        }
    }
}
