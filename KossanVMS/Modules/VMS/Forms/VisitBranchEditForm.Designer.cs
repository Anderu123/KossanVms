using ReaLTaiizor.Controls;
using System.Diagnostics;

namespace KossanVMS
{
    partial class VisitBranchEditForm
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
            textBoxBranchName = new CyberTextBox();
            thunderLabel7 = new ThunderLabel();
            textBoxBranchConnStr = new CyberTextBox();
            labelBranchConnString = new ThunderLabel();
            labelBranchStatus = new ThunderLabel();
            labelBranchDescription = new ThunderLabel();
            labelBranchName = new ThunderLabel();
            textBoxBranchDescription = new CyberTextBox();
            panel1 = new System.Windows.Forms.Panel();
            buttonSave = new CyberButton();
            buttonCancel = new CyberButton();
            radioPanelBranch = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            rbInactive = new System.Windows.Forms.RadioButton();
            rbActive = new System.Windows.Forms.RadioButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            radioPanelBranch.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(37, 52, 68);
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.10917F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.89083F));
            tableLayoutPanel1.Controls.Add(textBoxBranchName, 1, 0);
            tableLayoutPanel1.Controls.Add(thunderLabel7, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxBranchConnStr, 1, 3);
            tableLayoutPanel1.Controls.Add(labelBranchConnString, 0, 3);
            tableLayoutPanel1.Controls.Add(labelBranchStatus, 0, 2);
            tableLayoutPanel1.Controls.Add(labelBranchDescription, 0, 1);
            tableLayoutPanel1.Controls.Add(labelBranchName, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxBranchDescription, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 4);
            tableLayoutPanel1.Controls.Add(radioPanelBranch, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999962F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999962F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(636, 265);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxBranchName
            // 
            textBoxBranchName.Alpha = 20;
            textBoxBranchName.BackColor = Color.Transparent;
            textBoxBranchName.Background_WidthPen = 6F;
            textBoxBranchName.BackgroundPen = true;
            textBoxBranchName.ColorBackground = Color.LightGray;
            textBoxBranchName.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            textBoxBranchName.ColorLighting = Color.FromArgb(29, 200, 238);
            textBoxBranchName.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textBoxBranchName.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textBoxBranchName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textBoxBranchName.Dock = DockStyle.Fill;
            textBoxBranchName.Font = new Font("Arial", 10F);
            textBoxBranchName.ForeColor = Color.Black;
            textBoxBranchName.Lighting = false;
            textBoxBranchName.LinearGradientPen = false;
            textBoxBranchName.Location = new Point(166, 6);
            textBoxBranchName.Name = "textBoxBranchName";
            textBoxBranchName.PenWidth = 15;
            textBoxBranchName.RGB = false;
            textBoxBranchName.Rounding = true;
            textBoxBranchName.RoundingInt = 60;
            textBoxBranchName.Size = new Size(464, 43);
            textBoxBranchName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textBoxBranchName.TabIndex = 15;
            textBoxBranchName.Tag = "Cyber";
            textBoxBranchName.TextButton = "";
            textBoxBranchName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textBoxBranchName.Timer_RGB = 300;
            textBoxBranchName.Enter += textBoxUpdate_Enter;
            textBoxBranchName.Leave += textBoxUpdate_Leave;
            // 
            // thunderLabel7
            // 
            thunderLabel7.BackColor = Color.PaleTurquoise;
            thunderLabel7.Dock = DockStyle.Fill;
            thunderLabel7.ForeColor = Color.Transparent;
            thunderLabel7.Location = new Point(6, 214);
            thunderLabel7.Name = "thunderLabel7";
            thunderLabel7.Size = new Size(151, 45);
            thunderLabel7.TabIndex = 12;
            // 
            // textBoxBranchConnStr
            // 
            textBoxBranchConnStr.Alpha = 20;
            textBoxBranchConnStr.BackColor = Color.Transparent;
            textBoxBranchConnStr.Background_WidthPen = 6F;
            textBoxBranchConnStr.BackgroundPen = true;
            textBoxBranchConnStr.ColorBackground = Color.LightGray;
            textBoxBranchConnStr.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            textBoxBranchConnStr.ColorLighting = Color.FromArgb(29, 200, 238);
            textBoxBranchConnStr.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textBoxBranchConnStr.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textBoxBranchConnStr.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textBoxBranchConnStr.Dock = DockStyle.Fill;
            textBoxBranchConnStr.Font = new Font("Arial", 10F);
            textBoxBranchConnStr.ForeColor = Color.Black;
            textBoxBranchConnStr.Lighting = false;
            textBoxBranchConnStr.LinearGradientPen = false;
            textBoxBranchConnStr.Location = new Point(166, 162);
            textBoxBranchConnStr.Name = "textBoxBranchConnStr";
            textBoxBranchConnStr.PenWidth = 15;
            textBoxBranchConnStr.RGB = false;
            textBoxBranchConnStr.Rounding = true;
            textBoxBranchConnStr.RoundingInt = 60;
            textBoxBranchConnStr.Size = new Size(464, 43);
            textBoxBranchConnStr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textBoxBranchConnStr.TabIndex = 7;
            textBoxBranchConnStr.Tag = "Cyber";
            textBoxBranchConnStr.TextButton = "";
            textBoxBranchConnStr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textBoxBranchConnStr.Timer_RGB = 300;
            textBoxBranchConnStr.Enter += textBoxUpdate_Enter;
            textBoxBranchConnStr.Leave += textBoxUpdate_Leave;
            // 
            // labelBranchConnString
            // 
            labelBranchConnString.BackColor = Color.PaleTurquoise;
            labelBranchConnString.Dock = DockStyle.Fill;
            labelBranchConnString.ForeColor = Color.Transparent;
            labelBranchConnString.Location = new Point(6, 162);
            labelBranchConnString.Name = "labelBranchConnString";
            labelBranchConnString.Size = new Size(151, 43);
            labelBranchConnString.TabIndex = 6;
            labelBranchConnString.Text = "Branch Connection String";
            // 
            // labelBranchStatus
            // 
            labelBranchStatus.BackColor = Color.PaleTurquoise;
            labelBranchStatus.Dock = DockStyle.Fill;
            labelBranchStatus.ForeColor = Color.Transparent;
            labelBranchStatus.Location = new Point(6, 110);
            labelBranchStatus.Name = "labelBranchStatus";
            labelBranchStatus.Size = new Size(151, 43);
            labelBranchStatus.TabIndex = 4;
            labelBranchStatus.Text = "Branch Status";
            // 
            // labelBranchDescription
            // 
            labelBranchDescription.BackColor = Color.PaleTurquoise;
            labelBranchDescription.Dock = DockStyle.Fill;
            labelBranchDescription.ForeColor = Color.Transparent;
            labelBranchDescription.Location = new Point(6, 58);
            labelBranchDescription.Name = "labelBranchDescription";
            labelBranchDescription.Size = new Size(151, 43);
            labelBranchDescription.TabIndex = 3;
            labelBranchDescription.Text = "Branch Description";
            // 
            // labelBranchName
            // 
            labelBranchName.BackColor = Color.PaleTurquoise;
            labelBranchName.Dock = DockStyle.Fill;
            labelBranchName.ForeColor = Color.Transparent;
            labelBranchName.Location = new Point(6, 6);
            labelBranchName.Name = "labelBranchName";
            labelBranchName.Size = new Size(151, 43);
            labelBranchName.TabIndex = 0;
            labelBranchName.Text = "Branch Name";
            // 
            // textBoxBranchDescription
            // 
            textBoxBranchDescription.Alpha = 20;
            textBoxBranchDescription.BackColor = Color.Transparent;
            textBoxBranchDescription.Background_WidthPen = 6F;
            textBoxBranchDescription.BackgroundPen = true;
            textBoxBranchDescription.ColorBackground = Color.LightGray;
            textBoxBranchDescription.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            textBoxBranchDescription.ColorLighting = Color.FromArgb(29, 200, 238);
            textBoxBranchDescription.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textBoxBranchDescription.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textBoxBranchDescription.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textBoxBranchDescription.Dock = DockStyle.Fill;
            textBoxBranchDescription.Font = new Font("Arial", 10F);
            textBoxBranchDescription.ForeColor = Color.Black;
            textBoxBranchDescription.Lighting = false;
            textBoxBranchDescription.LinearGradientPen = false;
            textBoxBranchDescription.Location = new Point(166, 58);
            textBoxBranchDescription.Name = "textBoxBranchDescription";
            textBoxBranchDescription.PenWidth = 15;
            textBoxBranchDescription.RGB = false;
            textBoxBranchDescription.Rounding = true;
            textBoxBranchDescription.RoundingInt = 60;
            textBoxBranchDescription.Size = new Size(464, 43);
            textBoxBranchDescription.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textBoxBranchDescription.TabIndex = 2;
            textBoxBranchDescription.Tag = "Cyber";
            textBoxBranchDescription.TextButton = "";
            textBoxBranchDescription.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textBoxBranchDescription.Timer_RGB = 300;
            textBoxBranchDescription.Enter += textBoxUpdate_Enter;
            textBoxBranchDescription.Leave += textBoxUpdate_Leave;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonCancel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(166, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 45);
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
            buttonSave.Location = new Point(204, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.PenWidth = 15;
            buttonSave.Rounding = true;
            buttonSave.RoundingInt = 70;
            buttonSave.Size = new Size(130, 45);
            buttonSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonSave.TabIndex = 1;
            buttonSave.Tag = "Cyber";
            buttonSave.TextButton = "OK";
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
            buttonCancel.Location = new Point(334, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.PenWidth = 15;
            buttonCancel.Rounding = true;
            buttonCancel.RoundingInt = 70;
            buttonCancel.Size = new Size(130, 45);
            buttonCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonCancel.TabIndex = 0;
            buttonCancel.Tag = "Cyber";
            buttonCancel.TextButton = "Cancel";
            buttonCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonCancel.Timer_Effect_1 = 5;
            buttonCancel.Timer_RGB = 300;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // radioPanelBranch
            // 
            radioPanelBranch.Controls.Add(panel2);
            radioPanelBranch.Dock = DockStyle.Fill;
            radioPanelBranch.Location = new Point(166, 110);
            radioPanelBranch.Name = "radioPanelBranch";
            radioPanelBranch.Size = new Size(464, 43);
            radioPanelBranch.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbInactive);
            panel2.Controls.Add(rbActive);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 43);
            panel2.TabIndex = 15;
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
            // VisitBranchEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 265);
            Controls.Add(tableLayoutPanel1);
            Name = "VisitBranchEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VisitBranchEditForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            radioPanelBranch.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel7;
        private ReaLTaiizor.Controls.CyberTextBox textBoxBranchConnStr;
        private ReaLTaiizor.Controls.ThunderLabel labelBranchConnString;
        private ReaLTaiizor.Controls.ThunderLabel labelBranchStatus;
        private ReaLTaiizor.Controls.ThunderLabel labelBranchDescription;
        private ReaLTaiizor.Controls.ThunderLabel labelBranchName;
        private ReaLTaiizor.Controls.CyberTextBox textBoxBranchDescription;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.CyberButton buttonSave;
        private ReaLTaiizor.Controls.CyberButton buttonCancel;
        private System.Windows.Forms.Panel radioPanelBranch;
        private ReaLTaiizor.Controls.CyberTextBox textBoxBranchName;



        private void buttonUpdate_Enter(object sender, EventArgs e)
        {
            CyberButton clickedButton = sender as CyberButton;
            if (clickedButton != null)
            {
                Debug.WriteLine("Entered");
                // Revert to the original border color when the mouse leaves
                clickedButton.ColorBackground_Pen = Color.Turquoise;
                clickedButton.ColorBackground = Color.White;
                clickedButton.Invalidate(); // Force redraw
            }
        }
        private void buttonUpdate_Leave(object sender, EventArgs e)
        {
            CyberButton clickedButton = sender as CyberButton;
            if (clickedButton != null)
            {
                Debug.WriteLine("Left");
                // Revert to the original border color when the mouse leaves
                clickedButton.ColorBackground_Pen = Color.PaleTurquoise;
                clickedButton.ColorBackground = Color.LightGray;
                clickedButton.Invalidate(); // Force redraw
            }
        }
        private void textBoxUpdate_Enter(object sender, EventArgs e)
        {
            CyberTextBox clickedButton = sender as CyberTextBox;

            if (clickedButton != null)
            {
                Debug.WriteLine("Entered");
                // Revert to the original border color when the mouse leaves
                clickedButton.ColorBackground_Pen = Color.Turquoise;
                clickedButton.ColorBackground = Color.White;
                clickedButton.Invalidate(); // Force redraw
            }
        }
        private void textBoxUpdate_Leave(object sender, EventArgs e)
        {
            CyberTextBox clickedButton = sender as CyberTextBox;
            if (clickedButton != null)
            {
                Debug.WriteLine("Left");
                // Revert to the original border color when the mouse leaves
                clickedButton.ColorBackground_Pen = Color.PaleTurquoise;
                clickedButton.ColorBackground = Color.LightGray;
                clickedButton.Invalidate(); // Force redraw
            }
        }
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
    }
}