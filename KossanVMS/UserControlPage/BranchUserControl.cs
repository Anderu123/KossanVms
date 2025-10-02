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
    public partial class BranchUserControl : UserControl
    {
        private readonly VmsContext _db;
        private VisitBranch? CurrentItem => (VisitBranch)visitBranchBindingSource.Current;
        public BranchUserControl(VmsContext db)
        {
            InitializeComponent();
            _db = db;
            BranchGridViewUserControl.DataSource = visitBranchBindingSource;
            BranchGridViewUserControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Load += BranchUserControl_Load;

        }

        public async void BranchUserControl_Load(object sender, EventArgs e)
        {
            await _db.VisitBranches.Include(v => v.BranchID)
                .Include(v => v.BranchName)
                .Include(v => v.BranchDescription)
                .LoadAsync();
            visitBranchBindingSource.DataSource = _db.VisitBranches.Local.ToBindingList();
        }

       
        private void toolStripEditButton_Click(object sender, EventArgs e)
        {

        }

       

        private void toolStripAddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
