namespace KossanVMS
{
    partial class MainPage
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
            statusStrip1 = new StatusStrip();
            parrotPanel = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            dreamButton1 = new ReaLTaiizor.Controls.DreamButton();
            mainPanel = new ReaLTaiizor.Controls.Panel();
            parrotPanel.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(582, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // parrotPanel
            // 
            parrotPanel.BottomLeft = Color.Black;
            parrotPanel.BottomRight = Color.DodgerBlue;
            parrotPanel.CollapseControl = null;
            parrotPanel.Collapsed = true;
            parrotPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPanel.Controls.Add(cyberButton1);
            parrotPanel.Controls.Add(dreamButton1);
            parrotPanel.Dock = DockStyle.Left;
            parrotPanel.HideControls = false;
            parrotPanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPanel.Location = new Point(0, 0);
            parrotPanel.Name = "parrotPanel";
            parrotPanel.PanelWidthCollapsed = 50;
            parrotPanel.PanelWidthExpanded = 200;
            parrotPanel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPanel.PrimerColor = Color.White;
            parrotPanel.Size = new Size(100, 428);
            parrotPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPanel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotPanel.TabIndex = 1;
            parrotPanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotPanel.TopLeft = Color.Black;
            parrotPanel.TopRight = Color.Black;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Dock = DockStyle.Top;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(0, 40);
            cyberButton1.Margin = new Padding(10, 10, 5, 5);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(100, 50);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 2;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Register";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            // 
            // dreamButton1
            // 
            dreamButton1.ColorA = Color.FromArgb(31, 31, 31);
            dreamButton1.ColorB = Color.FromArgb(41, 41, 41);
            dreamButton1.ColorC = Color.FromArgb(51, 51, 51);
            dreamButton1.ColorD = Color.FromArgb(0, 0, 0, 0);
            dreamButton1.ColorE = Color.FromArgb(25, 255, 255, 255);
            dreamButton1.Dock = DockStyle.Top;
            dreamButton1.Enabled = false;
            dreamButton1.ForeColor = Color.FromArgb(40, 218, 255);
            dreamButton1.Location = new Point(0, 0);
            dreamButton1.Margin = new Padding(3, 20, 3, 3);
            dreamButton1.Name = "dreamButton1";
            dreamButton1.Size = new Size(100, 40);
            dreamButton1.TabIndex = 1;
            dreamButton1.Text = "VMS";
            dreamButton1.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(39, 51, 63);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.EdgeColor = Color.FromArgb(32, 41, 50);
            mainPanel.Location = new Point(100, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(5);
            mainPanel.Size = new Size(482, 428);
            mainPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            mainPanel.TabIndex = 2;
            mainPanel.Text = "MainPanel";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(582, 450);
            Controls.Add(mainPanel);
            Controls.Add(parrotPanel);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(1920, 1032);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += MainPage_Load;
            parrotPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ReaLTaiizor.Controls.ParrotSlidingPanel parrotPanel;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.DreamButton dreamButton1;
        private ReaLTaiizor.Controls.Panel mainPanel;
    }
}
