using KossanVMS.Security;

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
            buttonNavDms = new ReaLTaiizor.Controls.CyberButton();
            buttonNavVms = new ReaLTaiizor.Controls.CyberButton();
            dreamButton1 = new ReaLTaiizor.Controls.DreamButton();
            mainPanel = new ReaLTaiizor.Controls.Panel();
            hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            parrotPanel.SuspendLayout();
            mainPanel.SuspendLayout();
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
            parrotPanel.Controls.Add(buttonNavDms);
            parrotPanel.Controls.Add(buttonNavVms);
            parrotPanel.Controls.Add(dreamButton1);
            parrotPanel.Dock = DockStyle.Left;
            parrotPanel.HideControls = false;
            parrotPanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPanel.Location = new Point(0, 0);
            parrotPanel.Margin = new Padding(0);
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
            // buttonNavDms
            // 
            buttonNavDms.Alpha = 20;
            buttonNavDms.BackColor = Color.Transparent;
            buttonNavDms.Background = true;
            buttonNavDms.Background_WidthPen = 4F;
            buttonNavDms.BackgroundPen = true;
            buttonNavDms.ColorBackground = Color.FromArgb(37, 52, 68);
            buttonNavDms.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonNavDms.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonNavDms.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonNavDms.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonNavDms.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonNavDms.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonNavDms.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonNavDms.Dock = DockStyle.Top;
            buttonNavDms.Effect_1 = true;
            buttonNavDms.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonNavDms.Effect_1_Transparency = 25;
            buttonNavDms.Effect_2 = true;
            buttonNavDms.Effect_2_ColorBackground = Color.White;
            buttonNavDms.Effect_2_Transparency = 20;
            buttonNavDms.Font = new Font("Arial", 11F);
            buttonNavDms.ForeColor = Color.FromArgb(245, 245, 245);
            buttonNavDms.Lighting = false;
            buttonNavDms.LinearGradient_Background = false;
            buttonNavDms.LinearGradientPen = false;
            buttonNavDms.Location = new Point(0, 90);
            buttonNavDms.Margin = new Padding(10, 10, 5, 5);
            buttonNavDms.Name = "buttonNavDms";
            buttonNavDms.PenWidth = 15;
            buttonNavDms.Rounding = true;
            buttonNavDms.RoundingInt = 70;
            buttonNavDms.Size = new Size(100, 50);
            buttonNavDms.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonNavDms.TabIndex = 10;
            buttonNavDms.Tag = "Cyber";
            buttonNavDms.TextButton = "DMS";
            buttonNavDms.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonNavDms.Timer_Effect_1 = 5;
            buttonNavDms.Timer_RGB = 300;
            buttonNavDms.Click += buttonRegister_Click;
            // 
            // buttonNavVms
            // 
            buttonNavVms.Alpha = 20;
            buttonNavVms.BackColor = Color.Transparent;
            buttonNavVms.Background = true;
            buttonNavVms.Background_WidthPen = 4F;
            buttonNavVms.BackgroundPen = true;
            buttonNavVms.ColorBackground = Color.FromArgb(37, 52, 68);
            buttonNavVms.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonNavVms.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonNavVms.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonNavVms.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonNavVms.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonNavVms.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonNavVms.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonNavVms.Dock = DockStyle.Top;
            buttonNavVms.Effect_1 = true;
            buttonNavVms.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonNavVms.Effect_1_Transparency = 25;
            buttonNavVms.Effect_2 = true;
            buttonNavVms.Effect_2_ColorBackground = Color.White;
            buttonNavVms.Effect_2_Transparency = 20;
            buttonNavVms.Font = new Font("Arial", 11F);
            buttonNavVms.ForeColor = Color.FromArgb(245, 245, 245);
            buttonNavVms.Lighting = false;
            buttonNavVms.LinearGradient_Background = false;
            buttonNavVms.LinearGradientPen = false;
            buttonNavVms.Location = new Point(0, 40);
            buttonNavVms.Margin = new Padding(10, 10, 5, 5);
            buttonNavVms.Name = "buttonNavVms";
            buttonNavVms.PenWidth = 15;
            buttonNavVms.Rounding = true;
            buttonNavVms.RoundingInt = 70;
            buttonNavVms.Size = new Size(100, 50);
            buttonNavVms.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonNavVms.TabIndex = 2;
            buttonNavVms.Tag = "Cyber";
            buttonNavVms.TextButton = "VMS";
            buttonNavVms.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonNavVms.Timer_Effect_1 = 5;
            buttonNavVms.Timer_RGB = 300;
            buttonNavVms.Click += buttonNavMain_Click;
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
            mainPanel.Controls.Add(hopeTabPage1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.EdgeColor = Color.FromArgb(32, 41, 50);
            mainPanel.Location = new Point(100, 0);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(5);
            mainPanel.Size = new Size(482, 428);
            mainPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            mainPanel.TabIndex = 2;
            mainPanel.Text = "MainPanel";
            // 
            // hopeTabPage1
            // 
            hopeTabPage1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTabPage1.Dock = DockStyle.Fill;
            hopeTabPage1.Font = new Font("Segoe UI", 12F);
            hopeTabPage1.ForeColorA = Color.Silver;
            hopeTabPage1.ForeColorB = Color.Gray;
            hopeTabPage1.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            hopeTabPage1.ItemSize = new Size(120, 40);
            hopeTabPage1.Location = new Point(5, 5);
            hopeTabPage1.Margin = new Padding(0);
            hopeTabPage1.Name = "hopeTabPage1";
            hopeTabPage1.Padding = new Point(0, 0);
            hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopeTabPage1.SelectedIndex = 0;
            hopeTabPage1.Size = new Size(472, 418);
            hopeTabPage1.SizeMode = TabSizeMode.Fixed;
            hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopeTabPage1.TabIndex = 1;
            hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopeTabPage1.ThemeColorA = Color.FromArgb(64, 158, 255);
            hopeTabPage1.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
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
            MaximumSize = new Size(2540, 1440);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += MainPage_Load;
            parrotPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ReaLTaiizor.Controls.ParrotSlidingPanel parrotPanel;
        private ReaLTaiizor.Controls.CyberButton buttonNavVms;
        private ReaLTaiizor.Controls.DreamButton dreamButton1;
        private ReaLTaiizor.Controls.Panel mainPanel;
        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private ReaLTaiizor.Controls.CyberButton buttonNavDms;
    }
}
