namespace WOW_Koi_Launcher
{
    partial class Launcher_WindowLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher_WindowLoad));
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InfoLabel.Location = new System.Drawing.Point(75, 150);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(300, 25);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Launcher is starting...Please wait";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Launcher_WindowLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WOW_Koi_Launcher.Properties.Resources.wkoiload_bg;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher_WindowLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WOW Koi Launcher";
            this.Load += new System.EventHandler(this.Launcher_WindowLoad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
    }
}

