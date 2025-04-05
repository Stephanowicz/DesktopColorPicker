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
    public partial class LuminanceBar : UserControl
    {
        HSL hsl = new HSL(180,0.5f,0.5f);

        int hue, iHeight, iWidth;
        int cursorHeight = 10;
        bool bLoaded;
        // values changed event notification
        public event EventHandler LuminaceChanged;

        public HSL pBeamSetLocation
        {
            set
            {
                hsl = value;
                int y = Convert.ToInt32(iHeight - (hsl.Luminance * iHeight));
                pbBeam.Location = new Point(0, y - (cursorHeight/2));
                if (bLoaded) BackgroundImage = luminanceBar();
            }
        }
        public int Hue
        {
            set {
                hsl.Hue = value;
                BackgroundImage = luminanceBar();
            }
        }
        public float Saturation
        {
            set {
                hsl.Saturation = value;
                BackgroundImage = luminanceBar();
            }
        }

        public float Luminance
        {
            get { return hsl.Luminance; }
        }

        public LuminanceBar()
        {
            InitializeComponent();
        }
        void setHSL(Point p)
        {
            float luminance = (float)((float)(this.iHeight - p.Y) / (float)this.iHeight);
            hsl.Luminance = luminance;
            LuminaceChanged(this, new EventArgs());
        }

        #region Mouse events

        bool tracking = false;
        private void LuminanceBar_MouseDown(object sender, MouseEventArgs e)
        {
            tracking = true;
            int x = e.X <= 0 ? 0 : e.X > iWidth ? iWidth : e.X;
            int y = e.Y <= 0 ? 0 : e.Y > iHeight ? iHeight : e.Y;
            pbBeam.Location = new Point(0, y - (cursorHeight / 2));
            setHSL(new Point(e.X, e.Y));
        }

        private void LuminanceBar_MouseUp(object sender, MouseEventArgs e)
        {
           if (tracking)
            {
                int x = e.X <= 0 ? 0 : e.X > iWidth ? iWidth : e.X;
                int y = e.Y <= 0 ? 0 : e.Y > iHeight ? iHeight : e.Y;
                pbBeam.Location = new Point(0, y - (cursorHeight / 2));
            }

            tracking = false;
        }

        private void LuminanceBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (tracking)
            {
                int x = e.X <= 0 ? 0 : e.X > iWidth ? iWidth : e.X;
                int y = e.Y <= 0 ? 0 : e.Y > iHeight ? iHeight : e.Y;
                pbBeam.Location = new Point(0, y - (cursorHeight / 2));
                setHSL(new Point(x, y));
            }
        }

        #endregion  Mouse events

        #region Loading colortable and cursor image


        private void LuminaceBar_Load(object sender, EventArgs e)
        {
            bLoaded = true;
            iHeight = Height;
            iWidth = Width;
            BackgroundImage = luminanceBar();
            pbBeam.Image = beamImg(iWidth, cursorHeight);
            //            this.Cursor = new Cursor(((Bitmap)pbBeam.Image).GetHicon());

            pBeamSetLocation = hsl;
            //    int y = Convert.ToInt32(Height - (0.5f * Height));
            //    pbBeam.Location = new Point(0, y - 12);
            if (!DesignMode)
            LuminaceChanged(this, new EventArgs());
        }

        private System.Drawing.Image beamImg(int x, int y)
        {
            Point[] triangle = new Point[] { new Point(x/2, y/2), new Point(x, 0), new Point(x, y) };

            Brush brush = new SolidBrush(Color.Black);
            var pic = new Bitmap(x, y);
            Graphics gr = Graphics.FromImage(pic);
            gr.FillPolygon(brush, triangle);
            return pic;
        }

        private System.Drawing.Image luminanceBar()
        {
            //    Rectangle rc = ClientRectangle;
            //    var pic = new Bitmap(rc.Width, rc.Height);
            var pic = new Bitmap(iWidth, iHeight);
            Graphics gr = Graphics.FromImage(pic);
            Brush brush;
            Pen pen = new Pen(Color.Empty);

            RGB rgb_ = new RGB();
            HSL hsl_ = new HSL(hsl.Hue, hsl.Saturation, 0);

            for(int i = 0; i <= iHeight;i++)
            {
                hsl_.Luminance =  1f - ((float)i / (float)iHeight);
                rgb_ = hsl_.ToRGB();
                brush = new SolidBrush(rgb_.Color);
                pen = new Pen(brush);
                gr.DrawLine(pen, new Point(0,i), new Point(iWidth/2,i));
            }
            pen.Dispose();

            return pic;
        }
        #endregion  Loading colortable and cursor image
    }
}
