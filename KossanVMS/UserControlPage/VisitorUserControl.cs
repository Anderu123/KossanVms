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

namespace KossanVMS.UserControlPage
{
    public partial class VisitorUserControl : UserControl
    {
        private readonly VmsContext _db;

        private readonly BindingSource bindingSource = new();
        private BindingList<Visitor> _items = new();
        public VisitorUserControl(VmsContext db)
        {
            InitializeComponent();
            _db = db;

            VisitorGridViewUserControl.DataSource = bindingSource;
            VisitorGridViewUserControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Load += VisitorUserControl_Load;
          
        }

        private async void VisitorUserControl_Load(object sender, EventArgs e)
        {
            var list = await _db.Visitors
               .Include(v => v.BlackList)
               .Include(v => v.Company)
               .Include(v => v.Contact)
               .Include(v => v.Photo)
               .AsNoTracking()
               .ToListAsync();

            _items = new BindingList<Visitor>(list);
            visitorBindingSource.DataSource = _items;
        }
        // Clean, strongly-typed current item
        private Visitor? CurrentItem => visitorBindingSource.Current as Visitor;

        // Optional: expose actions
        //public void RefreshPage() => -= VisitorUserControl_Load;
    }
}
