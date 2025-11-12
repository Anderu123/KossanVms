using KossanVMS.Data;
using KossanVMS.Utility;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KossanVMS
{
    public partial class VisitorPreEditForm : Form
    {
        public Visitor  visitorModel { get; set; }
        private bool isMoving = false;
        private readonly VmsContext  _db;
        private bool _isNew  = false;
        private List<Category> _category { get; set; }
        private VisitorContactEditForm visitorContactEditForm;
        private string? savePhotoFilePath = @"C:\Vms\UploadPhotos";
        public string? uploadPath { get; set; }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;          
        //        return cp;
        //    }
        //}
      
        private void EnableDoubleBufferingForCheckedListBox()
        {
            typeof(CheckedListBox).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(checkedListBoxCat, true, null);
        }
        static void EnableDoubleBuffering(Control c)
        {
            var pi = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            pi?.SetValue(c, true, null);
        }
        public VisitorPreEditForm(VmsContext _db, Visitor exisitingVisitor = null)
        {
            InitializeComponent();
            EnableDoubleBuffering(tableLayoutPanel1);
            //EnableDoubleBuffering(checkedListBoxCat);
            EnableDoubleBufferingForCheckedListBox();
            this._db = _db ?? throw new ArgumentNullException(nameof(_db));
            if (exisitingVisitor == null)
            {
                Text = "Add Visitor";
                visitorModel = new Visitor();
                _isNew = true;
            }
            else
            {
                Text = "Edit Visitor";
                visitorModel = exisitingVisitor;
            }
            //buttonUpdateID.TextButton = visitorModel.VisitorNo.ToString();
            maskedTextBoxIC.Text = visitorModel.VisitorIdNo ?? "";
            textboxVisitorFullName.textBox.Text = visitorModel.VisitorFullName ?? "";
            buttonLabelUpdateContact.TextButton = visitorModel.VisitorContact?.ContactTel ?? "";
            LoadCategoryCheckList();
            LoadPurposeList();
            comboBoxIdType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIdType.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxIdType.ItemHeight = 45;
            comboBoxIdType.DataSource = Enum.GetValues(typeof(IdType)).Cast<IdType>();
            comboBoxIdType.SelectedItem = visitorModel.VisitorIdType;
             comboBoxIdType.DrawItem += ComboBoxIdType_DrawItem;

        }

        private void LoadPurposeList()
        {
            var items = _db.VisitPurposes.Where(p=> p.PurposeStatus).OrderBy(p=> p.PurposeName).Select( p => new { p.PurposeID, p.PurposeName }).ToList();

            comboBoxPurpose.DisplayMember = "PurposeName";  
            comboBoxPurpose.ValueMember = "PurposeID";
            comboBoxPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPurpose.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxPurpose.DataSource = items;
            //comboBoxPurpose.SelectedIndex = items.Count > 0 ? 0 : -1;
            comboBoxPurpose.DrawItem += ComboBoxPurpose_DrawItem;


        }
        private void LoadCategoryCheckList()
        {
            checkedListBoxCat.BeginUpdate();
            try
            {
                var items = _db.VisitCategories.OrderBy(c => c.CategoryName).Select(c => new ListItem { Id = c.CategoryID, Text = c.CategoryName }).ToList();
                checkedListBoxCat.DataSource = null;
                checkedListBoxCat.Items.Clear();
                checkedListBoxCat.DisplayMember = nameof(ListItem.Text);
                checkedListBoxCat.ValueMember = nameof(ListItem.Id);
                checkedListBoxCat.DataSource = items;
                var linkedCategories = (visitorModel?.VisitorNo >0) ?  new HashSet<int>(_db
                    .VisitorCategoryLinks.Where(x=>x.IdNo == visitorModel.VisitorIdNo)
                    .Select(x => x.CategoryID).ToList())
                    : new HashSet<int>();   
                for (int i = 0; i < checkedListBoxCat.Items.Count; i++)
                {
                    if(linkedCategories.Contains(((ListItem)checkedListBoxCat.Items[i]).Id))
                    {
                        checkedListBoxCat.SetItemChecked(i, true);
                    }
                }
            }
            finally
            {
                checkedListBoxCat.EndUpdate();
            }
        }


        #region Button Methods
        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a photo";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);
                    if (!Directory.Exists(savePhotoFilePath))
                    {
                        Directory.CreateDirectory(savePhotoFilePath);
                    }
                    try
                    {
                        uploadPath = savePhotoFilePath + @"\" + ConfigurationManager.AppSettings["branch"] + "_" + DateTime.UtcNow.ToString("yyyyMMddhhmmss") + System.IO.Path.GetExtension(openFileDialog.FileName);
                        selectedImage.Save(uploadPath, ImageFormat.Jpeg);
                       
                        MessageBox.Show("Photo successfully uploaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error saving photo: " + ex.Message );
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!SaveResults())
                return;
            SaveVisitorCategories();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            visitorContactEditForm?.Dispose();

            if (visitorModel.VisitorContact == null)
            {
                visitorModel.VisitorContact = new Contact();
            }
            visitorContactEditForm = new VisitorContactEditForm(visitorModel.VisitorContact)
            {
                StartPosition = FormStartPosition.Manual,
                TopMost = true
            };
            this.LocationChanged -= VisitorEditForm_ContactLocationChanged;
            visitorContactEditForm.LocationChanged -= VisitorContactEditForm_LocationChanged;
            this.LocationChanged += VisitorEditForm_ContactLocationChanged;
            visitorContactEditForm.LocationChanged += VisitorContactEditForm_LocationChanged;
            visitorContactEditForm.Load -= VisitorContactEdit_Load;
            visitorContactEditForm.Load += VisitorContactEdit_Load;
            visitorContactEditForm.ShowDialog(this);
            CenterContactForms();
            //var result = visitorContactEditForm.ShowDialog(this);
            //if (result == DialogResult.OK)
            //{
            //    if (visitorContactEditForm.SaveContact())
            //    {
            //        buttonLabelUpdateContact.TextButton = visitorModel.Contact?.Tel ?? "";
            //    }
            //}
        }

        #endregion

        private bool SaveResults()
        {
            var ic = maskedTextBoxIC.Text.Trim() ?? "";
            if(ic.Length == 0)
            {
                MessageBox.Show("Please fill in the Visitor Identity");
                maskedTextBoxIC.Focus();
                return false;
            }
            visitorModel.VisitorIdNo = maskedTextBoxIC.Text.Trim();
            visitorModel.VisitorFullName = textboxVisitorFullName.textBox.Text.Trim();
            visitorModel.VisitorContact ??= new Contact();
            visitorModel.VisitorIdType = (IdType)comboBoxIdType.SelectedIndex;
            visitorModel.VisitorPhoto.PhotoUploadPath = uploadPath ?? "";
            //visitorModel.
            return true;
        }
        private void SaveVisitorCategories()
        {
            if (_isNew) return;
            var selectedId = checkedListBoxCat.CheckedItems.Cast<ListItem>()
                .Select(l => l.Id).ToList();
            var existingLinks = _db.VisitorCategoryLinks
                .Where(x => x.IdNo == visitorModel.VisitorIdNo).ToList();

            var toDelete = existingLinks
                          .Where(link => !selectedId.Contains(link.CategoryID))
                          .ToList();
            if (toDelete.Count > 0)
            {
                _db.VisitorCategoryLinks.RemoveRange(toDelete);
            }
         
            var existingIds = existingLinks.Select(x => x.CategoryID).ToHashSet();
            var toAdd = selectedId
                        .Where(id => !existingIds.Contains(id))
                        .Select(id => new CategoryLink
                        {
                            IdNo = visitorModel.VisitorIdNo,
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
        private void buttonSearch_click(object sender, EventArgs e)
        {
           
            var identityNo = maskedTextBoxIC.Text.Trim();
            var searchResult = _db.Visitors.FirstOrDefault(x => x.VisitorIdNo == identityNo);
            if (searchResult != null)
            {
                MessageBox.Show(this, "Search Found!", "Success",
    MessageBoxButtons.OK, MessageBoxIcon.Information);

                textboxVisitorFullName.textBox.Text = searchResult.VisitorFullName.Trim();


            }
        }

        #region Combox Settings
        private void ComboBoxIdType_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if(e.Index >= 0 )
            {
                using var bg = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(bg, e.Bounds);
                string text = comboBoxIdType.GetItemText(comboBoxIdType.Items[e.Index]);
                bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                var fore = selected ? SystemColors.HighlightText :comboBoxIdType.ForeColor;
                TextRenderer.DrawText(e.Graphics, text, comboBoxIdType.Font, e.Bounds, Color.Black, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
            e.DrawFocusRectangle();
        }
        private void ComboBoxPurpose_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                using var bg = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(bg, e.Bounds);
                string text = comboBoxPurpose.GetItemText(comboBoxPurpose.Items[e.Index]);
                bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                var fore = selected ? SystemColors.HighlightText : comboBoxPurpose.ForeColor;
                TextRenderer.DrawText(e.Graphics, text, comboBoxPurpose.Font, e.Bounds, Color.Black, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
            e.DrawFocusRectangle();
        }
        private void ComboBoxPurpose_Click(object sender, EventArgs e)
        {
            comboBoxPurpose.DroppedDown = false;
            var messageBoxResult = MessageBox.Show("Changing ID Type will clear the existing ID Number. Do you want to proceed?", "Confirm Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (messageBoxResult == DialogResult.Yes)
            {
                comboBoxPurpose.DroppedDown = true;
                var type = (IdType)comboBoxPurpose.SelectedItem;
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
                //else if (type == IdType.Permit)//&& string.IsNullOrEmpty(visitorModel.IdNo))
                //{
                //    maskedTextBoxIC.Mask = "00000000";
                //    maskedTextBoxIC.TextMaskFormat = MaskFormat.IncludeLiterals;
                //}
            }
            else
            {
                // Revert to previous selection if user cancels
                comboBoxPurpose.DroppedDown = false;
            }

        }
        private void ComboBoxIdType_Click(object sender, EventArgs e)
        {
            comboBoxIdType.DroppedDown = false;
            var messageBoxResult = MessageBox.Show("Changing ID Type will clear the existing ID Number. Do you want to proceed?", "Confirm Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (messageBoxResult == DialogResult.Yes)
            {
                comboBoxIdType.DroppedDown = true;
                var type = (IdType)comboBoxIdType.SelectedItem;
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
                //else if (type == IdType.Permit)//&& string.IsNullOrEmpty(visitorModel.IdNo))
                //{
                //    maskedTextBoxIC.Mask = "00000000";
                //    maskedTextBoxIC.TextMaskFormat = MaskFormat.IncludeLiterals;
                //}
            }
            else
            {
                // Revert to previous selection if user cancels
                comboBoxIdType.DroppedDown = false;
            }
        
        }
        #endregion


        #region Forms Alightment
        private void CenterForms()
        {
            // Get the dimensions of the primary screen's working area
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Calculate the total width of the two forms
            int totalWidth = this.Width;

            // Calculate the new starting X and Y coordinates to center them
            int startX = (workingArea.Width - totalWidth / 2);
            int startY = (workingArea.Height - this.Height) / 2;

            // Apply the new location to the forms
            this.Location = new Point(startX, startY);
          
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
        //private void VisitorPhotoCapture_Load(object sender, EventArgs e)
        //{
        //    CenterForms(this, visitorPhotoCapture);
        //}
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

            //visitorPhotoCapture.Location = new Point(this.Right, this.Top);

            //// Check if the pair is moving out of the right boundary
            //if (visitorPhotoCapture.Right > Screen.PrimaryScreen.WorkingArea.Width)
            //{
            //    int newX = Screen.PrimaryScreen.WorkingArea.Width - visitorPhotoCapture.Width;
            //    visitorPhotoCapture.Location = new Point(newX, visitorPhotoCapture.Top);
            //    this.Location = new Point(newX - this.Width, this.Top);
            //}

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


        //private void VisitorPhotoCaptureForm_LocationChanged(object sender, EventArgs e)
        //{
        //    if (isMoving) return;

        //    isMoving = true;

        //    // Check if the form is moving out of the right boundary
        //    if (visitorPhotoCapture.Right > Screen.PrimaryScreen.WorkingArea.Width)
        //    {
        //        visitorPhotoCapture.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - visitorPhotoCapture.Width, visitorPhotoCapture.Top);
        //    }

        //    this.Location = new Point(visitorPhotoCapture.Left - this.Width, visitorPhotoCapture.Top);

        //    // Check if the pair is moving out of the left boundary
        //    if (this.Left < 0)
        //    {
        //        int newX = 0;
        //        this.Location = new Point(newX, this.Top);
        //        visitorPhotoCapture.Location = new Point(newX + this.Width, visitorPhotoCapture.Top);
        //    }

        //    isMoving = false;
        //}
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
        #region Text Box Style
        private void textBoxUpdate_Leave(object sender, EventArgs e)
        {
            CyberTextBox clickedButton = sender as CyberTextBox;
            if (clickedButton != null)
            {
                clickedButton.ColorBackground_Pen = Color.PaleTurquoise;
                clickedButton.ColorBackground = Color.LightGray;
                clickedButton.Invalidate();
            }
        }

        private void textBoxUpdate_Enter(object sender, EventArgs e)
        {
            CyberTextBox clickedButton = sender as CyberTextBox;

            if (clickedButton != null)
            {
                clickedButton.ColorBackground_Pen = Color.Turquoise;
                clickedButton.ColorBackground = Color.White;
                clickedButton.Invalidate();
            }

        }
        #endregion
    }
}
