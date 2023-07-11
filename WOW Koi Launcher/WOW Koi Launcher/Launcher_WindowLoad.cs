using System;
using System.Threading;
using System.Windows.Forms;
using WOW_Koi_Launcher.Classes;
using WOW_Koi_Launcher.Language;

namespace WOW_Koi_Launcher
{
    public partial class Launcher_WindowLoad : Form
    {

        public Launcher_WindowLoad()
        {
            InitializeComponent();
            
        }

        private async void Launcher_WindowLoad_Load(object sender, EventArgs e)
        {
            await Configuration.LoadSettings();
            _ = new LanguageManager();
            Thread Startup = new Thread(StartupLauncher);
            Startup.Start();
        }

        private void StartupLauncher()
        {
            Thread.Sleep(500);
            OpenMainWindow();
        }

        private void OpenMainWindow()
        {
            MethodInvoker InvokeDelegate = delegate () {
                Launcher_WindowMain MainWindow = new Launcher_WindowMain();
                this.Visible = false;
                MainWindow.ShowDialog();
            };
            if (InvokeRequired)
                Invoke(InvokeDelegate);
            else
                InvokeDelegate();
            
            
        }


    }
}
