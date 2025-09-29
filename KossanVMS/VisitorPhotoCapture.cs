using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;


namespace KossanVMS
{
    public partial class VisitorPhotoCapture : Form
    {
        private  VideoCapture capture;
        private  CascadeClassifier cascadeClassifier;
        private readonly VisitorEditForm mainForm;
        private bool isMoving = false;
        public VisitorPhotoCapture(VisitorEditForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        private void VisitorPhotoCapture_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture();
            cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");

            capture.Open(0, VideoCaptureAPIs.DSHOW);
            capture.Set(VideoCaptureProperties.FourCC, VideoWriter.FourCC('M', 'J', 'P', 'G'));
            capture.Set(VideoCaptureProperties.FrameWidth, 700);
            capture.Set(VideoCaptureProperties.FrameHeight, 480);
            capture.Set(VideoCaptureProperties.Fps, 15);             // 15–20fps is realistic in VB
            capture.Set(VideoCaptureProperties.BufferSize, 1);
            //capture.Set(VideoCaptureProperties.FrameWidth, 640);
            if (!capture.IsOpened())
            {
                MessageBox.Show("Camera is in user, please close the other application first");
                return;
            }
            backgroundWorkerWebcam.RunWorkerAsync();
        }
        private void backgroundWorkerWebCam_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker)sender;
            while (!bgWorker.CancellationPending)
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    var rects = cascadeClassifier.DetectMultiScale(frameMat, 1.1, 5, HaarDetectionTypes.ScaleImage, new OpenCvSharp.Size(30, 30));
                    if (rects.Length > 0)
                    {
                        Cv2.Rectangle(frameMat, rects[0], Scalar.Red);
                    }
                    var frameBitmap = BitmapConverter.ToBitmap(frameMat);
                    bgWorker.ReportProgress(0, frameBitmap);
                }
            }
        }
        private void backgroundWorkerWebCam_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var frameBitmap = (Bitmap)e.UserState;
            pictureBoxWebCam.Image?.Dispose();
            pictureBoxWebCam.Image = frameBitmap;
        }

        private void buttonCapturePhoto_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerWebcam.IsBusy)
            {
                backgroundWorkerWebcam.CancelAsync();
                //progressbarWebCam.Percentage = 100;
            }
        }

        private void buttonRetakePhoto_Click(object sender, EventArgs e)
        {
            if (!backgroundWorkerWebcam.IsBusy)
            {
                backgroundWorkerWebcam.RunWorkerAsync();
                //progressbarWebCam.Percentage = 50;
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            //e.Cancel = true;
            backgroundWorkerWebcam?.CancelAsync();
            capture.Dispose();
            base.OnFormClosed(e);
        }
        private void VisitorPhotoCaptureForm_LocationChanged(object sender, EventArgs e)
        {
            if (isMoving) return;
            isMoving = true;

            // Check if the form is moving out of the right boundary
            if (this.Right > Screen.PrimaryScreen.WorkingArea.Width)
            {
                this.Location = new System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, this.Top);
            }

            // Synchronize the main form's location to the webcam form's new position
            mainForm.Location = new System.Drawing.Point(this.Left - mainForm.Width, this.Top);

            // Check if the pair is moving out of the left boundary
            if (mainForm.Left < 0)
            {
                int newX = 0;
                mainForm.Location = new System.Drawing.Point(newX, mainForm.Top);
                this.Location = new System.Drawing.Point(newX + mainForm.Width, this.Top);
            }

            isMoving = false;
        }
    }
}
