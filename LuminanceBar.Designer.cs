namespace ColorPicker
{
    partial class LuminanceBar
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbBeam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeam)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBeam
            // 
            this.pbBeam.BackColor = System.Drawing.Color.Transparent;
            this.pbBeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBeam.Enabled = false;
            this.pbBeam.Location = new System.Drawing.Point(0, 0);
            this.pbBeam.Margin = new System.Windows.Forms.Padding(0);
            this.pbBeam.Name = "pbBeam";
            this.pbBeam.Size = new System.Drawing.Size(22, 22);
            this.pbBeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBeam.TabIndex = 1;
            this.pbBeam.TabStop = false;
            // 
            // LuminanceBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.pbBeam);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LuminanceBar";
            this.Size = new System.Drawing.Size(38, 141);
            this.Load += new System.EventHandler(this.LuminaceBar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LuminanceBar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LuminanceBar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LuminanceBar_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBeam;
    }
}
