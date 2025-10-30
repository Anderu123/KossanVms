using KossanVMS.Utility;
using ReaLTaiizor.Controls;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using Panel = System.Windows.Forms.Panel;
using System.Diagnostics;
namespace KossanVMS
{
    partial class VisitorPBEditForm
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
                //_db.Dispose();
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cyberTextBox1 = new CyberTextBox();
            labelVisitorPermitNo = new ThunderLabel();
            textboxVisitorFullName = new CyberTextBox();
            labelVisitorFullName = new ThunderLabel();
            textboxVisitorRemarks = new CyberTextBox();
            labelVisitorPurpose = new ThunderLabel();
            checkedListBoxBranch = new CheckedListBox();
            labelVisitorBranch = new ThunderLabel();
            textboxVisitorGatePass = new CyberTextBox();
            labelVisitorGatePass = new ThunderLabel();
            textboxVisitorTagNo = new CyberTextBox();
            labelVisitorTagNo = new ThunderLabel();
            thunderLabel3 = new ThunderLabel();
            thunderLabel2 = new ThunderLabel();
            thunderLabel1 = new ThunderLabel();
            labelVisitorCompany = new ThunderLabel();
            labelVisitorContact = new ThunderLabel();
            panel2 = new Panel();
            buttonVisitorVideoCapture = new CyberButton();
            foxLinkLabel1 = new FoxLinkLabel();
            panel3 = new Panel();
            buttonSave = new CyberButton();
            cyberButton1 = new CyberButton();
            panel4 = new Panel();
            buttonLabelUpdateContact = new CyberButton();
            buttonEditContact = new CyberButton();
            checkedListBoxCat = new CheckedListBox();
            panel5 = new Panel();
            cyberButtonSearch = new CyberButton();
            maskedTextBoxIC = new MaskedTextBox();
            comboBoxIdType = new ComboBox();
            panel6 = new Panel();
            cyberButtonCompany = new CyberButton();
            cyberButton2 = new CyberButton();
            visitorBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 865);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(37, 52, 68);
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.44555F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.55445F));
            tableLayoutPanel1.Controls.Add(cyberTextBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(labelVisitorPermitNo, 0, 2);
            tableLayoutPanel1.Controls.Add(textboxVisitorFullName, 1, 0);
            tableLayoutPanel1.Controls.Add(labelVisitorFullName, 0, 0);
            tableLayoutPanel1.Controls.Add(textboxVisitorRemarks, 1, 8);
            tableLayoutPanel1.Controls.Add(labelVisitorPurpose, 0, 8);
            tableLayoutPanel1.Controls.Add(checkedListBoxBranch, 1, 5);
            tableLayoutPanel1.Controls.Add(labelVisitorBranch, 0, 5);
            tableLayoutPanel1.Controls.Add(textboxVisitorGatePass, 1, 10);
            tableLayoutPanel1.Controls.Add(labelVisitorGatePass, 0, 10);
            tableLayoutPanel1.Controls.Add(textboxVisitorTagNo, 1, 9);
            tableLayoutPanel1.Controls.Add(labelVisitorTagNo, 0, 9);
            tableLayoutPanel1.Controls.Add(thunderLabel3, 0, 7);
            tableLayoutPanel1.Controls.Add(thunderLabel2, 0, 11);
            tableLayoutPanel1.Controls.Add(thunderLabel1, 0, 6);
            tableLayoutPanel1.Controls.Add(labelVisitorCompany, 0, 4);
            tableLayoutPanel1.Controls.Add(labelVisitorContact, 0, 3);
            tableLayoutPanel1.Controls.Add(panel2, 1, 6);
            tableLayoutPanel1.Controls.Add(panel3, 1, 11);
            tableLayoutPanel1.Controls.Add(panel4, 1, 3);
            tableLayoutPanel1.Controls.Add(checkedListBoxCat, 1, 7);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxIdType, 0, 1);
            tableLayoutPanel1.Controls.Add(panel6, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.23138046F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.11449146F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.11449337F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.114495F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.114495F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.1744585F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.114496F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.22553F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.99973154F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.514529F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.16598463F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.11591768F));
            tableLayoutPanel1.Size = new Size(558, 865);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cyberTextBox1
            // 
            cyberTextBox1.Alpha = 20;
            cyberTextBox1.BackColor = Color.Transparent;
            cyberTextBox1.Background_WidthPen = 6F;
            cyberTextBox1.BackgroundPen = true;
            cyberTextBox1.ColorBackground = Color.LightGray;
            cyberTextBox1.ColorBackground_Pen = Color.PaleTurquoise;
            cyberTextBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberTextBox1.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox1.Dock = DockStyle.Fill;
            cyberTextBox1.Font = new Font("Arial", 13F);
            cyberTextBox1.ForeColor = Color.Black;
            cyberTextBox1.Lighting = false;
            cyberTextBox1.LinearGradientPen = false;
            cyberTextBox1.Location = new Point(176, 129);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = false;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 60;
            cyberTextBox1.Size = new Size(376, 52);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox1.TabIndex = 38;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "";
            cyberTextBox1.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // labelVisitorPermitNo
            // 
            labelVisitorPermitNo.BackColor = Color.PaleTurquoise;
            labelVisitorPermitNo.Dock = DockStyle.Fill;
            labelVisitorPermitNo.ForeColor = Color.Transparent;
            labelVisitorPermitNo.Location = new Point(6, 129);
            labelVisitorPermitNo.Name = "labelVisitorPermitNo";
            labelVisitorPermitNo.Size = new Size(161, 52);
            labelVisitorPermitNo.TabIndex = 37;
            labelVisitorPermitNo.Text = "Permit No";
            // 
            // textboxVisitorFullName
            // 
            textboxVisitorFullName.Alpha = 20;
            textboxVisitorFullName.BackColor = Color.Transparent;
            textboxVisitorFullName.Background_WidthPen = 6F;
            textboxVisitorFullName.BackgroundPen = true;
            textboxVisitorFullName.ColorBackground = Color.LightGray;
            textboxVisitorFullName.ColorBackground_Pen = Color.PaleTurquoise;
            textboxVisitorFullName.ColorLighting = Color.FromArgb(29, 200, 238);
            textboxVisitorFullName.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textboxVisitorFullName.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textboxVisitorFullName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textboxVisitorFullName.Dock = DockStyle.Fill;
            textboxVisitorFullName.Font = new Font("Arial", 13F);
            textboxVisitorFullName.ForeColor = Color.Black;
            textboxVisitorFullName.Lighting = false;
            textboxVisitorFullName.LinearGradientPen = false;
            textboxVisitorFullName.Location = new Point(176, 6);
            textboxVisitorFullName.Name = "textboxVisitorFullName";
            textboxVisitorFullName.PenWidth = 15;
            textboxVisitorFullName.RGB = false;
            textboxVisitorFullName.Rounding = true;
            textboxVisitorFullName.RoundingInt = 60;
            textboxVisitorFullName.Size = new Size(376, 53);
            textboxVisitorFullName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textboxVisitorFullName.TabIndex = 36;
            textboxVisitorFullName.Tag = "Cyber";
            textboxVisitorFullName.TextButton = "";
            textboxVisitorFullName.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            textboxVisitorFullName.Timer_RGB = 300;
            // 
            // labelVisitorFullName
            // 
            labelVisitorFullName.BackColor = Color.PaleTurquoise;
            labelVisitorFullName.Dock = DockStyle.Fill;
            labelVisitorFullName.ForeColor = Color.Transparent;
            labelVisitorFullName.Location = new Point(6, 6);
            labelVisitorFullName.Name = "labelVisitorFullName";
            labelVisitorFullName.Size = new Size(161, 53);
            labelVisitorFullName.TabIndex = 35;
            labelVisitorFullName.Text = "Full Name";
            // 
            // textboxVisitorRemarks
            // 
            textboxVisitorRemarks.Alpha = 20;
            textboxVisitorRemarks.BackColor = Color.Transparent;
            textboxVisitorRemarks.Background_WidthPen = 6F;
            textboxVisitorRemarks.BackgroundPen = true;
            textboxVisitorRemarks.ColorBackground = Color.LightGray;
            textboxVisitorRemarks.ColorBackground_Pen = Color.PaleTurquoise;
            textboxVisitorRemarks.ColorLighting = Color.FromArgb(29, 200, 238);
            textboxVisitorRemarks.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textboxVisitorRemarks.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textboxVisitorRemarks.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textboxVisitorRemarks.Dock = DockStyle.Fill;
            textboxVisitorRemarks.Font = new Font("Arial", 12F);
            textboxVisitorRemarks.ForeColor = Color.Black;
            textboxVisitorRemarks.Lighting = false;
            textboxVisitorRemarks.LinearGradientPen = false;
            textboxVisitorRemarks.Location = new Point(176, 621);
            textboxVisitorRemarks.Name = "textboxVisitorRemarks";
            textboxVisitorRemarks.PenWidth = 15;
            textboxVisitorRemarks.RGB = false;
            textboxVisitorRemarks.Rounding = true;
            textboxVisitorRemarks.RoundingInt = 60;
            textboxVisitorRemarks.Size = new Size(376, 51);
            textboxVisitorRemarks.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textboxVisitorRemarks.TabIndex = 34;
            textboxVisitorRemarks.Tag = "Cyber";
            textboxVisitorRemarks.TextButton = "";
            textboxVisitorRemarks.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            textboxVisitorRemarks.Timer_RGB = 300;
            // 
            // labelVisitorPurpose
            // 
            labelVisitorPurpose.BackColor = Color.PaleTurquoise;
            labelVisitorPurpose.Dock = DockStyle.Fill;
            labelVisitorPurpose.ForeColor = Color.Transparent;
            labelVisitorPurpose.Location = new Point(6, 621);
            labelVisitorPurpose.Name = "labelVisitorPurpose";
            labelVisitorPurpose.Size = new Size(161, 51);
            labelVisitorPurpose.TabIndex = 33;
            labelVisitorPurpose.Text = "Remarks";
            // 
            // checkedListBoxBranch
            // 
            checkedListBoxBranch.BackColor = Color.PaleTurquoise;
            checkedListBoxBranch.Dock = DockStyle.Fill;
            checkedListBoxBranch.FormattingEnabled = true;
            checkedListBoxBranch.Location = new Point(176, 312);
            checkedListBoxBranch.Name = "checkedListBoxBranch";
            checkedListBoxBranch.Size = new Size(376, 111);
            checkedListBoxBranch.TabIndex = 32;
            // 
            // labelVisitorBranch
            // 
            labelVisitorBranch.BackColor = Color.PaleTurquoise;
            labelVisitorBranch.Dock = DockStyle.Fill;
            labelVisitorBranch.ForeColor = Color.Transparent;
            labelVisitorBranch.Location = new Point(6, 312);
            labelVisitorBranch.Name = "labelVisitorBranch";
            labelVisitorBranch.Size = new Size(161, 111);
            labelVisitorBranch.TabIndex = 31;
            labelVisitorBranch.Text = "Branch";
            // 
            // textboxVisitorGatePass
            // 
            textboxVisitorGatePass.Alpha = 20;
            textboxVisitorGatePass.BackColor = Color.Transparent;
            textboxVisitorGatePass.Background_WidthPen = 6F;
            textboxVisitorGatePass.BackgroundPen = true;
            textboxVisitorGatePass.ColorBackground = Color.LightGray;
            textboxVisitorGatePass.ColorBackground_Pen = Color.PaleTurquoise;
            textboxVisitorGatePass.ColorLighting = Color.FromArgb(29, 200, 238);
            textboxVisitorGatePass.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textboxVisitorGatePass.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textboxVisitorGatePass.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textboxVisitorGatePass.Dock = DockStyle.Fill;
            textboxVisitorGatePass.Font = new Font("Arial", 13F);
            textboxVisitorGatePass.ForeColor = Color.Black;
            textboxVisitorGatePass.Lighting = false;
            textboxVisitorGatePass.LinearGradientPen = false;
            textboxVisitorGatePass.Location = new Point(176, 737);
            textboxVisitorGatePass.Name = "textboxVisitorGatePass";
            textboxVisitorGatePass.PenWidth = 15;
            textboxVisitorGatePass.RGB = false;
            textboxVisitorGatePass.Rounding = true;
            textboxVisitorGatePass.RoundingInt = 60;
            textboxVisitorGatePass.Size = new Size(376, 53);
            textboxVisitorGatePass.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textboxVisitorGatePass.TabIndex = 30;
            textboxVisitorGatePass.Tag = "Cyber";
            textboxVisitorGatePass.TextButton = "";
            textboxVisitorGatePass.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            textboxVisitorGatePass.Timer_RGB = 300;
            textboxVisitorGatePass.Enter += textBoxUpdate_Enter;
            textboxVisitorGatePass.Leave += textBoxUpdate_Leave;
            // 
            // labelVisitorGatePass
            // 
            labelVisitorGatePass.BackColor = Color.PaleTurquoise;
            labelVisitorGatePass.Dock = DockStyle.Fill;
            labelVisitorGatePass.ForeColor = Color.Transparent;
            labelVisitorGatePass.Location = new Point(6, 737);
            labelVisitorGatePass.Name = "labelVisitorGatePass";
            labelVisitorGatePass.Size = new Size(161, 53);
            labelVisitorGatePass.TabIndex = 29;
            labelVisitorGatePass.Text = "GatePass";
            // 
            // textboxVisitorTagNo
            // 
            textboxVisitorTagNo.Alpha = 20;
            textboxVisitorTagNo.BackColor = Color.Transparent;
            textboxVisitorTagNo.Background_WidthPen = 6F;
            textboxVisitorTagNo.BackgroundPen = true;
            textboxVisitorTagNo.ColorBackground = Color.LightGray;
            textboxVisitorTagNo.ColorBackground_Pen = Color.PaleTurquoise;
            textboxVisitorTagNo.ColorLighting = Color.FromArgb(29, 200, 238);
            textboxVisitorTagNo.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textboxVisitorTagNo.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textboxVisitorTagNo.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textboxVisitorTagNo.Dock = DockStyle.Fill;
            textboxVisitorTagNo.Font = new Font("Arial", 11F);
            textboxVisitorTagNo.ForeColor = Color.Black;
            textboxVisitorTagNo.Lighting = false;
            textboxVisitorTagNo.LinearGradientPen = false;
            textboxVisitorTagNo.Location = new Point(176, 681);
            textboxVisitorTagNo.Name = "textboxVisitorTagNo";
            textboxVisitorTagNo.PenWidth = 15;
            textboxVisitorTagNo.RGB = false;
            textboxVisitorTagNo.Rounding = true;
            textboxVisitorTagNo.RoundingInt = 60;
            textboxVisitorTagNo.Size = new Size(376, 47);
            textboxVisitorTagNo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textboxVisitorTagNo.TabIndex = 28;
            textboxVisitorTagNo.Tag = "Cyber";
            textboxVisitorTagNo.TextButton = "";
            textboxVisitorTagNo.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            textboxVisitorTagNo.Timer_RGB = 300;
            textboxVisitorTagNo.Enter += textBoxUpdate_Enter;
            textboxVisitorTagNo.Leave += textBoxUpdate_Leave;
            // 
            // labelVisitorTagNo
            // 
            labelVisitorTagNo.BackColor = Color.PaleTurquoise;
            labelVisitorTagNo.Dock = DockStyle.Fill;
            labelVisitorTagNo.ForeColor = Color.Transparent;
            labelVisitorTagNo.Location = new Point(6, 681);
            labelVisitorTagNo.Name = "labelVisitorTagNo";
            labelVisitorTagNo.Size = new Size(161, 47);
            labelVisitorTagNo.TabIndex = 27;
            labelVisitorTagNo.Text = "TagNo";
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.PaleTurquoise;
            thunderLabel3.Dock = DockStyle.Fill;
            thunderLabel3.ForeColor = Color.Transparent;
            thunderLabel3.Location = new Point(6, 493);
            thunderLabel3.Name = "thunderLabel3";
            thunderLabel3.Size = new Size(161, 119);
            thunderLabel3.TabIndex = 21;
            thunderLabel3.Text = "Category";
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.PaleTurquoise;
            thunderLabel2.Dock = DockStyle.Fill;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(6, 799);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(161, 60);
            thunderLabel2.TabIndex = 17;
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.PaleTurquoise;
            thunderLabel1.Dock = DockStyle.Fill;
            thunderLabel1.ForeColor = Color.Transparent;
            thunderLabel1.Location = new Point(6, 432);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(161, 52);
            thunderLabel1.TabIndex = 10;
            thunderLabel1.Text = "Photo";
            // 
            // labelVisitorCompany
            // 
            labelVisitorCompany.BackColor = Color.PaleTurquoise;
            labelVisitorCompany.Dock = DockStyle.Fill;
            labelVisitorCompany.ForeColor = Color.Transparent;
            labelVisitorCompany.Location = new Point(6, 251);
            labelVisitorCompany.Name = "labelVisitorCompany";
            labelVisitorCompany.Size = new Size(161, 52);
            labelVisitorCompany.TabIndex = 6;
            labelVisitorCompany.Text = "Company";
            // 
            // labelVisitorContact
            // 
            labelVisitorContact.BackColor = Color.PaleTurquoise;
            labelVisitorContact.Dock = DockStyle.Fill;
            labelVisitorContact.ForeColor = Color.Transparent;
            labelVisitorContact.Location = new Point(6, 190);
            labelVisitorContact.Name = "labelVisitorContact";
            labelVisitorContact.Size = new Size(161, 52);
            labelVisitorContact.TabIndex = 4;
            labelVisitorContact.Text = "Contact";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonVisitorVideoCapture);
            panel2.Controls.Add(foxLinkLabel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(176, 432);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 52);
            panel2.TabIndex = 11;
            // 
            // buttonVisitorVideoCapture
            // 
            buttonVisitorVideoCapture.Alpha = 20;
            buttonVisitorVideoCapture.BackColor = Color.Transparent;
            buttonVisitorVideoCapture.Background = true;
            buttonVisitorVideoCapture.Background_WidthPen = 4F;
            buttonVisitorVideoCapture.BackgroundPen = true;
            buttonVisitorVideoCapture.ColorBackground = Color.FromArgb(37, 52, 68);
            buttonVisitorVideoCapture.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonVisitorVideoCapture.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonVisitorVideoCapture.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonVisitorVideoCapture.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonVisitorVideoCapture.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonVisitorVideoCapture.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonVisitorVideoCapture.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonVisitorVideoCapture.Dock = DockStyle.Fill;
            buttonVisitorVideoCapture.Effect_1 = true;
            buttonVisitorVideoCapture.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonVisitorVideoCapture.Effect_1_Transparency = 25;
            buttonVisitorVideoCapture.Effect_2 = true;
            buttonVisitorVideoCapture.Effect_2_ColorBackground = Color.White;
            buttonVisitorVideoCapture.Effect_2_Transparency = 20;
            buttonVisitorVideoCapture.Font = new Font("Arial", 11F);
            buttonVisitorVideoCapture.ForeColor = Color.FromArgb(245, 245, 245);
            buttonVisitorVideoCapture.Lighting = false;
            buttonVisitorVideoCapture.LinearGradient_Background = false;
            buttonVisitorVideoCapture.LinearGradientPen = false;
            buttonVisitorVideoCapture.Location = new Point(201, 0);
            buttonVisitorVideoCapture.Name = "buttonVisitorVideoCapture";
            buttonVisitorVideoCapture.PenWidth = 15;
            buttonVisitorVideoCapture.Rounding = true;
            buttonVisitorVideoCapture.RoundingInt = 70;
            buttonVisitorVideoCapture.Size = new Size(175, 52);
            buttonVisitorVideoCapture.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonVisitorVideoCapture.TabIndex = 1;
            buttonVisitorVideoCapture.Tag = "Cyber";
            buttonVisitorVideoCapture.TextButton = "Capture Photo";
            buttonVisitorVideoCapture.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            buttonVisitorVideoCapture.Timer_Effect_1 = 5;
            buttonVisitorVideoCapture.Timer_RGB = 300;
            buttonVisitorVideoCapture.Click += buttonVisitorVideoCapture_Click;
            // 
            // foxLinkLabel1
            // 
            foxLinkLabel1.BackColor = Color.PaleTurquoise;
            foxLinkLabel1.Dock = DockStyle.Left;
            foxLinkLabel1.DownColor = Color.FromArgb(255, 149, 0);
            foxLinkLabel1.EnabledCalc = true;
            foxLinkLabel1.Font = new Font("Segoe UI", 10F);
            foxLinkLabel1.ForeColor = Color.Black;
            foxLinkLabel1.Location = new Point(0, 0);
            foxLinkLabel1.Name = "foxLinkLabel1";
            foxLinkLabel1.OverColor = Color.FromArgb(23, 140, 229);
            foxLinkLabel1.Size = new Size(201, 52);
            foxLinkLabel1.TabIndex = 0;
            foxLinkLabel1.Click += foxLinkLabel1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleTurquoise;
            panel3.Controls.Add(buttonSave);
            panel3.Controls.Add(cyberButton1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(176, 799);
            panel3.Name = "panel3";
            panel3.Size = new Size(376, 60);
            panel3.TabIndex = 12;
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
            buttonSave.Location = new Point(170, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.PenWidth = 15;
            buttonSave.Rounding = true;
            buttonSave.RoundingInt = 70;
            buttonSave.Size = new Size(103, 60);
            buttonSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonSave.TabIndex = 4;
            buttonSave.Tag = "Cyber";
            buttonSave.TextButton = "Save";
            buttonSave.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            buttonSave.Timer_Effect_1 = 5;
            buttonSave.Timer_RGB = 300;
            buttonSave.Click += buttonSave_Click;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Dock = DockStyle.Right;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.Red;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.Red;
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(273, 0);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(103, 60);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 3;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Cancel";
            cyberButton1.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonLabelUpdateContact);
            panel4.Controls.Add(buttonEditContact);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(176, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(376, 52);
            panel4.TabIndex = 15;
            // 
            // buttonLabelUpdateContact
            // 
            buttonLabelUpdateContact.Alpha = 20;
            buttonLabelUpdateContact.BackColor = Color.Transparent;
            buttonLabelUpdateContact.Background = true;
            buttonLabelUpdateContact.Background_WidthPen = 6F;
            buttonLabelUpdateContact.BackgroundPen = true;
            buttonLabelUpdateContact.ColorBackground = Color.LightGray;
            buttonLabelUpdateContact.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonLabelUpdateContact.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonLabelUpdateContact.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonLabelUpdateContact.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonLabelUpdateContact.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonLabelUpdateContact.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonLabelUpdateContact.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonLabelUpdateContact.Dock = DockStyle.Fill;
            buttonLabelUpdateContact.Effect_1 = true;
            buttonLabelUpdateContact.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonLabelUpdateContact.Effect_1_Transparency = 25;
            buttonLabelUpdateContact.Effect_2 = true;
            buttonLabelUpdateContact.Effect_2_ColorBackground = Color.White;
            buttonLabelUpdateContact.Effect_2_Transparency = 20;
            buttonLabelUpdateContact.Font = new Font("Arial", 11F);
            buttonLabelUpdateContact.ForeColor = SystemColors.ActiveCaptionText;
            buttonLabelUpdateContact.Lighting = false;
            buttonLabelUpdateContact.LinearGradient_Background = false;
            buttonLabelUpdateContact.LinearGradientPen = false;
            buttonLabelUpdateContact.Location = new Point(0, 0);
            buttonLabelUpdateContact.Name = "buttonLabelUpdateContact";
            buttonLabelUpdateContact.PenWidth = 15;
            buttonLabelUpdateContact.RightToLeft = RightToLeft.No;
            buttonLabelUpdateContact.Rounding = true;
            buttonLabelUpdateContact.RoundingInt = 70;
            buttonLabelUpdateContact.Size = new Size(273, 52);
            buttonLabelUpdateContact.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonLabelUpdateContact.TabIndex = 17;
            buttonLabelUpdateContact.Tag = "Cyber";
            buttonLabelUpdateContact.TextButton = "Contact";
            buttonLabelUpdateContact.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            buttonLabelUpdateContact.Timer_Effect_1 = 5;
            buttonLabelUpdateContact.Timer_RGB = 300;
            // 
            // buttonEditContact
            // 
            buttonEditContact.Alpha = 20;
            buttonEditContact.BackColor = Color.Transparent;
            buttonEditContact.Background = true;
            buttonEditContact.Background_WidthPen = 4F;
            buttonEditContact.BackgroundPen = true;
            buttonEditContact.ColorBackground = Color.FromArgb(37, 52, 68);
            buttonEditContact.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonEditContact.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonEditContact.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonEditContact.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonEditContact.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonEditContact.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonEditContact.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonEditContact.Dock = DockStyle.Right;
            buttonEditContact.Effect_1 = true;
            buttonEditContact.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonEditContact.Effect_1_Transparency = 25;
            buttonEditContact.Effect_2 = true;
            buttonEditContact.Effect_2_ColorBackground = Color.White;
            buttonEditContact.Effect_2_Transparency = 20;
            buttonEditContact.Font = new Font("Arial", 11F);
            buttonEditContact.ForeColor = Color.FromArgb(245, 245, 245);
            buttonEditContact.Lighting = false;
            buttonEditContact.LinearGradient_Background = false;
            buttonEditContact.LinearGradientPen = false;
            buttonEditContact.Location = new Point(273, 0);
            buttonEditContact.Name = "buttonEditContact";
            buttonEditContact.PenWidth = 15;
            buttonEditContact.Rounding = true;
            buttonEditContact.RoundingInt = 70;
            buttonEditContact.Size = new Size(103, 52);
            buttonEditContact.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonEditContact.TabIndex = 2;
            buttonEditContact.Tag = "Cyber";
            buttonEditContact.TextButton = "Edit";
            buttonEditContact.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            buttonEditContact.Timer_Effect_1 = 5;
            buttonEditContact.Timer_RGB = 300;
            buttonEditContact.Click += buttonEditContact_Click;
            // 
            // checkedListBoxCat
            // 
            checkedListBoxCat.BackColor = Color.PaleTurquoise;
            checkedListBoxCat.Dock = DockStyle.Fill;
            checkedListBoxCat.FormattingEnabled = true;
            checkedListBoxCat.Location = new Point(176, 493);
            checkedListBoxCat.Name = "checkedListBoxCat";
            checkedListBoxCat.Size = new Size(376, 119);
            checkedListBoxCat.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.Controls.Add(cyberButtonSearch);
            panel5.Controls.Add(maskedTextBoxIC);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(176, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(376, 52);
            panel5.TabIndex = 23;
            // 
            // cyberButtonSearch
            // 
            cyberButtonSearch.Alpha = 20;
            cyberButtonSearch.BackColor = Color.Transparent;
            cyberButtonSearch.Background = true;
            cyberButtonSearch.Background_WidthPen = 4F;
            cyberButtonSearch.BackgroundPen = true;
            cyberButtonSearch.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButtonSearch.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButtonSearch.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButtonSearch.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButtonSearch.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButtonSearch.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButtonSearch.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButtonSearch.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButtonSearch.Dock = DockStyle.Right;
            cyberButtonSearch.Effect_1 = true;
            cyberButtonSearch.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButtonSearch.Effect_1_Transparency = 25;
            cyberButtonSearch.Effect_2 = true;
            cyberButtonSearch.Effect_2_ColorBackground = Color.White;
            cyberButtonSearch.Effect_2_Transparency = 20;
            cyberButtonSearch.Font = new Font("Arial", 11F);
            cyberButtonSearch.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButtonSearch.Lighting = false;
            cyberButtonSearch.LinearGradient_Background = false;
            cyberButtonSearch.LinearGradientPen = false;
            cyberButtonSearch.Location = new Point(273, 0);
            cyberButtonSearch.Name = "cyberButtonSearch";
            cyberButtonSearch.PenWidth = 15;
            cyberButtonSearch.Rounding = true;
            cyberButtonSearch.RoundingInt = 70;
            cyberButtonSearch.Size = new Size(103, 52);
            cyberButtonSearch.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButtonSearch.TabIndex = 21;
            cyberButtonSearch.Tag = "Cyber";
            cyberButtonSearch.TextButton = "Search";
            cyberButtonSearch.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            cyberButtonSearch.Timer_Effect_1 = 5;
            cyberButtonSearch.Timer_RGB = 300;
            cyberButtonSearch.Click += cyberButtonSearch_Click;
            // 
            // maskedTextBoxIC
            // 
            maskedTextBoxIC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxIC.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxIC.Location = new Point(-1, 8);
            maskedTextBoxIC.Margin = new Padding(5);
            maskedTextBoxIC.Mask = "000000-00-0000";
            maskedTextBoxIC.Name = "maskedTextBoxIC";
            maskedTextBoxIC.Size = new Size(273, 35);
            maskedTextBoxIC.TabIndex = 20;
            // 
            // comboBoxIdType
            // 
            comboBoxIdType.BackColor = Color.PaleTurquoise;
            comboBoxIdType.Dock = DockStyle.Fill;
            comboBoxIdType.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxIdType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIdType.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxIdType.FormattingEnabled = true;
            comboBoxIdType.ItemHeight = 45;
            comboBoxIdType.Location = new Point(6, 68);
            comboBoxIdType.Name = "comboBoxIdType";
            comboBoxIdType.Size = new Size(161, 51);
            comboBoxIdType.TabIndex = 25;
            comboBoxIdType.DrawItem += ComboBoxIdType_DrawItem;
            comboBoxIdType.SelectedIndexChanged += comboBoxIdType_SelectedIndexChanged;
            comboBoxIdType.Click += ComboBoxIdType_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(cyberButtonCompany);
            panel6.Controls.Add(cyberButton2);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(176, 251);
            panel6.Name = "panel6";
            panel6.Size = new Size(376, 52);
            panel6.TabIndex = 26;
            // 
            // cyberButtonCompany
            // 
            cyberButtonCompany.Alpha = 20;
            cyberButtonCompany.BackColor = Color.Transparent;
            cyberButtonCompany.Background = true;
            cyberButtonCompany.Background_WidthPen = 6F;
            cyberButtonCompany.BackgroundPen = true;
            cyberButtonCompany.ColorBackground = Color.LightGray;
            cyberButtonCompany.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButtonCompany.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButtonCompany.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButtonCompany.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButtonCompany.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButtonCompany.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButtonCompany.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButtonCompany.Dock = DockStyle.Fill;
            cyberButtonCompany.Effect_1 = true;
            cyberButtonCompany.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButtonCompany.Effect_1_Transparency = 25;
            cyberButtonCompany.Effect_2 = true;
            cyberButtonCompany.Effect_2_ColorBackground = Color.White;
            cyberButtonCompany.Effect_2_Transparency = 20;
            cyberButtonCompany.Font = new Font("Arial", 11F);
            cyberButtonCompany.ForeColor = SystemColors.ActiveCaptionText;
            cyberButtonCompany.Lighting = false;
            cyberButtonCompany.LinearGradient_Background = false;
            cyberButtonCompany.LinearGradientPen = false;
            cyberButtonCompany.Location = new Point(0, 0);
            cyberButtonCompany.Name = "cyberButtonCompany";
            cyberButtonCompany.PenWidth = 15;
            cyberButtonCompany.RightToLeft = RightToLeft.No;
            cyberButtonCompany.Rounding = true;
            cyberButtonCompany.RoundingInt = 70;
            cyberButtonCompany.Size = new Size(273, 52);
            cyberButtonCompany.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButtonCompany.TabIndex = 18;
            cyberButtonCompany.Tag = "Cyber";
            cyberButtonCompany.TextButton = "Company";
            cyberButtonCompany.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            cyberButtonCompany.Timer_Effect_1 = 5;
            cyberButtonCompany.Timer_RGB = 300;
            // 
            // cyberButton2
            // 
            cyberButton2.Alpha = 20;
            cyberButton2.BackColor = Color.Transparent;
            cyberButton2.Background = true;
            cyberButton2.Background_WidthPen = 4F;
            cyberButton2.BackgroundPen = true;
            cyberButton2.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Dock = DockStyle.Right;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Arial", 11F);
            cyberButton2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = false;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(273, 0);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(103, 52);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 3;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "Edit";
            cyberButton2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            // 
            // visitorBindingSource
            // 
            visitorBindingSource.DataSource = typeof(Data.Visitor);
            // 
            // VisitorPBEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 52, 68);
            ClientSize = new Size(558, 865);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(37, 52, 68);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "VisitorPBEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VisitorEditForm";
            Load += this.VisitorPBEditForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visitorBindingSource).EndInit();
            ResumeLayout(false);
        }

        private void TextboxVisitorTagNo_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextboxVisitorGatePass_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.ThunderLabel labelVisitorContact;
        private ReaLTaiizor.Controls.ThunderLabel labelVisitorCompany;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.CyberButton buttonVisitorVideoCapture;
        private ReaLTaiizor.Controls.FoxLinkLabel foxLinkLabel1;
        private Panel panel3;
        private Panel panel4;
        private ReaLTaiizor.Controls.CyberButton buttonEditContact;


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
        private ThunderLabel thunderLabel2;
        private CyberButton buttonLabelUpdateContact;
        private CyberButton buttonSave;
        private CyberButton cyberButton1;
        private ThunderLabel thunderLabel3;
        private CheckedListBox checkedListBoxCat;
        private BindingSource visitorBindingSource;
        private Panel panel6;
        private CyberButton cyberButtonCompany;
        private CyberButton cyberButton2;
        private ThunderLabel labelVisitorTagNo;
        private CyberTextBox textboxVisitorGatePass;
        private ThunderLabel labelVisitorGatePass;
        private CyberTextBox textboxVisitorTagNo;
        private ThunderLabel labelVisitorBranch;
        private ThunderLabel labelVisitorPurpose;
        private CheckedListBox checkedListBoxBranch;
        private CyberTextBox textboxVisitorRemarks;
        private CyberTextBox textboxVisitorFullName;
        private ThunderLabel labelVisitorFullName;
        private Panel panel5;
        private CyberButton cyberButtonSearch;
        private MaskedTextBox maskedTextBoxIC;
        private ComboBox comboBoxIdType;
        private ThunderLabel labelVisitorPermitNo;
        private CyberTextBox cyberTextBox1;
    }
}