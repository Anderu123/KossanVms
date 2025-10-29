using KossanVMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KossanVMS.Modules.VMS.UserControlPage
{
    public partial class PreRegisteredPBUserControl : UserControl
    {
        private VmsContext _db;
        

        public PreRegisteredPBUserControl(VmsContext db)
        {
            InitializeComponent();
            ApplyLayoutGuards();
        }
        private void ApplyLayoutGuards()
        {
            tableLayoutPanel4.RowStyles[0] = new RowStyle(SizeType.Absolute, 220f);
            tableLayoutPanel4.RowStyles[1] = new RowStyle(SizeType.Percent, 50f);
            for(int i =0; i<6; i++)
            {
                tableLayoutPanel3.RowStyles[i] = new RowStyle(SizeType.Absolute, 48f);
                tableLayoutPanel3.RowStyles[6] = new RowStyle(SizeType.Percent, 100f);
            }
            for(int i=0; i <6; i++)
            {
                tableLayoutPanel5.RowStyles[i] = new RowStyle(SizeType.Absolute, 48f);
                tableLayoutPanel5.RowStyles[6] = new RowStyle(SizeType.Absolute, 52F);
            }
            foreach (var t in new ReaLTaiizor.Controls.CyberTextBox[]
            {
        textboxTagNo, textboxRegisterType, textboxName, textboxIdNo, textboxCompany, textboxContact,
        textboxVehicleNo, textboxCategory, textboxGatePass, textboxPerson, textboxDoNo, textboxRemark
            })
            {
                t.AutoSize = false;
                if (t.MinimumSize.Height < 44) t.MinimumSize = new Size(0, 44);
                if (t.PenWidth > 10) t.PenWidth = 10; // optional: more inner space
            }

            // 5) Safety net: allow scrolling if space gets tight (small window, DPI, etc.)
            panel3.AutoScroll = true;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.Dock = DockStyle.Top;

            // (Optional) remove unused paint hooks to avoid redraw churn
            //tableLayoutPanel2.Paint -= tableLayoutPanel2_Paint;
        }
    }
}
