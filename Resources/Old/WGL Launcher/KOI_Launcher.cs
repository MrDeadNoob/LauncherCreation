using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KOI_Launcher.Properties;

namespace KOI_Launcher
{
    public partial class KOI_Launcher : Form
    {
        internal bool Hover_Quit = false;
        internal bool Hover_Minimize = false;
        internal bool Hover_Play = false;
        internal bool Active_Play = false;

        internal bool MoveActive = false;
        internal Point LauncherPosition;

        internal string WGL_Version = "0.0.1";

        
        

        public KOI_Launcher()
        {
            InitializeComponent();
            Version_Label.Text = WGL_Version;
            Play_Button_State(true);

        }

        private void QuitWGLLauncher(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeWGLLauncher(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void StartGame(object sender, EventArgs e)
        {
            try
            {
                //Process.Start("Wow.exe");
                ErrorMessage.Text = GetWoWVersion("Wow.exe");
                ErrorMessage.ForeColor = Color.BlueViolet;
                ErrorMessage.Text = "Spiel konnte nicht gestartet werden";
                ErrorMessage.Visible = true;
            }
            catch (Exception)
            {
                Play_Button_State(false);
                ErrorMessage.Visible = true;

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
            if (!Hover_Minimize)
            {
                Minimize_Button.BackgroundImage = Resources.minimize_normal;
                return;
            }
            Minimize_Button.BackgroundImage = Resources.minimize_hover;
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

        private void Play_Button_State(bool state)
        {
            Active_Play = state;
            if (state)
            {
                Play_Button.Image = Resources.button_normal;
                Play_Button.Cursor = DefaultCursor;
                return;
            }
            Play_Button.Image = Resources.button_inactive;
            Play_Button.Cursor = Cursors.No;
        }


    }
}
