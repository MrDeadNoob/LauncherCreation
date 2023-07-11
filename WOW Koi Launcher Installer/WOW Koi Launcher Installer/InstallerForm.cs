using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using WOW_Koi_Launcher_Installer.Properties;

namespace WOW_Koi_Launcher_Installer
{
    public partial class InstallerForm : Form
    {
        private readonly Stopwatch stopwatch = new Stopwatch();

        internal string InstallLang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        internal string InstallPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        internal string InstallURL = "https://mrdeadnoob.ml/downloads/programs/KOILauncher.exe";

        internal bool HoverQuit = false;
        internal bool HoverInstall = false;
        internal bool InstallInactive = false;
        internal bool InstallActive = false;

        internal bool MoveActive = false;
        internal Point LauncherPosition;

        public InstallerForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!IsAdministrator())
            {
                if (MessageBox.Show("It is recommended to start this installer with administrator rights", "WOW Koi Launcher Setup", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }

        private void InstallerForm_Load(object sender, EventArgs e)
        {
            InstallPathLabel.Text = InstallPath;
            if (!CheckFreeDiskSpace(25))
            {
                Diskwarning.Visible = true;
                SetInstallButtonInactive(true);
            }
        }

        private void QuitInstaller(object sender, EventArgs e)
        {
            if (InstallActive) return;
            if (MessageBox.Show("Are you sure you want to cancel WOW Koi Launcher installation?", "WOW Koi Launcher Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private bool CheckFreeDiskSpace(long mbytes)
        {
            FileInfo path = new FileInfo(InstallPath);
            DriveInfo drive = new DriveInfo(path.FullName);
            if (ConvertBytesToMegabytes(drive.AvailableFreeSpace) > mbytes)
            {
                return true;
            }
            return false;
        }

        private void PreInstallRoutine(object sender, EventArgs e)
        {
            SetInstallButtonInactive(true);
            InstallActive = true;
            ProgressBarBG.Visible = true;
            ProgressBar.Visible = true;
            DownloadInfo.Visible = true;
            InstallButton.Visible = false;
            DLSpeedLabel.Visible = true;
            InstallProgram();
        }

        private void InstallProgram()
        {
            
            try
            {
                WebClient Downloader = new WebClient();
                Downloader.DownloadFileCompleted += DownloadProgressCompleted;
                Downloader.DownloadProgressChanged += DownloadProgressChanged;
                stopwatch.Start();
                Downloader.DownloadFileAsync(new Uri(InstallURL), InstallPath + "KOI Launcher.exe");
            }
            catch (Exception)
            {
                if (MessageBox.Show("Error while installing the Launcher. Remember that the Installation needs an working internet connection\nDo you want to try it again?", "WOW Koi Launcher Setup", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    Application.Exit();
                } else {
                    InstallProgram();
                }
            }

        }

        private void DownloadProgressCompleted(object sender, AsyncCompletedEventArgs e)
        {
            stopwatch.Reset();
            if (e.Error != null)
            {
                if (MessageBox.Show("Error while installing the Launcher. Remember that the Installation needs an working internet connection\nDo you want to try it again?", "WOW Koi Launcher Setup", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                }
                else
                {
                    InstallProgram();
                    return;
                }
            }
            ProgressBarBG.Visible = false;
            ProgressBar.Visible = false;
            DLSpeedLabel.Visible = false;
            DownloadInfo.Text = "Installation complete. Starting Launcher...";
            Thread StartingLauncher = new Thread(StartLauncher);
            StartingLauncher.Start();
            
        }

        private void StartLauncher()
        {
            Thread.Sleep(1500);
            Process.Start(InstallPath + "KOI Launcher.exe");
            Application.Exit();
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DLSpeedLabel.Text = string.Format("{0} MB/s", (e.BytesReceived / 1024.0 / 1024.0 / stopwatch.Elapsed.TotalSeconds).ToString("0.0"));
            ProgressBar.Width = 428 / 100 * e.ProgressPercentage;
        }

        //Launcher MoveWindow
        private void MoveBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveActive = true;
            LauncherPosition = e.Location;
        }

        private void MoveBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveActive)
            {
                Location = new Point((Location.X - LauncherPosition.X) + e.X, (Location.Y - LauncherPosition.Y) + e.Y);
                Update();
            }
        }

        private void MoveBox_MouseUp(object sender, MouseEventArgs e)
        {
            MoveActive = false;
        }

        private void ChangeInstallPath(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (InstallActive) return;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    InstallPath = fbd.SelectedPath + "\\";
                    InstallPathLabel.Text = InstallPath;
                    if (!CheckFreeDiskSpace(25))
                    {
                        Diskwarning.Visible = true;
                        SetInstallButtonInactive(true);
                        
                    } else {
                        Diskwarning.Visible = false;
                        SetInstallButtonInactive(false);
                    }
                }
            }
        }


        //Quit Button
        private void QuitButton_MouseHover(object sender, EventArgs e)
        {
            if (InstallActive) return;
            QuitButton.BackgroundImage = Resources.close_hover;
            HoverQuit = true;
        }

        private void QuitButton_MouseLeave(object sender, EventArgs e)
        {
            if (InstallActive) return;
            QuitButton.BackgroundImage = Resources.close_normal;
            HoverQuit = false;
        }

        private void QuitButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (InstallActive) return;
            QuitButton.BackgroundImage = Resources.close_press;
        }

        private void QuitButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (InstallActive) return;
            if (!HoverQuit)
            {
                QuitButton.BackgroundImage = Resources.close_normal;
                return;
            }
            QuitButton.BackgroundImage = Resources.close_hover;
        }

        //Install Button
        private void SetInstallButtonInactive(bool state)
        {
            InstallInactive = state;
            if(state) { InstallButton.Image = Resources.button_inactive; return; }
            InstallButton.Image = Resources.button_normal;
        }

        private void InstallButton_MouseHover(object sender, EventArgs e)
        {
            if (InstallActive) return;
            if (InstallInactive) return;
            InstallButton.Image = Resources.button_hover;
            HoverInstall = true;
        }

        private void InstallButton_MouseLeave(object sender, EventArgs e)
        {
            if (InstallActive) return;
            if (InstallInactive) return;
            InstallButton.Image = Resources.button_normal;
            HoverInstall = false;
        }

        private void InstallButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (InstallActive) return;
            if (InstallInactive) return;
            InstallButton.Image = Resources.button_press;
        }

        private void InstallButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (InstallActive) return;
            if (InstallInactive) return;
            if (!HoverInstall)
            {
                InstallButton.Image = Resources.button_normal;
                return;
            }
            InstallButton.Image = Resources.button_hover;
        }

    }
}
