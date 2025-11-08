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
            splitContainer1 = new SplitContainer();
            pictureBoxWebCam = new PictureBox();
            flowLayoutPanelPhotoCaptureControl = new FlowLayoutPanel();
            buttonCapturePhoto = new ReaLTaiizor.Controls.CyberButton();
            buttonRetakePhoto = new ReaLTaiizor.Controls.CyberButton();
            buttonCancelPhoto = new ReaLTaiizor.Controls.CyberButton();
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
            splitContainer1.SplitterDistance = 657;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBoxWebCam
            // 
            pictureBoxWebCam.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxWebCam.Dock = DockStyle.Fill;
            pictureBoxWebCam.Location = new Point(0, 0);
            pictureBoxWebCam.Name = "pictureBoxWebCam";
            pictureBoxWebCam.Size = new Size(657, 450);
            pictureBoxWebCam.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWebCam.TabIndex = 0;
            pictureBoxWebCam.TabStop = false;
            // 
            // flowLayoutPanelPhotoCaptureControl
            // 
            flowLayoutPanelPhotoCaptureControl.BackColor = Color.FromArgb(41, 44, 61);
            flowLayoutPanelPhotoCaptureControl.Controls.Add(buttonCapturePhoto);
            flowLayoutPanelPhotoCaptureControl.Controls.Add(buttonRetakePhoto);
            flowLayoutPanelPhotoCaptureControl.Controls.Add(buttonCancelPhoto);
            flowLayoutPanelPhotoCaptureControl.Dock = DockStyle.Fill;
            flowLayoutPanelPhotoCaptureControl.Location = new Point(0, 0);
            flowLayoutPanelPhotoCaptureControl.Name = "flowLayoutPanelPhotoCaptureControl";
            flowLayoutPanelPhotoCaptureControl.Size = new Size(139, 450);
            flowLayoutPanelPhotoCaptureControl.TabIndex = 0;
            // 
            // buttonCapturePhoto
            // 
            buttonCapturePhoto.Alpha = 20;
            buttonCapturePhoto.BackColor = Color.Transparent;
            buttonCapturePhoto.Background = true;
            buttonCapturePhoto.Background_WidthPen = 6F;
            buttonCapturePhoto.BackgroundPen = true;
            buttonCapturePhoto.ColorBackground = Color.Lime;
            buttonCapturePhoto.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonCapturePhoto.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonCapturePhoto.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonCapturePhoto.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonCapturePhoto.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonCapturePhoto.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonCapturePhoto.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonCapturePhoto.Effect_1 = true;
            buttonCapturePhoto.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonCapturePhoto.Effect_1_Transparency = 25;
            buttonCapturePhoto.Effect_2 = true;
            buttonCapturePhoto.Effect_2_ColorBackground = Color.White;
            buttonCapturePhoto.Effect_2_Transparency = 20;
            buttonCapturePhoto.Font = new Font("Arial", 11F);
            buttonCapturePhoto.ForeColor = Color.Black;
            buttonCapturePhoto.Lighting = false;
            buttonCapturePhoto.LinearGradient_Background = false;
            buttonCapturePhoto.LinearGradientPen = false;
            buttonCapturePhoto.Location = new Point(3, 3);
            buttonCapturePhoto.Name = "buttonCapturePhoto";
            buttonCapturePhoto.PenWidth = 15;
            buttonCapturePhoto.Rounding = true;
            buttonCapturePhoto.RoundingInt = 70;
            buttonCapturePhoto.Size = new Size(130, 50);
            buttonCapturePhoto.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonCapturePhoto.TabIndex = 0;
            buttonCapturePhoto.Tag = "Cyber";
            buttonCapturePhoto.TextButton = "Capture";
            buttonCapturePhoto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonCapturePhoto.Timer_Effect_1 = 5;
            buttonCapturePhoto.Timer_RGB = 300;
            buttonCapturePhoto.Click += buttonCapturePhoto_Click;
            // 
            // buttonRetakePhoto
            // 
            buttonRetakePhoto.Alpha = 20;
            buttonRetakePhoto.BackColor = Color.Transparent;
            buttonRetakePhoto.Background = true;
            buttonRetakePhoto.Background_WidthPen = 6F;
            buttonRetakePhoto.BackgroundPen = true;
            buttonRetakePhoto.ColorBackground = Color.FromArgb(255, 128, 0);
            buttonRetakePhoto.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonRetakePhoto.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonRetakePhoto.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonRetakePhoto.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonRetakePhoto.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonRetakePhoto.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonRetakePhoto.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonRetakePhoto.Effect_1 = true;
            buttonRetakePhoto.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonRetakePhoto.Effect_1_Transparency = 25;
            buttonRetakePhoto.Effect_2 = true;
            buttonRetakePhoto.Effect_2_ColorBackground = Color.White;
            buttonRetakePhoto.Effect_2_Transparency = 20;
            buttonRetakePhoto.Font = new Font("Arial", 11F);
            buttonRetakePhoto.ForeColor = Color.Black;
            buttonRetakePhoto.Lighting = false;
            buttonRetakePhoto.LinearGradient_Background = false;
            buttonRetakePhoto.LinearGradientPen = false;
            buttonRetakePhoto.Location = new Point(3, 59);
            buttonRetakePhoto.Name = "buttonRetakePhoto";
            buttonRetakePhoto.PenWidth = 15;
            buttonRetakePhoto.Rounding = true;
            buttonRetakePhoto.RoundingInt = 70;
            buttonRetakePhoto.Size = new Size(130, 50);
            buttonRetakePhoto.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonRetakePhoto.TabIndex = 2;
            buttonRetakePhoto.Tag = "Cyber";
            buttonRetakePhoto.TextButton = "Retake";
            buttonRetakePhoto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonRetakePhoto.Timer_Effect_1 = 5;
            buttonRetakePhoto.Timer_RGB = 300;
            buttonRetakePhoto.Click += buttonRetakePhoto_Click;
            // 
            // buttonCancelPhoto
            // 
            buttonCancelPhoto.Alpha = 20;
            buttonCancelPhoto.BackColor = Color.Transparent;
            buttonCancelPhoto.Background = true;
            buttonCancelPhoto.Background_WidthPen = 6F;
            buttonCancelPhoto.BackgroundPen = true;
            buttonCancelPhoto.ColorBackground = Color.Red;
            buttonCancelPhoto.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonCancelPhoto.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonCancelPhoto.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonCancelPhoto.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonCancelPhoto.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonCancelPhoto.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonCancelPhoto.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonCancelPhoto.Effect_1 = true;
            buttonCancelPhoto.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonCancelPhoto.Effect_1_Transparency = 25;
            buttonCancelPhoto.Effect_2 = true;
            buttonCancelPhoto.Effect_2_ColorBackground = Color.White;
            buttonCancelPhoto.Effect_2_Transparency = 20;
            buttonCancelPhoto.Font = new Font("Arial", 11F);
            buttonCancelPhoto.ForeColor = Color.Black;
            buttonCancelPhoto.Lighting = false;
            buttonCancelPhoto.LinearGradient_Background = false;
            buttonCancelPhoto.LinearGradientPen = false;
            buttonCancelPhoto.Location = new Point(3, 115);
            buttonCancelPhoto.Name = "buttonCancelPhoto";
            buttonCancelPhoto.PenWidth = 15;
            buttonCancelPhoto.Rounding = true;
            buttonCancelPhoto.RoundingInt = 70;
            buttonCancelPhoto.Size = new Size(130, 50);
            buttonCancelPhoto.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonCancelPhoto.TabIndex = 3;
            buttonCancelPhoto.Tag = "Cyber";
            buttonCancelPhoto.TextButton = "Cancel";
            buttonCancelPhoto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonCancelPhoto.Timer_Effect_1 = 5;
            buttonCancelPhoto.Timer_RGB = 300;
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VisitorPhotoCapture";
            Text = "VisitorPhotoCapture";
            Load += VisitorPhotoCapture_Load;
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
        private System.ComponentModel.BackgroundWorker backgroundWorkerWebcam;
        private ReaLTaiizor.Controls.CyberButton buttonCapturePhoto;
        private ReaLTaiizor.Controls.CyberButton buttonRetakePhoto;
        private ReaLTaiizor.Controls.CyberButton buttonCancelPhoto;
    }
}