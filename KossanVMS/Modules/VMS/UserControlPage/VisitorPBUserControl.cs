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
using OpenCvSharp.Internal.Vectors;

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
                    await _db.Visitors//.Include(v => v.BlackList)
                        .Include(v => v.Contact)
                                      .Include(v => v.Photo).LoadAsync();
                    visitorBindingSource.DataSource = _db.Visitors.Local.ToBindingList();
                    UpdateHQPhotoPreview(CurrentItem);
                    UpdateSitePhotoPreview(CurrentItem);

                }
            }
            catch
            {
                MessageBox.Show("Database connection error. Please contact the administrator.");
            }
        }

        private void VisitorGridViewPBControl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = VisitorGridViewPBControl;

            if (e.RowIndex < 0)
            {
                return;
            }
            if (grid.Columns[e.ColumnIndex].Name == "colPhoto")
            {
                e.Value = string.Empty;
                if (grid.Rows[e.RowIndex].DataBoundItem is Visitor v)
                {

                    if (v.Photo != null)
                    {

                        e.Value = v.Photo.CapturePhotoPath ?? string.Empty;
                    }
                    else
                    {

                        e.Value = string.Empty;
                    }
                }
                else
                {
                    e.Value = string.Empty;
                }
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

            if (grid.Columns[e.ColumnIndex].Name == "colCategories")
            {
                if (grid.Rows[e.RowIndex].DataBoundItem is Visitor v2)
                {
                    var names = _db.VisitorCategoryLinks.Local
                        .Where(l => l.VisitorNo == v2.VisitorNo)
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
                    e.Value = string.Empty;
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
                VisitorNo = selecteditem.VisitorNo,
                IdType = selecteditem.IdType,
                IdNo = selecteditem.IdNo,
                FullName = selecteditem.FullName,
                Contact = selecteditem.Contact,
                Photo = selecteditem.Photo,
                BlackList = selecteditem.BlackList
            };

            using var editVisitorModel = new VisitorPBEditForm(_db, copyVisitorModel);
            if (editVisitorModel.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var updatedVisitorModel = editVisitorModel.visitorModel;
            selecteditem.IdNo = updatedVisitorModel.IdNo.Trim() ?? "";
            selecteditem.IdType = updatedVisitorModel.IdType;
            selecteditem.FullName = updatedVisitorModel.FullName.Trim() ?? "";

            selecteditem.Contact = new VisitorContact { VisitorNo = selecteditem.VisitorNo };
            selecteditem.Contact.Tel = updatedVisitorModel.Contact.Tel;
            selecteditem.Contact.City = updatedVisitorModel.Contact.City;
            selecteditem.Contact.Address = updatedVisitorModel.Contact.Address;
            selecteditem.Contact.PostCode = updatedVisitorModel.Contact.PostCode;

            if (!string.IsNullOrWhiteSpace(updatedVisitorModel.Photo?.CapturePhotoPath))
            {
                if (selecteditem.Photo == null)
                {
                    selecteditem.Photo = new VisitorPhoto { VisitorNo = selecteditem.VisitorNo };
                }
                selecteditem.Photo.CapturePhotoPath = updatedVisitorModel.Photo.CapturePhotoPath;
                selecteditem.Photo.CaptureDate = updatedVisitorModel.Photo.CaptureDate;

            }
            else
            {
                if (selecteditem != null)
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

            UpdateHQPhotoPreview(updatedVisitorModel);
            UpdateSitePhotoPreview(updatedVisitorModel);
        }
        private void SetFallbackImage(PictureBox box)
        {

            var resourceManager = new System.ComponentModel.ComponentResourceManager(typeof(VisitorPBUserControl));

            object resourceObject = resourceManager.GetObject($"{box.Name}.InitialImage");


            if (resourceObject is Image fallbackImage)
            {
                box.Image = fallbackImage;
            }
        }
        private void UpdateHQPhotoPreview(Visitor v)
        {
            var pb = visitorPictureBox;
            if (pb.Image != null)
            {
                pb.Image.Dispose();
                SetFallbackImage(pb);
            }
            var path = v?.Photo?.CapturePhotoPath;
            if (string.IsNullOrWhiteSpace(path))
            {
                SetFallbackImage(pb);
                return;
            }
            try
            {
                using var fs = new System.IO.FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using var img = Image.FromStream(fs, useEmbeddedColorManagement: false, validateImageData: true);


                pb.Image = new Bitmap(img);
                //pb.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {

                MessageBox.Show("Photo file can’t be read (missing/corrupt/in use).");
                //pb.Image = (Image)this.GetObject("visitorUploadPictureBox.InitialImage");
                SetFallbackImage(pb);
            }

        }
        private void UpdateSitePhotoPreview(Visitor v)
        {
            var pb = visitorUploadPictureBox;
            if (pb.Image != null)
            {
                pb.Image.Dispose();
                SetFallbackImage(pb);
            }
            var path = v?.Photo?.UploadPhotoPath;
            if (string.IsNullOrWhiteSpace(path))
            {
                SetFallbackImage(pb);
                return;
            }
            try
            {
                using var fs = new System.IO.FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using var img = Image.FromStream(fs, useEmbeddedColorManagement: false, validateImageData: true);


                pb.Image = new Bitmap(img);
                //pb.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {

                MessageBox.Show("Photo file can’t be read (missing/corrupt/in use).");
                //pb.Image = (Image)this.GetObject("visitorUploadPictureBox.InitialImage");
                SetFallbackImage(pb);
            }
        }
        private void VisitorGridViewPBControl_SelectionChanged(object sender, EventArgs e)
        {
            var v = CurrentItem;
            UpdateHQPhotoPreview(v);
            UpdateSitePhotoPreview(v);
        }

        private void toolStripAddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
