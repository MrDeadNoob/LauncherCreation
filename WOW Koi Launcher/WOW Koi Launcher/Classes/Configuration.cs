using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace WOW_Koi_Launcher.Classes
{
    internal class Configuration
    {
        public bool Install { get; set; }

        //TOML File
        internal static Dictionary<string, object> dictionary = new Dictionary<string, object>();
        //[GameSettings]
        public static bool InstallBool { get; private set; }
        public static string InstallPath { get; private set; }
        public static int InstallDate { get; private set; }
        //[LauncherSettings]
        public string LauncherLang { get; private set; }

        internal static string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WOW Koi Launcher";
        internal static string ConfigFile = ConfigPath + "\\config.toml";
        internal static bool FreshInstall = false;

        
        internal static Task LoadSettings()
        {
            if (!Directory.Exists(ConfigPath)) { Directory.CreateDirectory(ConfigPath); FreshInstall = true; }
            if (!File.Exists(ConfigFile)) {  File.Create(ConfigFile); FreshInstall = true; }
            if (!FreshInstall)
            {

            }
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            InstallPath = Path.GetDirectoryName(path);
            return Task.CompletedTask;
        }

        internal static void DetectWoWVersion()
        {

        }

        internal static void DetectKoiVersion()
        {

        }

    }
}
