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
            toolStrip1 = new ToolStrip();
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            dreamButton1 = new ReaLTaiizor.Controls.DreamButton();
            foxButton1 = new ReaLTaiizor.Controls.FoxButton();
            nightForm1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(3, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(576, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(3, 64);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(576, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.FromArgb(40, 48, 51);
            nightForm1.Controls.Add(foxButton1);
            nightForm1.Controls.Add(dreamButton1);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(3, 89);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(576, 336);
            nightForm1.TabIndex = 2;
            nightForm1.Text = "nightForm1";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            // 
            // dreamButton1
            // 
            dreamButton1.ColorA = Color.FromArgb(31, 31, 31);
            dreamButton1.ColorB = Color.FromArgb(41, 41, 41);
            dreamButton1.ColorC = Color.FromArgb(51, 51, 51);
            dreamButton1.ColorD = Color.FromArgb(0, 0, 0, 0);
            dreamButton1.ColorE = Color.FromArgb(25, 255, 255, 255);
            dreamButton1.ForeColor = Color.FromArgb(40, 218, 255);
            dreamButton1.Location = new Point(178, 147);
            dreamButton1.Name = "dreamButton1";
            dreamButton1.Size = new Size(120, 40);
            dreamButton1.TabIndex = 0;
            dreamButton1.Text = "dreamButton1";
            dreamButton1.UseVisualStyleBackColor = true;
            // 
            // foxButton1
            // 
            foxButton1.BackColor = Color.Transparent;
            foxButton1.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton1.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton1.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton1.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton1.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton1.DownColor = Color.FromArgb(232, 232, 232);
            foxButton1.EnabledCalc = true;
            foxButton1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            foxButton1.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton1.Location = new Point(282, 228);
            foxButton1.Name = "foxButton1";
            foxButton1.OverColor = Color.FromArgb(242, 242, 242);
            foxButton1.Size = new Size(120, 40);
            foxButton1.TabIndex = 1;
            foxButton1.Text = "foxButton1";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(582, 450);
            Controls.Add(nightForm1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            MaximumSize = new Size(1920, 1032);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.Fuchsia;
            WindowState = FormWindowState.Maximized;
            Load += MainPage_Load;
            nightForm1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.DreamButton dreamButton1;
        private ReaLTaiizor.Controls.FoxButton foxButton1;
    }
}
