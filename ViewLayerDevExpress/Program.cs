using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
