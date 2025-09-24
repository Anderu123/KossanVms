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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            toolStripDelButton = new ToolStripButton();
            toolStripAddButton = new ToolStripButton();
            toolStripEditButton = new ToolStripButton();
            VisitorGridViewUserControl = new DataGridView();
            visitorBindingSource = new BindingSource(components);
            visitorPictureBox = new PictureBox();
            visitorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            companyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            photoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            blackListDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisitorGridViewUserControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.61728F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.38272F));
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(VisitorGridViewUserControl, 1, 1);
            tableLayoutPanel1.Controls.Add(visitorPictureBox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.30303F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94.69697F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(972, 515);
            tableLayoutPanel1.TabIndex = 0;
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
            VisitorGridViewUserControl.BackgroundColor = SystemColors.ActiveCaptionText;
            VisitorGridViewUserControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitorGridViewUserControl.Columns.AddRange(new DataGridViewColumn[] { visitorIDDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, contactDataGridViewTextBoxColumn, companyDataGridViewTextBoxColumn, photoDataGridViewTextBoxColumn, blackListDataGridViewTextBoxColumn });
            VisitorGridViewUserControl.DataSource = visitorBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 44, 61);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            VisitorGridViewUserControl.DefaultCellStyle = dataGridViewCellStyle1;
            VisitorGridViewUserControl.Dock = DockStyle.Fill;
            VisitorGridViewUserControl.EditMode = DataGridViewEditMode.EditProgrammatically;
            VisitorGridViewUserControl.Location = new Point(251, 30);
            VisitorGridViewUserControl.MultiSelect = false;
            VisitorGridViewUserControl.Name = "VisitorGridViewUserControl";
            VisitorGridViewUserControl.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            VisitorGridViewUserControl.RowTemplate.Height = 25;
            VisitorGridViewUserControl.Size = new Size(718, 482);
            VisitorGridViewUserControl.TabIndex = 0;
            // 
            // visitorBindingSource
            // 
            visitorBindingSource.DataSource = typeof(Data.Visitor);
            // 
            // visitorPictureBox
            // 
            visitorPictureBox.Cursor = Cursors.IBeam;
            visitorPictureBox.Dock = DockStyle.Top;
            visitorPictureBox.Image = (Image)resources.GetObject("visitorPictureBox.Image");
            visitorPictureBox.InitialImage = (Image)resources.GetObject("visitorPictureBox.InitialImage");
            visitorPictureBox.Location = new Point(3, 30);
            visitorPictureBox.Name = "visitorPictureBox";
            visitorPictureBox.Size = new Size(242, 332);
            visitorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            visitorPictureBox.TabIndex = 1;
            visitorPictureBox.TabStop = false;
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
            // contactDataGridViewTextBoxColumn
            // 
            contactDataGridViewTextBoxColumn.DataPropertyName = "Contact.Tel.ToString()";
            contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            companyDataGridViewTextBoxColumn.HeaderText = "Company";
            companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // blackListDataGridViewTextBoxColumn
            // 
            blackListDataGridViewTextBoxColumn.DataPropertyName = "BlackList";
            blackListDataGridViewTextBoxColumn.HeaderText = "BlackList";
            blackListDataGridViewTextBoxColumn.Name = "blackListDataGridViewTextBoxColumn";
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
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VisitorGridViewUserControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView VisitorGridViewUserControl;
        private BindingSource visitorBindingSource;
        private PictureBox visitorPictureBox;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripEditButton;
        private ToolStripButton toolStripAddButton;
        private ToolStripButton toolStripDelButton;
        private DataGridViewTextBoxColumn visitorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn blackListDataGridViewTextBoxColumn;
    }
}
