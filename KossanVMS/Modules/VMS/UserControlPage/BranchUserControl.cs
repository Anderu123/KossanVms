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
            BranchGridViewUserControl.Dock = DockStyle.Fill;
            BranchGridViewUserControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // optional, makes columns stretch

            BranchGridViewUserControl.DataSource = visitBranchBindingSource;
            BranchGridViewUserControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Load += BranchUserControl_Load;

        }

        public async void BranchUserControl_Load(object sender, EventArgs e)
        {
            await _db.VisitBranches
                .LoadAsync();
            visitBranchBindingSource.DataSource = _db.VisitBranches.Local.ToBindingList();
        }


        private void toolStripEditButton_Click(object sender, EventArgs e)
        {
            var selectedItem = CurrentItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Select a row to edit!");
                return;
            }
            var copyVisitBranchModel = new VisitBranch
            {
                BranchName = selectedItem.BranchName,
                BranchDescription = selectedItem.BranchDescription,
                BranchStatus = selectedItem.BranchStatus,
                BranchConnectionString = selectedItem.BranchConnectionString

            };
            using var editVisitBranchModel = new VisitBranchEditForm(copyVisitBranchModel);
            if (editVisitBranchModel.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            var updatedVisitorModel = editVisitBranchModel.visitBranchModel;
            selectedItem.BranchName = updatedVisitorModel.BranchName;
            selectedItem.BranchDescription = updatedVisitorModel.BranchDescription;
            selectedItem.BranchStatus = updatedVisitorModel.BranchStatus;
            _db.SaveChanges();
            visitBranchBindingSource.ResetCurrentItem();
        }



        private void toolStripAddButton_Click(object sender, EventArgs e)
        {
            using var addVisitBranchModel = new VisitBranchEditForm();
            var newVisitBranchModel = addVisitBranchModel.visitBranchModel;
            if (addVisitBranchModel.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            _db.VisitBranches.Add(newVisitBranchModel);
            _db.SaveChanges();
            visitorBindingSource.ResetBindings(false);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var selectedItem = CurrentItem;
            if(selectedItem == null)
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }
            var msgResult = MessageBox.Show("Delete this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgResult != DialogResult.Yes)
            {
                return;
            }
            _db.VisitBranches.Remove(selectedItem);
            _db.SaveChanges();
        }
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        {
        //            _db?.Dispose();
        //            components?.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }

        //}
    }
}
