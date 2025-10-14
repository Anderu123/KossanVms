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
    {
        private VmsContext _db;
        private Visitor? CurrentItem => visitorBindingSource.Current as Visitor;
        public VisitorPBUserControl(VmsContext db)
        {
            InitializeComponent();
            _db = db ?? throw new ArgumentNullException(nameof(db));
            VisitorGridViewPBControl.DataSource = visitorBindingSource;
            VisitorGridViewPBControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Load += VisitorPBUserControl_Load;

        }

        private async void VisitorPBUserControl_Load(object? sender, EventArgs e)
        {
            try
            {
                if (_db != null)
                {
                    await _db.VisitCategories.LoadAsync();
                    await _db.VisitorCategoryLinks.LoadAsync();
                    await _db.Visitors.Include(v => v.BlackList).Include(v => v.Photo).Include(v => v.Contact).LoadAsync();
                }
            }
            catch
            {
                MessageBox.Show("Database connection error. Please contact the administrator.");
            }
        }

        private void VisitorGridViewUserControl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = VisitorGridViewPBControl;

            if (e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count)
            {
                return;
            }
            if (grid.Columns[e.ColumnIndex].Name == "colPhoto")
            {
                if (grid.Rows[e.RowIndex].DataBoundItem is Visitor visitor)
                {
                    if (grid.Rows[e.RowIndex].DataBoundItem is Visitor v)
                    {
                        if (v.Photo != null)
                        {
                            if (string.IsNullOrEmpty(v.Photo.PhotoPath))
                            {
                                e.Value = v.Photo.PhotoPath;
                            }
                            else
                            {
                                e.Value = string.Empty;
                            }
                            e.FormattingApplied = true;
                        }
                        return;
                    }
                }
            }

            if (grid.Columns[e.ColumnIndex].Name == "colCategories")
            {
                if (grid.Rows[e.RowIndex].DataBoundItem is Visitor v2)
                {
                    var names = _db.VisitorCategoryLinks.Local
                        .Where(l => l.VisitorID == v2.VisitorID)
                        .Join((_db.VisitCategories.Local),
                              link => link.CategoryID,
                              category => category.CategoryID,
                              (link, category) => category.CategoryName).ToList();

                    if (names.Count > 0)
                    {
                        e.Value = string.Join(", ", names);
                    }
                    else
                    {
                        e.Value = string.Empty;
                    }
                }
                else
                {

                }
                e.FormattingApplied = true;
                return;
            }
        }
        private async void toolStripEditButton_Click(object sender, EventArgs e)
        {
            var selecteditem = CurrentItem;
            if (selecteditem == null)
            {
                MessageBox.Show("Please select a visitor to edit.");
                return;
            }
            var copyVisitorModel = new Visitor
            {
                VisitorID = selecteditem.VisitorID,
                IdType = selecteditem.IdType,
                IdNo = selecteditem.IdNo,
                FullName = selecteditem.FullName,
                Contact = selecteditem.Contact,
                Photo = selecteditem.Photo,
                BlackList = selecteditem.BlackList
            };

            using var editVisitorModel = new VisitorPBForm(_db, copyVisitorModel);
            if (editVisitorModel.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var updatedVisitorModel = editVisitorModel.visitorModel;
            selecteditem.IdNo = updatedVisitorModel.IdNo.Trim() ?? "";
            selecteditem.IdType = updatedVisitorModel.IdType;
            selecteditem.FullName = updatedVisitorModel.FullName.Trim() ?? "";

            selecteditem.Contact = new VisitorContact { VisitorID = selecteditem.VisitorID };
            selecteditem.Contact.Tel = updatedVisitorModel.Contact.Tel;
            selecteditem.Contact.City = updatedVisitorModel.Contact.City;
            selecteditem.Contact.Address = updatedVisitorModel.Contact.Address;
            selecteditem.Contact.PostCode = updatedVisitorModel.Contact.PostCode;

            if (!string.IsNullOrWhiteSpace(updatedVisitorModel.Photo?.PhotoPath))
            {
                if (selecteditem.Photo == null)
                {
                    selecteditem.Photo = new VisitorPhoto { VisitorID = selecteditem.VisitorID };
                }
                selecteditem.Photo.PhotoPath = updatedVisitorModel.Photo.PhotoPath;
                selecteditem.Photo.CaptureDate = updatedVisitorModel.Photo.CaptureDate;

            }
            else
            {
                if(selecteditem != null)
                {
                    _db.Remove(selecteditem.Photo);
                    selecteditem.Photo = null;
                }
            }
            _db.SaveChanges();
            visitorBindingSource.ResetCurrentItem();
            var grid = VisitorGridViewPBControl;
            var r = grid.CurrentCell?.RowIndex ?? -1;
            if (r >= 0)
            {
                int catCol = grid.Columns["colCategories"]?.Index ?? -1;
                int phoCol = grid.Columns["colPhoto"]?.Index ?? -1;
                if (catCol >= 0) grid.InvalidateCell(catCol, r);
                if (phoCol >= 0) grid.InvalidateCell(phoCol, r);
            }
            grid.Refresh();

            UpdatePhotoPreview(updatedVisitorModel);
        }
        
        private void UpdatePhotoPreview(Visitor v)
        {
            var pb = visitorPictureBox;
            if (pb.Image != null)
            {
                pb.Image.Dispose();
                pb.Image = null;
            }
            var path = v?.Photo?.PhotoPath;
            if(string.IsNullOrWhiteSpace(path))
            {
                return;
            }
            using(var fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite))
                using (var ms = new System.IO.MemoryStream())
            {
                fs.CopyTo(ms);
                ms.Position = 0;
                pb.Image = Image.FromStream(ms);
            }

        }
        private void VisitorGridViewUserControl_SelectionChanged(object sender, EventArgs e)
        {
            var v = CurrentItem;
            UpdatePhotoPreview(v);
        }

    }
}
