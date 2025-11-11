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
            
            //_db?.Dispose();
           
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
            visitorBindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            visitorUploadPictureBox = new PictureBox();
            panel1 = new Panel();
            visitorPictureBox = new PictureBox();
            VisitorGridViewUserControl = new DataGridView();
            VisitorFullName = new DataGridViewTextBoxColumn();
            VisitorBranches = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            VisitorCategories = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            UpdatedBy = new DataGridViewTextBoxColumn();
            UpdatedDate = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            visitorNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorIdTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorIdNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorFullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorExpiryDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorBlackListDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            visitorVehicleNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorContactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorPhotoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorPurposeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorCategoriesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorBranchesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitRecordsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitorUploadPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VisitorGridViewUserControl).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // visitorBindingSource1
            // 
            //visitorBindingSource1.DataSource = typeof(Data.Visitor);
            // 
            // panel2
            // 
            panel2.Controls.Add(visitorUploadPictureBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 542);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 479);
            panel2.TabIndex = 7;
            // 
            // visitorUploadPictureBox
            // 
            visitorUploadPictureBox.BackColor = Color.Black;
            visitorUploadPictureBox.Cursor = Cursors.IBeam;
            visitorUploadPictureBox.Dock = DockStyle.Fill;
            visitorUploadPictureBox.Image = (Image)resources.GetObject("visitorUploadPictureBox.Image");
            visitorUploadPictureBox.InitialImage = (Image)resources.GetObject("visitorUploadPictureBox.InitialImage");
            visitorUploadPictureBox.Location = new Point(0, 0);
            visitorUploadPictureBox.Margin = new Padding(10);
            visitorUploadPictureBox.Name = "visitorUploadPictureBox";
            visitorUploadPictureBox.Size = new Size(221, 479);
            visitorUploadPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            visitorUploadPictureBox.TabIndex = 6;
            visitorUploadPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(visitorPictureBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 506);
            panel1.TabIndex = 6;
            // 
            // visitorPictureBox
            // 
            visitorPictureBox.BackColor = Color.Black;
            visitorPictureBox.Cursor = Cursors.IBeam;
            visitorPictureBox.Dock = DockStyle.Fill;
            visitorPictureBox.Image = (Image)resources.GetObject("visitorPictureBox.Image");
            visitorPictureBox.InitialImage = (Image)resources.GetObject("visitorPictureBox.InitialImage");
            visitorPictureBox.Location = new Point(0, 0);
            visitorPictureBox.Margin = new Padding(10);
            visitorPictureBox.Name = "visitorPictureBox";
            visitorPictureBox.Size = new Size(221, 506);
            visitorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            visitorPictureBox.TabIndex = 5;
            visitorPictureBox.TabStop = false;
            // 
            // VisitorGridViewUserControl
            // 
            VisitorGridViewUserControl.AllowUserToAddRows = false;
            VisitorGridViewUserControl.AllowUserToDeleteRows = false;
            VisitorGridViewUserControl.AutoGenerateColumns = false;
            VisitorGridViewUserControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisitorGridViewUserControl.BackgroundColor = Color.LightGray;
            VisitorGridViewUserControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitorGridViewUserControl.Columns.AddRange(new DataGridViewColumn[] { VisitorFullName, VisitorBranches, colContact, VisitorCategories, Status, CreatedBy, CreatedDate, UpdatedBy, UpdatedDate, visitorNoDataGridViewTextBoxColumn, visitorIdTypeDataGridViewTextBoxColumn, visitorIdNoDataGridViewTextBoxColumn, visitorFullNameDataGridViewTextBoxColumn, visitorExpiryDateDataGridViewTextBoxColumn, visitorBlackListDataGridViewCheckBoxColumn, visitorVehicleNoDataGridViewTextBoxColumn, visitorContactDataGridViewTextBoxColumn, visitorPhotoDataGridViewTextBoxColumn, visitorPurposeDataGridViewTextBoxColumn, visitorCategoriesDataGridViewTextBoxColumn, visitorBranchesDataGridViewTextBoxColumn, visitRecordsDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, createdByDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, updatedByDataGridViewTextBoxColumn, updatedDateDataGridViewTextBoxColumn });
            VisitorGridViewUserControl.DataSource = visitorBindingSource1;
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
            VisitorGridViewUserControl.Location = new Point(230, 30);
            VisitorGridViewUserControl.MultiSelect = false;
            VisitorGridViewUserControl.Name = "VisitorGridViewUserControl";
            VisitorGridViewUserControl.ReadOnly = true;
            VisitorGridViewUserControl.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            tableLayoutPanel1.SetRowSpan(VisitorGridViewUserControl, 2);
            VisitorGridViewUserControl.RowTemplate.Height = 25;
            VisitorGridViewUserControl.Size = new Size(1136, 991);
            VisitorGridViewUserControl.TabIndex = 0;
            VisitorGridViewUserControl.CellContentClick += VisitorGridViewUserControl_CellContentClick;
            VisitorGridViewUserControl.CellFormatting += VisitorGridViewUserControl_CellFormatting;
            VisitorGridViewUserControl.SelectionChanged += VisitorGridViewUserControl_SelectionChanged;
            // 
            // VisitorFullName
            // 
            VisitorFullName.DataPropertyName = "VisitorFullName";
            VisitorFullName.HeaderText = "Full Name";
            VisitorFullName.Name = "VisitorFullName";
            VisitorFullName.ReadOnly = true;
            // 
            // VisitorBranches
            // 
            VisitorBranches.DataPropertyName = "VisitorBranches";
            VisitorBranches.HeaderText = "Branch";
            VisitorBranches.Name = "VisitorBranches";
            VisitorBranches.ReadOnly = true;
            // 
            // colContact
            // 
            colContact.HeaderText = "Contact";
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            // 
            // VisitorCategories
            // 
            VisitorCategories.DataPropertyName = "VisitorCategories";
            VisitorCategories.HeaderText = "Categories";
            VisitorCategories.Name = "VisitorCategories";
            VisitorCategories.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // CreatedBy
            // 
            CreatedBy.DataPropertyName = "CreatedBy";
            CreatedBy.HeaderText = "CreatedBy";
            CreatedBy.Name = "CreatedBy";
            CreatedBy.ReadOnly = true;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "CreatedDate";
            CreatedDate.Name = "CreatedDate";
            CreatedDate.ReadOnly = true;
            // 
            // UpdatedBy
            // 
            UpdatedBy.DataPropertyName = "UpdatedBy";
            UpdatedBy.HeaderText = "UpdatedBy";
            UpdatedBy.Name = "UpdatedBy";
            UpdatedBy.ReadOnly = true;
            // 
            // UpdatedDate
            // 
            UpdatedDate.DataPropertyName = "UpdatedDate";
            UpdatedDate.HeaderText = "UpdatedDate";
            UpdatedDate.Name = "UpdatedDate";
            UpdatedDate.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(37, 52, 68);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6544914F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3455048F));
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(VisitorGridViewUserControl, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.63671875F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.217804F));
            tableLayoutPanel1.Size = new Size(1369, 1024);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            tableLayoutPanel1.SetColumnSpan(toolStrip1, 2);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripButton2, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1369, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripDelButton";
            toolStripButton3.Click += toolStripDelButton_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripEditButton";
            toolStripButton2.Click += toolStripEditButton_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripAddButton";
            toolStripButton1.Click += toolStripAddButton_Click;
            // 
            // visitorNoDataGridViewTextBoxColumn
            // 
            visitorNoDataGridViewTextBoxColumn.DataPropertyName = "VisitorNo";
            visitorNoDataGridViewTextBoxColumn.HeaderText = "VisitorNo";
            visitorNoDataGridViewTextBoxColumn.Name = "visitorNoDataGridViewTextBoxColumn";
            visitorNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorIdTypeDataGridViewTextBoxColumn
            // 
            visitorIdTypeDataGridViewTextBoxColumn.DataPropertyName = "VisitorIdType";
            visitorIdTypeDataGridViewTextBoxColumn.HeaderText = "VisitorIdType";
            visitorIdTypeDataGridViewTextBoxColumn.Name = "visitorIdTypeDataGridViewTextBoxColumn";
            visitorIdTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorIdNoDataGridViewTextBoxColumn
            // 
            visitorIdNoDataGridViewTextBoxColumn.DataPropertyName = "VisitorIdNo";
            visitorIdNoDataGridViewTextBoxColumn.HeaderText = "VisitorIdNo";
            visitorIdNoDataGridViewTextBoxColumn.Name = "visitorIdNoDataGridViewTextBoxColumn";
            visitorIdNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorFullNameDataGridViewTextBoxColumn
            // 
            visitorFullNameDataGridViewTextBoxColumn.DataPropertyName = "VisitorFullName";
            visitorFullNameDataGridViewTextBoxColumn.HeaderText = "VisitorFullName";
            visitorFullNameDataGridViewTextBoxColumn.Name = "visitorFullNameDataGridViewTextBoxColumn";
            visitorFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorExpiryDateDataGridViewTextBoxColumn
            // 
            visitorExpiryDateDataGridViewTextBoxColumn.DataPropertyName = "VisitorExpiryDate";
            visitorExpiryDateDataGridViewTextBoxColumn.HeaderText = "VisitorExpiryDate";
            visitorExpiryDateDataGridViewTextBoxColumn.Name = "visitorExpiryDateDataGridViewTextBoxColumn";
            visitorExpiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorBlackListDataGridViewCheckBoxColumn
            // 
            visitorBlackListDataGridViewCheckBoxColumn.DataPropertyName = "VisitorBlackList";
            visitorBlackListDataGridViewCheckBoxColumn.HeaderText = "VisitorBlackList";
            visitorBlackListDataGridViewCheckBoxColumn.Name = "visitorBlackListDataGridViewCheckBoxColumn";
            visitorBlackListDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // visitorVehicleNoDataGridViewTextBoxColumn
            // 
            visitorVehicleNoDataGridViewTextBoxColumn.DataPropertyName = "VisitorVehicleNo";
            visitorVehicleNoDataGridViewTextBoxColumn.HeaderText = "VisitorVehicleNo";
            visitorVehicleNoDataGridViewTextBoxColumn.Name = "visitorVehicleNoDataGridViewTextBoxColumn";
            visitorVehicleNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorContactDataGridViewTextBoxColumn
            // 
            visitorContactDataGridViewTextBoxColumn.DataPropertyName = "VisitorContact";
            visitorContactDataGridViewTextBoxColumn.HeaderText = "VisitorContact";
            visitorContactDataGridViewTextBoxColumn.Name = "visitorContactDataGridViewTextBoxColumn";
            visitorContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorPhotoDataGridViewTextBoxColumn
            // 
            visitorPhotoDataGridViewTextBoxColumn.DataPropertyName = "VisitorPhoto";
            visitorPhotoDataGridViewTextBoxColumn.HeaderText = "VisitorPhoto";
            visitorPhotoDataGridViewTextBoxColumn.Name = "visitorPhotoDataGridViewTextBoxColumn";
            visitorPhotoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorPurposeDataGridViewTextBoxColumn
            // 
            visitorPurposeDataGridViewTextBoxColumn.DataPropertyName = "VisitorPurpose";
            visitorPurposeDataGridViewTextBoxColumn.HeaderText = "VisitorPurpose";
            visitorPurposeDataGridViewTextBoxColumn.Name = "visitorPurposeDataGridViewTextBoxColumn";
            visitorPurposeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorCategoriesDataGridViewTextBoxColumn
            // 
            visitorCategoriesDataGridViewTextBoxColumn.DataPropertyName = "VisitorCategories";
            visitorCategoriesDataGridViewTextBoxColumn.HeaderText = "VisitorCategories";
            visitorCategoriesDataGridViewTextBoxColumn.Name = "visitorCategoriesDataGridViewTextBoxColumn";
            visitorCategoriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorBranchesDataGridViewTextBoxColumn
            // 
            visitorBranchesDataGridViewTextBoxColumn.DataPropertyName = "VisitorBranches";
            visitorBranchesDataGridViewTextBoxColumn.HeaderText = "VisitorBranches";
            visitorBranchesDataGridViewTextBoxColumn.Name = "visitorBranchesDataGridViewTextBoxColumn";
            visitorBranchesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitRecordsDataGridViewTextBoxColumn
            // 
            visitRecordsDataGridViewTextBoxColumn.DataPropertyName = "VisitRecords";
            visitRecordsDataGridViewTextBoxColumn.HeaderText = "VisitRecords";
            visitRecordsDataGridViewTextBoxColumn.Name = "visitRecordsDataGridViewTextBoxColumn";
            visitRecordsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            createdByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            updatedByDataGridViewTextBoxColumn.HeaderText = "UpdatedBy";
            updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            updatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedDateDataGridViewTextBoxColumn
            // 
            updatedDateDataGridViewTextBoxColumn.DataPropertyName = "UpdatedDate";
            updatedDateDataGridViewTextBoxColumn.HeaderText = "UpdatedDate";
            updatedDateDataGridViewTextBoxColumn.Name = "updatedDateDataGridViewTextBoxColumn";
            updatedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VisitorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "VisitorUserControl";
            Size = new Size(1369, 1024);
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visitorUploadPictureBox).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)VisitorGridViewUserControl).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource visitorBindingSource1;
        private DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private Panel panel2;
        private PictureBox visitorUploadPictureBox;
        private Panel panel1;
        private PictureBox visitorPictureBox;
        private DataGridView VisitorGridViewUserControl;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
        private DataGridViewTextBoxColumn VisitorFullName;
        private DataGridViewTextBoxColumn VisitorBranches;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn VisitorCategories;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn CreatedBy;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn UpdatedBy;
        private DataGridViewTextBoxColumn UpdatedDate;
        private DataGridViewTextBoxColumn visitorNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorIdTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorIdNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorFullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorExpiryDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn visitorBlackListDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn visitorVehicleNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorContactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorPhotoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorPurposeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorCategoriesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorBranchesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitRecordsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
    }
}
