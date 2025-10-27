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
    public partial class GatePassUserControl : UserControl
    {
        public GatePassUserControl()
        {
            InitializeComponent();
            hopeTabPage1.SuspendLayout();
            var tab1 = new System.Windows.Forms.TabPage("Pre-Registered") { Name = "Pre-RegisteredTab" };
            tab1.SuspendLayout();
            tab1.Controls.Add(new PreRegisteredPBUserControl() { Dock = DockStyle.Fill});
            tab1.ResumeLayout();
            hopeTabPage1.TabPages.Add(tab1);

            var tab2 = new System.Windows.Forms.TabPage("Check-Out") { Name = "Check-OutTab", AutoScroll = true };
            tab2.SuspendLayout();
            tab2.Controls.Add(new CheckOutPBUserControl() { Dock = DockStyle.Fill });
            tab2.ResumeLayout();
            hopeTabPage1.TabPages.Add(tab2);

            hopeTabPage1.ResumeLayout();
            hopeTabPage1.SelectedTab = tab1;
        }
    }
}
