using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using KossanVMS.Data;
using Microsoft.EntityFrameworkCore;

namespace KossanVMS.UserControlPage
{
    public partial class VisitorPBUserControl : UserControl
    {   private VmsContext _db;
        public VisitorPBUserControl(VmsContext db)
        {
            InitializeComponent();
            _db = db ?? throw new ArgumentNullException(nameof(db));
            VisitorGridViewUserControl.DataSource = visitorBindingSource;
            VisitorGridViewUserControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Load += VisitorPBUserControl_Load;

        }

        private async void VisitorPBUserControl_Load(object? sender, EventArgs e)
        {
            try
            {
                if(_db != null)
                {
                    await _db.VisitCategories.LoadAsync() ;
                    await _db.VisitorCategoryLinks.LoadAsync();
                    await _db.Visitors.Include(v => v.BlackList).Include(v => v.Photo).Include(v=>v.Contact).LoadAsync();
                }
            }
            catch
            {
                MessageBox.Show("Database connection error. Please contact the administrator.");
            }
        }
    }
}
