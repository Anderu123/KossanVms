namespace KossanVMS.Utility
{
    partial class VisitorCard
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
            parrotCard1 = new ReaLTaiizor.Controls.ParrotCard();
            SuspendLayout();
            // 
            // parrotCard1
            // 
            parrotCard1.BackColor = Color.Transparent;
            parrotCard1.Color1 = Color.DodgerBlue;
            parrotCard1.Color2 = Color.LimeGreen;
            parrotCard1.Dock = DockStyle.Fill;
            parrotCard1.ForeColor = Color.White;
            parrotCard1.Location = new Point(0, 0);
            parrotCard1.Name = "parrotCard1";
            parrotCard1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotCard1.Size = new Size(350, 200);
            parrotCard1.TabIndex = 0;
            parrotCard1.Text = "parrotCard1";
            parrotCard1.Text1 = "Credit Card";
            parrotCard1.Text2 = "1357 2468 9013 5724";
            parrotCard1.Text3 = "Exp: 01/02 - 03/04";
            parrotCard1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // VisitorCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parrotCard1);
            Name = "VisitorCard";
            Size = new Size(350, 200);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotCard parrotCard1;
    }
}
