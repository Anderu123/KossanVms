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

namespace KossanVMS.Modules.VMS.UserControlPage
{
    public partial class PurposeUserControl : UserControl
    {
        private readonly VmsContext _db;

        private Purpose? CurrentItem => (Purpose)purposeBindingSource.Current;
        public PurposeUserControl(VmsContext db)
        {
            InitializeComponent();
            _db = db;
            PurposeGridViewUserControl.Dock = DockStyle.Fill;
            PurposeGridViewUserControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // optional, makes columns stretch

            PurposeGridViewUserControl.DataSource = purposeBindingSource;
            PurposeGridViewUserControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Load += PurposeUserControl_Load;

        }


        public async void PurposeUserControl_Load(object sender, EventArgs e)
        {
            await _db.VisitPurposes
                .LoadAsync();
            purposeBindingSource.DataSource = _db.VisitPurposes.Local.ToBindingList();
        }

        public void toolStripAddButton_Click(object sender, EventArgs e)
        {
            using var addPurposeForm = new VisitPurposeEditForm();
            if (addPurposeForm.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            _db.VisitPurposes.Add(addPurposeForm.visitPurposeModel);
            _db.SaveChanges();
            purposeBindingSource.ResetBindings(false);
        }
        private void toolStripEditButton_Click(object sender, EventArgs e)
        {
            var selectedItem = CurrentItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Select a row to edit!");
                return;
            }
            var copyVisitPurposeModel = new Purpose
            {
                PurposeName = selectedItem.PurposeName,
                PurposeDescription = selectedItem.PurposeDescription,
                //PurposeStatus = selectedItem.PurposeStatus,
            };
            using var editVisitPurposeModel = new VisitPurposeEditForm(copyVisitPurposeModel);
            if (editVisitPurposeModel.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            var updatedPurposeModel = editVisitPurposeModel.visitPurposeModel;
            selectedItem.PurposeName = updatedPurposeModel.PurposeName;
            selectedItem.PurposeDescription = updatedPurposeModel.PurposeDescription;
            //_db.SaveChanges();
            purposeBindingSource.ResetCurrentItem();
        }

        private void toolStripDelButton_Click(object sender, EventArgs e)
        {
            var selectedItem = CurrentItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }
            var msgResult = MessageBox.Show("Delete this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgResult != DialogResult.Yes)
            {
                return;
            }
            _db.VisitPurposes.Remove(selectedItem);
            _db.SaveChanges();
        }

       
    }
}
