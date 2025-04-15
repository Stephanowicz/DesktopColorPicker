namespace ColorPicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblActColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHue = new System.Windows.Forms.TextBox();
            this.tbSat = new System.Windows.Forms.TextBox();
            this.tbLum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TextBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbHex1 = new System.Windows.Forms.TextBox();
            this.tbHex2 = new System.Windows.Forms.TextBox();
            this.tbHex3 = new System.Windows.Forms.TextBox();
            this.cbHEXDelimiter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRGBDelimiter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRGB = new System.Windows.Forms.TextBox();
            this.tbHEX = new System.Windows.Forms.TextBox();
            this.btnDesktopPicker = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.luminanceBar1 = new ColorPicker.LuminanceBar();
            this.colorGradient = new ColorPicker.ColorGradient();
            this.tbDecimal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActColor
            // 
            this.lblActColor.BackColor = System.Drawing.Color.Black;
            this.lblActColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActColor.Location = new System.Drawing.Point(12, 255);
            this.lblActColor.Name = "lblActColor";
            this.lblActColor.Size = new System.Drawing.Size(69, 64);
            this.lblActColor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "L";
            // 
            // tbHue
            // 
            this.tbHue.Location = new System.Drawing.Point(100, 252);
            this.tbHue.Name = "tbHue";
            this.tbHue.Size = new System.Drawing.Size(45, 20);
            this.tbHue.TabIndex = 3;
            this.tbHue.Text = "0";
            this.tbHue.WordWrap = false;
            this.tbHue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHue_KeyPress);
            this.tbHue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbHue_KeyUp);
            // 
            // tbSat
            // 
            this.tbSat.Location = new System.Drawing.Point(100, 275);
            this.tbSat.Name = "tbSat";
            this.tbSat.Size = new System.Drawing.Size(45, 20);
            this.tbSat.TabIndex = 3;
            this.tbSat.Text = "0";
            this.tbSat.WordWrap = false;
            this.tbSat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSL_KeyPress);
            this.tbSat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSL_KeyUp);
            // 
            // tbLum
            // 
            this.tbLum.Location = new System.Drawing.Point(100, 297);
            this.tbLum.Name = "tbLum";
            this.tbLum.Size = new System.Drawing.Size(45, 20);
            this.tbLum.TabIndex = 3;
            this.tbLum.Text = "0";
            this.tbLum.WordWrap = false;
            this.tbLum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSL_KeyPress);
            this.tbLum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSL_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "B";
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(166, 252);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(45, 20);
            this.tbR.TabIndex = 3;
            this.tbR.Text = "255";
            this.tbR.WordWrap = false;
            this.tbR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRGB_KeyPress);
            this.tbR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRGB_KeyUp);
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(166, 275);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(45, 20);
            this.tbG.TabIndex = 3;
            this.tbG.Text = "255";
            this.tbG.WordWrap = false;
            this.tbG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRGB_KeyPress);
            this.tbG.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRGB_KeyUp);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(166, 297);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(45, 20);
            this.tbB.TabIndex = 3;
            this.tbB.Text = "255";
            this.tbB.WordWrap = false;
            this.tbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRGB_KeyPress);
            this.tbB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRGB_KeyUp);
            // 
            // tbHex1
            // 
            this.tbHex1.Location = new System.Drawing.Point(215, 252);
            this.tbHex1.Name = "tbHex1";
            this.tbHex1.Size = new System.Drawing.Size(45, 20);
            this.tbHex1.TabIndex = 11;
            this.tbHex1.Text = "FF";
            this.tbHex1.WordWrap = false;
            this.tbHex1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHEX123_KeyPress);
            this.tbHex1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbHEX123_KeyUp);
            // 
            // tbHex2
            // 
            this.tbHex2.Location = new System.Drawing.Point(215, 275);
            this.tbHex2.Name = "tbHex2";
            this.tbHex2.Size = new System.Drawing.Size(45, 20);
            this.tbHex2.TabIndex = 10;
            this.tbHex2.Text = "FF";
            this.tbHex2.WordWrap = false;
            this.tbHex2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHEX123_KeyPress);
            this.tbHex2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbHEX123_KeyUp);
            // 
            // tbHex3
            // 
            this.tbHex3.Location = new System.Drawing.Point(215, 297);
            this.tbHex3.Name = "tbHex3";
            this.tbHex3.Size = new System.Drawing.Size(45, 20);
            this.tbHex3.TabIndex = 9;
            this.tbHex3.Text = "FF";
            this.tbHex3.WordWrap = false;
            this.tbHex3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHEX123_KeyPress);
            this.tbHex3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbHEX123_KeyUp);
            // 
            // cbHEXDelimiter
            // 
            this.cbHEXDelimiter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHEXDelimiter.FormattingEnabled = true;
            this.cbHEXDelimiter.Items.AddRange(new object[] {
            "",
            ",",
            ";"});
            this.cbHEXDelimiter.Location = new System.Drawing.Point(77, 40);
            this.cbHEXDelimiter.Name = "cbHEXDelimiter";
            this.cbHEXDelimiter.Size = new System.Drawing.Size(31, 26);
            this.cbHEXDelimiter.TabIndex = 15;
            this.cbHEXDelimiter.SelectedIndexChanged += new System.EventHandler(this.CbHEXDelimiter_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "HEX-Delimiter:";
            // 
            // cbRGBDelimiter
            // 
            this.cbRGBDelimiter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRGBDelimiter.FormattingEnabled = true;
            this.cbRGBDelimiter.Items.AddRange(new object[] {
            "",
            ",",
            ";"});
            this.cbRGBDelimiter.Location = new System.Drawing.Point(77, 12);
            this.cbRGBDelimiter.Name = "cbRGBDelimiter";
            this.cbRGBDelimiter.Size = new System.Drawing.Size(31, 26);
            this.cbRGBDelimiter.TabIndex = 13;
            this.cbRGBDelimiter.SelectedIndexChanged += new System.EventHandler(this.CbRGBDelimiter_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "RGB-Delimiter:";
            // 
            // tbRGB
            // 
            this.tbRGB.Location = new System.Drawing.Point(115, 15);
            this.tbRGB.Name = "tbRGB";
            this.tbRGB.ReadOnly = true;
            this.tbRGB.Size = new System.Drawing.Size(70, 20);
            this.tbRGB.TabIndex = 18;
            this.tbRGB.Text = "255,255,255";
            this.tbRGB.WordWrap = false;
            // 
            // tbHEX
            // 
            this.tbHEX.Location = new System.Drawing.Point(115, 43);
            this.tbHEX.Name = "tbHEX";
            this.tbHEX.Size = new System.Drawing.Size(70, 20);
            this.tbHEX.TabIndex = 11;
            this.tbHEX.Text = "FF";
            this.tbHEX.WordWrap = false;
            this.tbHEX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHEX_KeyPress);
            this.tbHEX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbHEX_KeyUp);
            // 
            // btnDesktopPicker
            // 
            this.btnDesktopPicker.BackgroundImage = global::ColorPicker.Properties.Resources.Colorpicker;
            this.btnDesktopPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesktopPicker.Location = new System.Drawing.Point(12, 350);
            this.btnDesktopPicker.Name = "btnDesktopPicker";
            this.btnDesktopPicker.Size = new System.Drawing.Size(49, 49);
            this.btnDesktopPicker.TabIndex = 19;
            this.btnDesktopPicker.UseVisualStyleBackColor = true;
            this.btnDesktopPicker.Click += new System.EventHandler(this.btnDesktopPicker_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRGB);
            this.groupBox1.Controls.Add(this.cbHEXDelimiter);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbRGBDelimiter);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbHEX);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(73, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 71);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // luminanceBar1
            // 
            this.luminanceBar1.AutoSize = true;
            this.luminanceBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("luminanceBar1.BackgroundImage")));
            this.luminanceBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.luminanceBar1.Location = new System.Drawing.Point(248, 17);
            this.luminanceBar1.Margin = new System.Windows.Forms.Padding(0);
            this.luminanceBar1.Name = "luminanceBar1";
            this.luminanceBar1.Size = new System.Drawing.Size(23, 229);
            this.luminanceBar1.TabIndex = 5;
            // 
            // colorGradient
            // 
            this.colorGradient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorGradient.BackgroundImage")));
            this.colorGradient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colorGradient.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorGradient.Location = new System.Drawing.Point(12, 17);
            this.colorGradient.Name = "colorGradient";
            this.colorGradient.Size = new System.Drawing.Size(231, 229);
            this.colorGradient.TabIndex = 4;
            // 
            // tbARGB
            // 
            this.tbDecimal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDecimal.Location = new System.Drawing.Point(166, 322);
            this.tbDecimal.Name = "tbARGB";
            this.tbDecimal.Size = new System.Drawing.Size(94, 20);
            this.tbDecimal.TabIndex = 22;
            this.tbDecimal.Text = "16777215";
            this.tbDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDecimal.WordWrap = false;
            this.tbDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDecimal_KeyPress);
            this.tbDecimal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDecimal_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Decimal (VBA)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Colorpicker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 423);
            this.Controls.Add(this.tbDecimal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDesktopPicker);
            this.Controls.Add(this.tbHex3);
            this.Controls.Add(this.tbHex2);
            this.Controls.Add(this.tbHex1);
            this.Controls.Add(this.luminanceBar1);
            this.Controls.Add(this.colorGradient);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbLum);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.tbSat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblActColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ColorPicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label lblActColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHue;
        private System.Windows.Forms.TextBox tbSat;
        private System.Windows.Forms.TextBox tbLum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.TextBox tbB;
        private ColorGradient colorGradient;
        private LuminanceBar luminanceBar1;
        private System.Windows.Forms.TextBox tbHex1;
        private System.Windows.Forms.TextBox tbHex2;
        private System.Windows.Forms.TextBox tbHex3;
        private System.Windows.Forms.ComboBox cbHEXDelimiter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRGBDelimiter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRGB;
        private System.Windows.Forms.TextBox tbHEX;
        private System.Windows.Forms.Button btnDesktopPicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDecimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

