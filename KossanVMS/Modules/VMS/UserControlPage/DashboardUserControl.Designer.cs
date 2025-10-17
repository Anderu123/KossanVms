namespace KossanVMS.Modules.VMS.UserControlPage
{
    partial class DashboardUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            dataGridView2 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            labelTotalIn = new ReaLTaiizor.Controls.SkyLabel();
            panel1 = new Panel();
            parrotCircleProgressBar1 = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.61905F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.61905F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.76190472F));
            tableLayoutPanel1.Size = new Size(687, 452);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7596436F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.24036F));
            tableLayoutPanel3.Controls.Add(skyLabel2, 0, 0);
            tableLayoutPanel3.Controls.Add(dataGridView2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(346, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0047846F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 88.99522F));
            tableLayoutPanel3.Size = new Size(338, 209);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // skyLabel2
            // 
            skyLabel2.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(skyLabel2, 2);
            skyLabel2.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            skyLabel2.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel2.Location = new Point(3, 0);
            skyLabel2.Name = "skyLabel2";
            skyLabel2.Size = new Size(104, 12);
            skyLabel2.TabIndex = 0;
            skyLabel2.Text = "Total Checked Out :";
            skyLabel2.Click += skyLabel2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel3.SetColumnSpan(dataGridView2, 2);
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(332, 180);
            dataGridView2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7596436F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.24036F));
            tableLayoutPanel2.Controls.Add(skyLabel1, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0047846F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.99522F));
            tableLayoutPanel2.Size = new Size(337, 209);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(skyLabel1, 2);
            skyLabel1.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(3, 0);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(96, 12);
            skyLabel1.TabIndex = 0;
            skyLabel1.Text = "Total Checked In :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(331, 180);
            dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.93245F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.0675468F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 218);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(681, 209);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4524879F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5475121F));
            tableLayoutPanel5.Controls.Add(labelTotalIn, 0, 0);
            tableLayoutPanel5.Controls.Add(panel1, 1, 1);
            tableLayoutPanel5.Controls.Add(parrotCircleProgressBar1, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8078814F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 87.1921158F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(442, 203);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // labelTotalIn
            // 
            labelTotalIn.AutoSize = true;
            tableLayoutPanel5.SetColumnSpan(labelTotalIn, 2);
            labelTotalIn.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            labelTotalIn.ForeColor = Color.FromArgb(27, 94, 137);
            labelTotalIn.Location = new Point(3, 0);
            labelTotalIn.Name = "labelTotalIn";
            labelTotalIn.Size = new Size(92, 12);
            labelTotalIn.TabIndex = 1;
            labelTotalIn.Text = "Total Current In :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 52, 68);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(226, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 171);
            panel1.TabIndex = 3;
            // 
            // parrotCircleProgressBar1
            // 
            parrotCircleProgressBar1.AnimationSpeed = 5;
            parrotCircleProgressBar1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotCircleProgressBar1.Dock = DockStyle.Fill;
            parrotCircleProgressBar1.FilledColor = Color.FromArgb(60, 220, 210);
            parrotCircleProgressBar1.FilledColorAlpha = 130;
            parrotCircleProgressBar1.FilledThickness = 40;
            parrotCircleProgressBar1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotCircleProgressBar1.IsAnimated = false;
            parrotCircleProgressBar1.Location = new Point(3, 29);
            parrotCircleProgressBar1.Name = "parrotCircleProgressBar1";
            parrotCircleProgressBar1.Percentage = 50;
            parrotCircleProgressBar1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotCircleProgressBar1.ShowText = true;
            parrotCircleProgressBar1.Size = new Size(217, 171);
            parrotCircleProgressBar1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotCircleProgressBar1.TabIndex = 4;
            parrotCircleProgressBar1.TextColor = Color.Gray;
            parrotCircleProgressBar1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotCircleProgressBar1.TextSize = 25;
            parrotCircleProgressBar1.UnFilledColor = Color.FromArgb(114, 114, 114);
            parrotCircleProgressBar1.UnfilledThickness = 24;
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardUserControl";
            Size = new Size(687, 452);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private ReaLTaiizor.Controls.SkyLabel labelTotalIn;
        private Panel panel1;
        private ReaLTaiizor.Controls.ParrotCircleProgressBar parrotCircleProgressBar1;
    }
}
