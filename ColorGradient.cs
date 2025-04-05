using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class ColorGradient : UserControl
    {
        HSL HSL = new HSL(180, 0.5f, 0.5f);
        public HSL hsl
        { get { return HSL; } }

        public ColorGradient()
        {
            InitializeComponent();
        }
        // values changed event notification
        public event EventHandler HueChanged;

        public HSL setLocation
        {
            set {
                HSL = value;
                int x = HSL.Hue * Width / 360;
                int y = Convert.ToInt32(Height - (HSL.Saturation * Height));
                pbCrossHair.Location = new Point(x - 12, y - 12);
            }
        }
        void setHSL(Point p)
        {
            int hue = 360 * p.X / this.Width;
            float sat = (float)((float)(this.Height - p.Y) / (float)this.Height);

            HSL.Hue = hue;
            HSL.Saturation = sat;
            HueChanged(this, new EventArgs());
        }

        #region Mouse events

        bool tracking = false;
        private void ColorGradient_MouseDown(object sender, MouseEventArgs e)
        {
            tracking = true;
            setHSL(new Point(e.X, e.Y));
            pbCrossHair.Visible = false;
        }
        private void ColorGradient_MouseUp(object sender, MouseEventArgs e)
        {
            if (tracking)
            {
                int x = e.X <= 0 ? 0 : e.X > Width ? Width : e.X;
                int y = e.Y <= 0 ? 0 : e.Y > Height ? Height : e.Y;
                pbCrossHair.Location = new Point(x - 12, y - 12);
                pbCrossHair.Visible = true;
            }
            //if (tracking && (0 <= e.X && e.X <= Width) && (0 <= e.Y && e.Y <= Height))
            //{
            //    pbCrossHair.Location = new Point(e.X - 12, e.Y - 12);
            //    pbCrossHair.Visible = true;
            //}

            tracking = false;
        }

        private void ColorGradient_MouseMove(object sender, MouseEventArgs e)
        {
            if (tracking)
            {
                int x = e.X <= 0 ? 0 : e.X > Width ? Width : e.X;
                int y = e.Y <= 0 ? 0 : e.Y > Height ? Height : e.Y;

                //if (tracking && (0 <= e.X && e.X <= Width) && (0 <= e.Y && e.Y <= Height))
                //    setHSL(new Point(e.X, e.Y));
                setHSL(new Point(x, y));
            }
        }

        #endregion  Mouse events

        #region Loading colortable and cursor image

        int curWidth = 24;
        int curHeight = 24;
        int penWidth = 2;
        private void ColorGradient_Load(object sender, EventArgs e)
        {
            BackgroundImage = colorTable();
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush, penWidth);
            pbCrossHair.Image = crossHairImg(pen,brush,curWidth,curHeight);
            this.Cursor = new Cursor(((Bitmap)pbCrossHair.Image).GetHicon());

            int x = HSL.Hue * Width / 360;
            int y = Convert.ToInt32(Height - (HSL.Saturation * Height));
            pbCrossHair.Location = new Point(x - 12, y - 12);
            if (!DesignMode)
                HueChanged(this, new EventArgs());
        }

        private System.Drawing.Image crossHairImg(Pen pen, Brush brush, int x, int y)
        {
            var pic = new Bitmap(x, y);
            Graphics gr = Graphics.FromImage(pic);

            var pathX = new System.Drawing.Drawing2D.GraphicsPath();
            var pathY = new System.Drawing.Drawing2D.GraphicsPath();
            var pathX1 = new System.Drawing.Drawing2D.GraphicsPath();
            var pathY1 = new System.Drawing.Drawing2D.GraphicsPath();
            pathX.AddLine(0, (y / 2), (x / 2) - pen.Width, (y / 2));
            pathY.AddLine((x / 2), 0, (x / 2), (y / 2) - pen.Width);
            pathX1.AddLine((x / 2) + pen.Width, y / 2, x, (y / 2));
            pathY1.AddLine((x / 2), (y / 2) + pen.Width, (x / 2), y);
            gr.DrawPath(pen, pathX);
            gr.DrawPath(pen, pathY);
            gr.DrawPath(pen, pathX1);
            gr.DrawPath(pen, pathY1);

            return pic;
        }

        private System.Drawing.Image colorTable()
        {
            Rectangle rc = this.ClientRectangle;
            var pic = new Bitmap(Width,Height);
            Graphics gr = Graphics.FromImage(pic);
            System.Drawing.Drawing2D.LinearGradientBrush linGrBrush;
            Pen pen;
            RGB rgbStart = new RGB();
            HSL hslStart = new HSL();
            RGB rgbEnd = new RGB();
            HSL hslEnd = new HSL();
            Point x;
            Point y;

            // init HSL value
            hslStart.Luminance = 0.5f;
            hslStart.Saturation = 1.0f;
            hslEnd.Luminance = 0.5f;
            hslEnd.Saturation = 0f;

            for (int i = 0; i < 360; i++)
            {
                x = new Point((rc.Width * i) / 360, 0);
                y = new Point((rc.Width * i) / 360, rc.Height);
                hslStart.Hue = i;
                hslEnd.Hue = i;
                // convert from HSL to RGB
                rgbStart = hslStart.ToRGB();
                rgbEnd = hslEnd.ToRGB();
                // create brush
                linGrBrush = new System.Drawing.Drawing2D.LinearGradientBrush(x, y, rgbStart.Color, rgbEnd.Color);
                pen = new Pen(linGrBrush, (float)rc.Width / 360f);
                // draw one hue value
                gr.DrawLine(pen, x, y);

                //g.DrawIcon(crossIcon, pLast.X,pLast.Y);

                pen.Dispose();
                linGrBrush.Dispose();
            }
            return pic;
        }
        #endregion  Loading colortable and cursor image


    }
}
