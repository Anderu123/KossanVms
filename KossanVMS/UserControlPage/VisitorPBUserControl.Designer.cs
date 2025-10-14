namespace KossanVMS.UserControlPage
{
    partial class VisitorPBUserControl
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorPBUserControl));
            toolStrip1 = new ToolStrip();
            VisitorGridViewPBControl = new DataGridView();
            visitorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IdType = new DataGridViewTextBoxColumn();
            IdNo = new DataGridViewTextBoxColumn();
            colCategories = new DataGridViewTextBoxColumn();
            colPhoto = new DataGridViewTextBoxColumn();
            blackListDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            visitorUploadVisitorBox = new PictureBox();
            visitorPictureBox = new PictureBox();
            toolStrip2 = new ToolStrip();
            toolStripDelButton = new ToolStripButton();
            toolStripAddButton = new ToolStripButton();
            toolStripEditButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)VisitorGridViewPBControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitorUploadVisitorBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(686, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // VisitorGridViewUserControl
            // 
            VisitorGridViewPBControl.AutoGenerateColumns = false;
            VisitorGridViewPBControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisitorGridViewPBControl.BackgroundColor = Color.LightGray;
            VisitorGridViewPBControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitorGridViewPBControl.Columns.AddRange(new DataGridViewColumn[] { visitorIDDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, IdType, IdNo, colCategories, colPhoto, blackListDataGridViewTextBoxColumn });
            VisitorGridViewPBControl.DataSource = visitorBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            VisitorGridViewPBControl.DefaultCellStyle = dataGridViewCellStyle1;
            VisitorGridViewPBControl.Dock = DockStyle.Fill;
            VisitorGridViewPBControl.EditMode = DataGridViewEditMode.EditProgrammatically;
            VisitorGridViewPBControl.Location = new Point(178, 27);
            VisitorGridViewPBControl.MultiSelect = false;
            VisitorGridViewPBControl.Name = "VisitorGridViewUserControl";
            VisitorGridViewPBControl.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            tableLayoutPanel1.SetRowSpan(VisitorGridViewPBControl, 2);
            VisitorGridViewPBControl.RowTemplate.Height = 25;
            VisitorGridViewPBControl.Size = new Size(505, 408);
            VisitorGridViewPBControl.TabIndex = 0;
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
            // IdType
            // 
            IdType.DataPropertyName = "IdType";
            IdType.HeaderText = "IdType";
            IdType.Name = "IdType";
            // 
            // IdNo
            // 
            IdNo.DataPropertyName = "IdNo";
            IdNo.HeaderText = "IdNo";
            IdNo.Name = "IdNo";
            // 
            // colCategories
            // 
            colCategories.HeaderText = "Categories";
            colCategories.Name = "colCategories";
            // 
            // colPhoto
            // 
            colPhoto.HeaderText = "Photo";
            colPhoto.Name = "colPhoto";
            // 
            // blackListDataGridViewTextBoxColumn
            // 
            blackListDataGridViewTextBoxColumn.DataPropertyName = "BlackList";
            blackListDataGridViewTextBoxColumn.HeaderText = "BlackList";
            blackListDataGridViewTextBoxColumn.Name = "blackListDataGridViewTextBoxColumn";
            // 
            // visitorBindingSource
            // 
            visitorBindingSource.DataSource = typeof(Data.Visitor);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.61728F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.38272F));
            tableLayoutPanel1.Controls.Add(visitorUploadVisitorBox, 0, 2);
            tableLayoutPanel1.Controls.Add(visitorPictureBox, 0, 1);
            tableLayoutPanel1.Controls.Add(toolStrip2, 0, 0);
            tableLayoutPanel1.Controls.Add(VisitorGridViewPBControl, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.56438732F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.217804F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.217804F));
            tableLayoutPanel1.Size = new Size(686, 438);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // visitorUploadVisitorBox
            // 
            visitorUploadVisitorBox.BackColor = Color.Black;
            visitorUploadVisitorBox.Cursor = Cursors.IBeam;
            visitorUploadVisitorBox.Dock = DockStyle.Fill;
            visitorUploadVisitorBox.Image = (Image)resources.GetObject("visitorUploadVisitorBox.Image");
            visitorUploadVisitorBox.InitialImage = (Image)resources.GetObject("visitorUploadVisitorBox.InitialImage");
            visitorUploadVisitorBox.Location = new Point(10, 240);
            visitorUploadVisitorBox.Margin = new Padding(10);
            visitorUploadVisitorBox.Name = "visitorUploadVisitorBox";
            visitorUploadVisitorBox.Size = new Size(155, 188);
            visitorUploadVisitorBox.SizeMode = PictureBoxSizeMode.StretchImage;
            visitorUploadVisitorBox.TabIndex = 5;
            visitorUploadVisitorBox.TabStop = false;
            // 
            // visitorPictureBox
            // 
            visitorPictureBox.BackColor = Color.Black;
            visitorPictureBox.Cursor = Cursors.IBeam;
            visitorPictureBox.Dock = DockStyle.Fill;
            visitorPictureBox.Image = (Image)resources.GetObject("visitorPictureBox.Image");
            visitorPictureBox.InitialImage = (Image)resources.GetObject("visitorPictureBox.InitialImage");
            visitorPictureBox.Location = new Point(10, 34);
            visitorPictureBox.Margin = new Padding(10);
            visitorPictureBox.Name = "visitorPictureBox";
            visitorPictureBox.Size = new Size(155, 186);
            visitorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            visitorPictureBox.TabIndex = 4;
            visitorPictureBox.TabStop = false;
            // 
            // toolStrip2
            // 
            toolStrip2.BackColor = SystemColors.MenuBar;
            tableLayoutPanel1.SetColumnSpan(toolStrip2, 2);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripDelButton, toolStripAddButton, toolStripEditButton });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(686, 24);
            toolStrip2.TabIndex = 3;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDelButton
            // 
            toolStripDelButton.Alignment = ToolStripItemAlignment.Right;
            toolStripDelButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDelButton.Image = (Image)resources.GetObject("toolStripDelButton.Image");
            toolStripDelButton.ImageTransparentColor = Color.Magenta;
            toolStripDelButton.Name = "toolStripDelButton";
            toolStripDelButton.Size = new Size(23, 21);
            toolStripDelButton.Text = "toolStripDelButton";
            toolStripDelButton.ToolTipText = "Delete";
            // 
            // toolStripAddButton
            // 
            toolStripAddButton.Alignment = ToolStripItemAlignment.Right;
            toolStripAddButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripAddButton.Image = (Image)resources.GetObject("toolStripAddButton.Image");
            toolStripAddButton.ImageTransparentColor = Color.Magenta;
            toolStripAddButton.Name = "toolStripAddButton";
            toolStripAddButton.RightToLeftAutoMirrorImage = true;
            toolStripAddButton.Size = new Size(23, 21);
            toolStripAddButton.Text = "toolStripAddButton";
            toolStripAddButton.ToolTipText = "Add";
            // 
            // toolStripEditButton
            // 
            toolStripEditButton.Alignment = ToolStripItemAlignment.Right;
            toolStripEditButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripEditButton.Image = (Image)resources.GetObject("toolStripEditButton.Image");
            toolStripEditButton.ImageTransparentColor = Color.Magenta;
            toolStripEditButton.Name = "toolStripEditButton";
            toolStripEditButton.Size = new Size(23, 21);
            toolStripEditButton.Text = "toolStripEditButton";
            toolStripEditButton.ToolTipText = "Edit";
            // 
            // VisitorPBUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            Name = "VisitorPBUserControl";
            Size = new Size(686, 463);
            ((System.ComponentModel.ISupportInitialize)VisitorGridViewPBControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visitorUploadVisitorBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private DataGridView VisitorGridViewPBControl;
        private DataGridViewTextBoxColumn visitorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IdType;
        private DataGridViewTextBoxColumn IdNo;
        private DataGridViewTextBoxColumn colCategories;
        private DataGridViewTextBoxColumn colPhoto;
        private DataGridViewTextBoxColumn blackListDataGridViewTextBoxColumn;
        private BindingSource visitorBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox visitorUploadVisitorBox;
        private PictureBox visitorPictureBox;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripDelButton;
        private ToolStripButton toolStripAddButton;
        private ToolStripButton toolStripEditButton;
    }
}
