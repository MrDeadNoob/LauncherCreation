namespace WOW_Koi_Launcher
{
    partial class Launcher_WindowMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher_WindowMain));
            this.VersionLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.GameButton = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.MoveBox = new System.Windows.Forms.Panel();
            this.TaskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.LegionLogo = new System.Windows.Forms.PictureBox();
            this.ProgressBarBG = new System.Windows.Forms.PictureBox();
            this.NewsBox1 = new System.Windows.Forms.PictureBox();
            this.NewsBox2 = new System.Windows.Forms.PictureBox();
            this.NewsBox3 = new System.Windows.Forms.PictureBox();
            this.ProgressDL = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.PictureBox();
            this.GameVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegionLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionLabel
            // 
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.VersionLabel, "VersionLabel");
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.VersionLabel.Name = "VersionLabel";
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.BackgroundImage = global::WOW_Koi_Launcher.Properties.Resources.close_normal;
            resources.ApplyResources(this.QuitButton, "QuitButton");
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.TabStop = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitKOILauncher);
            this.QuitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuitButton_MouseDown);
            this.QuitButton.MouseEnter += new System.EventHandler(this.QuitButton_MouseHover);
            this.QuitButton.MouseLeave += new System.EventHandler(this.QuitButton_MouseLeave);
            this.QuitButton.MouseHover += new System.EventHandler(this.QuitButton_MouseHover);
            this.QuitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.QuitButton_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImage = global::WOW_Koi_Launcher.Properties.Resources.minimize_normal;
            resources.ApplyResources(this.MinimizeButton, "MinimizeButton");
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeKOILauncher);
            this.MinimizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizeButton_MouseDown);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseHover);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            this.MinimizeButton.MouseHover += new System.EventHandler(this.MinimizeButton_MouseHover);
            this.MinimizeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinimizeButton_MouseUp);
            // 
            // GameButton
            // 
            this.GameButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.GameButton, "GameButton");
            this.GameButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.GameButton.Image = global::WOW_Koi_Launcher.Properties.Resources.button_inactive;
            this.GameButton.Name = "GameButton";
            this.GameButton.Click += new System.EventHandler(this.StartGame);
            this.GameButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseDown);
            this.GameButton.MouseEnter += new System.EventHandler(this.GameButton_MouseHover);
            this.GameButton.MouseLeave += new System.EventHandler(this.GameButton_MouseLeave);
            this.GameButton.MouseHover += new System.EventHandler(this.GameButton_MouseHover);
            this.GameButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameButton_MouseUp);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ErrorMessage, "ErrorMessage");
            this.ErrorMessage.Name = "ErrorMessage";
            // 
            // MoveBox
            // 
            this.MoveBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MoveBox, "MoveBox");
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseDown);
            this.MoveBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseMove);
            this.MoveBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseUp);
            // 
            // TaskbarIcon
            // 
            resources.ApplyResources(this.TaskbarIcon, "TaskbarIcon");
            this.TaskbarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskbarIcon_DoubleClick);
            // 
            // LegionLogo
            // 
            this.LegionLogo.BackColor = System.Drawing.Color.Transparent;
            this.LegionLogo.BackgroundImage = global::WOW_Koi_Launcher.Properties.Resources.LegionLogo;
            resources.ApplyResources(this.LegionLogo, "LegionLogo");
            this.LegionLogo.Name = "LegionLogo";
            this.LegionLogo.TabStop = false;
            // 
            // ProgressBarBG
            // 
            this.ProgressBarBG.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ProgressBarBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ProgressBarBG, "ProgressBarBG");
            this.ProgressBarBG.Name = "ProgressBarBG";
            this.ProgressBarBG.TabStop = false;
            // 
            // NewsBox1
            // 
            this.NewsBox1.BackColor = System.Drawing.Color.Transparent;
            this.NewsBox1.BackgroundImage = global::WOW_Koi_Launcher.Properties.Resources.news_bg;
            resources.ApplyResources(this.NewsBox1, "NewsBox1");
            this.NewsBox1.Name = "NewsBox1";
            this.NewsBox1.TabStop = false;
            // 
            // NewsBox2
            // 
            this.NewsBox2.BackColor = System.Drawing.Color.Transparent;
            this.NewsBox2.BackgroundImage = global::WOW_Koi_Launcher.Properties.Resources.news_bg;
            resources.ApplyResources(this.NewsBox2, "NewsBox2");
            this.NewsBox2.Name = "NewsBox2";
            this.NewsBox2.TabStop = false;
            // 
            // NewsBox3
            // 
            this.NewsBox3.BackColor = System.Drawing.Color.Transparent;
            this.NewsBox3.BackgroundImage = global::WOW_Koi_Launcher.Properties.Resources.news_bg;
            resources.ApplyResources(this.NewsBox3, "NewsBox3");
            this.NewsBox3.Name = "NewsBox3";
            this.NewsBox3.TabStop = false;
            // 
            // ProgressDL
            // 
            this.ProgressDL.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ProgressDL, "ProgressDL");
            this.ProgressDL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProgressDL.Name = "ProgressDL";
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.BackgroundImage = global::WOW_Koi_Launcher.Properties.Resources.dlprogress;
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.TabStop = false;
            // 
            // GameVersion
            // 
            this.GameVersion.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.GameVersion, "GameVersion");
            this.GameVersion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameVersion.Name = "GameVersion";
            // 
            // Launcher_WindowMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WOW_Koi_Launcher.Properties.Resources.wkoi_bg;
            this.Controls.Add(this.GameVersion);
            this.Controls.Add(this.ProgressDL);
            this.Controls.Add(this.NewsBox3);
            this.Controls.Add(this.NewsBox2);
            this.Controls.Add(this.NewsBox1);
            this.Controls.Add(this.LegionLogo);
            this.Controls.Add(this.MoveBox);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.GameButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ProgressBarBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launcher_WindowMain";
            this.Load += new System.EventHandler(this.Launcher_WindowMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegionLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.PictureBox QuitButton;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.Label GameButton;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Panel MoveBox;
        private System.Windows.Forms.NotifyIcon TaskbarIcon;
        private System.Windows.Forms.PictureBox LegionLogo;
        private System.Windows.Forms.PictureBox ProgressBarBG;
        private System.Windows.Forms.PictureBox NewsBox1;
        private System.Windows.Forms.PictureBox NewsBox2;
        private System.Windows.Forms.PictureBox NewsBox3;
        private System.Windows.Forms.Label ProgressDL;
        private System.Windows.Forms.PictureBox ProgressBar;
        private System.Windows.Forms.Label GameVersion;
    }
}

