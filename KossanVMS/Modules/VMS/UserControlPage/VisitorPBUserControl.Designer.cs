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
            VisitorGridViewPBControl = new DataGridView();
            VisitorNo = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IdType = new DataGridViewTextBoxColumn();
            IdNo = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colPhoto = new DataGridViewTextBoxColumn();
            colCategories = new DataGridViewTextBoxColumn();
            visitorBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            visitorUploadPictureBox = new PictureBox();
            visitorPictureBox = new PictureBox();
            toolStrip2 = new ToolStrip();
            toolStripDelButton = new ToolStripButton();
            toolStripAddButton = new ToolStripButton();
            toolStripEditButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)VisitorGridViewPBControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitorUploadPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // VisitorGridViewPBControl
            // 
            VisitorGridViewPBControl.AutoGenerateColumns = false;
            VisitorGridViewPBControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisitorGridViewPBControl.BackgroundColor = Color.LightGray;
            VisitorGridViewPBControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitorGridViewPBControl.Columns.AddRange(new DataGridViewColumn[] { VisitorNo, fullNameDataGridViewTextBoxColumn, IdType, IdNo, colContact, colPhoto, colCategories });
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
            VisitorGridViewPBControl.Location = new Point(277, 28);
            VisitorGridViewPBControl.MultiSelect = false;
            VisitorGridViewPBControl.Name = "VisitorGridViewPBControl";
            VisitorGridViewPBControl.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            tableLayoutPanel1.SetRowSpan(VisitorGridViewPBControl, 2);
            VisitorGridViewPBControl.RowTemplate.Height = 25;
            VisitorGridViewPBControl.Size = new Size(792, 432);
            VisitorGridViewPBControl.TabIndex = 0;
            VisitorGridViewPBControl.CellFormatting += VisitorGridViewPBControl_CellFormatting;
            VisitorGridViewPBControl.SelectionChanged += VisitorGridViewPBControl_SelectionChanged;
            // 
            // VisitorNo
            // 
            VisitorNo.DataPropertyName = "VisitorNo";
            VisitorNo.HeaderText = "Visitor No";
            VisitorNo.Name = "VisitorNo";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // IdType
            // 
            IdType.DataPropertyName = "IdType";
            IdType.HeaderText = "Id Type";
            IdType.Name = "IdType";
            // 
            // IdNo
            // 
            IdNo.DataPropertyName = "IdNo";
            IdNo.HeaderText = "Id No";
            IdNo.Name = "IdNo";
            // 
            // colContact
            // 
            colContact.HeaderText = "Contact";
            colContact.Name = "colContact";
            // 
            // colPhoto
            // 
            colPhoto.HeaderText = "Capture Photo Path";
            colPhoto.Name = "colPhoto";
            // 
            // colCategories
            // 
            colCategories.DataPropertyName = "VisitorCategories";
            colCategories.HeaderText = "Categories";
            colCategories.Name = "colCategories";
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
            tableLayoutPanel1.Controls.Add(visitorUploadPictureBox, 0, 2);
            tableLayoutPanel1.Controls.Add(visitorPictureBox, 0, 1);
            tableLayoutPanel1.Controls.Add(toolStrip2, 0, 0);
            tableLayoutPanel1.Controls.Add(VisitorGridViewPBControl, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.56438732F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.217804F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.217804F));
            tableLayoutPanel1.Size = new Size(1072, 463);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // visitorUploadPictureBox
            // 
            visitorUploadPictureBox.BackColor = Color.Black;
            visitorUploadPictureBox.Cursor = Cursors.IBeam;
            visitorUploadPictureBox.Dock = DockStyle.Fill;
            visitorUploadPictureBox.Image = (Image)resources.GetObject("visitorUploadPictureBox.Image");
            visitorUploadPictureBox.InitialImage = (Image)resources.GetObject("visitorUploadPictureBox.InitialImage");
            visitorUploadPictureBox.Location = new Point(10, 253);
            visitorUploadPictureBox.Margin = new Padding(10);
            visitorUploadPictureBox.Name = "visitorUploadPictureBox";
            visitorUploadPictureBox.Size = new Size(254, 200);
            visitorUploadPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            visitorUploadPictureBox.TabIndex = 5;
            visitorUploadPictureBox.TabStop = false;
            // 
            // visitorPictureBox
            // 
            visitorPictureBox.BackColor = Color.Black;
            visitorPictureBox.Cursor = Cursors.IBeam;
            visitorPictureBox.Dock = DockStyle.Fill;
            visitorPictureBox.Image = (Image)resources.GetObject("visitorPictureBox.Image");
            visitorPictureBox.InitialImage = (Image)resources.GetObject("visitorPictureBox.InitialImage");
            visitorPictureBox.Location = new Point(10, 35);
            visitorPictureBox.Margin = new Padding(10);
            visitorPictureBox.Name = "visitorPictureBox";
            visitorPictureBox.Size = new Size(254, 198);
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
            toolStrip2.Size = new Size(1072, 25);
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
            toolStripDelButton.Size = new Size(23, 22);
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
            toolStripAddButton.Size = new Size(23, 22);
            toolStripAddButton.Text = "toolStripAddButton";
            toolStripAddButton.ToolTipText = "Add";
            toolStripAddButton.Click += toolStripAddButton_Click;
            // 
            // toolStripEditButton
            // 
            toolStripEditButton.Alignment = ToolStripItemAlignment.Right;
            toolStripEditButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripEditButton.Image = (Image)resources.GetObject("toolStripEditButton.Image");
            toolStripEditButton.ImageTransparentColor = Color.Magenta;
            toolStripEditButton.Name = "toolStripEditButton";
            toolStripEditButton.Size = new Size(23, 22);
            toolStripEditButton.Text = "toolStripEditButton";
            toolStripEditButton.ToolTipText = "Edit";
            toolStripEditButton.Click += toolStripEditButton_Click;
            // 
            // VisitorPBUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "VisitorPBUserControl";
            Size = new Size(1072, 463);
            ((System.ComponentModel.ISupportInitialize)VisitorGridViewPBControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visitorUploadPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView VisitorGridViewPBControl;
        private DataGridViewTextBoxColumn visitorIDDataGridViewTextBoxColumn;
        private BindingSource visitorBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox visitorUploadPictureBox;
        private PictureBox visitorPictureBox;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripDelButton;
        private ToolStripButton toolStripAddButton;
        private ToolStripButton toolStripEditButton;
        private DataGridViewTextBoxColumn VisitorNo;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IdType;
        private DataGridViewTextBoxColumn IdNo;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colPhoto;
        private DataGridViewTextBoxColumn colCategories;
    }
}
