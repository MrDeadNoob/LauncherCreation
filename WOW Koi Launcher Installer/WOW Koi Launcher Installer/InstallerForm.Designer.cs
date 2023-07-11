namespace WOW_Koi_Launcher_Installer
{
    partial class InstallerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallerForm));
            this.InstallPathLabel = new System.Windows.Forms.Label();
            this.InstallPathChange = new System.Windows.Forms.LinkLabel();
            this.LabelInstallPath = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.PictureBox();
            this.MoveBox = new System.Windows.Forms.Panel();
            this.ProgressBarBG = new System.Windows.Forms.PictureBox();
            this.ProgressBar = new System.Windows.Forms.PictureBox();
            this.DownloadInfo = new System.Windows.Forms.Label();
            this.InstallButton = new System.Windows.Forms.Label();
            this.Diskwarning = new System.Windows.Forms.Label();
            this.DLSpeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // InstallPathLabel
            // 
            this.InstallPathLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstallPathLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstallPathLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallPathLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.InstallPathLabel.Location = new System.Drawing.Point(39, 149);
            this.InstallPathLabel.Name = "InstallPathLabel";
            this.InstallPathLabel.Size = new System.Drawing.Size(250, 30);
            this.InstallPathLabel.TabIndex = 0;
            this.InstallPathLabel.Text = "C:\\";
            this.InstallPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InstallPathChange
            // 
            this.InstallPathChange.ActiveLinkColor = System.Drawing.Color.SeaGreen;
            this.InstallPathChange.BackColor = System.Drawing.Color.Transparent;
            this.InstallPathChange.Font = new System.Drawing.Font("Arial", 9.75F);
            this.InstallPathChange.LinkColor = System.Drawing.Color.SeaGreen;
            this.InstallPathChange.Location = new System.Drawing.Point(295, 149);
            this.InstallPathChange.Name = "InstallPathChange";
            this.InstallPathChange.Size = new System.Drawing.Size(80, 30);
            this.InstallPathChange.TabIndex = 1;
            this.InstallPathChange.TabStop = true;
            this.InstallPathChange.Text = "Change";
            this.InstallPathChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstallPathChange.VisitedLinkColor = System.Drawing.Color.SeaGreen;
            this.InstallPathChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeInstallPath);
            // 
            // LabelInstallPath
            // 
            this.LabelInstallPath.AutoSize = true;
            this.LabelInstallPath.BackColor = System.Drawing.Color.Transparent;
            this.LabelInstallPath.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LabelInstallPath.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelInstallPath.Location = new System.Drawing.Point(12, 124);
            this.LabelInstallPath.Name = "LabelInstallPath";
            this.LabelInstallPath.Size = new System.Drawing.Size(98, 16);
            this.LabelInstallPath.TabIndex = 2;
            this.LabelInstallPath.Text = "Installation path";
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.BackgroundImage = global::WOW_Koi_Launcher_Installer.Properties.Resources.close_normal;
            this.QuitButton.Location = new System.Drawing.Point(398, 4);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(45, 20);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.TabStop = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitInstaller);
            this.QuitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuitButton_MouseDown);
            this.QuitButton.MouseLeave += new System.EventHandler(this.QuitButton_MouseLeave);
            this.QuitButton.MouseHover += new System.EventHandler(this.QuitButton_MouseHover);
            this.QuitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.QuitButton_MouseUp);
            // 
            // MoveBox
            // 
            this.MoveBox.BackColor = System.Drawing.Color.Transparent;
            this.MoveBox.Location = new System.Drawing.Point(0, 0);
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.Size = new System.Drawing.Size(395, 30);
            this.MoveBox.TabIndex = 4;
            this.MoveBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseDown);
            this.MoveBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseMove);
            this.MoveBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseUp);
            // 
            // ProgressBarBG
            // 
            this.ProgressBarBG.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProgressBarBG.Location = new System.Drawing.Point(10, 260);
            this.ProgressBarBG.Name = "ProgressBarBG";
            this.ProgressBarBG.Size = new System.Drawing.Size(430, 17);
            this.ProgressBarBG.TabIndex = 5;
            this.ProgressBarBG.TabStop = false;
            this.ProgressBarBG.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackgroundImage = global::WOW_Koi_Launcher_Installer.Properties.Resources.dlprogress;
            this.ProgressBar.Location = new System.Drawing.Point(11, 261);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(0, 15);
            this.ProgressBar.TabIndex = 6;
            this.ProgressBar.TabStop = false;
            this.ProgressBar.Visible = false;
            // 
            // DownloadInfo
            // 
            this.DownloadInfo.BackColor = System.Drawing.Color.Transparent;
            this.DownloadInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DownloadInfo.Location = new System.Drawing.Point(0, 240);
            this.DownloadInfo.Name = "DownloadInfo";
            this.DownloadInfo.Size = new System.Drawing.Size(450, 13);
            this.DownloadInfo.TabIndex = 7;
            this.DownloadInfo.Text = "Installing... please wait";
            this.DownloadInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownloadInfo.Visible = false;
            // 
            // InstallButton
            // 
            this.InstallButton.BackColor = System.Drawing.Color.Transparent;
            this.InstallButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InstallButton.Image = global::WOW_Koi_Launcher_Installer.Properties.Resources.button_normal;
            this.InstallButton.Location = new System.Drawing.Point(320, 246);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(120, 30);
            this.InstallButton.TabIndex = 8;
            this.InstallButton.Text = "Install";
            this.InstallButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InstallButton.Click += new System.EventHandler(this.PreInstallRoutine);
            this.InstallButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InstallButton_MouseDown);
            this.InstallButton.MouseLeave += new System.EventHandler(this.InstallButton_MouseLeave);
            this.InstallButton.MouseHover += new System.EventHandler(this.InstallButton_MouseHover);
            this.InstallButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InstallButton_MouseUp);
            // 
            // Diskwarning
            // 
            this.Diskwarning.AutoSize = true;
            this.Diskwarning.BackColor = System.Drawing.Color.Transparent;
            this.Diskwarning.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Diskwarning.ForeColor = System.Drawing.Color.Red;
            this.Diskwarning.Location = new System.Drawing.Point(12, 185);
            this.Diskwarning.Name = "Diskwarning";
            this.Diskwarning.Size = new System.Drawing.Size(138, 16);
            this.Diskwarning.TabIndex = 9;
            this.Diskwarning.Text = "Not enough Diskspace";
            this.Diskwarning.Visible = false;
            // 
            // DLSpeedLabel
            // 
            this.DLSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.DLSpeedLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DLSpeedLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DLSpeedLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DLSpeedLabel.Location = new System.Drawing.Point(337, 270);
            this.DLSpeedLabel.Name = "DLSpeedLabel";
            this.DLSpeedLabel.Size = new System.Drawing.Size(100, 23);
            this.DLSpeedLabel.TabIndex = 10;
            this.DLSpeedLabel.Text = "0 kB/s";
            this.DLSpeedLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DLSpeedLabel.Visible = false;
            // 
            // InstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 295);
            this.Controls.Add(this.Diskwarning);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.DownloadInfo);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.MoveBox);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.LabelInstallPath);
            this.Controls.Add(this.InstallPathChange);
            this.Controls.Add(this.InstallPathLabel);
            this.Controls.Add(this.ProgressBarBG);
            this.Controls.Add(this.DLSpeedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WOW Koi Installer";
            this.Load += new System.EventHandler(this.InstallerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstallPathLabel;
        private System.Windows.Forms.LinkLabel InstallPathChange;
        private System.Windows.Forms.Label LabelInstallPath;
        private System.Windows.Forms.PictureBox QuitButton;
        private System.Windows.Forms.Panel MoveBox;
        private System.Windows.Forms.PictureBox ProgressBarBG;
        private System.Windows.Forms.PictureBox ProgressBar;
        private System.Windows.Forms.Label DownloadInfo;
        private System.Windows.Forms.Label InstallButton;
        private System.Windows.Forms.Label Diskwarning;
        private System.Windows.Forms.Label DLSpeedLabel;
    }
}

