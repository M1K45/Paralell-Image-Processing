using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paralell_Image_Processing
{
    public class ProcessingFunctions
    {
        public static Bitmap Grayscale(Bitmap image)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int x = 0; x < image.Height; x++)
                {
                    Color oc = image.GetPixel(i, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    image.SetPixel(i, x, nc);
                }
            }
            return image;
        }

        public static void  Threshold(Bitmap image, int threshVal)
        {
            Bitmap grayscale = Grayscale(image);
            for (int i = 0; i < grayscale.Width; i++)
            {
                for (int x = 0; x < grayscale.Height; x++)
                {
                    Color color = grayscale.GetPixel(i, x);
                    if (color.R < 128)
                    {
                        image.SetPixel(i, x, Color.Black);
                    }
                    else
                    {
                        image.SetPixel(i, x, Color.White);
                    }
                }
            }
        }

        public static void EdgeDetection (Bitmap image, Bitmap source)
        {
            double[,] xSobel = new double[,]
            {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };
            double[,] ySobel = new double[,]
            {
                { 1, 2, 1 },
                { 0, 0, 0 },
                { -1, -2, -1 }
            };

            for (int i = 0; i < image.Width; i++)
            {
                for (int x = 0; x < image.Height; x++)
                {
                    double xGradient = 0;
                    double yGradient = 0;
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int k = -1; k <= 1; k++)
                        {
                            xGradient += xSobel[1 + j, 1 + k] * source.GetPixel(i + j +1, x + k +1).R;
                            yGradient += ySobel[1 + j, 1 + k] * source.GetPixel(i + j +1, x + k  +1).R;
                        }
                    }
                    int g = (int)Math.Sqrt((xGradient * xGradient) + (yGradient * yGradient));
                    g = Math.Min(255, g);
                    Color nc = Color.FromArgb(255, g, g, g);
                    image.SetPixel(i, x, nc);
                }
            }
        }

        public static void Mirror (Bitmap image)
        {
            for (int x = 0; x < image.Width / 2; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelMirrored = image.GetPixel(image.Width - x - 1, y);
                    Color pixelInverted = image.GetPixel(x, y);
                    image.SetPixel(x, y, pixelMirrored);
                    image.SetPixel(image.Width - x - 1, y, pixelInverted);
                }
            }
        }
    }
}
