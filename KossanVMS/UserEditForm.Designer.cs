namespace KossanVMS
{
    partial class UserEditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
            visitorBindingSource1 = new BindingSource(components);
            visitorBindingSource = new BindingSource(components);
            panel1 = new Panel();
            VisitorGridView = new DataGridView();
            visitorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            Photo = new DataGridViewTextBoxColumn();
            BlackList = new DataGridViewTextBoxColumn();
            parrotToolStrip1 = new ReaLTaiizor.Controls.ParrotToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisitorGridView).BeginInit();
            parrotToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // visitorBindingSource1
            // 
            visitorBindingSource1.DataSource = typeof(Data.Visitor);
            // 
            // visitorBindingSource
            // 
            visitorBindingSource.DataSource = typeof(Data.Visitor);
            // 
            // panel1
            // 
            panel1.Controls.Add(VisitorGridView);
            panel1.Controls.Add(parrotToolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 450);
            panel1.TabIndex = 1;
            // 
            // VisitorGridView
            // 
            VisitorGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VisitorGridView.AutoGenerateColumns = false;
            VisitorGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisitorGridView.BackgroundColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            VisitorGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            VisitorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitorGridView.Columns.AddRange(new DataGridViewColumn[] { visitorIDDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, Contact, Company, Photo, BlackList });
            VisitorGridView.DataSource = visitorBindingSource1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            VisitorGridView.DefaultCellStyle = dataGridViewCellStyle2;
            VisitorGridView.Location = new Point(0, 25);
            VisitorGridView.Name = "VisitorGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionBackColor = Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            VisitorGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            VisitorGridView.RowTemplate.Height = 25;
            VisitorGridView.Size = new Size(830, 425);
            VisitorGridView.TabIndex = 3;
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
            // Contact
            // 
            Contact.DataPropertyName = "Contact";
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            // 
            // Company
            // 
            Company.DataPropertyName = "Company";
            Company.HeaderText = "Company";
            Company.Name = "Company";
            // 
            // Photo
            // 
            Photo.DataPropertyName = "Photo";
            Photo.HeaderText = "Photo";
            Photo.Name = "Photo";
            // 
            // BlackList
            // 
            BlackList.DataPropertyName = "BlackList";
            BlackList.HeaderText = "BlackList";
            BlackList.Name = "BlackList";
            // 
            // parrotToolStrip1
            // 
            parrotToolStrip1.BackColor = Color.White;
            parrotToolStrip1.BorderColor = Color.DodgerBlue;
            parrotToolStrip1.ForeColor = Color.Black;
            parrotToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            parrotToolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton3, toolStripButton1 });
            parrotToolStrip1.Location = new Point(0, 0);
            parrotToolStrip1.Name = "parrotToolStrip1";
            parrotToolStrip1.Size = new Size(830, 25);
            parrotToolStrip1.TabIndex = 2;
            parrotToolStrip1.Text = "parrotToolStrip1";
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
            // 
            // UserEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(830, 450);
            Controls.Add(panel1);
            Name = "UserEditForm";
            Text = "UserEditForm";
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VisitorGridView).EndInit();
            parrotToolStrip1.ResumeLayout(false);
            parrotToolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource visitorBindingSource;
        private DataGridViewTextBoxColumn iCNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companiesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitorBlackListDataGridViewTextBoxColumn;
        private BindingSource visitorBindingSource1;
        private Panel panel1;
        private DataGridView VisitorGridView;
        private DataGridViewTextBoxColumn visitorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Photo;
        private DataGridViewTextBoxColumn BlackList;
        private ReaLTaiizor.Controls.ParrotToolStrip parrotToolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton1;
    }
}