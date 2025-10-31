using KossanVMS.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using KossanVMS.UserControlPage;
using ReaLTaiizor.Controls;
using KossanVMS.Modules.VMS.UserControlPage;

namespace KossanVMS
{
    public partial class MainPage : Form
    {

        private readonly VmsContext _db;
        private int _cornerRadius = 10;

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    this.
        //    (); 
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;


        //    GraphicsPath path = new GraphicsPath();
        //    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

        //    path.AddArc(rect.X, rect.Y, _cornerRadius * 2, _cornerRadius * 2, 180, 90);
        //    path.AddArc(rect.Width - _cornerRadius * 2, rect.Y, _cornerRadius * 2, _cornerRadius * 2, 270, 90);
        //    path.AddArc(rect.Width - _cornerRadius * 2, rect.Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 0, 90);
        //    path.AddArc(rect.X, rect.Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 90, 90);
        //    path.CloseAllFigures();

        //    this.Region = new Region(path);


        //}

        public MainPage(VmsContext db)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            // If you ever set size manually, use WorkingArea (not Bounds):
            var wa = Screen.FromControl(this).WorkingArea;
            this.Location = wa.Location;
            this.Size = wa.Size;
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Amber200, TextShade.WHITE);
            //this.Hide();
            _db = db;
            var visitorForm = new VisitorUserControl(_db) { Dock = DockStyle.Fill };
            var dashboardForm = new DashboardUserControl(_db) { Dock = DockStyle.Fill };
            //mainPanel.Controls.Clear();
            //mainPanel.Controls.Add(visitorForm);
            hopeTabPage1.SuspendLayout();

            var tab1 = new System.Windows.Forms.TabPage("Dashboard") { Name = "DashboardTab" };
            tab1.SuspendLayout();
            tab1.Controls.Add(new DashboardUserControl(_db) { Dock = DockStyle.Fill });
            tab1.ResumeLayout();
            hopeTabPage1.TabPages.Add(tab1);

            var tab2 = new System.Windows.Forms.TabPage("Pre-Register") { Name = "VisitorsTab" };
            tab2.SuspendLayout();
            tab2.Controls.Add(new VisitorUserControl(_db) { Dock = DockStyle.Fill });
            hopeTabPage1.TabPages.Add(tab2);
            tab2.ResumeLayout();
            
            var tab3 = new System.Windows.Forms.TabPage("Register") { Name = "PBTab" };
            tab3.SuspendLayout();
            tab3.Controls.Add(new VisitorPBUserControl(_db) { Dock = DockStyle.Fill });
            tab3.ResumeLayout();
            hopeTabPage1.TabPages.Add(tab3);

            var tab4 = new System.Windows.Forms.TabPage("Branch") { Name = "BranchesTab" };
            tab4.SuspendLayout();
            tab4.Controls.Add(new BranchUserControl(_db) { Dock = DockStyle.Fill });
            tab4.ResumeLayout();
            hopeTabPage1.TabPages.Add(tab4);    
            
            var tab5 = new System.Windows.Forms.TabPage("Category") { Name = "CategoriesTab" };
            tab5.SuspendLayout();
            tab5.Controls.Add(new CategoryUserControl(_db) { Dock = DockStyle.Fill });
            tab5.ResumeLayout();
            hopeTabPage1.TabPages.Add(tab5);
            var tab6 = new System.Windows.Forms.TabPage("GatePass") { Name = "GatePassTab" };
            tab6.SuspendLayout();
            tab6.Controls.Add(new GatePassUserControl(_db) { Dock = DockStyle.Fill });
            tab6.ResumeLayout();
            hopeTabPage1.TabPages.Add(tab6);

            hopeTabPage1.ResumeLayout();
            hopeTabPage1.SelectedTab = tab1;


            //UserLoginForm userLoginForm = new UserLoginForm();

            ////userLoginForm.Show();
            //UserEditForm userEditForm = new UserEditForm();
            //userEditForm.Show();

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Update if the form moves to a different monitor
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ShowPage(UserControl page, CyberButton activeBtn)
        {
            mainPanel.SuspendLayout();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(page);
            mainPanel.ResumeLayout();
            Control navContainer = activeBtn.Parent; // 
            foreach (var cb in navContainer.Controls.OfType<CyberButton>())
            {
                bool isActive = cb == activeBtn;
                cb.BackColor = isActive ? Color.SteelBlue : SystemColors.Control;
                cb.ForeColor = isActive ? Color.White : SystemColors.ControlText;
            }
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            //toolStripLoginLabel.Text = $"Welcome, {AppSession.UserName} ({AppSession.Role})";
        }

        private void buttonNavBranch_Click(object sender, EventArgs e)
        {
            var visitBranch = new BranchUserControl(_db) { Dock = DockStyle.Fill };
            ShowPage(visitBranch, buttonNavDms);
        }

        private void buttonNavMain_Click(object sender, EventArgs e)
        {
          
            
            //var visitorForm = new VisitorUserControl(_db) { Dock = DockStyle.Fill };
            //var dashboardForm = new DashboardUserControl(_db) { Dock = DockStyle.Fill };
            ////mainPanel.Controls.Clear();
            ////mainPanel.Controls.Add(visitorForm);
            hopeTabPage1.SuspendLayout();

            //var tab1 = new System.Windows.Forms.TabPage("Dashboard") { Name = "DashboardTab" };
            //tab1.SuspendLayout();
            //tab1.Controls.Add(new DashboardUserControl(_db) { Dock = DockStyle.Fill });
            //tab1.ResumeLayout();
            //hopeTabPage1.TabPages.Add(tab1);

            //var tab2 = new System.Windows.Forms.TabPage("Pre-Register") { Name = "VisitorsTab" };
            //tab2.SuspendLayout();
            //tab2.Controls.Add(new VisitorUserControl(_db) { Dock = DockStyle.Fill });
            //hopeTabPage1.TabPages.Add(tab2);
            //tab2.ResumeLayout();

            //var tab3 = new System.Windows.Forms.TabPage("Register") { Name = "PBTab" };
            //tab3.SuspendLayout();
            //tab3.Controls.Add(new VisitorPBUserControl(_db) { Dock = DockStyle.Fill });
            //tab3.ResumeLayout();
            //hopeTabPage1.TabPages.Add(tab3);

            //var tab4 = new System.Windows.Forms.TabPage("Branch") { Name = "BranchesTab" };
            //tab4.SuspendLayout();
            //tab4.Controls.Add(new BranchUserControl(_db) { Dock = DockStyle.Fill });
            //tab4.ResumeLayout();
            //hopeTabPage1.TabPages.Add(tab4);

            //var tab5 = new System.Windows.Forms.TabPage("Category") { Name = "CategoriesTab" };
            //tab5.SuspendLayout();
            //tab5.Controls.Add(new CategoryUserControl(_db) { Dock = DockStyle.Fill });
            //tab5.ResumeLayout();
            //hopeTabPage1.TabPages.Add(tab5);
            //var tab6 = new System.Windows.Forms.TabPage("GatePass") { Name = "GatePassTab" };
            //tab6.SuspendLayout();
            //tab6.Controls.Add(new GatePassUserControl(_db) { Dock = DockStyle.Fill });
            //tab6.ResumeLayout();
            //hopeTabPage1.TabPages.Add(tab6);

            hopeTabPage1.ResumeLayout();
           // hopeTabPage1.SelectedTab = tab1;

        }

        //private void buttonNavCategory_Click(object sender, EventArgs e)
        //{
        //    var visitCategory = new CategoryUserControl(_db) { Dock = DockStyle.Fill };
        //    ShowPage(visitCategory, buttonNavCategory);
        //}

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //var visitRegisterForm = new VisitorPBUserControl(_db) { Dock = DockStyle.Fill };
            //ShowPage(visitRegisterForm, buttonNavDms);
        }
    }
}
