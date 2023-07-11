using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace WOW_Koi_Launcher.Language
{
    internal class LanguageManager
    {
        internal static ResourceManager ResourceManager { get; set; }

        public static string UserLanguage { get; set; }       
        
        internal string[] locales = { "en", "de", "es" };

        public LanguageManager()
        {
            if (string.IsNullOrEmpty(UserLanguage)) {
                UserLanguage = CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;
            }
            if (locales.Contains(UserLanguage))
            {
                ResourceManager = new ResourceManager("WOW_Koi_Launcher.Language.Lang_" + char.ToUpper(UserLanguage[0]) + UserLanguage.Substring(1), Assembly.GetExecutingAssembly());
            } else {
                ResourceManager = new ResourceManager("WOW_Koi_Launcher.Language.Lang_En", Assembly.GetExecutingAssembly());
            }
        }

        internal static string GetString(string l_string)
        {
            return ResourceManager.GetString(l_string);
        }


    }


}
