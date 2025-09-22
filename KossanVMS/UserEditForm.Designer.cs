namespace KossanVMS
{
    partial class UserEditForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
            parrotSlidingPanel1 = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            VisitorGridView = new DataGridView();
            visitorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorBindingSource = new BindingSource(components);
            parrotToolStrip1 = new ReaLTaiizor.Controls.ParrotToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            nightPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisitorGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
            parrotToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // parrotSlidingPanel1
            // 
            parrotSlidingPanel1.BottomLeft = Color.Black;
            parrotSlidingPanel1.BottomRight = Color.DodgerBlue;
            parrotSlidingPanel1.CollapseControl = null;
            parrotSlidingPanel1.Collapsed = true;
            parrotSlidingPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotSlidingPanel1.Dock = DockStyle.Left;
            parrotSlidingPanel1.HideControls = false;
            parrotSlidingPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotSlidingPanel1.Location = new Point(0, 0);
            parrotSlidingPanel1.Name = "parrotSlidingPanel1";
            parrotSlidingPanel1.PanelWidthCollapsed = 50;
            parrotSlidingPanel1.PanelWidthExpanded = 200;
            parrotSlidingPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSlidingPanel1.PrimerColor = Color.White;
            parrotSlidingPanel1.Size = new Size(87, 450);
            parrotSlidingPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotSlidingPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotSlidingPanel1.TabIndex = 0;
            parrotSlidingPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSlidingPanel1.TopLeft = Color.Black;
            parrotSlidingPanel1.TopRight = Color.Black;
            // 
            // nightPanel1
            // 
            nightPanel1.Controls.Add(VisitorGridView);
            nightPanel1.Controls.Add(parrotToolStrip1);
            nightPanel1.Dock = DockStyle.Fill;
            nightPanel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel1.LeftSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Location = new Point(87, 0);
            nightPanel1.Name = "nightPanel1";
            nightPanel1.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel1.Size = new Size(743, 450);
            nightPanel1.TabIndex = 1;
            // 
            // VisitorGridView
            // 
            VisitorGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VisitorGridView.AutoGenerateColumns = false;
            VisitorGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisitorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitorGridView.Columns.AddRange(new DataGridViewColumn[] { visitorIDDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn });
            VisitorGridView.DataSource = visitorBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 44, 61);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            VisitorGridView.DefaultCellStyle = dataGridViewCellStyle1;
            VisitorGridView.Location = new Point(0, 25);
            VisitorGridView.Name = "VisitorGridView";
            VisitorGridView.RowTemplate.Height = 25;
            VisitorGridView.Size = new Size(743, 425);
            VisitorGridView.TabIndex = 1;
            // 
            // visitorIDDataGridViewTextBoxColumn
            // 
            visitorIDDataGridViewTextBoxColumn.DataPropertyName = "VisitorID";
            visitorIDDataGridViewTextBoxColumn.HeaderText = "VisitorID";
            visitorIDDataGridViewTextBoxColumn.Name = "visitorIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // visitorBindingSource
            // 
            visitorBindingSource.DataSource = typeof(Data.Visitor);
            // 
            // parrotToolStrip1
            // 
            parrotToolStrip1.BackColor = Color.White;
            parrotToolStrip1.BorderColor = Color.DodgerBlue;
            parrotToolStrip1.ForeColor = Color.Black;
            parrotToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            parrotToolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton3, toolStripButton1 });
            parrotToolStrip1.Location = new Point(0, 0);
            parrotToolStrip1.Name = "parrotToolStrip1";
            parrotToolStrip1.Size = new Size(743, 25);
            parrotToolStrip1.TabIndex = 0;
            parrotToolStrip1.Text = "parrotToolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // UserEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(830, 450);
            Controls.Add(nightPanel1);
            Controls.Add(parrotSlidingPanel1);
            Name = "UserEditForm";
            Text = "UserEditForm";
            nightPanel1.ResumeLayout(false);
            nightPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VisitorGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
            parrotToolStrip1.ResumeLayout(false);
            parrotToolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotSlidingPanel parrotSlidingPanel1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private ReaLTaiizor.Controls.ParrotToolStrip parrotToolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private BindingSource visitorBindingSource;
        private DataGridView VisitorGridView;
        private DataGridViewTextBoxColumn visitorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iCNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companiesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorBlackListDataGridViewTextBoxColumn;
    }
}