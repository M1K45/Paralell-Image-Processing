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

            Bitmap imgInverted =  new Bitmap (imgBasic);
            Bitmap imgThreshold = new Bitmap (imgBasic);

            // a copy of img Bacis for graying it out for paralell visualization purpose
            Bitmap imgGrayscale = new Bitmap(imgBasic);

            // grayed out image for edge detection
            Bitmap edgeGrayscale = new Bitmap (imgBasic);
            edgeGrayscale = ProcessingFunctions.Grayscale(edgeGrayscale);
 
            Bitmap imgEdge = new Bitmap(imgBasic.Width -2, imgBasic.Height -2);

            Thread[] threads = new Thread[4];
            threads[0] = new Thread(() =>
            {
                ProcessingFunctions.Threshold(imgThreshold, 127);
                pictureBoxThreshold.Image = imgThreshold;
            });

            threads[1] = new Thread(() =>
            {
                ProcessingFunctions.EdgeDetection(imgEdge, edgeGrayscale);
                pictureBoxEdge.Image = imgEdge;
            });

            threads[2] = new Thread(() =>
            {
                imgGrayscale = ProcessingFunctions.Grayscale(imgGrayscale);
                pictureBoxGrayscale.Image = imgGrayscale;
            });

            threads[3] = new Thread(() =>
            {
            ProcessingFunctions.Mirror(imgInverted);
                pictureBoxInversion.Image = imgInverted;
            });

            threads[0].Start();
            threads[1].Start();
            threads[2].Start();
            threads[3].Start();
        }
    }
}
