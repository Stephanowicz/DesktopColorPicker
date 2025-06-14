﻿//============================================================================
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

using DesktopColorPicker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class DesktopPicker : Form
    {
        public event EventHandler valueChanged;
        public Color rgb;
        public DesktopPicker()
        {
            InitializeComponent();
            magnifyingGlass1.UpdateTimer.Start();
            magnifyingGlass1.MovingGlass.MagnifyingGlass.Click += new EventHandler(MagnifyingGlass_Click);
            magnifyingGlass1.MovingGlass.VisibleChanged += new EventHandler(MovingGlass_VisibleChanged);
            magnifyingGlass1.MovingGlass.MagnifyingGlass.BeforeMakingScreenshot += new MagnifyingGlass.MakingScreenshotDelegate(MagnifyingGlass_BeforeMakingScreenshot);
            magnifyingGlass1.MovingGlass.MagnifyingGlass.AfterMakingScreenshot += new MagnifyingGlass.MakingScreenshotDelegate(MagnifyingGlass_AfterMakingScreenshot);
        }

        private void MagnifyingGlass_AfterMakingScreenshot(object sender)
        {
            // Show this again after the screenshot has been taken
            Show();
        }

        private void MagnifyingGlass_BeforeMakingScreenshot(object sender)
        {
            // Hide this before the moving glass will take the screenshot for working with it as screen image
            Hide();
        }
        private void MovingGlass_VisibleChanged(object sender, EventArgs e)
        {
            // Make this not the top window if the moving glass is shown because it will hide the glass display otherwise
            TopMost = !magnifyingGlass1.MovingGlass.Visible;
        }

        private void MagnifyingGlass_Click(object sender, EventArgs e)
        {
            // Select the color trough the moving glass
            SelectColor();
        }

        private void magnifyingGlass1_DisplayUpdated(MagnifyingGlass sender)
        {
            // Update the current color preview panels background color
            panel1.BackColor = magnifyingGlass1.PixelColor;
        }

        private void GUI_Deactivate(object sender, EventArgs e)
        {
            // Select the current color if the form lost the focus
            if (!magnifyingGlass1.MovingGlass.Visible)
            {
                SelectColor();
            }
        }

        private void SelectColor()
        {
            rgb = panel1.BackColor;
            Close();
        }

        private void DesktopPicker_Deactivate(object sender, EventArgs e)
        {
            SelectColor();
        }
    }
}
