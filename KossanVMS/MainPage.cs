using KossanVMS.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace KossanVMS
{
    public partial class MainPage : MaterialForm
    {

        private readonly VmsContext _db;
        private int _cornerRadius = 10;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;


            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            path.AddArc(rect.X, rect.Y, _cornerRadius * 2, _cornerRadius * 2, 180, 90);
            path.AddArc(rect.Width - _cornerRadius * 2, rect.Y, _cornerRadius * 2, _cornerRadius * 2, 270, 90);
            path.AddArc(rect.Width - _cornerRadius * 2, rect.Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 0, 90);
            path.AddArc(rect.X, rect.Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

        
        }
        
        public MainPage(VmsContext db)
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Amber200, TextShade.WHITE);
            //this.Hide();
            _db = db;
            UserLoginForm userLoginForm = new UserLoginForm();
           
            //userLoginForm.Show();
            UserEditForm userEditForm = new UserEditForm();
            userEditForm.Show();
           
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //toolStripLoginLabel.Text = $"Welcome, {AppSession.UserName} ({AppSession.Role})";
        }
    }
}
