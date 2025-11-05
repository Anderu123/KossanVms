using KossanVMS.Data;
using KossanVMS.UserControlPage;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabPage = System.Windows.Forms.TabPage;


namespace KossanVMS.Modules.VMS.UserControlPage
{
    public partial class MainPageUserControl : UserControl
    {
        private readonly VmsContext _db;
        private HopeTabPage hopeTabPage1;
        public MainPageUserControl(VmsContext db)
        {
            InitializeComponent();
            _db = db ?? throw new ArgumentNullException(nameof(db));

            // Build tab control (or use the designer one if you already have it)
            hopeTabPage1 = new HopeTabPage
            {
                Dock = DockStyle.Fill,
                Name = "hopeTabPage1",
            };
            Controls.Clear();
            Controls.Add(hopeTabPage1);

            // Populate tabs
            hopeTabPage1.SuspendLayout();
            hopeTabPage1.TabPages.Clear();

            var tabDashboard = new TabPage("Dashboard") { Name = "DashboardTab" };
            tabDashboard.Controls.Add(new DashboardUserControl(_db) { Dock = DockStyle.Fill });
            hopeTabPage1.TabPages.Add(tabDashboard);

            var tabPreRegister = new TabPage("Pre-Register") { Name = "VisitorTab" };
            tabPreRegister.Controls.Add(new VisitorUserControl(_db) { Dock = DockStyle.Fill });
            hopeTabPage1.TabPages.Add(tabPreRegister);

            var tabPbRegister = new TabPage("Register") { Name = "RegisterTab" };
            tabPbRegister.Controls.Add(new VisitorPBUserControl(_db) { Dock = DockStyle.Fill });
            hopeTabPage1.TabPages.Add(tabPbRegister);

            var tabGatePass = new TabPage("GatePass") { Name = "GatePass" };
            tabGatePass.Controls.Add(new GatePassUserControl(_db) { Dock = DockStyle.Fill });
            hopeTabPage1.TabPages.Add(tabGatePass);

            hopeTabPage1.SelectedTab = tabDashboard;
            hopeTabPage1.ResumeLayout();
        }
    }
}
