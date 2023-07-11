using KOI_Launcher.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KOI_Launcher
{
    public partial class LauncherMainWindow : Form
    {
        internal bool Hover_Quit = false;
        internal bool Hover_Minimize = false;
        internal bool Hover_Play = false;
        internal bool Active_Play = false;

        internal bool MoveActive = false;
        internal Point LauncherPosition;
        internal bool HideTaskbar = false;

        internal string KOI_Version = "0.0.1";

        public LauncherMainWindow()
        {
            InitializeComponent();

        }

        private void LauncherLoad(object sender, EventArgs e)
        {
            Version_Label.Text = KOI_Version;
            Play_Button_State(0);
        }

        private void QuitKOILauncher(object sender, EventArgs e)
        {
            Close();
        }

        private void HideInTaskbar(bool state)
        {
            if (state) { Hide(); return; }
            Show();
        }

        private void MinimizeKOILauncher(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void StartGame(object sender, EventArgs e)
        {
            if (!Active_Play) { return; }
            try
            {
                Process.Start("Wow.exe");
                Play_Button_State(2);
            }
            catch (Exception)
            {
                Play_Button_State(3);
                ErrorMessage.ForeColor = Color.DarkOrange;
                ErrorMessage.Text = "Spiel konnte nicht gestartet werden";
                ErrorMessage.Visible = true;
                MessageBox.Show("Fehler: Spiel konnte nicht gestartet werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        private void Quit_Button_MouseHover(object sender, EventArgs e)
        {
            Quit_Button.BackgroundImage = Resources.close_hover;
            Hover_Quit = true;
        }

        private void Quit_Button_MouseLeave(object sender, EventArgs e)
        {
            Quit_Button.BackgroundImage = Resources.close_normal;
            Hover_Quit = false;
        }

        private void Quit_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Quit_Button.BackgroundImage = Resources.close_press;
        }

        private void Quit_Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Hover_Quit)
            {
                Quit_Button.BackgroundImage = Resources.close_normal;
                return;
            }
            Quit_Button.BackgroundImage = Resources.close_hover;
        }

        //Minimize Button
        private void Minimize_Button_MouseHover(object sender, EventArgs e)
        {
            Minimize_Button.BackgroundImage = Resources.minimize_hover;
            Hover_Minimize = true;
        }

        private void Minimize_Button_MouseLeave(object sender, EventArgs e)
        {
            Minimize_Button.BackgroundImage = Resources.minimize_normal;
            Hover_Minimize = false;
        }

        private void Minimize_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Minimize_Button.BackgroundImage = Resources.minimize_press;
        }

        private void Minimize_Button_MouseUp(object sender, MouseEventArgs e)
        {

        }

        //Play Button
        private void Play_Button_MouseHover(object sender, EventArgs e)
        {
            if (!Active_Play) { return; }
            Play_Button.Image = Resources.button_hover;
            Hover_Play = true;
        }

        private void Play_Button_MouseLeave(object sender, EventArgs e)
        {
            if (!Active_Play) { return; }
            Play_Button.Image = Resources.button_normal;
            Hover_Play = false;
        }

        private void Play_Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Active_Play) { return; }
            Play_Button.Image = Resources.button_press;
        }

        private void Play_Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Active_Play) { return; }
            if (!Hover_Play)
            {
                Play_Button.Image = Resources.button_normal;
                return;
            }
            Play_Button.Image = Resources.button_hover;
        }

        private void Play_Button_State(int state)
        {
            switch (state)
            {
                case 0: //Game Ready
                    Play_Button.Image = Resources.button_normal;
                    Play_Button.Cursor = DefaultCursor;
                    Play_Button.Text = GetLocalString("ready");
                    Play_Button.ForeColor = SystemColors.ButtonFace;
                    Active_Play = true;
                    break;
                case 1: //Install Game
                    Play_Button.Image = Resources.button_normal;
                    Play_Button.Cursor = DefaultCursor;
                    Play_Button.Text = GetLocalString("install");
                    Play_Button.ForeColor = SystemColors.ButtonFace;
                    Active_Play = true;
                    break;
                case 2: //Game Running
                    Play_Button.Image = Resources.button_inactive;
                    Play_Button.Cursor = DefaultCursor;
                    Play_Button.Text = "Spiel läuft...";
                    Play_Button.ForeColor = SystemColors.ButtonFace;
                    Active_Play = false;
                    break;
                case 3: //Error
                    Play_Button.Image = Resources.button_inactive;
                    Play_Button.Cursor = Cursors.No;
                    Play_Button.ForeColor = SystemColors.AppWorkspace;
                    Active_Play = false;
                    break;
            }
        }

        private void TaskHideShow(object sender, MouseEventArgs e)
        {
            HideInTaskbar(!HideTaskbar);
            HideTaskbar = !HideTaskbar;
        }

        //Language Support
        private string GetLocalString(string placeholder)
        {
            switch (placeholder)
            {
                case "ready":
                    return "Spielen";
                case "install":
                    return "Installieren";
                case "running":
                    return "Spielen";
                case "error":
                    return "Spielen";
                default:
                    return "ERROR_LANG";
            }
        }
    }
}
