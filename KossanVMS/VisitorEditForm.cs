using KossanVMS.Data;
using KossanVMS.Utility;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KossanVMS
{

    public partial class VisitorEditForm : Form
    {
        public Visitor visitorModel { get; set; }
        private VisitorPhotoCapture visitorPhotoCapture;
        private bool isMoving = false;
        private readonly VmsContext _db;
        private bool _isNew = false;
        private List<VisitCategory> _category { get; set; }

        public VisitorEditForm(Visitor existingVisitor = null)
        {
            InitializeComponent();
            _db = new VmsContext();
            if (existingVisitor == null)
            {
                Text = "Add Visitor";
                visitorModel = new Visitor();
                _isNew = true;
            }
            else
            {
                Text = "Edit Visitor";
                visitorModel = existingVisitor;
            }
            buttonUpdateID.Text = visitorModel.VisitorID.ToString();
            maskedTextBoxIC.Text = visitorModel.ICNo ?? "";
            textboxVisitorFullName.textBox.Text = visitorModel.FullName ?? "";
            buttonLabelUpdateContact.Text = visitorModel.Contact?.Tel ?? "";

            //form alignment
            //visitorPhotoCapture = new VisitorPhotoCapture();
            //this.LocationChanged += VisitorEditForm_LocationChanged;
            //visitorPhotoCapture.LocationChanged += VisitorPhotoCaptureForm_LocationChanged;

            LoadCategoryCheckList();



        }
        // VisitorEditForm.cs
        // VisitorEditForm.cs

        private void LoadCategoryCheckList()
        {
            checkedListBoxCat.BeginUpdate();
            try
            {
                // 1) Load masters
                var items = _db.VisitCategories
                               .OrderBy(c => c.CategoryName)
                               .Select(c => new ListItem { Id = c.CategoryID, Text = c.CategoryName })
                               .ToList();

                // 2) Bind once
                checkedListBoxCat.DataSource = null;          // clear any previous binding
                checkedListBoxCat.Items.Clear();
                checkedListBoxCat.DisplayMember = nameof(ListItem.Text);
                checkedListBoxCat.ValueMember = nameof(ListItem.Id);
                checkedListBoxCat.DataSource = items;

                // 3) Load linked ids ONLY if we have a valid visitor id
                var linkedIds = (visitorModel?.VisitorID > 0)
                    ? new HashSet<int>(
                        _db.VisitorCategoryLinks
                           .Where(x => x.VisitorID == visitorModel.VisitorID)
                           .Select(x => x.CategoryID)
                           .ToList())
                    : new HashSet<int>();

                // 4) Pre-check after DataSource is set
                for (int i = 0; i < items.Count; i++)
                {
                    if (linkedIds.Contains(items[i].Id))
                        checkedListBoxCat.SetItemChecked(i, true);
                }
            }
            finally
            {
                checkedListBoxCat.EndUpdate();
            }
        }

        public void SaveVisitorCategories()
        {
            if (_isNew) return; // no categories for new visitor yet
            var selectedIds = checkedListBoxCat.CheckedItems
                                .Cast<ListItem>()
                                .Select(li => li.Id)
                                .ToList();
            var existingLinks = _db.VisitorCategoryLinks
                                   .Where(x => x.VisitorID == visitorModel.VisitorID)
                                   .ToList();
            // Delete unselected links
            var toDelete = existingLinks
                            .Where(link => !selectedIds.Contains(link.CategoryID))
                            .ToList();
            if (toDelete.Count > 0)
            {
                _db.VisitorCategoryLinks.RemoveRange(toDelete);
            }
            // Add new links
            var existingIds = existingLinks.Select(x => x.CategoryID).ToHashSet();
            var toAdd = selectedIds
                        .Where(id => !existingIds.Contains(id))
                        .Select(id => new VisitorCategoryLink
                        {
                            VisitorID = visitorModel.VisitorID,
                            CategoryID = id
                        })
                        .ToList();
            if (toAdd.Count > 0)
            {
                _db.VisitorCategoryLinks.AddRange(toAdd);
            }
            if (toDelete.Count > 0 || toAdd.Count > 0)
            {
                _db.SaveChanges();
            }
        }
        private void VisitorEditForm_LocationChanged(object sender, EventArgs e)
        {
            if (isMoving) return;

            isMoving = true;

            // Check if the form is moving out of the left boundary
            if (this.Left < 0)
            {
                this.Location = new Point(0, this.Top);
            }

            visitorPhotoCapture.Location = new Point(this.Right, this.Top);

            // Check if the pair is moving out of the right boundary
            if (visitorPhotoCapture.Right > Screen.PrimaryScreen.WorkingArea.Width)
            {
                int newX = Screen.PrimaryScreen.WorkingArea.Width - visitorPhotoCapture.Width;
                visitorPhotoCapture.Location = new Point(newX, visitorPhotoCapture.Top);
                this.Location = new Point(newX - this.Width, this.Top);
            }

            isMoving = false;
        }

        // MyOtherForm.cs
        private void VisitorPhotoCaptureForm_LocationChanged(object sender, EventArgs e)
        {
            if (isMoving) return;

            isMoving = true;

            // Check if the form is moving out of the right boundary
            if (visitorPhotoCapture.Right > Screen.PrimaryScreen.WorkingArea.Width)
            {
                visitorPhotoCapture.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - visitorPhotoCapture.Width, visitorPhotoCapture.Top);
            }

            this.Location = new Point(visitorPhotoCapture.Left - this.Width, visitorPhotoCapture.Top);

            // Check if the pair is moving out of the left boundary
            if (this.Left < 0)
            {
                int newX = 0;
                this.Location = new Point(newX, this.Top);
                visitorPhotoCapture.Location = new Point(newX + this.Width, visitorPhotoCapture.Top);
            }

            isMoving = false;
        }


        private bool SaveResults()
        {
            var ic = (maskedTextBoxIC.Text ?? "").Trim();   // trim!
            //System.Diagnostics.Debug.WriteLine($"DBG name={maskedTextBoxIC.Name}, text='{textboxVisitorIC.textBox.Text}', len={textboxVisitorIC.Text?.Length ?? -1}");

            if (ic.Length == 0)
            {
                MessageBox.Show("Please fill in the Visitor IC.");
                maskedTextBoxIC.Focus();
                return false;
            }
            // push values back into the model (if you’re not using data-binding)
            visitorModel.ICNo = maskedTextBoxIC.Text.Trim();
            visitorModel.FullName = textboxVisitorFullName.textBox.Text.Trim();
            visitorModel.Contact ??= new VisitorContact();
            visitorModel.Contact.Tel = buttonLabelUpdateContact.Text?.Trim();

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!SaveResults()) return;
            SaveVisitorCategories();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonVisitorVideoCapture_Click(object sender, EventArgs e)
        {
            // Manual positioning (designer might have set CenterScreen)
            this.StartPosition = FormStartPosition.Manual;

            visitorPhotoCapture?.Dispose();
            visitorPhotoCapture = new VisitorPhotoCapture(this)
            {
                StartPosition = FormStartPosition.Manual,
                TopMost = true   // optional
            };

            // wire once
            this.LocationChanged -= VisitorEditForm_LocationChanged;
            visitorPhotoCapture.LocationChanged -= VisitorPhotoCaptureForm_LocationChanged;
            this.LocationChanged += VisitorEditForm_LocationChanged;
            visitorPhotoCapture.LocationChanged += VisitorPhotoCaptureForm_LocationChanged;

            // Center AFTER the photo form has measured itself
            //  visitorPhotoCapture.Load += (_, __) => CenterForms(this, visitorPhotoCapture);
            visitorPhotoCapture.Load -= VisitorPhotoCapture_Load;
            visitorPhotoCapture.Load += VisitorPhotoCapture_Load;
            // Use owner so z-order is stable. Show() if you want side-by-side live.
            // If you must block, use ShowDialog(this) but keep the Load centering above.
            //visitorPhotoCapture.ShowDialog(this);
            
            if(visitorPhotoCapture.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(visitorPhotoCapture.capturePath))
            {
               visitorModel.Photo ??= new VisitorPhoto { VisitorID = visitorModel.VisitorID };
                visitorModel.Photo.PhotoPath = visitorPhotoCapture.capturePath;
                visitorModel.Photo.CaptureDate = DateTime.UtcNow;
                
            }
            CenterForms();
        }

        private void VisitorPhotoCapture_Load(object sender, EventArgs e)
        {
            CenterForms(this, visitorPhotoCapture);
        }
        private void CenterForms(Form leftForm, Form rightForm)
        {
            // Center on the screen containing the editor form
            var wa = Screen.FromControl(leftForm).WorkingArea;

            int totalWidth = leftForm.Width + rightForm.Width;
            int startX = wa.Left + (wa.Width - totalWidth) / 2;           // ✅ correct parentheses + offset
            int startY = wa.Top + (wa.Height - leftForm.Height) / 2;

            // place left form
            leftForm.Location = new Point(startX, startY);
            // snap right form to the right edge of left
            rightForm.Location = new Point(leftForm.Right, leftForm.Top);

            // clamp if the pair spills past the right edge
            if (rightForm.Right > wa.Right)
            {
                int shift = rightForm.Right - wa.Right;
                leftForm.Left -= shift;
                rightForm.Left -= shift;
            }
        }

        private void CenterForms()
        {
            // Get the dimensions of the primary screen's working area
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Calculate the total width of the two forms
            int totalWidth = this.Width + visitorPhotoCapture.Width;

            // Calculate the new starting X and Y coordinates to center them
            int startX = (workingArea.Width - totalWidth / 2);
            int startY = (workingArea.Height - this.Height) / 2;

            // Apply the new location to the forms
            this.Location = new Point(startX, startY);
            visitorPhotoCapture.Location = new Point(this.Right, this.Top);
        }

        private void textboxVisitorFullName_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}
