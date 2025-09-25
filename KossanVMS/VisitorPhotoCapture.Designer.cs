namespace KossanVMS
{
    partial class VisitorPhotoCapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Load += new System.EventHandler(this.VisitorPhotoCapture_Load);
            splitContainer1 = new SplitContainer();
            pictureBoxWebCam = new PictureBox();
            flowLayoutPanelPhotoCaptureControl = new FlowLayoutPanel();
            progressbarWebCam = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            buttonCapturePhoto = new ReaLTaiizor.Controls.DreamButton();
            buttonRetakePhoto = new ReaLTaiizor.Controls.DreamButton();
            buttonCancelPhoto = new ReaLTaiizor.Controls.DreamButton();
            backgroundWorkerWebcam = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWebCam).BeginInit();
            flowLayoutPanelPhotoCaptureControl.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBoxWebCam);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanelPhotoCaptureControl);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 665;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBoxWebCam
            // 
            pictureBoxWebCam.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxWebCam.Dock = DockStyle.Fill;
            pictureBoxWebCam.Location = new Point(0, 0);
            pictureBoxWebCam.Name = "pictureBoxWebCam";
            pictureBoxWebCam.Size = new Size(665, 450);
            pictureBoxWebCam.TabIndex = 0;
            pictureBoxWebCam.TabStop = false;
            // 
            // flowLayoutPanelPhotoCaptureControl
            // 
            flowLayoutPanelPhotoCaptureControl.BackColor = Color.FromArgb(41, 44, 61);
            flowLayoutPanelPhotoCaptureControl.Controls.Add(progressbarWebCam);
            flowLayoutPanelPhotoCaptureControl.Controls.Add(buttonCapturePhoto);
            flowLayoutPanelPhotoCaptureControl.Controls.Add(buttonRetakePhoto);
            flowLayoutPanelPhotoCaptureControl.Controls.Add(buttonCancelPhoto);
            flowLayoutPanelPhotoCaptureControl.Dock = DockStyle.Fill;
            flowLayoutPanelPhotoCaptureControl.Location = new Point(0, 0);
            flowLayoutPanelPhotoCaptureControl.Name = "flowLayoutPanelPhotoCaptureControl";
            flowLayoutPanelPhotoCaptureControl.Size = new Size(131, 450);
            flowLayoutPanelPhotoCaptureControl.TabIndex = 0;
            // 
            // progressbarWebCam
            // 
            progressbarWebCam.AnimationSpeed = 5;
            progressbarWebCam.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            progressbarWebCam.FilledColor = Color.FromArgb(60, 220, 210);
            progressbarWebCam.FilledColorAlpha = 130;
            progressbarWebCam.FilledThickness = 40;
            progressbarWebCam.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            progressbarWebCam.IsAnimated = false;
            progressbarWebCam.Location = new Point(3, 3);
            progressbarWebCam.Name = "progressbarWebCam";
            progressbarWebCam.Percentage = 50;
            progressbarWebCam.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            progressbarWebCam.ShowText = true;
            progressbarWebCam.Size = new Size(125, 109);
            progressbarWebCam.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            progressbarWebCam.TabIndex = 3;
            progressbarWebCam.TextColor = Color.Gray;
            progressbarWebCam.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            progressbarWebCam.TextSize = 25;
            progressbarWebCam.UnFilledColor = Color.FromArgb(114, 114, 114);
            progressbarWebCam.UnfilledThickness = 24;
            // 
            // buttonCapturePhoto
            // 
            buttonCapturePhoto.ColorA = Color.FromArgb(31, 31, 31);
            buttonCapturePhoto.ColorB = Color.FromArgb(41, 41, 41);
            buttonCapturePhoto.ColorC = Color.FromArgb(51, 51, 51);
            buttonCapturePhoto.ColorD = Color.FromArgb(0, 0, 0, 0);
            buttonCapturePhoto.ColorE = Color.FromArgb(25, 255, 255, 255);
            buttonCapturePhoto.ForeColor = Color.Lime;
            buttonCapturePhoto.Location = new Point(3, 118);
            buttonCapturePhoto.Name = "buttonCapturePhoto";
            buttonCapturePhoto.Size = new Size(128, 42);
            buttonCapturePhoto.TabIndex = 0;
            buttonCapturePhoto.Text = "Capture";
            buttonCapturePhoto.UseVisualStyleBackColor = true;
            buttonCapturePhoto.Click += buttonCapturePhoto_Click;
            // 
            // buttonRetakePhoto
            // 
            buttonRetakePhoto.ColorA = Color.FromArgb(31, 31, 31);
            buttonRetakePhoto.ColorB = Color.FromArgb(41, 41, 41);
            buttonRetakePhoto.ColorC = Color.FromArgb(51, 51, 51);
            buttonRetakePhoto.ColorD = Color.FromArgb(0, 0, 0, 0);
            buttonRetakePhoto.ColorE = Color.FromArgb(25, 255, 255, 255);
            buttonRetakePhoto.ForeColor = Color.FromArgb(255, 128, 0);
            buttonRetakePhoto.Location = new Point(3, 166);
            buttonRetakePhoto.Name = "buttonRetakePhoto";
            buttonRetakePhoto.Size = new Size(128, 42);
            buttonRetakePhoto.TabIndex = 1;
            buttonRetakePhoto.Text = "Retake";
            buttonRetakePhoto.UseVisualStyleBackColor = true;
            buttonRetakePhoto.Click += buttonRetakePhoto_Click;
            // 
            // buttonCancelPhoto
            // 
            buttonCancelPhoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancelPhoto.ColorA = Color.FromArgb(31, 31, 31);
            buttonCancelPhoto.ColorB = Color.FromArgb(41, 41, 41);
            buttonCancelPhoto.ColorC = Color.FromArgb(51, 51, 51);
            buttonCancelPhoto.ColorD = Color.FromArgb(0, 0, 0, 0);
            buttonCancelPhoto.ColorE = Color.FromArgb(25, 255, 255, 255);
            buttonCancelPhoto.ForeColor = Color.Red;
            buttonCancelPhoto.Location = new Point(3, 214);
            buttonCancelPhoto.Name = "buttonCancelPhoto";
            buttonCancelPhoto.Size = new Size(128, 42);
            buttonCancelPhoto.TabIndex = 2;
            buttonCancelPhoto.Text = "Cancel";
            buttonCancelPhoto.UseVisualStyleBackColor = true;
            // 
            // backgroundWorkerWebcam
            // 
            backgroundWorkerWebcam.WorkerReportsProgress = true;
            backgroundWorkerWebcam.WorkerSupportsCancellation = true;
            backgroundWorkerWebcam.DoWork += backgroundWorkerWebCam_DoWork;
            backgroundWorkerWebcam.ProgressChanged += backgroundWorkerWebCam_ProgressChanged;
            // 
            // VisitorPhotoCapture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "VisitorPhotoCapture";
            Text = "VisitorPhotoCapture";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxWebCam).EndInit();
            flowLayoutPanelPhotoCaptureControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void BackgroundWorkerWebcam_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBoxWebCam;
        private FlowLayoutPanel flowLayoutPanelPhotoCaptureControl;
        private ReaLTaiizor.Controls.DreamButton buttonCapturePhoto;
        private ReaLTaiizor.Controls.DreamButton buttonRetakePhoto;
        private ReaLTaiizor.Controls.DreamButton buttonCancelPhoto;
        private System.ComponentModel.BackgroundWorker backgroundWorkerWebcam;
        private ReaLTaiizor.Controls.ParrotCircleProgressBar progressbarWebCam;
    }
}