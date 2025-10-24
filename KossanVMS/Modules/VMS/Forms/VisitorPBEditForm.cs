using KossanVMS.Data;
using KossanVMS.Utility;
using Microsoft.EntityFrameworkCore;
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
using System.Configuration;

namespace KossanVMS
{

    public partial class VisitorPBEditForm : Form
    {
        public Visitor visitorModel { get; set; }
        private VisitorPhotoCapture visitorPhotoCapture;
        private bool isMoving = false;
        private readonly VmsContext _db;
        private bool _isNew = false;
        private List<VisitCategory> _category { get; set; }
        private VisitorContactEditForm visitorContactEditForm;
       private VisitRecord _visitRecord { get; set; }
        public VisitorPBEditForm(VmsContext db,Visitor existingVisitor = null, VisitRecord visitRecord = null)
        {
            InitializeComponent();
            //_db = new VmsContext();
            _db = db ?? throw new ArgumentNullException(nameof(db));
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
            buttonUpdateID.Text = visitorModel.VisitorNo.ToString();
            maskedTextBoxIC.Text = visitorModel.IdNo ?? "";
            textboxVisitorFullName.textBox.Text = visitorModel.FullName ?? "";
            buttonLabelUpdateContact.TextButton = visitorModel.Contact?.Tel ?? "";
            //var visitType= visitorModel.IdType;
            LoadCategoryCheckList();
            LoadBranchCheckList();

            comboBoxIdType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIdType.DrawMode = DrawMode.OwnerDrawFixed;   // if you need it
            comboBoxIdType.ItemHeight = 45;

            comboBoxIdType.DataSource = Enum.GetValues(typeof(Data.IdType));
          

            comboBoxIdType.SelectedItem = visitorModel.IdType;

            comboBoxIdType.DrawItem += ComboBoxIdType_DrawItem;  // only if OwnerDraw

        }





        #region Initial Load Data
        
        private void LoadBranchCheckList()
        {
            checkedListBoxBranch.BeginUpdate();
            try
            {
                var items = _db.VisitBranches
                               .OrderBy(b => b.BranchName)
                               .Select(b => new ListItem { Id = b.BranchID, Text = b.BranchName })
                               .ToList();
                checkedListBoxBranch.DataSource = null;          // clear any previous binding
                checkedListBoxBranch.Items.Clear();
                checkedListBoxBranch.DisplayMember = nameof(ListItem.Text);
                checkedListBoxBranch.ValueMember = nameof(ListItem.Id);
                checkedListBoxBranch.DataSource = items;
                var linkedIds = (visitorModel?.VisitorNo > 0)
                    ? new HashSet<int>(
                        _db.VisitorBranchLinks
                           .Where(x => x.VisitorNo == visitorModel.VisitorNo)
                           .Select(x => x.BranchID)
                           .ToList())
                    : new HashSet<int>();
                for(int i = 0; i < items.Count; i++)
                {
                    if (linkedIds.Contains(items[i].Id))
                        checkedListBoxBranch.SetItemChecked(i, true);
                }
            }
            catch
            {

            }
            // Similar to LoadCategoryCheckList but for branches
        }
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
                var linkedIds = (visitorModel?.VisitorNo > 0)
                    ? new HashSet<int>(
                        _db.VisitorCategoryLinks
                           .Where(x => x.VisitorNo == visitorModel.VisitorNo)
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
        #endregion

        #region Save Methods
        public void SaveVisitorCategories()
        {
            if (_isNew) return; // no categories for new visitor yet
            var selectedIds = checkedListBoxCat.CheckedItems
                                .Cast<ListItem>()
                                .Select(li => li.Id)
                                .ToList();
            var existingLinks = _db.VisitorCategoryLinks
                                   .Where(x => x.VisitorNo == visitorModel.VisitorNo)
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
                            VisitorNo = visitorModel.VisitorNo,
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
        public void SaveVisitorRecord()
        {
            var visitorRecordDb = _db.VisitRecords.LoadAsync();
            var record = new VisitRecord
            {
                VisitorNo = visitorModel.VisitorNo,
                //BranchID =  visitorModel.VisitorBranches.Where(x=> x.).Select(vb => vb.BranchID).FirstOrDefault(),
            };
        }
        public void SaveVisitRecord()
        {
            _visitRecord.Visitor = visitorModel;
            //_visitRecord.
        }
        private bool SaveResults()
        {
            var ic = (maskedTextBoxIC.Text ?? "").Trim();   // trim!
            //System.Diagnostics.Debug.WriteLine($"DBG name={maskedTextBoxIC.Name}, text='{textboxVisitorIC.textBox.Text}', len={textboxVisitorIC.Text?.Length ?? -1}");

            if (ic.Length == 0)
            {
                MessageBox.Show("Please fill in the Visitor Identity.");
                maskedTextBoxIC.Focus();
                return false;
            }
            // push values back into the model (if you’re not using data-binding)
            visitorModel.IdNo = maskedTextBoxIC.Text.Trim();
            visitorModel.FullName = textboxVisitorFullName.textBox.Text.Trim();
            visitorModel.Contact ??= new VisitorContact();
            visitorModel.IdType = (IdType)comboBoxIdType.SelectedIndex;
            // visitorModel.Contact.Tel = buttonLabelUpdateContact.Text?.Trim();

            return true;
        }
        #endregion

        #region Button Clicks
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


            visitorPhotoCapture.Load -= VisitorPhotoCapture_Load;
            visitorPhotoCapture.Load += VisitorPhotoCapture_Load;

            //visitorPhotoCapture.ShowDialog(this);

            if (visitorPhotoCapture.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(visitorPhotoCapture.capturePath))
            {
                visitorModel.Photo ??= new VisitorPhoto { VisitorNo = visitorModel.VisitorNo };
                visitorModel.Photo.CapturePhotoPath = visitorPhotoCapture.capturePath;
                visitorModel.Photo.CaptureDate = DateTime.UtcNow;

            }
            CenterForms();
        }


        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            visitorContactEditForm?.Dispose();
            visitorContactEditForm = new VisitorContactEditForm(visitorModel.Contact)
            {
                StartPosition = FormStartPosition.Manual,
                TopMost = true   // optional
            };
            this.LocationChanged -= VisitorEditForm_ContactLocationChanged;
            visitorContactEditForm.LocationChanged -= VisitorContactEditForm_LocationChanged;
            this.LocationChanged += VisitorEditForm_ContactLocationChanged;
            visitorContactEditForm.LocationChanged += VisitorContactEditForm_LocationChanged;
            visitorContactEditForm.Load -= VisitorContactEdit_Load;
            visitorContactEditForm.Load += VisitorContactEdit_Load;
            visitorContactEditForm.ShowDialog(this);
            CenterContactForms();
        }

        private async void cyberButtonSearch_Click(object sender, EventArgs e)
        {
            // maskedTextBoxIC.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var ic = maskedTextBoxIC.Text.Trim();

            var foundVisitor = await _db.Visitors
                .Include(v => v.Contact)
                .FirstOrDefaultAsync(v => v.IdNo == ic);

            visitorModel = foundVisitor;      // OK (same type)
            buttonUpdateID.Text = visitorModel.VisitorNo.ToString();
            maskedTextBoxIC.Text = visitorModel.IdNo ?? "";
            textboxVisitorFullName.textBox.Text = visitorModel.FullName ?? "";
            buttonLabelUpdateContact.TextButton = visitorModel.Contact?.Tel ?? "";
        }
        #endregion

        #region Forms Alightment
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
        private void CenterContactForms()
        {
            // Get the dimensions of the primary screen's working area
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Calculate the total width of the two forms
            int totalWidth = this.Width + visitorContactEditForm.Width;

            // Calculate the new starting X and Y coordinates to center them
            int startX = (workingArea.Width - totalWidth / 2);
            int startY = (workingArea.Height - this.Height) / 2;

            // Apply the new location to the forms
            this.Location = new Point(startX, startY);
            visitorContactEditForm.Location = new Point(this.Right, this.Top);
        }
        private void CenterForms(Form leftForm, Form rightForm)
        {
            // Center on the screen containing the editor form
            var wa = Screen.FromControl(leftForm).WorkingArea;

            int totalWidth = leftForm.Width + rightForm.Width;
            int startX = wa.Left + (wa.Width - totalWidth) / 2;
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
        private void VisitorPhotoCapture_Load(object sender, EventArgs e)
        {
            CenterForms(this, visitorPhotoCapture);
        }
        private void VisitorContactEdit_Load(object sender, EventArgs e)
        {
            CenterForms(this, visitorContactEditForm);
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
        private void VisitorEditForm_ContactLocationChanged(object sender, EventArgs e)
        {
            if (isMoving) return;

            isMoving = true;

            // Check if the form is moving out of the left boundary
            if (this.Left < 0)
            {
                this.Location = new Point(0, this.Top);
            }

            visitorContactEditForm.Location = new Point(this.Right, this.Top);

            // Check if the pair is moving out of the right boundary
            if (visitorContactEditForm.Right > Screen.PrimaryScreen.WorkingArea.Width)
            {
                int newX = Screen.PrimaryScreen.WorkingArea.Width - visitorContactEditForm.Width;
                visitorContactEditForm.Location = new Point(newX, visitorContactEditForm.Top);
                this.Location = new Point(newX - this.Width, this.Top);
            }

            isMoving = false;
        }


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
        private void VisitorContactEditForm_LocationChanged(object sender, EventArgs e)
        {
            if (isMoving) return;

            isMoving = true;

            // Check if the form is moving out of the right boundary
            if (visitorContactEditForm.Right > Screen.PrimaryScreen.WorkingArea.Width)
            {
                visitorContactEditForm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - visitorContactEditForm.Width, visitorContactEditForm.Top);
            }

            this.Location = new Point(visitorContactEditForm.Left - this.Width, visitorContactEditForm.Top);

            // Check if the pair is moving out of the left boundary
            if (this.Left < 0)
            {
                int newX = 0;
                this.Location = new Point(newX, this.Top);
                visitorContactEditForm.Location = new Point(newX + this.Width, visitorContactEditForm.Top);
            }

            isMoving = false;
        }
        #endregion

        private void ComboBoxIdType_DrawItem(object? sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                using var bg = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(bg, e.Bounds);

                // get the text for the row that's actually being drawn
                string text = comboBoxIdType.GetItemText(comboBoxIdType.Items[e.Index]);
                bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                var fore = selected ? SystemColors.HighlightText : comboBoxIdType.ForeColor;
                TextRenderer.DrawText(e.Graphics, text, comboBoxIdType.Font,
                                      e.Bounds, Color.Black,
                                      TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
            e.DrawFocusRectangle();

        }
        private void comboBoxIdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var type = (IdType)comboBoxIdType.SelectedIndex;
            if (type == IdType.IC && string.IsNullOrEmpty(visitorModel.IdNo))
            {
                maskedTextBoxIC.Mask = "000000-00-0000";
                maskedTextBoxIC.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else if (type == IdType.Passport)// && string.IsNullOrEmpty(visitorModel.IdNo))
            {
                maskedTextBoxIC.Mask = "AAAAAAAAAA";
                maskedTextBoxIC.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else if (type == IdType.Permit )//&& string.IsNullOrEmpty(visitorModel.IdNo))
            {
                maskedTextBoxIC.Mask = "00000000";
                maskedTextBoxIC.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
        }

        private void ComboBoxIdType_Click(object sender, EventArgs e)
        {
            comboBoxIdType.DroppedDown = false;
            var messageBoxResult = MessageBox.Show("Changing ID Type will clear the existing ID Number. Do you want to proceed?", "Confirm Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (messageBoxResult == DialogResult.Yes)
            {
                comboBoxIdType.DroppedDown = true;
                var type = (IdType)comboBoxIdType.SelectedIndex;
                if (type == IdType.IC) //&& string.IsNullOrEmpty(visitorModel.IdNo))
                {
                    maskedTextBoxIC.Mask = "000000-00-0000";
                    maskedTextBoxIC.TextMaskFormat = MaskFormat.IncludeLiterals;
                }
                else if (type == IdType.Passport) //&& string.IsNullOrEmpty(visitorModel.IdNo))
                {
                    maskedTextBoxIC.Mask = "AAAAAAAAAA";
                    maskedTextBoxIC.TextMaskFormat = MaskFormat.IncludeLiterals;
                }
                else if (type == IdType.Permit)//&& string.IsNullOrEmpty(visitorModel.IdNo))
                {
                    maskedTextBoxIC.Mask = "00000000";
                    maskedTextBoxIC.TextMaskFormat = MaskFormat.IncludeLiterals;
                }
            }
            else
            {
                // Revert to previous selection if user cancels
                comboBoxIdType.DroppedDown = false;
            }
            //comboBoxIdType.DroppedDown = true;
        }
        private void foxLinkLabel1_Click(object sender, EventArgs e)
        {

        }
    }

}
