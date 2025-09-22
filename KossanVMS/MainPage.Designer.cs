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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ReaLTaiizor.Forms.NightForm nightForm1;
    }
}
