using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KossanVMS.Utility
{
    public partial class RoundedPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Create a rounded rectangle path
            using (var path = new GraphicsPath())
            {
                int radius = 10;
                path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                path.AddArc(Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
                path.AddArc(Width - radius * 2, Height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(0, Height - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                // Set the panel's region to the rounded rectangle
                this.Region = new System.Drawing.Region(path);

                // You can also draw the border directly
                using (var pen = new Pen(Color.FromArgb(128, 255,0,0), 2))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
}
}
