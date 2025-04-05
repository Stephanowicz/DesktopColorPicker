namespace ColorPicker
{
    partial class ColorGradient
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
            this.pbCrossHair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrossHair)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCrossHair
            // 
            this.pbCrossHair.BackColor = System.Drawing.Color.Transparent;
            this.pbCrossHair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbCrossHair.Location = new System.Drawing.Point(53, 61);
            this.pbCrossHair.Name = "pbCrossHair";
            this.pbCrossHair.Size = new System.Drawing.Size(13, 16);
            this.pbCrossHair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCrossHair.TabIndex = 0;
            this.pbCrossHair.TabStop = false;
            // 
            // ColorGradient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.pbCrossHair);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "ColorGradient";
            this.Size = new System.Drawing.Size(187, 181);
            this.Load += new System.EventHandler(this.ColorGradient_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorGradient_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorGradient_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorGradient_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrossHair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCrossHair;
    }
}
