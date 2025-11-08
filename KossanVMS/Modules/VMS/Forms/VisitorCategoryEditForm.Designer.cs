using ReaLTaiizor.Controls;
using System.Diagnostics;

namespace KossanVMS
{
    partial class VisitorCategoryEditForm
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
            
            cancelButton = new ReaLTaiizor.Controls.CyberButton();
            thunderLabel7 = new ReaLTaiizor.Controls.ThunderLabel();
            labelCategoryStatus = new ReaLTaiizor.Controls.ThunderLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxCategoryDescription = new ReaLTaiizor.Controls.CyberTextBox();
            labelCategoryDescription = new ReaLTaiizor.Controls.ThunderLabel();
            labelCategoryName = new ReaLTaiizor.Controls.ThunderLabel();
            labelCategoryId = new ReaLTaiizor.Controls.ThunderLabel();
            buttonCategoryID = new ReaLTaiizor.Controls.CyberButton();
            textBoxCategoryName = new ReaLTaiizor.Controls.CyberTextBox();
            panel1 = new  System.Windows.Forms.Panel();
            saveButton = new ReaLTaiizor.Controls.CyberButton();
            panel2 = new  System.Windows.Forms.Panel();
            rbInactive = new System.Windows.Forms.RadioButton();
            rbActive = new System.Windows.Forms.RadioButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Alpha = 20;
            cancelButton.BackColor = Color.Transparent;
            cancelButton.Background = true;
            cancelButton.Background_WidthPen = 4F;
            cancelButton.BackgroundPen = true;
            cancelButton.ColorBackground = Color.FromArgb(37, 52, 68);
            cancelButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cancelButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cancelButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cancelButton.ColorLighting = Color.FromArgb(29, 200, 238);
            cancelButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cancelButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cancelButton.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Effect_1 = true;
            cancelButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cancelButton.Effect_1_Transparency = 25;
            cancelButton.Effect_2 = true;
            cancelButton.Effect_2_ColorBackground = Color.White;
            cancelButton.Effect_2_Transparency = 20;
            cancelButton.Font = new Font("Arial", 11F);
            cancelButton.ForeColor = Color.Red;
            cancelButton.Lighting = false;
            cancelButton.LinearGradient_Background = false;
            cancelButton.LinearGradientPen = false;
            cancelButton.Location = new Point(246, 0);
            cancelButton.Name = "cancelButton";
            cancelButton.PenWidth = 15;
            cancelButton.Rounding = true;
            cancelButton.RoundingInt = 70;
            cancelButton.Size = new Size(130, 57);
            cancelButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cancelButton.TabIndex = 0;
            cancelButton.Tag = "Cyber";
            cancelButton.TextButton = "Cancel";
            cancelButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cancelButton.Timer_Effect_1 = 5;
            cancelButton.Timer_RGB = 300;
            // 
            // thunderLabel7
            // 
            thunderLabel7.BackColor = Color.PaleTurquoise;
            thunderLabel7.Dock = DockStyle.Fill;
            thunderLabel7.ForeColor = Color.Transparent;
            thunderLabel7.Location = new Point(6, 254);
            thunderLabel7.Name = "thunderLabel7";
            thunderLabel7.Size = new Size(121, 57);
            thunderLabel7.TabIndex = 12;
            // 
            // labelCategoryStatus
            // 
            labelCategoryStatus.BackColor = Color.PaleTurquoise;
            labelCategoryStatus.Dock = DockStyle.Fill;
            labelCategoryStatus.ForeColor = Color.Transparent;
            labelCategoryStatus.Location = new Point(6, 192);
            labelCategoryStatus.Name = "labelCategoryStatus";
            labelCategoryStatus.Size = new Size(121, 53);
            labelCategoryStatus.TabIndex = 6;
            labelCategoryStatus.Text = "Category Status";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.10917F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.89083F));
            tableLayoutPanel1.Controls.Add(thunderLabel7, 0, 4);
            tableLayoutPanel1.Controls.Add(labelCategoryStatus, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxCategoryDescription, 1, 2);
            tableLayoutPanel1.Controls.Add(labelCategoryDescription, 0, 2);
            tableLayoutPanel1.Controls.Add(labelCategoryName, 0, 1);
            tableLayoutPanel1.Controls.Add(labelCategoryId, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonCategoryID, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxCategoryName, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 4);
            tableLayoutPanel1.Controls.Add(panel2, 1, 3);
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
            tableLayoutPanel1.Size = new Size(518, 317);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxCategoryDescription
            // 
            textBoxCategoryDescription.Alpha = 20;
            textBoxCategoryDescription.BackColor = Color.Transparent;
            textBoxCategoryDescription.Background_WidthPen = 6F;
            textBoxCategoryDescription.BackgroundPen = true;
            textBoxCategoryDescription.ColorBackground = Color.LightGray;
            textBoxCategoryDescription.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            textBoxCategoryDescription.ColorLighting = Color.FromArgb(29, 200, 238);
            textBoxCategoryDescription.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textBoxCategoryDescription.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textBoxCategoryDescription.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textBoxCategoryDescription.Dock = DockStyle.Fill;
            textBoxCategoryDescription.Font = new Font("Arial", 13F);
            textBoxCategoryDescription.ForeColor = Color.Black;
            textBoxCategoryDescription.Lighting = false;
            textBoxCategoryDescription.LinearGradientPen = false;
            textBoxCategoryDescription.Location = new Point(136, 130);
            textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            textBoxCategoryDescription.PenWidth = 15;
            textBoxCategoryDescription.RGB = false;
            textBoxCategoryDescription.Rounding = true;
            textBoxCategoryDescription.RoundingInt = 60;
            textBoxCategoryDescription.Size = new Size(376, 53);
            textBoxCategoryDescription.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textBoxCategoryDescription.TabIndex = 5;
            textBoxCategoryDescription.Tag = "Cyber";
            textBoxCategoryDescription.TextButton = "";
            textBoxCategoryDescription.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textBoxCategoryDescription.Timer_RGB = 300;
            textBoxCategoryDescription.Leave += textBoxUpdate_Leave;
            textBoxCategoryDescription.Enter += textBoxUpdate_Enter;
            // 
            // labelCategoryDescription
            // 
            labelCategoryDescription.BackColor = Color.PaleTurquoise;
            labelCategoryDescription.Dock = DockStyle.Fill;
            labelCategoryDescription.ForeColor = Color.Transparent;
            labelCategoryDescription.Location = new Point(6, 130);
            labelCategoryDescription.Name = "labelCategoryDescription";
            labelCategoryDescription.Size = new Size(121, 53);
            labelCategoryDescription.TabIndex = 4;
            labelCategoryDescription.Text = "Category Description";
            // 
            // labelCategoryName
            // 
            labelCategoryName.BackColor = Color.PaleTurquoise;
            labelCategoryName.Dock = DockStyle.Fill;
            labelCategoryName.ForeColor = Color.Transparent;
            labelCategoryName.Location = new Point(6, 68);
            labelCategoryName.Name = "labelCategoryName";
            labelCategoryName.Size = new Size(121, 53);
            labelCategoryName.TabIndex = 3;
            labelCategoryName.Text = "Category Name";
            // 
            // labelCategoryId
            // 
            labelCategoryId.BackColor = Color.PaleTurquoise;
            labelCategoryId.Dock = DockStyle.Fill;
            labelCategoryId.ForeColor = Color.Transparent;
            labelCategoryId.Location = new Point(6, 6);
            labelCategoryId.Name = "labelCategoryId";
            labelCategoryId.Size = new Size(121, 53);
            labelCategoryId.TabIndex = 0;
            labelCategoryId.Text = "Category ID";
            // 
            // buttonCategoryID
            // 
            buttonCategoryID.Alpha = 20;
            buttonCategoryID.BackColor = Color.Transparent;
            buttonCategoryID.Background = true;
            buttonCategoryID.Background_WidthPen = 6F;
            buttonCategoryID.BackgroundPen = true;
            buttonCategoryID.ColorBackground = Color.LightGray;
            buttonCategoryID.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonCategoryID.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonCategoryID.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonCategoryID.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonCategoryID.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonCategoryID.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonCategoryID.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonCategoryID.Dock = DockStyle.Fill;
            buttonCategoryID.Effect_1 = true;
            buttonCategoryID.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonCategoryID.Effect_1_Transparency = 25;
            buttonCategoryID.Effect_2 = true;
            buttonCategoryID.Effect_2_ColorBackground = Color.White;
            buttonCategoryID.Effect_2_Transparency = 20;
            buttonCategoryID.Font = new Font("Arial", 11F);
            buttonCategoryID.ForeColor = Color.Black;
            buttonCategoryID.Lighting = false;
            buttonCategoryID.LinearGradient_Background = false;
            buttonCategoryID.LinearGradientPen = false;
            buttonCategoryID.Location = new Point(136, 6);
            buttonCategoryID.Name = "buttonCategoryID";
            buttonCategoryID.PenWidth = 15;
            buttonCategoryID.Rounding = true;
            buttonCategoryID.RoundingInt = 70;
            buttonCategoryID.Size = new Size(376, 53);
            buttonCategoryID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonCategoryID.TabIndex = 1;
            buttonCategoryID.Tag = "Cyber";
            buttonCategoryID.TextButton = "";
            buttonCategoryID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonCategoryID.Timer_Effect_1 = 5;
            buttonCategoryID.Timer_RGB = 300;
            // 
            // textBoxCategoryName
            // 
            textBoxCategoryName.Alpha = 20;
            textBoxCategoryName.BackColor = Color.Transparent;
            textBoxCategoryName.Background_WidthPen = 6F;
            textBoxCategoryName.BackgroundPen = true;
            textBoxCategoryName.ColorBackground = Color.LightGray;
            textBoxCategoryName.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            textBoxCategoryName.ColorLighting = Color.FromArgb(29, 200, 238);
            textBoxCategoryName.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textBoxCategoryName.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textBoxCategoryName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textBoxCategoryName.Dock = DockStyle.Fill;
            textBoxCategoryName.Font = new Font("Arial", 13F);
            textBoxCategoryName.ForeColor = Color.Black;
            textBoxCategoryName.Lighting = false;
            textBoxCategoryName.LinearGradientPen = false;
            textBoxCategoryName.Location = new Point(136, 68);
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.PenWidth = 15;
            textBoxCategoryName.RGB = false;
            textBoxCategoryName.Rounding = true;
            textBoxCategoryName.RoundingInt = 60;
            textBoxCategoryName.Size = new Size(376, 53);
            textBoxCategoryName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textBoxCategoryName.TabIndex = 2;
            textBoxCategoryName.Tag = "Cyber";
            textBoxCategoryName.TextButton = "";
            textBoxCategoryName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textBoxCategoryName.Timer_RGB = 300;
            textBoxCategoryName.Enter += textBoxUpdate_Enter;
            textBoxCategoryName.Leave += textBoxUpdate_Leave;
            // 
            // panel1
            // 
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(cancelButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(136, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 57);
            panel1.TabIndex = 13;
            // 
            // saveButton
            // 
            saveButton.Alpha = 20;
            saveButton.BackColor = Color.Transparent;
            saveButton.Background = true;
            saveButton.Background_WidthPen = 4F;
            saveButton.BackgroundPen = true;
            saveButton.ColorBackground = Color.FromArgb(37, 52, 68);
            saveButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            saveButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            saveButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            saveButton.ColorLighting = Color.FromArgb(29, 200, 238);
            saveButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            saveButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            saveButton.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            saveButton.Dock = DockStyle.Right;
            saveButton.Effect_1 = true;
            saveButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            saveButton.Effect_1_Transparency = 25;
            saveButton.Effect_2 = true;
            saveButton.Effect_2_ColorBackground = Color.White;
            saveButton.Effect_2_Transparency = 20;
            saveButton.Font = new Font("Arial", 11F);
            saveButton.ForeColor = Color.Lime;
            saveButton.Lighting = false;
            saveButton.LinearGradient_Background = false;
            saveButton.LinearGradientPen = false;
            saveButton.Location = new Point(116, 0);
            saveButton.Name = "saveButton";
            saveButton.PenWidth = 15;
            saveButton.Rounding = true;
            saveButton.RoundingInt = 70;
            saveButton.Size = new Size(130, 57);
            saveButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            saveButton.TabIndex = 1;
            saveButton.Tag = "Cyber";
            saveButton.TextButton = "Save";
            saveButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            saveButton.Timer_Effect_1 = 5;
            saveButton.Timer_RGB = 300;
            saveButton.Click += buttonSave_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbInactive);
            panel2.Controls.Add(rbActive);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(136, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 53);
            panel2.TabIndex = 14;
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
            // VisitorCategoryEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 52, 68);
            ClientSize = new Size(518, 317);
            Controls.Add(tableLayoutPanel1);
            Name = "VisitorCategoryEditForm";
            Text = "VisitorCategoryEditForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton cancelButton;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel7;
        private ReaLTaiizor.Controls.ThunderLabel labelCategoryStatus;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.CyberTextBox textBoxCategoryDescription;
        private ReaLTaiizor.Controls.ThunderLabel labelCategoryDescription;
        private ReaLTaiizor.Controls.ThunderLabel labelCategoryName;
        private ReaLTaiizor.Controls.ThunderLabel labelCategoryId;
        private ReaLTaiizor.Controls.CyberButton buttonCategoryID;
        private ReaLTaiizor.Controls.CyberTextBox textBoxCategoryName;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.CyberButton saveButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;

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
    }
}