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
        private VmsContext _db;
        private Visitor? CurrentItem => visitorBindingSource.Current as Visitor;
        //private readonly BindingSource bindingSource = new();
        // private BindingList<Visitor> _items = new();
        public VisitorUserControl(VmsContext db)
        {
            InitializeComponent();
            //_db = db;
            _db = db ?? throw new ArgumentNullException(nameof(db));
            VisitorGridViewUserControl.DataSource = visitorBindingSource;
            VisitorGridViewUserControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Load += VisitorUserControl_Load;

        }

        private async void VisitorUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                if (_db != null)
                {
                    await _db.VisitCategories.LoadAsync();
                    await _db.VisitorCategoryLinks.LoadAsync();
                    // LOAD INTO THE CONTEXT (no AsNoTracking, no ToListAsync)
                    await _db.Visitors
                       // .Include(v => v.BlackList)
                        //.Include(v => v.Company)
                        .Include(v => v.Contact)
                        .Include(v => v.Photo)
                        .LoadAsync();


                    visitorBindingSource.DataSource = _db.Visitors.Local.ToBindingList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void VisitorGridViewUserControl_CellFormatting(object s, DataGridViewCellFormattingEventArgs e)
        {
            var grid = VisitorGridViewUserControl;
            if (e.RowIndex < 0) return;

            // Photo column
            if (grid.Columns[e.ColumnIndex].Name == "colPhoto")
            {
                if (grid.Rows[e.RowIndex].DataBoundItem is Visitor v)
                    e.Value = v.Photo?.UploadPhotoPath ?? string.Empty;   // always set
                else
                    e.Value = string.Empty;

                e.FormattingApplied = true;
                return;
            }
            if (grid.Columns[e.ColumnIndex].Name == "colContact")
            {
                if (grid.Rows[e.RowIndex].DataBoundItem is Visitor v1)
                {
                    e.Value = v1.Contact?.Tel ?? string.Empty;
                }
                else
                {
                    e.Value = string.Empty;
                }
                e.FormattingApplied = true;
                return;
            }
            // Categories column
            if (grid.Columns[e.ColumnIndex].Name == "colCategories")
            {
                if (grid.Rows[e.RowIndex].DataBoundItem is Visitor v2)
                {
                    var names = _db.VisitorCategoryLinks.Local
                                 .Where(l => l.VisitorNo == v2.VisitorNo)
                                 .Join(_db.VisitCategories.Local,
                                       l => l.CategoryID, c => c.CategoryID,
                                       (l, c) => c.CategoryName)
                                 .OrderBy(n => n)
                                 .ToList();

                    e.Value = names.Count > 0 ? string.Join(", ", names) : string.Empty;
                }
                else
                {
                    e.Value = string.Empty;
                }

                e.FormattingApplied = true;
                return;
            }
        }

        //private void VisitorGridViewUserControl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    var grid = VisitorGridViewUserControl;
        //    if (e.RowIndex < 0) return;

        //    if (grid.Columns[e.ColumnIndex].Name == "colPhoto")
        //    {
        //        if (grid.Rows[e.RowIndex].DataBoundItem is Visitor v)
        //        {
        //            e.Value = v.Photo?.PhotoPath;
        //            e.FormattingApplied = true;
        //        }
        //        return;
        //    }

        //    if (VisitorGridViewUserControl.Columns[e.ColumnIndex].Name != "colCategories" || e.RowIndex<0)
        //        { return; }
        //    var rowItem = VisitorGridViewUserControl.Rows[e.RowIndex].DataBoundItem as Visitor;
        //    if (rowItem == null)
        //    { return; }
        //    var categories = _db.VisitorCategoryLinks.Local.Where(l => l.VisitorID == rowItem.VisitorID)
        //                                            .Join(_db.VisitCategories.Local, l => l.CategoryID, c => c.CategoryID, (l, c) => c.CategoryName)
        //                                            .OrderBy(n => n).ToList();
        //    e.Value= string.Join(", ", categories);
        //    e.FormattingApplied = true;
        //}
        private async Task RefreshCurrentRowAndColumns()
        {


            //// repaint the whole row (good for unbound/computed cells like colCategories/colPhoto)
            // repaint the specific computed cells
            var grid = VisitorGridViewUserControl;
            var rowIndex = grid.CurrentCell?.RowIndex ?? -1;
            if (rowIndex >= 0)
            {
                var catCol = grid.Columns["colCategories"]?.Index ?? -1;
                var phoCol = grid.Columns["colPhoto"]?.Index ?? -1;
                if (catCol >= 0) grid.InvalidateCell(catCol, rowIndex);
                if (phoCol >= 0) grid.InvalidateCell(phoCol, rowIndex);
            }

            // (optional) if many rows might change:
            /// visitorBindingSource.ResetBindings(false);


            //if you want to be extra sure:
            grid.Refresh();
            //_dbUpdate?.Dispose();
            
        }


        private async void toolStripEditButton_Click(object sender, EventArgs e)
        {
            
            var selectedItem = CurrentItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Select a row to edit.");
                return;
            }
            var copyVisitorModel = new Visitor
            {
                VisitorNo = selectedItem.VisitorNo,
                IdNo = selectedItem.IdNo,
                FullName = selectedItem.FullName,
                IdType = selectedItem.IdType,
                //Company = selectedItem.Company,
                Contact = selectedItem.Contact,
                Photo = selectedItem.Photo,
                BlackList = selectedItem.BlackList
            };

            using var editVisitorModel = new VisitorPreEditForm(_db, copyVisitorModel);
            if (editVisitorModel.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
           
            var updatedVisitorModel = editVisitorModel.visitorModel;
            selectedItem.IdNo = (updatedVisitorModel.IdNo ?? "").Trim();
            selectedItem.FullName = (updatedVisitorModel.FullName ?? "").Trim();
            selectedItem.IdType = updatedVisitorModel.IdType;
            if (selectedItem.Contact != null)
            {
                selectedItem.Contact = new VisitorContact { VisitorNo = selectedItem.VisitorNo };
                selectedItem.Contact.Tel = updatedVisitorModel.Contact.Tel;
                selectedItem.Contact.City = updatedVisitorModel.Contact.City;
                selectedItem.Contact.Address = updatedVisitorModel.Contact.Address;
                selectedItem.Contact.PostCode = updatedVisitorModel.Contact.PostCode;

            }
            else
            {
                selectedItem.Contact = new VisitorContact { VisitorNo = selectedItem.VisitorNo };
                selectedItem.Contact.Tel = updatedVisitorModel.Contact.Tel;
                selectedItem.Contact.City = updatedVisitorModel.Contact.City;
                selectedItem.Contact.Address = updatedVisitorModel.Contact.Address;
                selectedItem.Contact.PostCode = updatedVisitorModel.Contact.PostCode;

            }
            //if (!string.IsNullOrWhiteSpace(updatedVisitorModel?.Contact.Tel))
            //{
            //    if (selectedItem.Contact == null)
            //    {
            //        selectedItem.Contact = new VisitorContact{ VisitorID = selectedItem.VisitorID };
            //        selectedItem.Contact.Tel = updatedVisitorModel.Contact.Tel;

            //    }
            //    else if (selectedItem.Contact != null)
            //    {
            //        _db.Remove(selectedItem.Contact);
            //        selectedItem.Contact = null;
            //    }

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
            //}
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
            if (!string.IsNullOrWhiteSpace(updatedVisitorModel.Photo?.UploadPhotoPath))
            {
                if (selectedItem.Photo == null)
                    selectedItem.Photo = new VisitorPhoto { VisitorNo = selectedItem.VisitorNo };

                selectedItem.Photo.UploadPhotoPath = updatedVisitorModel.Photo.UploadPhotoPath;
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

            // repaint the specific computed cells
            var grid = VisitorGridViewUserControl;
            var r = grid.CurrentCell?.RowIndex ?? -1;
            if (r >= 0)
            {
                int catCol = grid.Columns["colCategories"]?.Index ?? -1;
                int phoCol = grid.Columns["colPhoto"]?.Index ?? -1;
                if (catCol >= 0) grid.InvalidateCell(catCol, r);
                if (phoCol >= 0) grid.InvalidateCell(phoCol, r);
            }
            grid.Refresh();

            UpdatePhotoPreview(selectedItem);
           // RefreshCurrentRowAndColumns();


            //editVisitorModel.DataChanged -= DataGridUpdate;
        }

        private void toolStripAddButton_Click(object sender, EventArgs e)
        {
            using var addVisitorModel = new VisitorPreEditForm(_db);
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
            var path = v?.Photo?.UploadPhotoPath;
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
            UploadPhotoPreview(v);
        }

        // Clean, strongly-typed current item
       
        private void DataGridUpdate(object sender, EventArgs e)
        {
            // This method is called when the DataGridView is updated
            // You can handle any additional logic here if needed
            // For example, you might want to refresh the photo preview
            visitorBindingSource.ResetCurrentItem();
            // 1. Mark the entire control area as invalid (needs redrawing)
            VisitorGridViewUserControl.Invalidate();

            // 2. Force the immediate repaint operation
            VisitorGridViewUserControl.Update();

            VisitorGridViewUserControl.Refresh();

        }
        private void UploadPhotoPreview(Visitor v)
        {
            var pb = visitorUploadPictureBox;
            if (pb.Image != null)
            {
                pb.Image.Dispose();
                pb.Image = null;
            }
            var path = v?.Photo?.UploadPhotoPath;
            if(string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return;
            }
            using (var fs = new System.IO.FileStream(path, System.IO.FileMode.Open,
                                            System.IO.FileAccess.Read,
                                            System.IO.FileShare.ReadWrite))
                using (var ms = new System.IO.MemoryStream())
            {                     fs.CopyTo(ms);
                    ms.Position = 0;
                    pb.Image = Image.FromStream(ms); // pictureBox owns this copy
            }
        }
        // Optional: expose actions
        //public void RefreshPage() => -= VisitorUserControl_Load;


    }
}
