using ViewLayer.agregarList;

namespace ViewLayer
{
    internal static class Program
    {

        public static string UsuarioActual;
        public static DateTime FechaHoy;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}