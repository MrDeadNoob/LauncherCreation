using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WOW_Koi_Launcher.Classes;
using WOW_Koi_Launcher.Language;
using WOW_Koi_Launcher.Properties;
using Timer = System.Timers.Timer;


namespace WOW_Koi_Launcher
{
    public partial class Launcher_WindowMain : Form
    {
        public static string LauncherVersion = "0.2.13";

        private Timer BackgroundTimer;

        private bool GameRunning = false;
        private bool GameWatcher = false;
        
        private bool HoverQuit = false;
        private bool HoverMinimize = false;
        private bool GameButtonHover = false;
        private bool GameButtonInactive = false;

        internal bool MoveActive = false;
        internal Point LauncherPosition;

        internal bool LauncherHided = false;        

        public Launcher_WindowMain()
        {
            InitializeComponent();
            Thread Watcher = new Thread(InitBackgroundWorker);
            Watcher.Start();
            Installer.DownloadWoW(Configuration.InstallPath);
        }

        private void Launcher_WindowMain_Load(object sender, EventArgs e)
        {
            _ = SimulateTaskbarAsync();
            string wowpath = Configuration.InstallPath + "\\Wow.exe";
            if (File.Exists(wowpath)) {
                string wowversion = GetWoWVersion(wowpath);
                GameVersion.Visible = true;
                GameVersion.Text = wowversion;
                VersionLabel.Text = $"Version: {LauncherVersion}";
            }            
            if (IsWoWRunning())
            {
                GameWatcher = true;
                SetGameButtonState(2);
                GameRunning = true;
            }
            else
            {
                SetGameButtonState(0);
            }
        }

        private async Task SimulateTaskbarAsync()
        {
            int countup = 0; float dlspeed = 99.9f;
            TaskbarManager taskbarman = TaskbarManager.Instance;
            taskbarman.SetProgressValue(countup, 100, Handle);
            taskbarman.SetProgressState(TaskbarProgressBarState.Normal, Handle);
            ProgressBar.Width = countup;
            ProgressBarBG.Visible = true;
            ProgressBar.Visible = true;
            ProgressDL.Visible = true;
            await Task.Delay(200);
            while (countup <= 100) {
                await Task.Delay(200);
                countup++;
                taskbarman.SetProgressValue(countup, 100, Handle);
                ProgressBar.Width = 930 / 100 * countup;
                ProgressDL.Text = $"{countup} % - {dlspeed} Mb/s";
            }
            taskbarman.SetProgressState(TaskbarProgressBarState.NoProgress, Handle);
            SoundPlayer audio = new SoundPlayer(Resources.Complete);
            audio.Play();
            await Task.Delay(1000);
            ProgressBar.Visible = false;
            ProgressBarBG.Visible = false;
            ProgressDL.Visible = false;

        }

        private void QuitKOILauncher(object sender, EventArgs e)
        {
            WOWKoiLauncher.CloseLauncher();
        }

        private void HideInTaskbar(bool state)
        {
            if (state) { Visible = false; return; }
            Visible = true;
            Focus();
        }

        private void MinimizeKOILauncher(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void StartGame(object sender, EventArgs e)
        {
            if (GameRunning) { return; }
            try
            {
                Process.Start(Configuration.InstallPath + "Wow.exe");
                SetGameButtonState(2);
                GameWatcher = true;
            }
            catch (Exception)
            {
                SetGameButtonState(3);
                ErrorMessage.ForeColor = Color.DarkOrange;
                ErrorMessage.Text = LanguageManager.GetString("game_error_1");
                ErrorMessage.Visible = true;
                SoundPlayer audio = new SoundPlayer(Resources.Info);
                audio.Play();
            }

        }

        private void InitBackgroundWorker()
        {
            BackgroundTimer = new Timer(100);
            BackgroundTimer.Elapsed += BackgroundWorker;
            BackgroundTimer.AutoReset = true;
            BackgroundTimer.Enabled = true;
        }

        private void BackgroundWorker(object sender, ElapsedEventArgs e)
        {
            if (GameWatcher) {
                GameRunning = IsWoWRunning();
                MethodInvoker InvokeDelegate = delegate () {
                    if (GameRunning) { SetGameButtonState(2); return; }
                    SetGameButtonState(0);
                    GameWatcher = false;
                };
                if (InvokeRequired)
                    Invoke(InvokeDelegate);
                else
                    InvokeDelegate();
            }
        }

        private bool IsWoWRunning()
        {
            Process[] Wow = Process.GetProcessesByName("Wow");
            if (Wow.Length == 0)
            {
                Process[] Wow64 = Process.GetProcessesByName("Wow-64");
                if (Wow64.Length == 0) return false;
                return true;
            }
            return true;
        }

        private string GetWoWVersion(string path)
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(path);
            return versionInfo.FileVersion;
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


        //Quit Button
        private void QuitButton_MouseHover(object sender, EventArgs e)
        {
            QuitButton.BackgroundImage = Resources.close_hover;
            HoverQuit = true;
        }

        private void QuitButton_MouseLeave(object sender, EventArgs e)
        {
            QuitButton.BackgroundImage = Resources.close_normal;
            HoverQuit = false;
        }

        private void QuitButton_MouseDown(object sender, MouseEventArgs e)
        {
            QuitButton.BackgroundImage = Resources.close_press;
        }

        private void QuitButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!HoverQuit)
            {
                QuitButton.BackgroundImage = Resources.close_normal;
                return;
            }
            QuitButton.BackgroundImage = Resources.close_hover;
        }

        //Minimize Button
        private void MinimizeButton_MouseHover(object sender, EventArgs e)
        {
            MinimizeButton.BackgroundImage = Resources.minimize_hover;
            HoverMinimize = true;
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.BackgroundImage = Resources.minimize_normal;
            HoverMinimize = false;
        }

        private void MinimizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            MinimizeButton.BackgroundImage = Resources.minimize_press;
        }

        private void MinimizeButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!HoverMinimize)
            {
                MinimizeButton.BackgroundImage = Resources.minimize_normal;
                return;
            }
            MinimizeButton.BackgroundImage = Resources.minimize_hover;
        }

        //Game Button
        private void GameButton_MouseHover(object sender, EventArgs e)
        {
            if (GameButtonInactive) { return; }
            GameButton.Image = Resources.button_hover;
            GameButtonHover = true;
        }

        private void GameButton_MouseLeave(object sender, EventArgs e)
        {
            if (GameButtonInactive) { return; }
            GameButton.Image = Resources.button_normal;
            GameButtonHover = false;
        }

        private void GameButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (GameButtonInactive) { return; }
            GameButton.Image = Resources.button_press;
        }

        private void GameButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (GameButtonInactive) { return; }
            if (!GameButtonHover)
            {
                GameButton.Image = Resources.button_normal;
                return;
            }
            GameButton.Image = Resources.button_hover;
        }

        private void SetGameButtonState(int state)
        {
            switch (state)
            {
                case 0: //Game Ready
                    GameButton.Image = Resources.button_normal;
                    GameButton.Cursor = DefaultCursor;
                    GameButton.Text = LanguageManager.GetString("ready");
                    GameButton.ForeColor = SystemColors.ButtonFace;
                    GameButtonInactive = false;
                    break;
                case 1: //Install Game
                    GameButton.Image = Resources.button_normal;
                    GameButton.Cursor = DefaultCursor;
                    GameButton.Text = LanguageManager.GetString("install");
                    GameButton.ForeColor = SystemColors.ButtonFace;
                    GameButtonInactive = false;
                    break;
                case 2: //Game Running
                    GameButton.Image = Resources.button_inactive;
                    GameButton.Cursor = DefaultCursor;
                    GameButton.Text = LanguageManager.GetString("running");
                    GameButton.ForeColor = SystemColors.ButtonFace;
                    GameButtonInactive = true;
                    break;
                case 3: //Error
                    GameButton.Image = Resources.button_inactive;
                    GameButton.Cursor = Cursors.No;
                    GameButton.ForeColor = SystemColors.AppWorkspace;
                    GameButtonInactive = true;
                    break;
            }
        }

        private void TaskbarIcon_DoubleClick(object sender, MouseEventArgs e)
        {
            HideInTaskbar(!LauncherHided);
            LauncherHided = !LauncherHided;
        }


    }
}
