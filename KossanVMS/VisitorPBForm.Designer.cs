using KossanVMS.Utility;
using ReaLTaiizor.Controls;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using Panel = System.Windows.Forms.Panel;
using System.Diagnostics;
namespace KossanVMS
{
    partial class VisitorEditForm
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
                _db.Dispose();
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            thunderLabel3 = new ThunderLabel();
            textboxVisitorFullName = new CyberTextBox();
            thunderLabel2 = new ThunderLabel();
            labelVisitorID = new ThunderLabel();
            thunderLabel1 = new ThunderLabel();
            labelVisitorCompany = new ThunderLabel();
            labelVisitorContact = new ThunderLabel();
            labelVisitorFullName = new ThunderLabel();
            labelVisitorIC = new ThunderLabel();
            skyComboBox1 = new SkyComboBox();
            panel2 = new Panel();
            buttonVisitorVideoCapture = new CyberButton();
            foxLinkLabel1 = new FoxLinkLabel();
            panel3 = new Panel();
            buttonSave = new CyberButton();
            cyberButton1 = new CyberButton();
            panel4 = new Panel();
            buttonLabelUpdateContact = new CyberButton();
            buttonEditContact = new CyberButton();
            buttonUpdateID = new CyberButton();
            checkedListBoxCat = new CheckedListBox();
            panel5 = new Panel();
            cyberButtonSearch = new CyberButton();
            maskedTextBoxIC = new MaskedTextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 523);
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
            tableLayoutPanel1.Controls.Add(thunderLabel3, 0, 6);
            tableLayoutPanel1.Controls.Add(textboxVisitorFullName, 1, 2);
            tableLayoutPanel1.Controls.Add(thunderLabel2, 0, 7);
            tableLayoutPanel1.Controls.Add(labelVisitorID, 0, 0);
            tableLayoutPanel1.Controls.Add(thunderLabel1, 0, 5);
            tableLayoutPanel1.Controls.Add(labelVisitorCompany, 0, 4);
            tableLayoutPanel1.Controls.Add(labelVisitorContact, 0, 3);
            tableLayoutPanel1.Controls.Add(labelVisitorFullName, 0, 2);
            tableLayoutPanel1.Controls.Add(labelVisitorIC, 0, 1);
            tableLayoutPanel1.Controls.Add(skyComboBox1, 1, 4);
            tableLayoutPanel1.Controls.Add(panel2, 1, 5);
            tableLayoutPanel1.Controls.Add(panel3, 1, 7);
            tableLayoutPanel1.Controls.Add(panel4, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonUpdateID, 1, 0);
            tableLayoutPanel1.Controls.Add(checkedListBoxCat, 1, 6);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1003828F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9209585F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9209642F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9209642F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9209642F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9209642F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.3716488F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.92315F));
            tableLayoutPanel1.Size = new Size(451, 523);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.PaleTurquoise;
            thunderLabel3.Dock = DockStyle.Fill;
            thunderLabel3.ForeColor = Color.Transparent;
            thunderLabel3.Location = new Point(6, 349);
            thunderLabel3.Name = "thunderLabel3";
            thunderLabel3.Size = new Size(128, 109);
            thunderLabel3.TabIndex = 21;
            thunderLabel3.Text = "Category";
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
            textboxVisitorFullName.Font = new Font("Arial", 12F);
            textboxVisitorFullName.ForeColor = Color.Black;
            textboxVisitorFullName.Lighting = false;
            textboxVisitorFullName.LinearGradientPen = false;
            textboxVisitorFullName.Location = new Point(143, 121);
            textboxVisitorFullName.Name = "textboxVisitorFullName";
            textboxVisitorFullName.PenWidth = 15;
            textboxVisitorFullName.RGB = false;
            textboxVisitorFullName.Rounding = true;
            textboxVisitorFullName.RoundingInt = 60;
            textboxVisitorFullName.Size = new Size(302, 48);
            textboxVisitorFullName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textboxVisitorFullName.TabIndex = 18;
            textboxVisitorFullName.Tag = "Cyber";
            textboxVisitorFullName.TextButton = "";
            textboxVisitorFullName.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            textboxVisitorFullName.Timer_RGB = 300;
            textboxVisitorFullName.Enter += textBoxUpdate_Enter;
            textboxVisitorFullName.Leave += textBoxUpdate_Leave;
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.PaleTurquoise;
            thunderLabel2.Dock = DockStyle.Fill;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(6, 467);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(128, 50);
            thunderLabel2.TabIndex = 17;
            // 
            // labelVisitorID
            // 
            labelVisitorID.BackColor = Color.PaleTurquoise;
            labelVisitorID.Dock = DockStyle.Fill;
            labelVisitorID.ForeColor = Color.Transparent;
            labelVisitorID.Location = new Point(6, 6);
            labelVisitorID.Name = "labelVisitorID";
            labelVisitorID.Size = new Size(128, 49);
            labelVisitorID.TabIndex = 13;
            labelVisitorID.Text = "ID";
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.PaleTurquoise;
            thunderLabel1.Dock = DockStyle.Fill;
            thunderLabel1.ForeColor = Color.Transparent;
            thunderLabel1.Location = new Point(6, 292);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(128, 48);
            thunderLabel1.TabIndex = 10;
            thunderLabel1.Text = "Photo";
            // 
            // labelVisitorCompany
            // 
            labelVisitorCompany.BackColor = Color.PaleTurquoise;
            labelVisitorCompany.Dock = DockStyle.Fill;
            labelVisitorCompany.ForeColor = Color.Transparent;
            labelVisitorCompany.Location = new Point(6, 235);
            labelVisitorCompany.Name = "labelVisitorCompany";
            labelVisitorCompany.Size = new Size(128, 48);
            labelVisitorCompany.TabIndex = 6;
            labelVisitorCompany.Text = "Company";
            // 
            // labelVisitorContact
            // 
            labelVisitorContact.BackColor = Color.PaleTurquoise;
            labelVisitorContact.Dock = DockStyle.Fill;
            labelVisitorContact.ForeColor = Color.Transparent;
            labelVisitorContact.Location = new Point(6, 178);
            labelVisitorContact.Name = "labelVisitorContact";
            labelVisitorContact.Size = new Size(128, 48);
            labelVisitorContact.TabIndex = 4;
            labelVisitorContact.Text = "Contact";
            // 
            // labelVisitorFullName
            // 
            labelVisitorFullName.BackColor = Color.PaleTurquoise;
            labelVisitorFullName.Dock = DockStyle.Fill;
            labelVisitorFullName.ForeColor = Color.Transparent;
            labelVisitorFullName.Location = new Point(6, 121);
            labelVisitorFullName.Name = "labelVisitorFullName";
            labelVisitorFullName.Size = new Size(128, 48);
            labelVisitorFullName.TabIndex = 2;
            labelVisitorFullName.Text = "Full Name";
            // 
            // labelVisitorIC
            // 
            labelVisitorIC.BackColor = Color.PaleTurquoise;
            labelVisitorIC.Dock = DockStyle.Fill;
            labelVisitorIC.ForeColor = Color.Transparent;
            labelVisitorIC.Location = new Point(6, 64);
            labelVisitorIC.Name = "labelVisitorIC";
            labelVisitorIC.Size = new Size(128, 48);
            labelVisitorIC.TabIndex = 1;
            labelVisitorIC.Text = "IC";
            // 
            // skyComboBox1
            // 
            skyComboBox1.BackColor = Color.Transparent;
            skyComboBox1.BGColorA = Color.FromArgb(245, 245, 245);
            skyComboBox1.BGColorB = Color.FromArgb(230, 230, 230);
            skyComboBox1.BorderColorA = Color.FromArgb(252, 252, 252);
            skyComboBox1.BorderColorB = Color.FromArgb(249, 249, 249);
            skyComboBox1.BorderColorC = Color.FromArgb(189, 189, 189);
            skyComboBox1.BorderColorD = Color.FromArgb(200, 168, 168, 168);
            skyComboBox1.Dock = DockStyle.Fill;
            skyComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            skyComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            skyComboBox1.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            skyComboBox1.ForeColor = Color.FromArgb(27, 94, 137);
            skyComboBox1.FormattingEnabled = true;
            skyComboBox1.ItemHeight = 40;
            skyComboBox1.ItemHighlightColor = Color.FromArgb(121, 176, 214);
            skyComboBox1.LineColorA = Color.White;
            skyComboBox1.LineColorB = Color.FromArgb(189, 189, 189);
            skyComboBox1.LineColorC = Color.White;
            skyComboBox1.ListBackColor = Color.FromArgb(255, 255, 255);
            skyComboBox1.ListBorderColor = Color.FromArgb(50, 0, 0, 0);
            skyComboBox1.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            skyComboBox1.ListForeColor = Color.Black;
            skyComboBox1.ListSelectedBackColorA = Color.FromArgb(15, 255, 255, 255);
            skyComboBox1.ListSelectedBackColorB = Color.FromArgb(0, 255, 255, 255);
            skyComboBox1.Location = new Point(143, 235);
            skyComboBox1.Name = "skyComboBox1";
            skyComboBox1.Size = new Size(302, 46);
            skyComboBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            skyComboBox1.StartIndex = 0;
            skyComboBox1.TabIndex = 7;
            skyComboBox1.TriangleColorA = Color.FromArgb(121, 176, 214);
            skyComboBox1.TriangleColorB = Color.FromArgb(27, 94, 137);
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonVisitorVideoCapture);
            panel2.Controls.Add(foxLinkLabel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(143, 292);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 48);
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
            buttonVisitorVideoCapture.Size = new Size(101, 48);
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
            foxLinkLabel1.Size = new Size(201, 48);
            foxLinkLabel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleTurquoise;
            panel3.Controls.Add(buttonSave);
            panel3.Controls.Add(cyberButton1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(143, 467);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 50);
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
            buttonSave.Location = new Point(96, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.PenWidth = 15;
            buttonSave.Rounding = true;
            buttonSave.RoundingInt = 70;
            buttonSave.Size = new Size(103, 50);
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
            cyberButton1.Location = new Point(199, 0);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(103, 50);
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
            panel4.Location = new Point(143, 178);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 48);
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
            buttonLabelUpdateContact.Size = new Size(199, 48);
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
            buttonEditContact.Location = new Point(199, 0);
            buttonEditContact.Name = "buttonEditContact";
            buttonEditContact.PenWidth = 15;
            buttonEditContact.Rounding = true;
            buttonEditContact.RoundingInt = 70;
            buttonEditContact.Size = new Size(103, 48);
            buttonEditContact.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonEditContact.TabIndex = 2;
            buttonEditContact.Tag = "Cyber";
            buttonEditContact.TextButton = "Edit";
            buttonEditContact.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            buttonEditContact.Timer_Effect_1 = 5;
            buttonEditContact.Timer_RGB = 300;
            buttonEditContact.Click += buttonEditContact_Click;
            // 
            // buttonUpdateID
            // 
            buttonUpdateID.Alpha = 20;
            buttonUpdateID.BackColor = Color.Transparent;
            buttonUpdateID.Background = true;
            buttonUpdateID.Background_WidthPen = 6F;
            buttonUpdateID.BackgroundPen = true;
            buttonUpdateID.ColorBackground = Color.LightGray;
            buttonUpdateID.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonUpdateID.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonUpdateID.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonUpdateID.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonUpdateID.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonUpdateID.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonUpdateID.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonUpdateID.Dock = DockStyle.Fill;
            buttonUpdateID.Effect_1 = true;
            buttonUpdateID.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonUpdateID.Effect_1_Transparency = 25;
            buttonUpdateID.Effect_2 = true;
            buttonUpdateID.Effect_2_ColorBackground = Color.White;
            buttonUpdateID.Effect_2_Transparency = 20;
            buttonUpdateID.Font = new Font("Arial", 11F);
            buttonUpdateID.ForeColor = SystemColors.ActiveCaptionText;
            buttonUpdateID.Lighting = false;
            buttonUpdateID.LinearGradient_Background = false;
            buttonUpdateID.LinearGradientPen = false;
            buttonUpdateID.Location = new Point(143, 6);
            buttonUpdateID.Name = "buttonUpdateID";
            buttonUpdateID.PenWidth = 15;
            buttonUpdateID.RightToLeft = RightToLeft.No;
            buttonUpdateID.Rounding = true;
            buttonUpdateID.RoundingInt = 70;
            buttonUpdateID.Size = new Size(302, 49);
            buttonUpdateID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonUpdateID.TabIndex = 16;
            buttonUpdateID.Tag = "Cyber";
            buttonUpdateID.TextButton = "ID";
            buttonUpdateID.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            buttonUpdateID.Timer_Effect_1 = 5;
            buttonUpdateID.Timer_RGB = 300;
            buttonUpdateID.Enter += buttonUpdate_Enter;
            buttonUpdateID.Leave += buttonUpdate_Leave;
            // 
            // checkedListBoxCat
            // 
            checkedListBoxCat.BackColor = Color.PaleTurquoise;
            checkedListBoxCat.Dock = DockStyle.Fill;
            checkedListBoxCat.FormattingEnabled = true;
            checkedListBoxCat.Location = new Point(143, 349);
            checkedListBoxCat.Name = "checkedListBoxCat";
            checkedListBoxCat.Size = new Size(302, 109);
            checkedListBoxCat.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.Controls.Add(cyberButtonSearch);
            panel5.Controls.Add(maskedTextBoxIC);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(143, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(302, 48);
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
            cyberButtonSearch.Location = new Point(199, 0);
            cyberButtonSearch.Name = "cyberButtonSearch";
            cyberButtonSearch.PenWidth = 15;
            cyberButtonSearch.Rounding = true;
            cyberButtonSearch.RoundingInt = 70;
            cyberButtonSearch.Size = new Size(103, 48);
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
            maskedTextBoxIC.Size = new Size(199, 35);
            maskedTextBoxIC.TabIndex = 20;
            // 
            // VisitorEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 52, 68);
            ClientSize = new Size(451, 523);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(37, 52, 68);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VisitorEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VisitorEditForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.ThunderLabel labelVisitorIC;
        private ReaLTaiizor.Controls.ThunderLabel labelVisitorFullName;
        private ReaLTaiizor.Controls.ThunderLabel labelVisitorContact;
        private ReaLTaiizor.Controls.ThunderLabel labelVisitorCompany;
        private ReaLTaiizor.Controls.SkyComboBox skyComboBox1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.CyberButton buttonVisitorVideoCapture;
        private ReaLTaiizor.Controls.FoxLinkLabel foxLinkLabel1;
        private Panel panel3;
        private ReaLTaiizor.Controls.ThunderLabel labelVisitorID;
        private Panel panel4;
        private ReaLTaiizor.Controls.CyberButton buttonEditContact;
        private ReaLTaiizor.Controls.CyberButton buttonUpdateID;


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
        private CyberTextBox textboxVisitorFullName;
        private ThunderLabel thunderLabel3;
        private CheckedListBox checkedListBoxCat;
        private Panel panel5;
        private CyberButton cyberButtonSearch;
        private MaskedTextBox maskedTextBoxIC;
    }
}