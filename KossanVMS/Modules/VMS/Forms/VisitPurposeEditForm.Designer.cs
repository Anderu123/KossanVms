namespace KossanVMS
{
    partial class VisitPurposeEditForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxPurposeName = new ReaLTaiizor.Controls.CyberTextBox();
            thunderLabel7 = new ReaLTaiizor.Controls.ThunderLabel();
            labelPurposeStatus = new ReaLTaiizor.Controls.ThunderLabel();
            labelPurposeDescription = new ReaLTaiizor.Controls.ThunderLabel();
            labelPurposeName = new ReaLTaiizor.Controls.ThunderLabel();
            textBoxPurposeDescription = new ReaLTaiizor.Controls.CyberTextBox();
            panel1 = new Panel();
            buttonSave = new ReaLTaiizor.Controls.CyberButton();
            buttonCancel = new ReaLTaiizor.Controls.CyberButton();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            rbInactive = new RadioButton();
            rbActive = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.10917F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.89083F));
            tableLayoutPanel1.Controls.Add(textBoxPurposeName, 1, 0);
            tableLayoutPanel1.Controls.Add(thunderLabel7, 0, 3);
            tableLayoutPanel1.Controls.Add(labelPurposeStatus, 0, 2);
            tableLayoutPanel1.Controls.Add(labelPurposeDescription, 0, 1);
            tableLayoutPanel1.Controls.Add(labelPurposeName, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxPurposeDescription, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 3);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(615, 233);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxPurposeName
            // 
            textBoxPurposeName.Alpha = 20;
            textBoxPurposeName.BackColor = Color.Transparent;
            textBoxPurposeName.Background_WidthPen = 6F;
            textBoxPurposeName.BackgroundPen = true;
            textBoxPurposeName.ColorBackground = Color.LightGray;
            textBoxPurposeName.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            textBoxPurposeName.ColorLighting = Color.FromArgb(29, 200, 238);
            textBoxPurposeName.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textBoxPurposeName.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textBoxPurposeName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textBoxPurposeName.Dock = DockStyle.Fill;
            textBoxPurposeName.Font = new Font("Arial", 12F);
            textBoxPurposeName.ForeColor = Color.Black;
            textBoxPurposeName.Lighting = false;
            textBoxPurposeName.LinearGradientPen = false;
            textBoxPurposeName.Location = new Point(161, 6);
            textBoxPurposeName.Name = "textBoxPurposeName";
            textBoxPurposeName.PenWidth = 15;
            textBoxPurposeName.RGB = false;
            textBoxPurposeName.Rounding = true;
            textBoxPurposeName.RoundingInt = 60;
            textBoxPurposeName.Size = new Size(448, 48);
            textBoxPurposeName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textBoxPurposeName.TabIndex = 15;
            textBoxPurposeName.Tag = "Cyber";
            textBoxPurposeName.TextButton = "";
            textBoxPurposeName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textBoxPurposeName.Timer_RGB = 300;
            textBoxPurposeName.Enter += textBoxUpdate_Enter;
            textBoxPurposeName.Leave += textBoxUpdate_Leave;
            // 
            // thunderLabel7
            // 
            thunderLabel7.BackColor = Color.PaleTurquoise;
            thunderLabel7.Dock = DockStyle.Fill;
            thunderLabel7.ForeColor = Color.Transparent;
            thunderLabel7.Location = new Point(6, 177);
            thunderLabel7.Name = "thunderLabel7";
            thunderLabel7.Size = new Size(146, 50);
            thunderLabel7.TabIndex = 12;
            // 
            // labelPurposeStatus
            // 
            labelPurposeStatus.BackColor = Color.PaleTurquoise;
            labelPurposeStatus.Dock = DockStyle.Fill;
            labelPurposeStatus.ForeColor = Color.Transparent;
            labelPurposeStatus.Location = new Point(6, 120);
            labelPurposeStatus.Name = "labelPurposeStatus";
            labelPurposeStatus.Size = new Size(146, 48);
            labelPurposeStatus.TabIndex = 4;
            labelPurposeStatus.Text = "Status";
            // 
            // labelPurposeDescription
            // 
            labelPurposeDescription.BackColor = Color.PaleTurquoise;
            labelPurposeDescription.Dock = DockStyle.Fill;
            labelPurposeDescription.ForeColor = Color.Transparent;
            labelPurposeDescription.Location = new Point(6, 63);
            labelPurposeDescription.Name = "labelPurposeDescription";
            labelPurposeDescription.Size = new Size(146, 48);
            labelPurposeDescription.TabIndex = 3;
            labelPurposeDescription.Text = "Description";
            // 
            // labelPurposeName
            // 
            labelPurposeName.BackColor = Color.PaleTurquoise;
            labelPurposeName.Dock = DockStyle.Fill;
            labelPurposeName.ForeColor = Color.Transparent;
            labelPurposeName.Location = new Point(6, 6);
            labelPurposeName.Name = "labelPurposeName";
            labelPurposeName.Size = new Size(146, 48);
            labelPurposeName.TabIndex = 0;
            labelPurposeName.Text = "Purpose";
            // 
            // textBoxPurposeDescription
            // 
            textBoxPurposeDescription.Alpha = 20;
            textBoxPurposeDescription.BackColor = Color.Transparent;
            textBoxPurposeDescription.Background_WidthPen = 6F;
            textBoxPurposeDescription.BackgroundPen = true;
            textBoxPurposeDescription.ColorBackground = Color.LightGray;
            textBoxPurposeDescription.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            textBoxPurposeDescription.ColorLighting = Color.FromArgb(29, 200, 238);
            textBoxPurposeDescription.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textBoxPurposeDescription.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textBoxPurposeDescription.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textBoxPurposeDescription.Dock = DockStyle.Fill;
            textBoxPurposeDescription.Font = new Font("Arial", 12F);
            textBoxPurposeDescription.ForeColor = Color.Black;
            textBoxPurposeDescription.Lighting = false;
            textBoxPurposeDescription.LinearGradientPen = false;
            textBoxPurposeDescription.Location = new Point(161, 63);
            textBoxPurposeDescription.Name = "textBoxPurposeDescription";
            textBoxPurposeDescription.PenWidth = 15;
            textBoxPurposeDescription.RGB = false;
            textBoxPurposeDescription.Rounding = true;
            textBoxPurposeDescription.RoundingInt = 60;
            textBoxPurposeDescription.Size = new Size(448, 48);
            textBoxPurposeDescription.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textBoxPurposeDescription.TabIndex = 2;
            textBoxPurposeDescription.Tag = "Cyber";
            textBoxPurposeDescription.TextButton = "";
            textBoxPurposeDescription.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textBoxPurposeDescription.Timer_RGB = 300;
            textBoxPurposeDescription.Enter += textBoxUpdate_Enter;
            textBoxPurposeDescription.Leave += textBoxUpdate_Leave;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonCancel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(161, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 50);
            panel1.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.Alpha = 20;
            buttonSave.BackColor = Color.Transparent;
            buttonSave.Background = true;
            buttonSave.Background_WidthPen = 4F;
            buttonSave.BackgroundPen = true;
            buttonSave.ColorBackground = Color.FromArgb(37, 52, 68);
            buttonSave.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonSave.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonSave.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonSave.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonSave.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonSave.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonSave.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonSave.Dock = DockStyle.Right;
            buttonSave.Effect_1 = true;
            buttonSave.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonSave.Effect_1_Transparency = 25;
            buttonSave.Effect_2 = true;
            buttonSave.Effect_2_ColorBackground = Color.White;
            buttonSave.Effect_2_Transparency = 20;
            buttonSave.Font = new Font("Arial", 11F);
            buttonSave.ForeColor = Color.Lime;
            buttonSave.Lighting = false;
            buttonSave.LinearGradient_Background = false;
            buttonSave.LinearGradientPen = false;
            buttonSave.Location = new Point(188, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.PenWidth = 15;
            buttonSave.Rounding = true;
            buttonSave.RoundingInt = 70;
            buttonSave.Size = new Size(130, 50);
            buttonSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonSave.TabIndex = 1;
            buttonSave.Tag = "Cyber";
            buttonSave.TextButton = "Save";
            buttonSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonSave.Timer_Effect_1 = 5;
            buttonSave.Timer_RGB = 300;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Alpha = 20;
            buttonCancel.BackColor = Color.Transparent;
            buttonCancel.Background = true;
            buttonCancel.Background_WidthPen = 4F;
            buttonCancel.BackgroundPen = true;
            buttonCancel.ColorBackground = Color.FromArgb(37, 52, 68);
            buttonCancel.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonCancel.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonCancel.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonCancel.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonCancel.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonCancel.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonCancel.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonCancel.Dock = DockStyle.Right;
            buttonCancel.Effect_1 = true;
            buttonCancel.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonCancel.Effect_1_Transparency = 25;
            buttonCancel.Effect_2 = true;
            buttonCancel.Effect_2_ColorBackground = Color.White;
            buttonCancel.Effect_2_Transparency = 20;
            buttonCancel.Font = new Font("Arial", 11F);
            buttonCancel.ForeColor = Color.Red;
            buttonCancel.Lighting = false;
            buttonCancel.LinearGradient_Background = false;
            buttonCancel.LinearGradientPen = false;
            buttonCancel.Location = new Point(318, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.PenWidth = 15;
            buttonCancel.Rounding = true;
            buttonCancel.RoundingInt = 70;
            buttonCancel.Size = new Size(130, 50);
            buttonCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonCancel.TabIndex = 0;
            buttonCancel.Tag = "Cyber";
            buttonCancel.TextButton = "Cancel";
            buttonCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonCancel.Timer_Effect_1 = 5;
            buttonCancel.Timer_RGB = 300;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(161, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 48);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 48);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(rbInactive);
            panel4.Controls.Add(rbActive);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(448, 48);
            panel4.TabIndex = 15;
            // 
            // rbInactive
            // 
            rbInactive.AutoSize = true;
            rbInactive.ForeColor = Color.Red;
            rbInactive.Location = new Point(111, 14);
            rbInactive.Name = "rbInactive";
            rbInactive.Size = new Size(66, 19);
            rbInactive.TabIndex = 1;
            rbInactive.TabStop = true;
            rbInactive.Text = "Inactive";
            rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.ForeColor = Color.Lime;
            rbActive.Location = new Point(3, 14);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(58, 19);
            rbActive.TabIndex = 0;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // VisitPurposeEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 52, 68);
            ClientSize = new Size(615, 233);
            Controls.Add(tableLayoutPanel1);
            Name = "VisitPurposeEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VisitPurposeEditForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel7;
        private ReaLTaiizor.Controls.ThunderLabel labelPurposeStatus;
        private ReaLTaiizor.Controls.ThunderLabel labelPurposeDescription;
        private ReaLTaiizor.Controls.ThunderLabel labelPurposeName;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberTextBox textBoxPurposeDescription;
        private Panel panel1;
        private ReaLTaiizor.Controls.CyberButton buttonSave;
        private ReaLTaiizor.Controls.CyberButton buttonCancel;
        private Panel panel2;
        private ReaLTaiizor.Controls.CyberTextBox textBoxPurposeName;
        private Panel panel3;
        private Panel panel4;
        private RadioButton rbInactive;
        private RadioButton rbActive;
    }
}