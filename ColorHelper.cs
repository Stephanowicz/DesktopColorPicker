// THIS FILE WAS CREATED FROM THE ACCORD IMAGING LIBRARY
// THANK YOU GUYS FOR YOUR GOOD WORK!
// https://github.com/accord-net/framework/tree/development
//----------------------------------------------------------------------
// Accord Imaging Library
// The Accord.NET Framework
// http://accord-framework.net
//
// AForge Image Processing Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2007-2011
// contacts@aforgenet.com
//
// Copyright © César Souza, 2009-2017
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
// 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPicker
{
    [Serializable]
    public struct RGB
    {
        //
        // Zusammenfassung:
        //     Index of red component.
        public const short R = 2;

        //
        // Zusammenfassung:
        //     Index of green component.
        public const short G = 1;

        //
        // Zusammenfassung:
        //     Index of blue component.
        public const short B = 0;

        //
        // Zusammenfassung:
        //     Index of alpha component for ARGB images.
        public const short A = 3;

        //
        // Zusammenfassung:
        //     Red component.
        public byte Red;

        //
        // Zusammenfassung:
        //     Green component.
        public byte Green;

        //
        // Zusammenfassung:
        //     Blue component.
        public byte Blue;

        //
        // Zusammenfassung:
        //     Alpha component.
        public byte Alpha;

        //
        // Zusammenfassung:
        //     Color value of the class.
        public Color Color
        {
            get
            {
                return Color.FromArgb(Alpha, Red, Green, Blue);
            }
            set
            {
                Red = value.R;
                Green = value.G;
                Blue = value.B;
                Alpha = value.A;
            }
        }

        //
        // Zusammenfassung:
        //     Initializes a new instance of the Accord.Imaging.RGB class.
        //
        // Parameter:
        //   red:
        //     Red component.
        //
        //   green:
        //     Green component.
        //
        //   blue:
        //     Blue component.
        public RGB(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = byte.MaxValue;
        }

        //
        // Zusammenfassung:
        //     Initializes a new instance of the Accord.Imaging.RGB class.
        //
        // Parameter:
        //   red:
        //     Red component.
        //
        //   green:
        //     Green component.
        //
        //   blue:
        //     Blue component.
        //
        //   alpha:
        //     Alpha component.
        public RGB(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        //
        // Zusammenfassung:
        //     Initializes a new instance of the Accord.Imaging.RGB class.
        //
        // Parameter:
        //   color:
        //     Initialize from specified color.
        public RGB(Color color)
        {
            Red = color.R;
            Green = color.G;
            Blue = color.B;
            Alpha = color.A;
        }

        //
        // Zusammenfassung:
        //     Performs an explicit conversion from Accord.Imaging.RGB to Accord.Imaging.HSL.
        //
        //
        // Parameter:
        //   rgb:
        //     The RGB color.
        //
        // Rückgabewerte:
        //     The result of the conversion.
        public static explicit operator HSL(RGB rgb)
        {
            return HSL.FromRGB(rgb);
        }

        //
        // Zusammenfassung:
        //     Performs an explicit conversion from Accord.Imaging.RGB to Accord.Imaging.YCbCr.
        //
        //
        // Parameter:
        //   rgb:
        //     The RGB color.
        //
        // Rückgabewerte:
        //     The result of the conversion.
        public static explicit operator YCbCr(RGB rgb)
        {
            return YCbCr.FromRGB(rgb);
        }
    }
    [Serializable]
    public struct HSL
    {
        //
        // Zusammenfassung:
        //     Hue component.
        //
        // Hinweise:
        //     Hue is measured in the range of [0, 359].
        public int Hue;

        //
        // Zusammenfassung:
        //     Saturation component.
        //
        // Hinweise:
        //     Saturation is measured in the range of [0, 1].
        public float Saturation;

        //
        // Zusammenfassung:
        //     Luminance value.
        //
        // Hinweise:
        //     Luminance is measured in the range of [0, 1].
        public float Luminance;

        //
        // Zusammenfassung:
        //     Initializes a new instance of the Accord.Imaging.HSL class.
        //
        // Parameter:
        //   hue:
        //     Hue component.
        //
        //   saturation:
        //     Saturation component.
        //
        //   luminance:
        //     Luminance component.
        public HSL(int hue, float saturation, float luminance)
        {
            Hue = hue;
            Saturation = saturation;
            Luminance = luminance;
        }

        //
        // Zusammenfassung:
        //     Convert from RGB to HSL color space.
        //
        // Parameter:
        //   rgb:
        //     Source color in RGB color space.
        //
        //   hsl:
        //     Destination color in HSL color space.
        //
        // Hinweise:
        //     See HSL and HSV Wiki for information about the algorithm to convert from RGB
        //     to HSL.
        public static void FromRGB(RGB rgb, ref HSL hsl)
        {
            float num = (float)(int)rgb.Red / 255f;
            float num2 = (float)(int)rgb.Green / 255f;
            float num3 = (float)(int)rgb.Blue / 255f;
            float num4 = System.Math.Min(System.Math.Min(num, num2), num3);
            float num5 = System.Math.Max(System.Math.Max(num, num2), num3);
            float num6 = num5 - num4;
            hsl.Luminance = (num5 + num4) / 2f;
            if (num6 == 0f)
            {
                hsl.Hue = 0;
                hsl.Saturation = 0f;
                return;
            }

            hsl.Saturation = (((double)hsl.Luminance <= 0.5) ? (num6 / (num5 + num4)) : (num6 / (2f - num5 - num4)));
            float num7 = ((num == num5) ? ((num2 - num3) / 6f / num6) : ((num2 != num5) ? (2f / 3f + (num - num2) / 6f / num6) : (1f / 3f + (num3 - num) / 6f / num6)));
            if (num7 < 0f)
            {
                num7 += 1f;
            }

            if (num7 > 1f)
            {
                num7 -= 1f;
            }

            hsl.Hue = (int)(num7 * 360f);
        }

        //
        // Zusammenfassung:
        //     Convert from RGB to HSL color space.
        //
        // Parameter:
        //   rgb:
        //     Source color in RGB color space.
        //
        // Rückgabewerte:
        //     Returns Accord.Imaging.HSL instance, which represents converted color value.
        public static HSL FromRGB(RGB rgb)
        {
            HSL hsl = default(HSL);
            FromRGB(rgb, ref hsl);
            return hsl;
        }

        //
        // Zusammenfassung:
        //     Convert from HSL to RGB color space.
        //
        // Parameter:
        //   hsl:
        //     Source color in HSL color space.
        //
        //   rgb:
        //     Destination color in RGB color space.
        public static void ToRGB(HSL hsl, ref RGB rgb)
        {
            if (hsl.Saturation == 0f)
            {
                rgb.Red = (rgb.Green = (rgb.Blue = (byte)(hsl.Luminance * 255f)));
            }
            else
            {
                float num = (float)hsl.Hue / 360f;
                float num2 = (((double)hsl.Luminance < 0.5) ? (hsl.Luminance * (1f + hsl.Saturation)) : (hsl.Luminance + hsl.Saturation - hsl.Luminance * hsl.Saturation));
                float v = 2f * hsl.Luminance - num2;
                rgb.Red = (byte)(255f * Hue_2_RGB(v, num2, num + 1f / 3f));
                rgb.Green = (byte)(255f * Hue_2_RGB(v, num2, num));
                rgb.Blue = (byte)(255f * Hue_2_RGB(v, num2, num - 1f / 3f));
            }

            rgb.Alpha = byte.MaxValue;
        }

        //
        // Zusammenfassung:
        //     Convert the color to RGB color space.
        //
        // Rückgabewerte:
        //     Returns Accord.Imaging.RGB instance, which represents converted color value.
        public RGB ToRGB()
        {
            RGB rgb = default(RGB);
            ToRGB(this, ref rgb);
            return rgb;
        }

        //
        // Zusammenfassung:
        //     Performs an explicit conversion from Accord.Imaging.HSL to Accord.Imaging.RGB.
        //
        //
        // Parameter:
        //   hsl:
        //     The HSL color.
        //
        // Rückgabewerte:
        //     The result of the conversion.
        public static explicit operator RGB(HSL hsl)
        {
            return hsl.ToRGB();
        }

        //
        // Zusammenfassung:
        //     Performs an explicit conversion from Accord.Imaging.HSL to Accord.Imaging.YCbCr.
        //
        //
        // Parameter:
        //   hsl:
        //     The HSL color.
        //
        // Rückgabewerte:
        //     The result of the conversion.
        public static explicit operator YCbCr(HSL hsl)
        {
            return YCbCr.FromRGB(hsl.ToRGB());
        }

        private static float Hue_2_RGB(float v1, float v2, float vH)
        {
            if (vH < 0f)
            {
                vH += 1f;
            }

            if (vH > 1f)
            {
                vH -= 1f;
            }

            if (6f * vH < 1f)
            {
                return v1 + (v2 - v1) * 6f * vH;
            }

            if (2f * vH < 1f)
            {
                return v2;
            }

            if (3f * vH < 2f)
            {
                return v1 + (v2 - v1) * (2f / 3f - vH) * 6f;
            }

            return v1;
        }
    }

    [Serializable]
    public struct YCbCr
    {
        //
        // Zusammenfassung:
        //     Index of Y component.
        public const short YIndex = 0;

        //
        // Zusammenfassung:
        //     Index of Cb component.
        public const short CbIndex = 1;

        //
        // Zusammenfassung:
        //     Index of Cr component.
        public const short CrIndex = 2;

        //
        // Zusammenfassung:
        //     Y component.
        public float Y;

        //
        // Zusammenfassung:
        //     Cb component.
        public float Cb;

        //
        // Zusammenfassung:
        //     Cr component.
        public float Cr;

        //
        // Zusammenfassung:
        //     Initializes a new instance of the Accord.Imaging.YCbCr class.
        //
        // Parameter:
        //   y:
        //     Y component.
        //
        //   cb:
        //     Cb component.
        //
        //   cr:
        //     Cr component.
        public YCbCr(float y, float cb, float cr)
        {
            Y = System.Math.Max(0f, System.Math.Min(1f, y));
            Cb = System.Math.Max(-0.5f, System.Math.Min(0.5f, cb));
            Cr = System.Math.Max(-0.5f, System.Math.Min(0.5f, cr));
        }

        //
        // Zusammenfassung:
        //     Convert from RGB to YCbCr color space (Rec 601-1 specification).
        //
        // Parameter:
        //   rgb:
        //     Source color in RGB color space.
        //
        //   ycbcr:
        //     Destination color in YCbCr color space.
        public static void FromRGB(RGB rgb, ref YCbCr ycbcr)
        {
            float num = (float)(int)rgb.Red / 255f;
            float num2 = (float)(int)rgb.Green / 255f;
            float num3 = (float)(int)rgb.Blue / 255f;
            ycbcr.Y = (float)(0.2989 * (double)num + 0.5866 * (double)num2 + 0.1145 * (double)num3);
            ycbcr.Cb = (float)(-0.1687 * (double)num - 0.3313 * (double)num2 + 0.5 * (double)num3);
            ycbcr.Cr = (float)(0.5 * (double)num - 0.4184 * (double)num2 - 0.0816 * (double)num3);
        }

        //
        // Zusammenfassung:
        //     Convert from RGB to YCbCr color space (Rec 601-1 specification).
        //
        // Parameter:
        //   rgb:
        //     Source color in RGB color space.
        //
        // Rückgabewerte:
        //     Returns Accord.Imaging.YCbCr instance, which represents converted color value.
        public static YCbCr FromRGB(RGB rgb)
        {
            YCbCr ycbcr = default(YCbCr);
            FromRGB(rgb, ref ycbcr);
            return ycbcr;
        }

        //
        // Zusammenfassung:
        //     Convert from YCbCr to RGB color space.
        //
        // Parameter:
        //   ycbcr:
        //     Source color in YCbCr color space.
        //
        //   rgb:
        //     Destination color in RGB color space.
        public static void ToRGB(YCbCr ycbcr, ref RGB rgb)
        {
            float num = System.Math.Max(0f, System.Math.Min(1f, (float)((double)ycbcr.Y + 0.0 * (double)ycbcr.Cb + 1.4022 * (double)ycbcr.Cr)));
            float num2 = System.Math.Max(0f, System.Math.Min(1f, (float)((double)ycbcr.Y - 0.3456 * (double)ycbcr.Cb - 0.7145 * (double)ycbcr.Cr)));
            float num3 = System.Math.Max(0f, System.Math.Min(1f, (float)((double)ycbcr.Y + 1.771 * (double)ycbcr.Cb + 0.0 * (double)ycbcr.Cr)));
            rgb.Red = (byte)(num * 255f);
            rgb.Green = (byte)(num2 * 255f);
            rgb.Blue = (byte)(num3 * 255f);
            rgb.Alpha = byte.MaxValue;
        }

        //
        // Zusammenfassung:
        //     Convert the color to RGB color space.
        //
        // Rückgabewerte:
        //     Returns Accord.Imaging.RGB instance, which represents converted color value.
        public RGB ToRGB()
        {
            RGB rgb = default(RGB);
            ToRGB(this, ref rgb);
            return rgb;
        }

        //
        // Zusammenfassung:
        //     Performs an explicit conversion from Accord.Imaging.YCbCr to Accord.Imaging.RGB.
        //
        //
        // Parameter:
        //   yCbCr:
        //     The YCbCr color.
        //
        // Rückgabewerte:
        //     The result of the conversion.
        public static explicit operator RGB(YCbCr yCbCr)
        {
            return yCbCr.ToRGB();
        }

        //
        // Zusammenfassung:
        //     Performs an explicit conversion from Accord.Imaging.YCbCr to Accord.Imaging.HSL.
        //
        //
        // Parameter:
        //   yCbCr:
        //     The YCbCr color.
        //
        // Rückgabewerte:
        //     The result of the conversion.
        public static explicit operator HSL(YCbCr yCbCr)
        {
            return HSL.FromRGB(yCbCr.ToRGB());
        }
    }

}
