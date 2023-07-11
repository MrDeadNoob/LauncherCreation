namespace KOI_Launcher
{
    partial class KOI_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KOI_Launcher));
            this.Minimize_Button = new System.Windows.Forms.PictureBox();
            this.Quit_Button = new System.Windows.Forms.PictureBox();
            this.Version_Label = new System.Windows.Forms.Label();
            this.Play_Button = new System.Windows.Forms.Label();
            this.MoveBox = new System.Windows.Forms.PictureBox();
            this.ErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_Button.BackgroundImage = global::KOI_Launcher.Properties.Resources.minimize_normal;
            resources.ApplyResources(this.Minimize_Button, "Minimize_Button");
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.TabStop = false;
            this.Minimize_Button.Click += new System.EventHandler(this.MinimizeWGLLauncher);
            this.Minimize_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Minimize_Button_MouseDown);
            this.Minimize_Button.MouseLeave += new System.EventHandler(this.Minimize_Button_MouseLeave);
            this.Minimize_Button.MouseHover += new System.EventHandler(this.Minimize_Button_MouseHover);
            this.Minimize_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Minimize_Button_MouseUp);
            // 
            // Quit_Button
            // 
            this.Quit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Quit_Button.BackgroundImage = global::KOI_Launcher.Properties.Resources.close_normal;
            resources.ApplyResources(this.Quit_Button, "Quit_Button");
            this.Quit_Button.Name = "Quit_Button";
            this.Quit_Button.TabStop = false;
            this.Quit_Button.Click += new System.EventHandler(this.QuitWGLLauncher);
            this.Quit_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Quit_Button_MouseDown);
            this.Quit_Button.MouseLeave += new System.EventHandler(this.Quit_Button_MouseLeave);
            this.Quit_Button.MouseHover += new System.EventHandler(this.Quit_Button_MouseHover);
            this.Quit_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Quit_Button_MouseUp);
            // 
            // Version_Label
            // 
            resources.ApplyResources(this.Version_Label, "Version_Label");
            this.Version_Label.BackColor = System.Drawing.Color.Transparent;
            this.Version_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Version_Label.Name = "Version_Label";
            // 
            // Play_Button
            // 
            this.Play_Button.BackColor = System.Drawing.Color.Transparent;
            this.Play_Button.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.Play_Button, "Play_Button");
            this.Play_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Play_Button.Image = global::KOI_Launcher.Properties.Resources.button_inactive;
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Click += new System.EventHandler(this.StartGame);
            this.Play_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Play_Button_MouseDown);
            this.Play_Button.MouseLeave += new System.EventHandler(this.Play_Button_MouseLeave);
            this.Play_Button.MouseHover += new System.EventHandler(this.Play_Button_MouseHover);
            this.Play_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Play_Button_MouseUp);
            // 
            // MoveBox
            // 
            this.MoveBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MoveBox, "MoveBox");
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.TabStop = false;
            this.MoveBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseDown);
            this.MoveBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseMove);
            this.MoveBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveBox_MouseUp);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ErrorMessage, "ErrorMessage");
            this.ErrorMessage.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorMessage.Name = "ErrorMessage";
            // 
            // KOI_Launcher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::KOI_Launcher.Properties.Resources.wkoi_bg;
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.MoveBox);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.Version_Label);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.Quit_Button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KOI_Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Quit_Button;
        private System.Windows.Forms.PictureBox Minimize_Button;
        private System.Windows.Forms.Label Version_Label;
        private System.Windows.Forms.Label Play_Button;
        private System.Windows.Forms.PictureBox MoveBox;
        private System.Windows.Forms.Label ErrorMessage;
    }
}

