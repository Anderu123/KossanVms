using KossanVMS.Data;
using KossanVMS.Modules.VMS.UserControlPage;
using KossanVMS.UserControlPage;
using MaterialSkin;
using MaterialSkin.Controls;
using ReaLTaiizor.Controls;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KossanVMS.Utility;
namespace KossanVMS
{
    public partial class MainPage : Form
    {
        private const int WM_GETMINMAXINFO = 0x24;
        private const int WM_DPICHANGED = 0x02E0;
        private const int MONITOR_DEFAULTTONEAREST = 0x00000002;


        private readonly VmsContext _db;
        private MainPageUserControl? _vmsPage;

        bool _isFullscreen;
        Rectangle _restoreBounds;
        FormBorderStyle _restoreBorder;
        bool _restoreTopMost;
        FormWindowState _restoreState;
        [StructLayout(LayoutKind.Sequential)]
        private struct POINT { public int x; public int y; }


        [StructLayout(LayoutKind.Sequential)]
        private struct MINMAXINFO
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT { public int Left, Top, Right, Bottom; }

        [StructLayout(LayoutKind.Sequential)]
        private struct MONITORINFO
        {
            public int cbSize;
            public RECT rcMonitor;  // monitor bounds
            public RECT rcWork;     // working area (taskbar excluded)
            public uint dwFlags;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr MonitorFromWindow(IntPtr hwnd, uint dwFlags);
        [DllImport("user32.dll")]
        static extern bool SetWindowPos(
        IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        const uint SWP_SHOWWINDOW = 0x0040;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFO lpmi);

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

        //public MainPage(VmsContext db)
        //{
        //    _db = db;
        //    InitializeComponent();  
        //   _vmsPage = new MainPageUserControl(_db) { Dock = DockStyle.Fill };
        //    mainPanel.Controls.Clear(); 
        //    mainPanel.Controls.Add(_vmsPage);
        //    _vmsPage.BringToFront();
           

        //}
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
            //var visitBranch = new BranchUserControl(_db) { Dock = DockStyle.Fill };
            //ShowPage(visitBranch, buttonNavDms);
            GatePass gatepass = new GatePass();
            var isGenerated = gatepass.TestGenerateGatePass();
        }

        private void buttonNavMain_Click(object sender, EventArgs e)
        {


            var mainPage = new MainPageUserControl(_db) { Dock = DockStyle.Fill };
            ShowPage(mainPage, buttonNavVms);

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
        void EnterFullscreen()
        {
            if (_isFullscreen) return;
            _isFullscreen = true;

            // save restore state
            _restoreBounds = this.Bounds;
            _restoreBorder = this.FormBorderStyle;
            _restoreTopMost = this.TopMost;
            _restoreState = this.WindowState;

            // IMPORTANT: never maximize – use borderless + Bounds
            this.TopMost = false;                         // avoid flicker while changing
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;

            var b = Screen.FromHandle(this.Handle).Bounds;
            // push above taskbar
            SetWindowPos(this.Handle, HWND_TOPMOST, b.Left, b.Top, b.Width, b.Height, SWP_SHOWWINDOW);
            this.TopMost = true;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Run AFTER the form is shown so Windows doesn't re-maximize it.
            BeginInvoke((Action)(() => EnterFullscreen()));
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_DPICHANGED = 0x02E0;
            if (m.Msg == WM_DPICHANGED && _isFullscreen)
            {
                var rc = Marshal.PtrToStructure<RECT>(m.LParam);
                this.Bounds = new Rectangle(rc.Left, rc.Top, rc.Right - rc.Left, rc.Bottom - rc.Top);
                return;
            }
            base.WndProc(ref m);
        }
        public MainPage(VmsContext db)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            this.Resize += MainPage_Resize;        // keep maximize/restore sane
            this.ResizeEnd += (_, __) =>           // snap inside when user drags across screens
            {
                if (WindowState == FormWindowState.Normal) SnapInside();
            };

            this.Shown += MainPage_Shown;
            _db = db;
            _vmsPage = new MainPageUserControl(_db) { Dock = DockStyle.Fill };
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(_vmsPage);
            _vmsPage.BringToFront();

        }
        private void MainPage_Shown(object? sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.AutoSize = false;
            // pick the screen you want (Primary, Owner, or Mouse)
            var target = Screen.FromPoint(Cursor.Position);
            var wa = target.WorkingArea;

            int w = Math.Min(wa.Width, Math.Max(Width, 1200));
            int h = Math.Min(wa.Height, Math.Max(Height, 800));
            Size = new Size(w, h);
            Location = new Point(wa.Left + (wa.Width - w) / 2, wa.Top + (wa.Height - h) / 2);
            // MaximizedBounds = 
            // // set both maximize bounds and a SAFE future restore target
            //// MaximizedBounds = wa;
            // DesktopBounds = new Rectangle(wa.Left + 50, wa.Top + 50,
            //                               Math.Min(1200, wa.Width - 100),
            //                               Math.Min(800, wa.Height - 100));
            // MainPage_Shown
            var mon = Screen.FromPoint(Cursor.Position).Bounds;
            MaximizedBounds = mon;

            // MainPage_Resize
            MaximizedBounds = Screen.FromHandle(this.Handle).Bounds;

            // WindowState = FormWindowState.Maximized;
        }

        private void MainPage_Resize(object? sender, EventArgs e)
        {
            if (_isFullscreen) return;                 // ← don’t clamp while fullscreen
            var s = Screen.FromHandle(this.Handle);
            MaximizedBounds = s.WorkingArea;

            if (WindowState == FormWindowState.Maximized)
                EnsureValidRestoreBounds();
            else if (WindowState == FormWindowState.Normal)
                SnapInside();            // clamp if we somehow got pushed off-screen
        }

        private void EnsureValidRestoreBounds()
        {
            var rb = this.RestoreBounds;
            bool onAny = Screen.AllScreens.Any(sc => sc.WorkingArea.IntersectsWith(rb));
            if (!onAny)
            {
                var wa = Screen.FromHandle(this.Handle).WorkingArea;
                this.DesktopBounds = new Rectangle(wa.Left + 50, wa.Top + 50,
                                                   Math.Min(Math.Max(800, rb.Width), wa.Width - 100),
                                                   Math.Min(Math.Max(600, rb.Height), wa.Height - 100));
            }
        }

        private void SnapInside()
        {
            if (_isFullscreen) return;                 // ← skip in fullscreen
            var wa = Screen.FromHandle(this.Handle).WorkingArea;
            var b = this.Bounds;
            int x = Math.Max(wa.Left, Math.Min(b.Left, wa.Right - 200));
            int y = Math.Max(wa.Top, Math.Min(b.Top, wa.Bottom - 100));
            Location = new Point(x, y);
            Size = new Size(Math.Min(b.Width, wa.Width - (Location.X - wa.Left)),
                            Math.Min(b.Height, wa.Height - (Location.Y - wa.Top)));
        }
    }
}
