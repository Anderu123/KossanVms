using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KossanVMS.Utility
{
    public class FocusableLabel:Label
    {
        public Color BorderColor { get; set; } = Color.Gray;
        public Color BorderColorFocus { get; set; } = Color.Teal;


        public FocusableLabel()
        {
            SetStyle(ControlStyles.Selectable,true);
            BorderStyle = BorderStyle.None;

        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            Invalidate();
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e); Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var rect = ClientRectangle;
            rect.Inflate(-1, 1);
            var c = Focused ? BorderColor : BorderColorFocus;
            ControlPaint.DrawBorder(e.Graphics, rect, c, ButtonBorderStyle.Solid);
        }
    }
}
