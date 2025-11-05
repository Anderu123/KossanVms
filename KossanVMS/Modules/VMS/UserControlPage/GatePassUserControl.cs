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
    public partial class GatePassUserControl : UserControl
    {
        public GatePassUserControl(VmsContext _db)
        {
            InitializeComponent();
            hopeTabPage1.SuspendLayout();
            var tab1 = new System.Windows.Forms.TabPage("Pre-Registered") { Name = "Pre-RegisteredTab" };
            tab1.SuspendLayout();
            tab1.Controls.Add(new PreRegisteredPBUserControl(_db) { Dock = DockStyle.Fill});
            tab1.ResumeLayout();
            hopeTabPage1.TabPages.Add(tab1);

            var tab2 = new System.Windows.Forms.TabPage("Check-Out") { Name = "Check-OutTab", AutoScroll = true };
            tab2.SuspendLayout();
            tab2.Controls.Add(new CheckOutPBUserControl(_db) { Dock = DockStyle.Fill });
            tab2.ResumeLayout();
            hopeTabPage1.TabPages.Add(tab2);


            hopeTabPage1.Padding = new Point(0,0);
            hopeTabPage1.Margin = new Padding(0);
            hopeTabPage1.Dock = DockStyle.Fill;

            //foreach (TabPage tp in hopeTabPage1.TabPages)
            //{
            //    tp.Margin = Padding.Empty;
            //    tp.Padding = Padding.Empty;           // TabPage uses Padding
            //}

            //// your user control on the page
            //var gate = new GatePassUserControl(_db)
            //{
            //    Dock = DockStyle.Fill,
            //    Margin = Padding.Empty,
            //    Padding = Padding.Empty
            //};
            hopeTabPage1.ResumeLayout();
            hopeTabPage1.SelectedTab = tab1;
        }
    }
}
