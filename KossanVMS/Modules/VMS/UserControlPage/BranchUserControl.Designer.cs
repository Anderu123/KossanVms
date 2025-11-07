using ReaLTaiizor.Controls;

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
                _db?.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchUserControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripEditButton = new ToolStripButton();
            toolStripAddButton = new ToolStripButton();
            BranchGridViewUserControl = new DataGridView();
            BranchName = new DataGridViewTextBoxColumn();
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
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BranchGridViewUserControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitBranchBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vmsUserBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripEditButton, toolStripAddButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(768, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripDelButton";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripEditButton
            // 
            toolStripEditButton.Alignment = ToolStripItemAlignment.Right;
            toolStripEditButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripEditButton.Image = (Image)resources.GetObject("toolStripEditButton.Image");
            toolStripEditButton.ImageTransparentColor = Color.Magenta;
            toolStripEditButton.Name = "toolStripEditButton";
            toolStripEditButton.Size = new Size(23, 22);
            toolStripEditButton.Text = "toolStripButton2";
            toolStripEditButton.Click += toolStripEditButton_Click;
            // 
            // toolStripAddButton
            // 
            toolStripAddButton.Alignment = ToolStripItemAlignment.Right;
            toolStripAddButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripAddButton.Image = (Image)resources.GetObject("toolStripAddButton.Image");
            toolStripAddButton.ImageTransparentColor = Color.Magenta;
            toolStripAddButton.Name = "toolStripAddButton";
            toolStripAddButton.Size = new Size(23, 22);
            toolStripAddButton.Text = "toolStripButton2";
            toolStripAddButton.Click += toolStripAddButton_Click;
            // 
            // BranchGridViewUserControl
            // 
            BranchGridViewUserControl.AllowUserToAddRows = false;
            BranchGridViewUserControl.AllowUserToDeleteRows = false;
            BranchGridViewUserControl.AutoGenerateColumns = false;
            BranchGridViewUserControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BranchGridViewUserControl.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BranchGridViewUserControl.BorderStyle = BorderStyle.None;
            BranchGridViewUserControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BranchGridViewUserControl.Columns.AddRange(new DataGridViewColumn[] { BranchName, BranchDescription, BranchStatus, createdByDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, updatedByDataGridViewTextBoxColumn, updatedDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            BranchGridViewUserControl.DataSource = visitBranchBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            BranchGridViewUserControl.DefaultCellStyle = dataGridViewCellStyle1;
            BranchGridViewUserControl.Dock = DockStyle.Fill;
            BranchGridViewUserControl.Location = new Point(0, 25);
            BranchGridViewUserControl.Name = "BranchGridViewUserControl";
            BranchGridViewUserControl.RowTemplate.Height = 25;
            BranchGridViewUserControl.Size = new Size(768, 432);
            BranchGridViewUserControl.TabIndex = 1;
            // 
            // BranchName
            // 
            BranchName.DataPropertyName = "BranchName";
            BranchName.HeaderText = "BranchName";
            BranchName.Name = "BranchName";
            BranchName.Width = 101;
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
            visitBranchBindingSource.DataSource = typeof(Data.Branch);
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
            AutoSize = true;
            Controls.Add(BranchGridViewUserControl);
            Controls.Add(toolStrip1);
            Name = "BranchUserControl";
            Size = new Size(768, 457);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BranchGridViewUserControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitBranchBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vmsUserBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private DataGridView BranchGridViewUserControl;
        private BindingSource visitBranchBindingSource;
        private BindingSource visitorBindingSource;
        private BindingSource vmsUserBindingSource;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripEditButton;
        private ToolStripButton toolStripAddButton;

        private void 
            _Enter(object sender, EventArgs e)
        {
            CyberButton clickedButton = sender as CyberButton;
            if (clickedButton != null)
            {
                clickedButton.ColorBackground_Pen = Color.PaleTurquoise;
                clickedButton.ColorBackground = Color.White;
                clickedButton.Invalidate();
            }
        }
        private void buttonUpdate_Leave(object sender, EventArgs e)
        {
            CyberButton clickedButton = sender as CyberButton;
            if(clickedButton != null)
            {
                clickedButton.ColorBackground_Pen = Color.PaleTurquoise;
                clickedButton.ColorBackground = Color.LightGray ;
            }
        }
        private void textBoxUpdate_Enter(object sender, EventArgs e)
        {
            CyberTextBox clickedTextBox = sender as CyberTextBox;
            if(clickedTextBox != null)
            {
                clickedTextBox.ColorBackground_Pen = Color.Turquoise;
                clickedTextBox.ColorBackground = Color.White;
                clickedTextBox.Invalidate();

            }
        }

        private void textBoxUpdate_Leave(object sender, EventArgs e)
        {
            CyberTextBox clickedTextBox = sender as CyberTextBox ;
            if(clickedTextBox != null)
            {
                clickedTextBox.ColorBackground_Pen = Color.Turquoise;
                clickedTextBox.ColorBackground = Color.White;
                clickedTextBox.Invalidate();

            }
        }
        private DataGridViewTextBoxColumn BranchName;
        private DataGridViewTextBoxColumn BranchDescription;
        private DataGridViewCheckBoxColumn BranchStatus;
        private DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
