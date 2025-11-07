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
    public partial class CategoryUserControl : UserControl
    {
        private VmsContext _db;
        private Category? CurrentItem => visitCategoryBindingSource.Current as Category;
        public CategoryUserControl(VmsContext db)
        {
            InitializeComponent();
            _db = db ?? throw new ArgumentNullException(nameof(_db));
            visitorCatUserControlGridView.DataSource = visitCategoryBindingSource;
            visitorCatUserControlGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Load += CategoryUserControl_Load;

        }
        private async void CategoryUserControl_Load(object? sender, EventArgs e)
        {
            try
            {
                if (_db != null)
                {
                    await _db.VisitCategories.LoadAsync();
                    visitCategoryBindingSource.DataSource = _db.VisitCategories.Local.ToBindingList();
                }
            }
            catch
            {
                MessageBox.Show("Database connection error. Please contact the administrator.");
            }
        }
        private async void toolStripEditButton_Click(object sender, EventArgs e)
        {
            var selecteditem = CurrentItem;
            if (selecteditem == null)
            {
                MessageBox.Show("Please select a category to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var copyVisitCategoryModel = new Category
            {
                CategoryID = selecteditem.CategoryID,
                CategoryName = selecteditem.CategoryName,
                CategoryDescription = selecteditem.CategoryDescription,
                CategoryStatus = selecteditem.CategoryStatus
                //CreatedBy = selecteditem.CreatedBy,
                //CreatedDate = selecteditem.CreatedDate,
                //UpdatedBy = selecteditem.UpdatedBy,
                //UpdatedDate = selecteditem.UpdatedDate
            };
            using var editVisitCategoryModel = new VisitorCategoryEditForm(_db, copyVisitCategoryModel);
            if (editVisitCategoryModel.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var udpatedVisitCategoryModel = editVisitCategoryModel.visitCategoryModel;
            selecteditem.CategoryName = udpatedVisitCategoryModel.CategoryName;
            selecteditem.CategoryDescription = udpatedVisitCategoryModel.CategoryDescription;
            selecteditem.CategoryStatus = udpatedVisitCategoryModel.CategoryStatus;

            _db.SaveChanges();
            visitCategoryBindingSource.ResetCurrentItem();

        }
        private async void toolStripAddButton_Click(object sender, EventArgs e)
        {

            using var addVisitCategoryModel = new VisitorCategoryEditForm(_db);
            var newVisitCategory = addVisitCategoryModel.visitCategoryModel;
            if (addVisitCategoryModel.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            _db.VisitCategories.Add(newVisitCategory);
            _db.SaveChanges();
            visitCategoryBindingSource.ResetBindings(false);


        }
        private void toolStripDelButton_Click(object sender, EventArgs e)
        {
            var selecteditem = CurrentItem;
            if (selecteditem == null)
            {
                MessageBox.Show("Please select a category to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirmResult = MessageBox.Show($"Are you sure to delete the category '{selecteditem.CategoryName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }
            try
            {
                _db.VisitCategories.Remove(selecteditem);
                _db.SaveChanges();

                visitCategoryBindingSource.ResetBindings(false);
                // visitCategoryBindingSource.RemoveCurrent();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Unable to delete the category. It may be referenced by other records.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception (ex) as needed
            }
        }

        private void visitorCatUserControlGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
