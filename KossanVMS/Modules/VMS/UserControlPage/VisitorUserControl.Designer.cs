using System.Windows.Forms;

namespace KossanVMS.UserControlPage
{
    partial class VisitorUserControl
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
            
            _db?.Dispose();
           
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorUserControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            visitorUploadPictureBox = new PictureBox();
            visitorPictureBox = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripDelButton = new ToolStripButton();
            toolStripAddButton = new ToolStripButton();
            toolStripEditButton = new ToolStripButton();
            VisitorGridViewUserControl = new DataGridView();
            visitorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IdType = new DataGridViewTextBoxColumn();
            IdNo = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colCategories = new DataGridViewTextBoxColumn();
            colPhoto = new DataGridViewTextBoxColumn();
            visitorBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitorUploadPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisitorGridViewUserControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.61728F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.38272F));
            tableLayoutPanel1.Controls.Add(visitorUploadPictureBox, 0, 2);
            tableLayoutPanel1.Controls.Add(visitorPictureBox, 0, 1);
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(VisitorGridViewUserControl, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.56438732F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.217804F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.217804F));
            tableLayoutPanel1.Size = new Size(972, 515);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // visitorUploadPictureBox
            // 
            visitorUploadPictureBox.BackColor = Color.Black;
            visitorUploadPictureBox.Cursor = Cursors.IBeam;
            visitorUploadPictureBox.Dock = DockStyle.Fill;
            visitorUploadPictureBox.Image = (Image)resources.GetObject("visitorUploadPictureBox.Image");
            visitorUploadPictureBox.InitialImage = (Image)resources.GetObject("visitorUploadPictureBox.InitialImage");
            visitorUploadPictureBox.Location = new Point(10, 281);
            visitorUploadPictureBox.Margin = new Padding(10);
            visitorUploadPictureBox.Name = "visitorUploadPictureBox";
            visitorUploadPictureBox.Size = new Size(228, 224);
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
            visitorPictureBox.Location = new Point(10, 38);
            visitorPictureBox.Margin = new Padding(10);
            visitorPictureBox.Name = "visitorPictureBox";
            visitorPictureBox.Size = new Size(228, 223);
            visitorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            visitorPictureBox.TabIndex = 4;
            visitorPictureBox.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.MenuBar;
            tableLayoutPanel1.SetColumnSpan(toolStrip1, 2);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDelButton, toolStripAddButton, toolStripEditButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(972, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
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
            toolStripDelButton.Click += toolStripDelButton_Click;
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
            // VisitorGridViewUserControl
            // 
            VisitorGridViewUserControl.AutoGenerateColumns = false;
            VisitorGridViewUserControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisitorGridViewUserControl.BackgroundColor = Color.LightGray;
            VisitorGridViewUserControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitorGridViewUserControl.Columns.AddRange(new DataGridViewColumn[] { visitorIDDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, IdType, IdNo, colContact, colCategories, colPhoto });
            VisitorGridViewUserControl.DataSource = visitorBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            VisitorGridViewUserControl.DefaultCellStyle = dataGridViewCellStyle1;
            VisitorGridViewUserControl.Dock = DockStyle.Fill;
            VisitorGridViewUserControl.EditMode = DataGridViewEditMode.EditProgrammatically;
            VisitorGridViewUserControl.Location = new Point(251, 31);
            VisitorGridViewUserControl.MultiSelect = false;
            VisitorGridViewUserControl.Name = "VisitorGridViewUserControl";
            VisitorGridViewUserControl.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            tableLayoutPanel1.SetRowSpan(VisitorGridViewUserControl, 2);
            VisitorGridViewUserControl.RowTemplate.Height = 25;
            VisitorGridViewUserControl.Size = new Size(718, 481);
            VisitorGridViewUserControl.TabIndex = 0;
            VisitorGridViewUserControl.CellContentClick += VisitorGridViewUserControl_CellContentClick;
            VisitorGridViewUserControl.CellFormatting += VisitorGridViewUserControl_CellFormatting;
            VisitorGridViewUserControl.SelectionChanged += VisitorGridViewUserControl_SelectionChanged;
            // 
            // visitorIDDataGridViewTextBoxColumn
            // 
            visitorIDDataGridViewTextBoxColumn.DataPropertyName = "VisitorNo";
            visitorIDDataGridViewTextBoxColumn.HeaderText = "VisitorNo";
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
            // colContact
            // 
            colContact.HeaderText = "Contact";
            colContact.Name = "colContact";
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
            // visitorBindingSource
            // 
            visitorBindingSource.DataSource = typeof(Data.Visitor);
            // 
            // VisitorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "VisitorUserControl";
            Size = new Size(972, 515);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visitorUploadPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VisitorGridViewUserControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView VisitorGridViewUserControl;
        private BindingSource visitorBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripEditButton;
        private ToolStripButton toolStripAddButton;
        private ToolStripButton toolStripDelButton;
        private DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private PictureBox visitorPictureBox;
        private PictureBox visitorUploadPictureBox;
        private DataGridViewTextBoxColumn visitorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IdType;
        private DataGridViewTextBoxColumn IdNo;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colCategories;
        private DataGridViewTextBoxColumn colPhoto;
    }
}
