namespace KOI_Launcher
{
    partial class LauncherMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherMainWindow));
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.MoveBox = new System.Windows.Forms.Panel();
            this.Version_Label = new System.Windows.Forms.Label();
            this.Quit_Button = new System.Windows.Forms.PictureBox();
            this.Minimize_Button = new System.Windows.Forms.PictureBox();
            this.Play_Button = new System.Windows.Forms.Label();
            this.TaskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Quit_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ErrorMessage.Location = new System.Drawing.Point(888, 428);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(300, 20);
            this.ErrorMessage.TabIndex = 0;
            this.ErrorMessage.Text = "ErrorMessage";
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrorMessage.Visible = false;
            // 
            // MoveBox
            // 
            this.MoveBox.BackColor = System.Drawing.Color.Transparent;
            this.MoveBox.Location = new System.Drawing.Point(0, 0);
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.Size = new System.Drawing.Size(1070, 35);
            this.MoveBox.TabIndex = 1;
            this.MoveBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseDown);
            this.MoveBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseMove);
            this.MoveBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseUp);
            // 
            // Version_Label
            // 
            this.Version_Label.BackColor = System.Drawing.Color.Transparent;
            this.Version_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Version_Label.Location = new System.Drawing.Point(1123, 532);
            this.Version_Label.Name = "Version_Label";
            this.Version_Label.Size = new System.Drawing.Size(75, 15);
            this.Version_Label.TabIndex = 2;
            this.Version_Label.Text = "0.0.0";
            this.Version_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Quit_Button
            // 
            this.Quit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Quit_Button.BackgroundImage = global::KOI_Launcher.Properties.Resources.close_normal;
            this.Quit_Button.Location = new System.Drawing.Point(1152, 3);
            this.Quit_Button.Name = "Quit_Button";
            this.Quit_Button.Size = new System.Drawing.Size(45, 20);
            this.Quit_Button.TabIndex = 3;
            this.Quit_Button.TabStop = false;
            this.Quit_Button.Click += new System.EventHandler(this.QuitKOILauncher);
            this.Quit_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Quit_Button_MouseDown);
            this.Quit_Button.MouseLeave += new System.EventHandler(this.Quit_Button_MouseLeave);
            this.Quit_Button.MouseHover += new System.EventHandler(this.Quit_Button_MouseHover);
            this.Quit_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Quit_Button_MouseUp);
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_Button.BackgroundImage = global::KOI_Launcher.Properties.Resources.minimize_normal;
            this.Minimize_Button.Location = new System.Drawing.Point(1101, 3);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(45, 20);
            this.Minimize_Button.TabIndex = 4;
            this.Minimize_Button.TabStop = false;
            this.Minimize_Button.Click += new System.EventHandler(this.MinimizeKOILauncher);
            this.Minimize_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Minimize_Button_MouseDown);
            this.Minimize_Button.MouseLeave += new System.EventHandler(this.Minimize_Button_MouseLeave);
            this.Minimize_Button.MouseHover += new System.EventHandler(this.Minimize_Button_MouseHover);
            this.Minimize_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Minimize_Button_MouseUp);
            // 
            // Play_Button
            // 
            this.Play_Button.BackColor = System.Drawing.Color.Transparent;
            this.Play_Button.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Play_Button.Image = global::KOI_Launcher.Properties.Resources.button_inactive;
            this.Play_Button.Location = new System.Drawing.Point(958, 453);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(230, 68);
            this.Play_Button.TabIndex = 5;
            this.Play_Button.Text = "Install";
            this.Play_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Play_Button.Click += new System.EventHandler(this.StartGame);
            this.Play_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Play_Button_MouseDown);
            this.Play_Button.MouseLeave += new System.EventHandler(this.Play_Button_MouseLeave);
            this.Play_Button.MouseHover += new System.EventHandler(this.Play_Button_MouseHover);
            this.Play_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Play_Button_MouseUp);
            // 
            // TaskbarIcon
            // 
            this.TaskbarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskbarIcon.Icon")));
            this.TaskbarIcon.Text = "Koi Launcher";
            this.TaskbarIcon.Visible = true;
            this.TaskbarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskHideShow);
            // 
            // LauncherMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KOI_Launcher.Properties.Resources.wkoi_bg;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.Quit_Button);
            this.Controls.Add(this.Version_Label);
            this.Controls.Add(this.MoveBox);
            this.Controls.Add(this.ErrorMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LauncherMainWindow";
            this.Text = "Koi Launcher";
            this.Load += new System.EventHandler(this.LauncherLoad);
            ((System.ComponentModel.ISupportInitialize)(this.Quit_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Panel MoveBox;
        private System.Windows.Forms.Label Version_Label;
        private System.Windows.Forms.PictureBox Quit_Button;
        private System.Windows.Forms.PictureBox Minimize_Button;
        private System.Windows.Forms.Label Play_Button;
        private System.Windows.Forms.NotifyIcon TaskbarIcon;
    }
}

