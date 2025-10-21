using KossanVMS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KossanVMS.Data;
namespace KossanVMS.Modules.VMS.UserControlPage
{
    public partial class DashboardUserControl : UserControl
    {
        private readonly VmsContext _db;
        private List<VmsDashboard.TotalCheckIn> totalCheckIns = new List<VmsDashboard.TotalCheckIn>();
        public DashboardUserControl(VmsContext db)
        {
            InitializeComponent();
            // Make sure the circle has sane bounds
            parrotCircleProgressBar1.Percentage = 50;
            //parrotCircleProgressBar1.Maximum = 100;
            //parrotCircleProgressBar1.Value = 0;  // or use .percentage if you prefer
            parrotCircleProgressBar1.MinimumSize = new Size(100, 100);
            this._db = db ?? throw new ArgumentNullException(nameof(db));
            //this.Load += dashboardLoad;
        }


        private async void dashboardLoad(object sender, EventArgs e)
        {
          
         // var checkIns = _db.VisitRecords.AsNoTracking().Where(x=> x.OutTime == null).ToListAsync();
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var results = await _db.VisitRecords.AsNoTracking().Where(x => x.InTime >= today && x.InTime < tomorrow && x.OutTime == null)
                .Select(x => new VmsDashboard.TotalCheckIn
                {
                    checkInName = x.Visitor.FullName,
                 //   checkInPurpose = x.Purpose.PurposeName,
                    checkInTime = x.InTime,
                    ExpiryDateTime = x.ExpiryDate
                })
                .ToListAsync();


        }

        private void statusBarDashboard_Click(object sender, EventArgs e)
        {

        }

        private void skyLabel2_Click(object sender, EventArgs e)
        {

        }

        private void skyLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
