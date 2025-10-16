using KossanVMS.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using KossanVMS.UserControlPage;
using ReaLTaiizor.Controls;

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
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Amber200, TextShade.WHITE);
            //this.Hide();
            _db = db;
            var visitorForm = new VisitorUserControl(_db) { Dock = DockStyle.Fill };
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(visitorForm);
            //UserLoginForm userLoginForm = new UserLoginForm();

            ////userLoginForm.Show();
            //UserEditForm userEditForm = new UserEditForm();
            //userEditForm.Show();

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
            ShowPage(visitBranch, buttonNavBranch);
        }

        private void buttonNavMain_Click(object sender, EventArgs e)
        {
            var visitForm = new VisitorUserControl(_db) { Dock = DockStyle.Fill };
            ShowPage(visitForm, buttonNavMain);
        }

        private void buttonNavCategory_Click(object sender, EventArgs e)
        {
            var visitCategory = new CategoryUserControl(_db) { Dock = DockStyle.Fill };
            ShowPage(visitCategory, buttonNavCategory);
        }
    }
}
