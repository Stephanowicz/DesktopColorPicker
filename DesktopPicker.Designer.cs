namespace ColorPicker
{
    partial class DesktopPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.magnifyingGlass1 = new DesktopColorPicker.MagnifyingGlass();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(146, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 105);
            this.panel1.TabIndex = 2;
            // 
            // magnifyingGlass1
            // 
            this.magnifyingGlass1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.magnifyingGlass1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.magnifyingGlass1.Location = new System.Drawing.Point(12, 12);
            this.magnifyingGlass1.Name = "magnifyingGlass1";
            this.magnifyingGlass1.PixelRange = 10;
            this.magnifyingGlass1.PixelSize = 5;
            this.magnifyingGlass1.PosAlign = System.Drawing.ContentAlignment.TopLeft;
            this.magnifyingGlass1.PosFormat = "#x ; #y";
            this.magnifyingGlass1.ShowPixel = true;
            this.magnifyingGlass1.ShowPosition = true;
            this.magnifyingGlass1.Size = new System.Drawing.Size(105, 105);
            this.magnifyingGlass1.TabIndex = 0;
            this.magnifyingGlass1.UseMovingGlass = true;
            this.magnifyingGlass1.DisplayUpdated += new DesktopColorPicker.MagnifyingGlass.DisplayUpdatedDelegate(this.magnifyingGlass1_DisplayUpdated);
            // 
            // DesktopPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 133);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.magnifyingGlass1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DesktopPicker";
            this.Text = "DesktopPicker";
            this.Deactivate += new System.EventHandler(this.DesktopPicker_Deactivate);
            this.ResumeLayout(false);

        }

        #endregion

        private DesktopColorPicker.MagnifyingGlass magnifyingGlass1;
        private System.Windows.Forms.Panel panel1;
    }
}