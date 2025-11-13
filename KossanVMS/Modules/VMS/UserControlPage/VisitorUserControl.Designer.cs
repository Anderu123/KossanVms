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
            panel2 = new Panel();
            visitorUploadPictureBox = new PictureBox();
            panel1 = new Panel();
            visitorPictureBox = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            VisitorGridView = new DataGridView();
            visitorBindingSource = new BindingSource(components);
            visitorIdTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorIdNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorFullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorExpiryDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorBlackListDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            visitorVehicleNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorVisitPersonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorRemarksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            visitorPhotoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorPurposeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            visitorBranchesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitRecordsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitorUploadPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisitorGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
            SuspendLayout();
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(37, 52, 68);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6544914F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3455048F));
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Controls.Add(VisitorGridView, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.63671875F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.217804F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            // VisitorGridView
            // 
            VisitorGridView.AllowUserToAddRows = false;
            VisitorGridView.AllowUserToDeleteRows = false;
            VisitorGridView.AutoGenerateColumns = false;
            VisitorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitorGridView.Columns.AddRange(new DataGridViewColumn[] { visitorIdTypeDataGridViewTextBoxColumn, visitorIdNoDataGridViewTextBoxColumn, visitorFullNameDataGridViewTextBoxColumn, visitorExpiryDateDataGridViewTextBoxColumn, visitorBlackListDataGridViewCheckBoxColumn, visitorVehicleNoDataGridViewTextBoxColumn, visitorVisitPersonDataGridViewTextBoxColumn, visitorRemarksDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, visitorPhotoDataGridViewTextBoxColumn, visitorPurposeDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, visitorBranchesDataGridViewTextBoxColumn, visitRecordsDataGridViewTextBoxColumn, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            VisitorGridView.DataSource = visitorBindingSource;
            VisitorGridView.Dock = DockStyle.Fill;
            VisitorGridView.Location = new Point(230, 30);
            VisitorGridView.Name = "VisitorGridView";
            VisitorGridView.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(VisitorGridView, 2);
            VisitorGridView.RowTemplate.Height = 25;
            VisitorGridView.Size = new Size(1136, 991);
            VisitorGridView.TabIndex = 9;
            // 
            // visitorBindingSource
            // 
            visitorBindingSource.DataSource = typeof(Data.Visitor);
            // 
            // visitorIdTypeDataGridViewTextBoxColumn
            // 
            visitorIdTypeDataGridViewTextBoxColumn.DataPropertyName = "VisitorIdType";
            visitorIdTypeDataGridViewTextBoxColumn.HeaderText = "Id Type";
            visitorIdTypeDataGridViewTextBoxColumn.Name = "visitorIdTypeDataGridViewTextBoxColumn";
            visitorIdTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorIdNoDataGridViewTextBoxColumn
            // 
            visitorIdNoDataGridViewTextBoxColumn.DataPropertyName = "VisitorIdNo";
            visitorIdNoDataGridViewTextBoxColumn.HeaderText = "Id No";
            visitorIdNoDataGridViewTextBoxColumn.Name = "visitorIdNoDataGridViewTextBoxColumn";
            visitorIdNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorFullNameDataGridViewTextBoxColumn
            // 
            visitorFullNameDataGridViewTextBoxColumn.DataPropertyName = "VisitorFullName";
            visitorFullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            visitorFullNameDataGridViewTextBoxColumn.Name = "visitorFullNameDataGridViewTextBoxColumn";
            visitorFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorExpiryDateDataGridViewTextBoxColumn
            // 
            visitorExpiryDateDataGridViewTextBoxColumn.DataPropertyName = "VisitorExpiryDate";
            visitorExpiryDateDataGridViewTextBoxColumn.HeaderText = "Expiry Date";
            visitorExpiryDateDataGridViewTextBoxColumn.Name = "visitorExpiryDateDataGridViewTextBoxColumn";
            visitorExpiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorBlackListDataGridViewCheckBoxColumn
            // 
            visitorBlackListDataGridViewCheckBoxColumn.DataPropertyName = "VisitorBlackList";
            visitorBlackListDataGridViewCheckBoxColumn.HeaderText = "Black List";
            visitorBlackListDataGridViewCheckBoxColumn.Name = "visitorBlackListDataGridViewCheckBoxColumn";
            visitorBlackListDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // visitorVehicleNoDataGridViewTextBoxColumn
            // 
            visitorVehicleNoDataGridViewTextBoxColumn.DataPropertyName = "VisitorVehicleNo";
            visitorVehicleNoDataGridViewTextBoxColumn.HeaderText = "Vehicle No";
            visitorVehicleNoDataGridViewTextBoxColumn.Name = "visitorVehicleNoDataGridViewTextBoxColumn";
            visitorVehicleNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorVisitPersonDataGridViewTextBoxColumn
            // 
            visitorVisitPersonDataGridViewTextBoxColumn.DataPropertyName = "VisitorVisitPerson";
            visitorVisitPersonDataGridViewTextBoxColumn.HeaderText = "Visit Person";
            visitorVisitPersonDataGridViewTextBoxColumn.Name = "visitorVisitPersonDataGridViewTextBoxColumn";
            visitorVisitPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorRemarksDataGridViewTextBoxColumn
            // 
            visitorRemarksDataGridViewTextBoxColumn.DataPropertyName = "VisitorRemarks";
            visitorRemarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            visitorRemarksDataGridViewTextBoxColumn.Name = "visitorRemarksDataGridViewTextBoxColumn";
            visitorRemarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "VisitorContact";
            dataGridViewTextBoxColumn1.HeaderText = "Contact";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // visitorPhotoDataGridViewTextBoxColumn
            // 
            visitorPhotoDataGridViewTextBoxColumn.DataPropertyName = "VisitorPhoto";
            visitorPhotoDataGridViewTextBoxColumn.HeaderText = "Photo";
            visitorPhotoDataGridViewTextBoxColumn.Name = "visitorPhotoDataGridViewTextBoxColumn";
            visitorPhotoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorPurposeDataGridViewTextBoxColumn
            // 
            visitorPurposeDataGridViewTextBoxColumn.DataPropertyName = "VisitorPurpose";
            visitorPurposeDataGridViewTextBoxColumn.HeaderText = "Purpose";
            visitorPurposeDataGridViewTextBoxColumn.Name = "visitorPurposeDataGridViewTextBoxColumn";
            visitorPurposeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "VisitorCategories";
            dataGridViewTextBoxColumn2.HeaderText = "Categories";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // visitorBranchesDataGridViewTextBoxColumn
            // 
            visitorBranchesDataGridViewTextBoxColumn.DataPropertyName = "VisitorBranches";
            visitorBranchesDataGridViewTextBoxColumn.HeaderText = "Branches";
            visitorBranchesDataGridViewTextBoxColumn.Name = "visitorBranchesDataGridViewTextBoxColumn";
            visitorBranchesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitRecordsDataGridViewTextBoxColumn
            // 
            visitRecordsDataGridViewTextBoxColumn.DataPropertyName = "VisitRecords";
            visitRecordsDataGridViewTextBoxColumn.HeaderText = "Records";
            visitRecordsDataGridViewTextBoxColumn.Name = "visitRecordsDataGridViewTextBoxColumn";
            visitRecordsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            dataGridViewTextBoxColumn3.HeaderText = "Status";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "CreatedBy";
            dataGridViewTextBoxColumn4.HeaderText = "Created By";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "CreatedDate";
            dataGridViewTextBoxColumn5.HeaderText = "Created Date";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "UpdatedBy";
            dataGridViewTextBoxColumn6.HeaderText = "Updated By";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "UpdatedDate";
            dataGridViewTextBoxColumn7.HeaderText = "Updated Date";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // VisitorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "VisitorUserControl";
            Size = new Size(1369, 1024);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visitorUploadPictureBox).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VisitorGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource visitorBindingSource1;
        private Panel panel2;
        private PictureBox visitorUploadPictureBox;
        private Panel panel1;
        private PictureBox visitorPictureBox;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private BindingSource visitorBindingSource;
        private DataGridViewTextBoxColumn visitorContactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorCategoriesDataGridViewTextBoxColumn;
        private DataGridView VisitorGridView;
        private DataGridViewTextBoxColumn visitorIdTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorIdNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorFullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorExpiryDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn visitorBlackListDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn visitorVehicleNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorVisitPersonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorRemarksDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn visitorPhotoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorPurposeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn visitorBranchesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitRecordsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}