namespace Paralell_Image_Processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            pictureBoxBasic = new PictureBox();
            buttonLoad = new Button();
            buttonProcess = new Button();
            pictureBoxThreshold = new PictureBox();
            pictureBoxEdge = new PictureBox();
            pictureBoxInversion = new PictureBox();
            pictureBoxGrayscale = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBasic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInversion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrayscale).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxBasic
            // 
            pictureBoxBasic.Location = new Point(12, 12);
            pictureBoxBasic.Name = "pictureBoxBasic";
            pictureBoxBasic.Size = new Size(448, 426);
            pictureBoxBasic.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxBasic.TabIndex = 0;
            pictureBoxBasic.TabStop = false;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(491, 156);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(91, 43);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonProcess
            // 
            buttonProcess.Location = new Point(491, 283);
            buttonProcess.Name = "buttonProcess";
            buttonProcess.Size = new Size(91, 45);
            buttonProcess.TabIndex = 2;
            buttonProcess.Text = "Start image processing";
            buttonProcess.UseVisualStyleBackColor = true;
            buttonProcess.Click += buttonProcess_Click;
            // 
            // pictureBoxThreshold
            // 
            pictureBoxThreshold.Location = new Point(614, 12);
            pictureBoxThreshold.Name = "pictureBoxThreshold";
            pictureBoxThreshold.Size = new Size(267, 232);
            pictureBoxThreshold.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxThreshold.TabIndex = 3;
            pictureBoxThreshold.TabStop = false;
            // 
            // pictureBoxEdge
            // 
            pictureBoxEdge.Location = new Point(614, 283);
            pictureBoxEdge.Name = "pictureBoxEdge";
            pictureBoxEdge.Size = new Size(267, 232);
            pictureBoxEdge.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxEdge.TabIndex = 4;
            pictureBoxEdge.TabStop = false;
            // 
            // pictureBoxInversion
            // 
            pictureBoxInversion.Location = new Point(970, 12);
            pictureBoxInversion.Name = "pictureBoxInversion";
            pictureBoxInversion.Size = new Size(267, 232);
            pictureBoxInversion.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxInversion.TabIndex = 5;
            pictureBoxInversion.TabStop = false;
            // 
            // pictureBoxGrayscale
            // 
            pictureBoxGrayscale.Location = new Point(970, 283);
            pictureBoxGrayscale.Name = "pictureBoxGrayscale";
            pictureBoxGrayscale.Size = new Size(267, 232);
            pictureBoxGrayscale.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxGrayscale.TabIndex = 6;
            pictureBoxGrayscale.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 651);
            Controls.Add(pictureBoxGrayscale);
            Controls.Add(pictureBoxInversion);
            Controls.Add(pictureBoxEdge);
            Controls.Add(pictureBoxThreshold);
            Controls.Add(buttonProcess);
            Controls.Add(buttonLoad);
            Controls.Add(pictureBoxBasic);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBasic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdge).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInversion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrayscale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBoxBasic;
        private Button buttonLoad;
        private Button buttonProcess;
        private PictureBox pictureBoxThreshold;
        private PictureBox pictureBoxEdge;
        private PictureBox pictureBoxInversion;
        private PictureBox pictureBoxGrayscale;
    }
}
