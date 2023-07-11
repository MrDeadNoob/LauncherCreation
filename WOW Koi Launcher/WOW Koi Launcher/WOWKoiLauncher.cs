using System;
using System.Windows.Forms;
using WOW_Koi_Launcher.Language;

namespace WOW_Koi_Launcher
{
    internal static class WOWKoiLauncher
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Launcher_WindowLoad());
        }

        internal static void CloseLauncher()
        {
            Application.Exit();
        }



    }
}
