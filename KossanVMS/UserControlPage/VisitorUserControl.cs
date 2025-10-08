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

        //private readonly BindingSource bindingSource = new();
        // private BindingList<Visitor> _items = new();
        public VisitorUserControl(VmsContext db)
        {
            InitializeComponent();
            _db = db;

            VisitorGridViewUserControl.DataSource = visitorBindingSource;
            VisitorGridViewUserControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Load += VisitorUserControl_Load;

        }

        private async void VisitorUserControl_Load(object sender, EventArgs e)
        {
            await _db.VisitCategories.LoadAsync();
            await _db.VisitorCategoryLinks.LoadAsync();
            // LOAD INTO THE CONTEXT (no AsNoTracking, no ToListAsync)
            await _db.Visitors
                .Include(v => v.BlackList)
                //.Include(v => v.Company)
                .Include(v => v.Contact)
                .Include(v => v.Photo)
                .LoadAsync();


            visitorBindingSource.DataSource = _db.Visitors.Local.ToBindingList();
        }

        private void VisitorGridViewUserControl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (VisitorGridViewUserControl.Columns[e.ColumnIndex].Name != "colCategories" || e.RowIndex<0)
                { return; }
            var rowItem = VisitorGridViewUserControl.Rows[e.RowIndex].DataBoundItem as Visitor;
            if (rowItem == null)
            { return; }
            var categories = _db.VisitorCategoryLinks.Local.Where(l => l.VisitorID == rowItem.VisitorID)
                                                    .Join(_db.VisitCategories.Local, l => l.CategoryID, c => c.CategoryID, (l, c) => c.CategoryName)
                                                    .OrderBy(n => n).ToList();
            e.Value= string.Join(", ", categories);
            e.FormattingApplied = true;
        }
        private void toolStripEditButton_Click(object sender, EventArgs e)
        {
            var selectedItem = CurrentItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Select a row to edit.");
                return;
            }
            var copyVisitorModel = new Visitor
            {
                VisitorID = selectedItem.VisitorID,
                ICNo = selectedItem.ICNo,
                FullName = selectedItem.FullName,
                //Company = selectedItem.Company,
                Contact = selectedItem.Contact,
                Photo = selectedItem.Photo,
                BlackList = selectedItem.BlackList
            };

            using var editVisitorModel = new VisitorEditForm(copyVisitorModel);
            if (editVisitorModel.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            var updatedVisitorModel = editVisitorModel.visitorModel;
            selectedItem.ICNo = (updatedVisitorModel.ICNo ?? "").Trim();
            selectedItem.FullName = (updatedVisitorModel.FullName ?? "").Trim();
            if (!string.IsNullOrWhiteSpace(updatedVisitorModel?.Contact.Tel))
            {
                if (selectedItem.Contact == null)
                {
                    selectedItem.Contact = new VisitorContact { VisitorID = selectedItem.VisitorID };
                    selectedItem.Contact.Tel = updatedVisitorModel.Contact.Tel;

                }
                else if (selectedItem.Contact != null)
                {
                    _db.Remove(selectedItem.Contact);
                    selectedItem.Contact = null;
                }

                //if (!string.IsNullOrWhiteSpace(updatedVisitorModel.Company?.Company))
                //{
                //    if (selectedItem.Company == null)
                //    {
                //        selectedItem.Company = new VisitorCompany { VisitorID = selectedItem.VisitorID };
                //        selectedItem.Company.Company = updatedVisitorModel.Company.Company;
                //    }

                //}
                //else if (selectedItem.Company != null)
                //{
                //    _db.Remove(selectedItem.Company);
                //    selectedItem.Company = null;
                //}
            }
                //if (updatedVisitorModel?.BlackList.IsBlackList == true)
                //{
                //    if (selectedItem.BlackList == null)
                //    {
                //        selectedItem.BlackList = new VisitorBlackList { VisitorID = selectedItem.VisitorID };
                //        selectedItem.BlackList.IsBlackList = true;
                //        //selectedItem.BlackList.UpdateTime = DateTime.UtcNow;
                //        //selectedItem.BlackList.LastEditUser = Environment.UserName;
                //    }

                //}
                //else if (selectedItem.BlackList != null)
                //{
                //    _db.Remove(selectedItem.BlackList);
                //    selectedItem.BlackList = null;
                //}
                // after: var updatedVisitorModel = editVisitorModel.visitorModel;

                // --- COPY PHOTO BACK FROM DIALOG ---
                if (!string.IsNullOrWhiteSpace(updatedVisitorModel.Photo?.PhotoPath))
                {
                    if (selectedItem.Photo == null)
                        selectedItem.Photo = new VisitorPhoto { VisitorID = selectedItem.VisitorID };

                    selectedItem.Photo.PhotoPath = updatedVisitorModel.Photo.PhotoPath;
                    selectedItem.Photo.CaptureDate = updatedVisitorModel.Photo.CaptureDate; // or DateTime.UtcNow
                }
                else
                {
                    // Optional: if user cleared the photo in dialog
                    if (selectedItem.Photo != null)
                    {
                        _db.Remove(selectedItem.Photo);   // only if you want it removed from DB
                        selectedItem.Photo = null;
                    }
                }

            
            _db.SaveChanges();
            visitorBindingSource.ResetCurrentItem();
            UpdatePhotoPreview(selectedItem);
        }

        private void toolStripAddButton_Click(object sender, EventArgs e)
        {
            using var addVisitorModel = new VisitorEditForm();
            var newVisitorModel = addVisitorModel.visitorModel;
            if (addVisitorModel.ShowDialog(this) != DialogResult.OK)
            {
                return;

            }
            _db.Visitors.Add(newVisitorModel);
            _db.SaveChanges();
            visitorBindingSource.ResetBindings(false);
            UpdatePhotoPreview(newVisitorModel);
        }

        private void toolStripDelButton_Click(object sender, EventArgs e)
        {
            var selectedItem = CurrentItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }
            var msgResult = MessageBox.Show("Delete this item?", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (msgResult != DialogResult.Yes)
            { return; }
            _db.Visitors.Remove(selectedItem);
            _db.SaveChanges();
            

        }
        private void UpdatePhotoPreview(Visitor v)
        {
            var pb = visitorPictureBox;
            if (pb.Image!= null)
            {
                pb.Image.Dispose();
                pb.Image = null;
            }
            var path = v?.Photo?.PhotoPath;
            if(string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return;
            }
            using (var fs = new System.IO.FileStream(path, System.IO.FileMode.Open,
                                            System.IO.FileAccess.Read,
                                            System.IO.FileShare.ReadWrite))
            using (var ms = new System.IO.MemoryStream())
            {
                fs.CopyTo(ms);
                ms.Position = 0;
                pb.Image = Image.FromStream(ms); // pictureBox owns this copy
            }
        }
        private void VisitorGridViewUserControl_SelectionChanged(object sender, EventArgs e)
        {
            var v = CurrentItem;
            UpdatePhotoPreview(v);
        }

        // Clean, strongly-typed current item
        private Visitor? CurrentItem => visitorBindingSource.Current as Visitor;

        // Optional: expose actions
        //public void RefreshPage() => -= VisitorUserControl_Load;


    }
}
