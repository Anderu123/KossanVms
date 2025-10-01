namespace KossanVMS.UserControlPage
{
    partial class BranchUserControl
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
            toolStrip1 = new ToolStrip();
            BranchGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            BranchDescription = new DataGridViewTextBoxColumn();
            BranchStatus = new DataGridViewCheckBoxColumn();
            createdByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitBranchBindingSource = new BindingSource(components);
            visitorBindingSource = new BindingSource(components);
            vmsUserBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)BranchGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitBranchBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vmsUserBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(770, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // BranchGridView
            // 
            BranchGridView.AutoGenerateColumns = false;
            BranchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BranchGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BranchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BranchGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, BranchDescription, BranchStatus, createdByDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, updatedByDataGridViewTextBoxColumn, updatedDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            BranchGridView.DataSource = visitBranchBindingSource;
            BranchGridView.Dock = DockStyle.Fill;
            BranchGridView.Location = new Point(0, 25);
            BranchGridView.Name = "BranchGridView";
            BranchGridView.RowTemplate.Height = 25;
            BranchGridView.Size = new Size(770, 365);
            BranchGridView.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BranchID";
            Column1.HeaderText = "BranchID";
            Column1.Name = "Column1";
            Column1.Width = 80;
            // 
            // BranchDescription
            // 
            BranchDescription.DataPropertyName = "BranchDescription";
            BranchDescription.HeaderText = "BranchDescription";
            BranchDescription.Name = "BranchDescription";
            BranchDescription.Width = 129;
            // 
            // BranchStatus
            // 
            BranchStatus.DataPropertyName = "BranchStatus";
            BranchStatus.HeaderText = "BranchStatus";
            BranchStatus.Name = "BranchStatus";
            BranchStatus.Width = 82;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            createdByDataGridViewTextBoxColumn.Width = 86;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.Width = 97;
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            updatedByDataGridViewTextBoxColumn.HeaderText = "UpdatedBy";
            updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            updatedByDataGridViewTextBoxColumn.Width = 90;
            // 
            // updatedDateDataGridViewTextBoxColumn
            // 
            updatedDateDataGridViewTextBoxColumn.DataPropertyName = "UpdatedDate";
            updatedDateDataGridViewTextBoxColumn.HeaderText = "UpdatedDate";
            updatedDateDataGridViewTextBoxColumn.Name = "updatedDateDataGridViewTextBoxColumn";
            updatedDateDataGridViewTextBoxColumn.Width = 101;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 64;
            // 
            // visitBranchBindingSource
            // 
            visitBranchBindingSource.DataSource = typeof(Data.VisitBranch);
            // 
            // visitorBindingSource
            // 
            visitorBindingSource.DataSource = typeof(Data.Visitor);
            // 
            // vmsUserBindingSource
            // 
            vmsUserBindingSource.DataSource = typeof(Data.VmsUser);
            // 
            // BranchUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BranchGridView);
            Controls.Add(toolStrip1);
            Name = "BranchUserControl";
            Size = new Size(770, 390);
            ((System.ComponentModel.ISupportInitialize)BranchGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitBranchBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vmsUserBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private DataGridView BranchGridView;
        private BindingSource visitBranchBindingSource;
        private BindingSource visitorBindingSource;
        private BindingSource vmsUserBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn BranchDescription;
        private DataGridViewCheckBoxColumn BranchStatus;
        private DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
