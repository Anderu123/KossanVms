namespace KossanVMS
{
    partial class ADLoginScreen
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            labelSignIn = new ReaLTaiizor.Controls.LostLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxLoginUser = new ReaLTaiizor.Controls.CyberTextBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            textBoxLoginPassword = new ReaLTaiizor.Controls.CyberTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            buttonLogin = new ReaLTaiizor.Controls.CyberButton();
            buttonCancel = new ReaLTaiizor.Controls.CyberButton();
            statusStripLogin = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.PaleTurquoise;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(599, 330);
            splitContainer1.SplitterDistance = 174;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(labelSignIn);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer2.Size = new Size(599, 174);
            splitContainer2.SplitterDistance = 32;
            splitContainer2.TabIndex = 1;
            // 
            // labelSignIn
            // 
            labelSignIn.BackColor = Color.PaleTurquoise;
            labelSignIn.Dock = DockStyle.Fill;
            labelSignIn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSignIn.ForeColor = Color.Black;
            labelSignIn.Location = new Point(0, 0);
            labelSignIn.Name = "labelSignIn";
            labelSignIn.Size = new Size(599, 32);
            labelSignIn.TabIndex = 0;
            labelSignIn.Text = "Sign In";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(37, 52, 68);
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.10917F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.89083F));
            tableLayoutPanel1.Controls.Add(textBoxLoginUser, 1, 0);
            tableLayoutPanel1.Controls.Add(thunderLabel2, 0, 1);
            tableLayoutPanel1.Controls.Add(thunderLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxLoginPassword, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(599, 138);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxLoginUser
            // 
            textBoxLoginUser.Alpha = 20;
            textBoxLoginUser.BackColor = Color.Transparent;
            textBoxLoginUser.Background_WidthPen = 6F;
            textBoxLoginUser.BackgroundPen = true;
            textBoxLoginUser.ColorBackground = Color.LightGray;
            textBoxLoginUser.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            textBoxLoginUser.ColorLighting = Color.FromArgb(29, 200, 238);
            textBoxLoginUser.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textBoxLoginUser.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textBoxLoginUser.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textBoxLoginUser.Dock = DockStyle.Fill;
            textBoxLoginUser.Font = new Font("Arial", 14F);
            textBoxLoginUser.ForeColor = Color.Black;
            textBoxLoginUser.Lighting = false;
            textBoxLoginUser.LinearGradientPen = false;
            textBoxLoginUser.Location = new Point(157, 6);
            textBoxLoginUser.Name = "textBoxLoginUser";
            textBoxLoginUser.PenWidth = 15;
            textBoxLoginUser.RGB = false;
            textBoxLoginUser.Rounding = true;
            textBoxLoginUser.RoundingInt = 60;
            textBoxLoginUser.Size = new Size(436, 58);
            textBoxLoginUser.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textBoxLoginUser.TabIndex = 4;
            textBoxLoginUser.Tag = "Cyber";
            textBoxLoginUser.TextButton = "";
            textBoxLoginUser.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textBoxLoginUser.Timer_RGB = 300;
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.PaleTurquoise;
            thunderLabel2.Dock = DockStyle.Fill;
            thunderLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thunderLabel2.ForeColor = Color.Transparent;
            thunderLabel2.Location = new Point(6, 73);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(142, 59);
            thunderLabel2.TabIndex = 3;
            thunderLabel2.Text = "Password";
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.PaleTurquoise;
            thunderLabel1.Dock = DockStyle.Fill;
            thunderLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thunderLabel1.ForeColor = Color.Transparent;
            thunderLabel1.Location = new Point(6, 6);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(142, 58);
            thunderLabel1.TabIndex = 0;
            thunderLabel1.Text = "User";
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.Alpha = 20;
            textBoxLoginPassword.BackColor = Color.Transparent;
            textBoxLoginPassword.Background_WidthPen = 6F;
            textBoxLoginPassword.BackgroundPen = true;
            textBoxLoginPassword.ColorBackground = Color.LightGray;
            textBoxLoginPassword.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            textBoxLoginPassword.ColorLighting = Color.FromArgb(29, 200, 238);
            textBoxLoginPassword.ColorPen_1 = Color.FromArgb(29, 200, 238);
            textBoxLoginPassword.ColorPen_2 = Color.FromArgb(37, 52, 68);
            textBoxLoginPassword.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            textBoxLoginPassword.Dock = DockStyle.Fill;
            textBoxLoginPassword.Font = new Font("Arial", 14F);
            textBoxLoginPassword.ForeColor = Color.Black;
            textBoxLoginPassword.Lighting = false;
            textBoxLoginPassword.LinearGradientPen = false;
            textBoxLoginPassword.Location = new Point(157, 73);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Password = true;
            textBoxLoginPassword.PenWidth = 15;
            textBoxLoginPassword.RGB = false;
            textBoxLoginPassword.Rounding = true;
            textBoxLoginPassword.RoundingInt = 60;
            textBoxLoginPassword.Size = new Size(436, 59);
            textBoxLoginPassword.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            textBoxLoginPassword.TabIndex = 2;
            textBoxLoginPassword.Tag = "Cyber";
            textBoxLoginPassword.TextButton = "";
            textBoxLoginPassword.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            textBoxLoginPassword.Timer_RGB = 300;
            // Delete the old line:
            // textBoxLoginPassword.KeyPress += textBoxLoginPassword_KeyDown;

            // Add the new line:
            this.textBoxLoginPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLoginPassword_KeyDown);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Controls.Add(statusStripLogin, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(599, 152);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(buttonCancel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(302, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 60);
            panel1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            buttonLogin.Alpha = 20;
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.Background = true;
            buttonLogin.Background_WidthPen = 4F;
            buttonLogin.BackgroundPen = true;
            buttonLogin.ColorBackground = Color.FromArgb(37, 52, 68);
            buttonLogin.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            buttonLogin.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            buttonLogin.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            buttonLogin.ColorLighting = Color.FromArgb(29, 200, 238);
            buttonLogin.ColorPen_1 = Color.FromArgb(37, 52, 68);
            buttonLogin.ColorPen_2 = Color.FromArgb(41, 63, 86);
            buttonLogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            buttonLogin.Dock = DockStyle.Right;
            buttonLogin.Effect_1 = true;
            buttonLogin.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            buttonLogin.Effect_1_Transparency = 25;
            buttonLogin.Effect_2 = true;
            buttonLogin.Effect_2_ColorBackground = Color.White;
            buttonLogin.Effect_2_Transparency = 20;
            buttonLogin.Font = new Font("Arial", 11F);
            buttonLogin.ForeColor = Color.Lime;
            buttonLogin.Lighting = false;
            buttonLogin.LinearGradient_Background = false;
            buttonLogin.LinearGradientPen = false;
            buttonLogin.Location = new Point(34, 0);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.PenWidth = 15;
            buttonLogin.Rounding = true;
            buttonLogin.RoundingInt = 70;
            buttonLogin.Size = new Size(130, 60);
            buttonLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonLogin.TabIndex = 3;
            buttonLogin.Tag = "Cyber";
            buttonLogin.TextButton = "Login";
            buttonLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonLogin.Timer_Effect_1 = 5;
            buttonLogin.Timer_RGB = 300;
            buttonLogin.Click += buttonLogin_Click;
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
            buttonCancel.Location = new Point(164, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.PenWidth = 15;
            buttonCancel.Rounding = true;
            buttonCancel.RoundingInt = 70;
            buttonCancel.Size = new Size(130, 60);
            buttonCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            buttonCancel.TabIndex = 2;
            buttonCancel.Tag = "Cyber";
            buttonCancel.TextButton = "Cancel";
            buttonCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            buttonCancel.Timer_Effect_1 = 5;
            buttonCancel.Timer_RGB = 300;
            // 
            // statusStripLogin
            // 
            tableLayoutPanel2.SetColumnSpan(statusStripLogin, 2);
            statusStripLogin.Location = new Point(0, 132);
            statusStripLogin.Name = "statusStripLogin";
            statusStripLogin.Size = new Size(599, 20);
            statusStripLogin.TabIndex = 1;
            statusStripLogin.Text = "statusStrip1";
            // 
            // ADLoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 330);
            Controls.Add(splitContainer1);
            Name = "ADLoginScreen";
            Text = "ADLoginScreen";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.CyberTextBox textBoxLoginPassword;
        private ReaLTaiizor.Controls.LostLabel labelSignIn;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private ReaLTaiizor.Controls.CyberButton buttonLogin;
        private ReaLTaiizor.Controls.CyberButton buttonCancel;
        private ReaLTaiizor.Controls.CyberTextBox textBoxLoginUser;
        private StatusStrip statusStripLogin;
    }
}