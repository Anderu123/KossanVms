namespace KossanVMS.Modules.VMS.UserControlPage
{
    partial class PurposeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurposeUserControl));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripEditButton = new ToolStripButton();
            toolStripAddButton = new ToolStripButton();
            PurposeGridViewUserControl = new DataGridView();
            purposeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            purposeDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            purposeBindingSource = new BindingSource(components);
            purposeBindingSource1 = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PurposeGridViewUserControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)purposeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)purposeBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripEditButton, toolStripAddButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(747, 25);
            toolStrip1.TabIndex = 1;
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
            toolStripButton1.Click += toolStripDelButton_Click;
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
            // PurposeGridViewUserControl
            // 
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurposeUserControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            PurposeGridViewUserControl.AllowUserToAddRows = false;
            PurposeGridViewUserControl.AllowUserToDeleteRows = false;
            PurposeGridViewUserControl.AutoGenerateColumns = false;
            PurposeGridViewUserControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PurposeGridViewUserControl.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            PurposeGridViewUserControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PurposeGridViewUserControl.Columns.AddRange(new DataGridViewColumn[] { purposeNameDataGridViewTextBoxColumn, purposeDescriptionDataGridViewTextBoxColumn, Status, CreatedBy, CreatedDate });
            PurposeGridViewUserControl.DataSource = purposeBindingSource1;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            PurposeGridViewUserControl.DefaultCellStyle = dataGridViewCellStyle1;

            PurposeGridViewUserControl.Dock = DockStyle.Fill;
            PurposeGridViewUserControl.Location = new Point(0, 25);
            PurposeGridViewUserControl.Name = "PurposeGridViewUserControl";
            PurposeGridViewUserControl.ReadOnly = true;
            PurposeGridViewUserControl.RowTemplate.Height = 25;
            PurposeGridViewUserControl.Size = new Size(747, 418);
            PurposeGridViewUserControl.TabIndex = 2;
            // 
            // purposeNameDataGridViewTextBoxColumn
            // 
            purposeNameDataGridViewTextBoxColumn.DataPropertyName = "PurposeName";
            purposeNameDataGridViewTextBoxColumn.HeaderText = "Name";
            purposeNameDataGridViewTextBoxColumn.Name = "purposeNameDataGridViewTextBoxColumn";
            purposeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purposeDescriptionDataGridViewTextBoxColumn
            // 
            purposeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PurposeDescription";
            purposeDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            purposeDescriptionDataGridViewTextBoxColumn.Name = "purposeDescriptionDataGridViewTextBoxColumn";
            purposeDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "PurposeStatus";
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
            // purposeBindingSource
            // 
            purposeBindingSource.DataSource = typeof(Data.Purpose);
            // 
            // purposeBindingSource1
            // 
            purposeBindingSource1.DataSource = typeof(Data.Purpose);
            // 
            // PurposeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PurposeGridViewUserControl);
            Controls.Add(toolStrip1);
            Name = "PurposeUserControl";
            Size = new Size(747, 443);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PurposeGridViewUserControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)purposeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)purposeBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripEditButton;
        private ToolStripButton toolStripAddButton;
        private DataGridView PurposeGridViewUserControl;
        private DataGridViewCheckBoxColumn purposeStatusDataGridViewCheckBoxColumn;
        private BindingSource purposeBindingSource;
        private DataGridViewTextBoxColumn purposeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purposeDescriptionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn CreatedBy;
        private DataGridViewTextBoxColumn CreatedDate;
        private BindingSource purposeBindingSource1;
    }
}
