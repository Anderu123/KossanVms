using MaterialSkin.Controls;
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
    public static  class ApplyRoundEdgeHelper
    {
        public static void ApplyRoundEdge(Form form, int cornerRadius)
        {
            form.FormBorderStyle = FormBorderStyle.None;

            // Subscribe to the form's Paint and Resize events
            form.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Create a graphics path for the rounded rectangle
                using (GraphicsPath path = new GraphicsPath())
                {
                    Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);

                    path.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
                    path.AddArc(rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
                    path.AddArc(rect.Width - cornerRadius * 2, rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                    path.AddArc(rect.X, rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                    path.CloseAllFigures();

                    // Set the form's region to the new rounded path
                    form.Region = new Region(path);

                    // Draw the border
                    //using (Pen borderPen = new Pen(borderColor, borderWidth))
                    //{
                    //    e.Graphics.DrawPath(borderPen, path);
                    //}
                }
            };

            form.Resize += (sender, e) =>
            {
                form.Invalidate(); // Force a redraw on resize
            };
        }
    }
}
