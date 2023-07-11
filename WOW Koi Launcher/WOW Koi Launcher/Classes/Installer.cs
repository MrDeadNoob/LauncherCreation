using MonoTorrent;
using MonoTorrent.Client;
using System.IO;
using System.IO.Compression;
using WOW_Koi_Launcher.Properties;

namespace WOW_Koi_Launcher.Classes
{
    internal class Installer
    {


        public static void Unzip(string zipfile, string Installpath)
        {
            ZipFile.ExtractToDirectory(zipfile, Installpath);
        }

        public static void DownloadWoW(string Installpath)
        {

        }

        internal static void TorrentStateChanged(object o, TorrentStateChangedEventArgs e)
        {

        }

    }
}
