using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KossanVMS.Data;
using KossanVMS.Utility;

namespace KossanVMS
{
    public partial class VisitorPreEditForm : Form
    {
        public Visitor  visitorModel { get; set; }
        private bool isMoving = false;
        private readonly VmsContext  _db;
        private bool _isNew  = false;
        private List<VisitCategory> _category { get; set; }
        private VisitorContactEditForm visitorContactEditForm;



        public VisitorPreEditForm(VmsContext _db, Visitor exisitingVisitor = null)
        {
            InitializeComponent();
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
            buttonUpdateID.TextButton = visitorModel.VisitorID.ToString();
            maskedTextBoxIC.Text = visitorModel.IdNo ?? "";
            textboxVisitorFullName.Text = visitorModel.FullName ?? "";
            buttonLabelUpdateContact.TextButton = visitorModel.Contact?.Tel ?? "";
            LoadCategoryCheckList();
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
                var linkedCategories = (visitorModel?.VisitorID>0) ?  new HashSet<int>(_db
                    .VisitorCategoryLinks.Where(x=>x.VisitorID == visitorModel.VisitorID)
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
                    // L
                    // oad the selected image into the PictureBox
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);
                   
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
            visitorModel.IdNo = maskedTextBoxIC.Text.Trim();
            visitorModel.FullName = textboxVisitorFullName.textBox.Text.Trim();
            visitorModel.Contact ??= new VisitorContact();
            visitorModel.IdType = (IdType)comboBoxIdType.SelectedIndex;
            return true;
        }
        private void SaveVisitorCategories()
        {
            if (_isNew) return;
            var selectedId = checkedListBoxCat.CheckedItems.Cast<ListItem>()
                .Select(l => l.Id).ToList();
            var existingLinks = _db.VisitorCategoryLinks
                .Where(x => x.VisitorID == visitorModel.VisitorID).ToList();

            var toDelete = existingLinks
                          .Where(link => !selectedId.Contains(link.CategoryID))
                          .ToList();
            if (toDelete.Count > 0)
            {
                _db.VisitorCategoryLinks.RemoveRange(toDelete);
            }
            // Add new links
            var existingIds = existingLinks.Select(x => x.CategoryID).ToHashSet();
            var toAdd = selectedId
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
        private void buttonSearch_click(object sender, EventArgs e)
        {
           
            var identityNo = maskedTextBoxIC.Text.Trim();
            var searchResult = _db.Visitors.FirstOrDefault(x => x.IdNo == identityNo);
            if (searchResult != null)
            {
                MessageBox.Show(this, "Search Found!", "Success",
    MessageBoxButtons.OK, MessageBoxIcon.Information);

                textboxVisitorFullName.textBox.Text = searchResult.FullName.Trim();


            }
        }
    }
}
