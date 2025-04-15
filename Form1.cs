//============================================================================
// DesktopColorPicker 1.x
// Copyright © 2025 Stephanowicz
// 
// <https://github.com/Stephanowicz/DesktopColorPicker>
// 
//This file is part of DesktopColorPicker.
//
//DesktopColorPicker is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//
//DesktopColorPicker is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with DesktopColorPicker.  If not, see <http://www.gnu.org/licenses/>.
//
//============================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        int rgb = 0;
        public Form1()
        {
            InitializeComponent();
            this.colorGradient.HueChanged += ColorGradient_HueChanged;
            this.luminanceBar1.LuminaceChanged += LuminanceBar1_LuminaceChanged;
            Color color = colorGradient.hsl.ToRGB().Color;

            int r1 = color.R;
            int g1 = color.G;
            int b1 = color.B;

            rgb = r1 + 256 * g1 + b1 * ((int)Math.Pow(256, 2));
            tbDecimal.Text = rgb.ToString();
        }

        private void LuminanceBar1_LuminaceChanged(object sender, EventArgs e)
        {
            HSL hSL = colorGradient.hsl;
            hSL.Luminance = luminanceBar1.Luminance;
            Color color = hSL.ToRGB().Color;

            setValues(color, setFlags.LuminanceBarPos| setFlags.LuminanceBarVal | setFlags.ColorGradient);
        }

        private void ColorGradient_HueChanged(object sender, EventArgs e)
        {

            HSL hSL = colorGradient.hsl;
            hSL.Luminance = luminanceBar1.Luminance;
            Color color = hSL.ToRGB().Color;

            setValues(color, setFlags.LuminanceBarPos | setFlags.ColorGradient);
        }

        public enum setFlags
        {
            None = 0,
            TextBoxRGB123 = 1,
            TextBoxDecimal = 2,
            TextBoxHex123 = 4,
            TextBoxHSL123 = 8,
            TextBoxHex = 16,
            ColorGradient = 32,
            LuminanceBarVal = 64,
            LuminanceBarPos = 128
        }

        private void setValues(Color color,setFlags flags)
        {
            HSL hSL = new HSL();
            hSL.Hue = Convert.ToInt32(color.GetHue());
            hSL.Luminance = color.GetBrightness();
            hSL.Saturation = color.GetSaturation();
            if (!flags.HasFlag(setFlags.LuminanceBarVal))
            {
                luminanceBar1.Saturation = hSL.Saturation;
                luminanceBar1.Hue = hSL.Hue;
            }
            if (!flags.HasFlag(setFlags.LuminanceBarPos))
            {
                luminanceBar1.pBeamSetLocation = hSL;
            }
            if (!flags.HasFlag(setFlags.ColorGradient)) colorGradient.setLocation = hSL;

            lblActColor.BackColor = color;

            if (!flags.HasFlag(setFlags.TextBoxRGB123))
            {
                tbR.Text = color.R.ToString();
                tbG.Text = color.G.ToString();
                tbB.Text = color.B.ToString();
            }

            if(!flags.HasFlag(setFlags.TextBoxHSL123))
            { 
                tbHue.Text = hSL.Hue.ToString();
                tbLum.Text = hSL.Luminance.ToString();
                tbSat.Text = hSL.Saturation.ToString();
            }
            if(!flags.HasFlag(setFlags.TextBoxHex123))
            {
                tbHex1.Text = String.Format("{0:x2}", (uint)System.Convert.ToUInt32(color.R.ToString())).ToUpper();
                tbHex2.Text = String.Format("{0:x2}", (uint)System.Convert.ToUInt32(color.G.ToString())).ToUpper();
                tbHex3.Text = String.Format("{0:x2}", (uint)System.Convert.ToUInt32(color.B.ToString())).ToUpper();
            }

            setRGBText();
            if (!flags.HasFlag(setFlags.TextBoxHex)) setHEXText();
            if (!flags.HasFlag(setFlags.TextBoxDecimal))
            {
                rgb = color.R + 256 * color.G + color.B * ((int)Math.Pow(256, 2));
                tbDecimal.Text = rgb.ToString();
            }

        }

        bool bSetCombo = false;
        void setRGBText()
        {
            bSetCombo = true;
            if (cbRGBDelimiter.SelectedIndex < 0) cbRGBDelimiter.SelectedIndex = 0;
            string delimiter = cbRGBDelimiter.SelectedItem.ToString();
            tbRGB.Text = tbR.Text + delimiter + tbG.Text + delimiter + tbB.Text;
            bSetCombo = false;
        }
        void setHEXText()
        {
            bSetCombo = true;
            if (cbHEXDelimiter.SelectedIndex < 0) cbHEXDelimiter.SelectedIndex = 0;
            string delimiter = cbHEXDelimiter.SelectedItem.ToString();
            tbHEX.Text = "#" + tbHex1.Text + delimiter + tbHex2.Text + delimiter + tbHex3.Text;
            bSetCombo = false;
        }
        private void CbRGBDelimiter_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(!bSetCombo) setRGBText();
        }

        private void CbHEXDelimiter_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!bSetCombo) setHEXText();
        }


        private void tbDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }
        private void tbDecimal_KeyUp(object sender, KeyEventArgs e)
        {
            if ((((TextBox)sender).Text != "") && Convert.ToInt32(((TextBox)sender).Text) > 16777215)
                ((TextBox)sender).Text = "16777215";
            SetDecimal(null, null);
        }
        private void SetDecimal(object sender, EventArgs e)
        {
            if (tbDecimal.Text.All(Char.IsDigit) && tbDecimal.Text != "")
                DecimalToHSL(tbDecimal.Text);
        }

        private void DecimalToHSL(String sRGB)
        {
            rgb = Convert.ToInt32(sRGB);
            int b = (rgb & 0xff0000) >> 16;
            int g = (rgb & 0xff00) >> 8;
            int r = (rgb & 0xff);
            Color c = Color.FromArgb(r, g, b);
            setValues(c, setFlags.TextBoxDecimal);

        }
        private void tbRGB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }
        private void tbRGB_KeyUp(object sender, KeyEventArgs e)
        {
            if ((((TextBox)sender).Text != "") && Convert.ToInt32(((TextBox)sender).Text) > 255)
                ((TextBox)sender).Text = "255";
            SetRGB_Click(null, null);
        }
        private void SetRGB_Click(object sender, EventArgs e)
        {
            if ((tbR.Text.All(Char.IsDigit) && tbR.Text != "") &&
                (tbB.Text.All(Char.IsDigit) && tbB.Text != "") &&
                (tbG.Text.All(Char.IsDigit) && tbG.Text != "")
                )
            {
                Color c = Color.FromArgb(Convert.ToInt32(tbR.Text), Convert.ToInt32(tbG.Text), Convert.ToInt32(tbB.Text));
                setValues(c, setFlags.TextBoxRGB123);
            }
        }

        private void tbHEX123_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex myRegex = new Regex("^[a-fA-F0-9]+$");

            if ((myRegex.IsMatch(e.KeyChar.ToString()) && ((TextBox)sender).Text.Length < 2 | ((TextBox)sender).SelectionLength > 0) || e.KeyChar == '\b') //The  character represents a backspace
            {
                if(myRegex.IsMatch(e.KeyChar.ToString()))
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }
        private void tbHEX123_KeyUp(object sender, KeyEventArgs e)
        {
            if ((((TextBox)sender).Text != "") && Convert.ToInt32(((TextBox)sender).Text, 16) > 255)
                ((TextBox)sender).Text = String.Format("{0:x2}", (uint)System.Convert.ToUInt32(255)).ToUpper();
            SetHEX123(null, null);
        }
        private void SetHEX123(object sender, EventArgs e)
        {
            Regex myRegex = new Regex("^[a-fA-F0-9]+$");
            if ((tbHex1.Text != "" && myRegex.IsMatch(tbHex1.Text)) &&
                (tbHex2.Text != "" && myRegex.IsMatch(tbHex2.Text)) &&
                (tbHex3.Text != "" && myRegex.IsMatch(tbHex3.Text))
                )
            {
                Color c = Color.FromArgb(Convert.ToInt32(tbHex1.Text,16), Convert.ToInt32(tbHex2.Text,16), Convert.ToInt32(tbHex3.Text,16));
                setValues(c, setFlags.TextBoxHex123);
            }
        }

        private void tbHEX_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex myRegex = new Regex("^[a-fA-F0-9]+$");

            if ((myRegex.IsMatch(e.KeyChar.ToString()) && ((TextBox)sender).Text.Length < 7 | ((TextBox)sender).SelectionLength > 0) || e.KeyChar == '\b' || (e.KeyChar == '\u0016')) //The  character represents a backspace
            {
                if (myRegex.IsMatch(e.KeyChar.ToString()))
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }
        private void tbHEX_KeyUp(object sender, KeyEventArgs e)
        {
            //            if ((((TextBox)sender).Text != "") && Convert.ToInt32(((TextBox)sender).Text.Trim('#'), 16) > 16777215)
            //                ((TextBox)sender).Text = String.Format("{0:x2}", (uint)System.Convert.ToUInt32(16777215)).ToUpper();
            string s = ((TextBox)sender).Text;
            s = Regex.Replace(s, "[.,#]", "");

            SetHEX(s);
        }
        private void SetHEX(String s)
        {
            Regex myRegex = new Regex("^[#a-fA-F0-9]+$");
            if (s != "" && myRegex.IsMatch(s))
            {
                string sHex = s.Trim('#').PadRight(6, '0');
                Color c = Color.FromArgb(Convert.ToInt32(sHex.Substring(0, 2), 16), Convert.ToInt32(sHex.Substring(2, 2), 16), Convert.ToInt32(sHex.Substring(4, 2), 16));
                setValues(c, setFlags.TextBoxHex);
            }
        }

        private void tbHue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }


        private void tbSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '.' || e.KeyChar == ',') //The  character represents a backspace
            {
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar == ',' && (((TextBox)sender).Text.Contains(',') || ((TextBox)sender).Text.Length==0))
                    e.Handled = true;
                else
                    e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }
        private void tbHue_KeyUp(object sender, KeyEventArgs e)
        {
            if ((((TextBox)sender).Text != "") && Convert.ToInt32(((TextBox)sender).Text) > 360)
                ((TextBox)sender).Text = "360";
            SetHSL();
        }

        private void tbSL_KeyUp(object sender, KeyEventArgs e)
        {
            if ((((TextBox)sender).Text != "") && Convert.ToDouble(((TextBox)sender).Text) > 1)
                ((TextBox)sender).Text = "1";
            SetHSL();
        }
        private void SetHSL()
        {
            decimal i = 0;
            if ((tbHue.Text != "" && tbHue.Text.All(Char.IsDigit)) &&
                (tbSat.Text != "" && decimal.TryParse(tbSat.Text, out i)) &&
                (tbLum.Text != "" && decimal.TryParse(tbLum.Text, out i))
                )
            {
                HSL hSL = new HSL();
                hSL.Hue = Convert.ToInt32(tbHue.Text);
                hSL.Luminance = (float)Convert.ToDouble(tbLum.Text);
                hSL.Saturation = (float)Convert.ToDouble(tbSat.Text);
                Color color = hSL.ToRGB().Color;

                setValues(color, setFlags.TextBoxHSL123);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDesktopPicker_Click(object sender, EventArgs e)
        {
            DesktopPicker p = new DesktopPicker();
            p.ShowDialog();
            if(p.rgb != null)
            {
                Color c = p.rgb;
                setValues(c, setFlags.None);
                Activate();
                BringToFront();
            }
        }
    }
}
