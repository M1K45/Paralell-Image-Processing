namespace Paralell_Image_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap? imgBasic;

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                imgBasic = new Bitmap(file);
                pictureBoxBasic.Image = imgBasic;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            Bitmap imgInverted = imgBasic;

            Bitmap imgThreshold = imgBasic;
            Bitmap imgGrayscale = imgBasic;
            Bitmap imgEdge = new Bitmap(imgBasic.Width -2, imgBasic.Height -2);

            // Loop through the images pixels to reset color.
            for (int i = 0; i < imgThreshold.Width; i++)
            {
                for (int x = 0; x < imgThreshold.Height; x++)
                {

                    Color oc = imgBasic.GetPixel(i, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    imgGrayscale.SetPixel(i, x, nc);
                    if (grayScale < 128)
                    {
                        imgThreshold.SetPixel(i, x, Color.Black);
                    }
                    else
                    {
                        imgThreshold.SetPixel(i, x, Color.White);
                    }
                }
            }

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

            for (int i = 0; i < imgEdge.Width; i++)
            {
                for (int x = 0; x < imgEdge.Height; x++)
                {
                    double xGradient = 0;
                    double yGradient = 0;
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int k = -1; k <= 1; k++)
                        {
                            xGradient += xSobel[1+j, 1+k] * imgGrayscale.GetPixel(i + j+1, x + k+1).R;
                            yGradient += ySobel[1+j, 1+k] * imgGrayscale.GetPixel(i + j+1, x + k+1).R;
                        }
                    }
                    int g = (int)Math.Sqrt((xGradient * xGradient) + (yGradient * yGradient));
                    g = Math.Min(255, g);
                    Color nc = Color.FromArgb(255, g, g, g);
                    imgEdge.SetPixel(i, x, nc);
                }
            }

            //for (int x =0; x < imgInverted.Width; x++)
            //{
            //    for (int y = 0; y < imgInverted.Height; y++)
            //    {
            //        Color oc = imgInverted.GetPixel(x, y);
            //        Color nc = Color.FromArgb(oc.A, 255 - oc.R, 255 - oc.G, 255 - oc.B);
            //        imgInverted.SetPixel(x, y, nc);
            //    }

            //}

            for (int x =0; x < imgInverted.Width; x++)
            {
                for (int y = 0; y < imgInverted.Height / 2; y++)
                {
                    Console.WriteLine(imgInverted.Height - y);

                    Color pixelMirrored = imgBasic.GetPixel(x, (imgInverted.Height -y -1));
                    Color pixelInverted = imgBasic.GetPixel(x, y);
                    imgInverted.SetPixel(x, y, pixelMirrored);
                    
                    imgInverted.SetPixel(x, imgInverted.Height - y - 1, pixelInverted);
                }
            }



            pictureBoxThreshold.Image = imgThreshold;
            pictureBoxEdge.Image = imgEdge;
            pictureBoxInversion.Image = imgInverted;
            pictureBoxGrayscale.Image = imgGrayscale;

        }
    }
}
