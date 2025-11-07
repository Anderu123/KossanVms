namespace KossanVMS.UserControlPage
{
    partial class CategoryUserControl
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
                _db.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryUserControl));
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            visitorCatUserControlGridView = new DataGridView();
            CategoryName = new DataGridViewTextBoxColumn();
            CategoryDescription = new DataGridViewTextBoxColumn();
            createdByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitCategoryBindingSource = new BindingSource(components);
            visitBranchBindingSource = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitorCatUserControlGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitCategoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitBranchBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton1, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1072, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
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
            toolStripButton2.Click += toolStripDelButton_Click;
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
            toolStripButton1.Click += toolStripEditButton_Click;
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
            toolStripButton3.Click += toolStripAddButton_Click;
            // 
            // visitorCatUserControlGridView
            // 
            visitorCatUserControlGridView.AllowUserToAddRows = false;
            visitorCatUserControlGridView.AutoGenerateColumns = false;
            visitorCatUserControlGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            visitorCatUserControlGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            visitorCatUserControlGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitorCatUserControlGridView.Columns.AddRange(new DataGridViewColumn[] { CategoryName, CategoryDescription, createdByDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, updatedByDataGridViewTextBoxColumn, updatedDateDataGridViewTextBoxColumn });
            visitorCatUserControlGridView.DataSource = visitCategoryBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            visitorCatUserControlGridView.DefaultCellStyle = dataGridViewCellStyle1;
            visitorCatUserControlGridView.Dock = DockStyle.Fill;
            visitorCatUserControlGridView.Location = new Point(0, 25);
            visitorCatUserControlGridView.Name = "visitorCatUserControlGridView";
            visitorCatUserControlGridView.RowTemplate.Height = 25;
            visitorCatUserControlGridView.Size = new Size(1072, 463);
            visitorCatUserControlGridView.TabIndex = 1;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "CategoryName";
            CategoryName.Name = "CategoryName";
            // 
            // CategoryDescription
            // 
            CategoryDescription.DataPropertyName = "CategoryDescription";
            CategoryDescription.HeaderText = "CategoryDescription";
            CategoryDescription.Name = "CategoryDescription";
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            updatedByDataGridViewTextBoxColumn.HeaderText = "UpdatedBy";
            updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            // 
            // updatedDateDataGridViewTextBoxColumn
            // 
            updatedDateDataGridViewTextBoxColumn.DataPropertyName = "UpdatedDate";
            updatedDateDataGridViewTextBoxColumn.HeaderText = "UpdatedDate";
            updatedDateDataGridViewTextBoxColumn.Name = "updatedDateDataGridViewTextBoxColumn";
            // 
            // visitCategoryBindingSource
            // 
            visitCategoryBindingSource.DataSource = typeof(Data.Category);
            // 
            // visitBranchBindingSource
            // 
            visitBranchBindingSource.DataSource = typeof(Data.Branch);
            // 
            // CategoryUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(visitorCatUserControlGridView);
            Controls.Add(toolStrip1);
            Name = "CategoryUserControl";
            Size = new Size(1072, 488);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visitorCatUserControlGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitCategoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitBranchBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton3;
        private DataGridView visitorCatUserControlGridView;
        private BindingSource visitCategoryBindingSource;
        private BindingSource visitBranchBindingSource;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn CategoryDescription;
        private DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
    }
}
