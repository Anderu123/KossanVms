using KossanVMS.Data;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KossanVMS
{
    public partial class VisitPurposeEditForm : Form
    {
        public Purpose visitPurposeModel { get; set; }
        private bool _updatingStatus;
        private bool _syncing;
        public VisitPurposeEditForm(Purpose existingVisitPurpose = null)
        {
            InitializeComponent();
            if (existingVisitPurpose != null)
            {
                Text = "Edit Branch";
                visitPurposeModel = existingVisitPurpose;
            }
            else
            {
                Text = "Add Branch";
                visitPurposeModel = new Purpose();
            }
            textBoxPurposeName.textBox.Text = visitPurposeModel.PurposeName ?? "";
            textBoxPurposeDescription.textBox.Text = visitPurposeModel.PurposeDescription ?? "";
            if (visitPurposeModel.PurposeStatus)
            {
                rbActive.Checked = true;
                rbInactive.Checked = false;
            }
            else
            {
                rbInactive.Checked = true;
                rbActive.Checked = false;
            }

        }
        private bool SaveResults()
        {
            var purposeName = (textBoxPurposeName.textBox.Text.Trim());
            if (string.IsNullOrEmpty(purposeName))
            {
                MessageBox.Show("Please fill in purpose name");
                textBoxPurposeName.Focus();
                return false;
            }
            visitPurposeModel.PurposeName = purposeName;
            visitPurposeModel.PurposeDescription = textBoxPurposeDescription.textBox.Text.Trim();
            visitPurposeModel.PurposeStatus = rbActive.Checked;
            return true;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!SaveResults())
            {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();



        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxPurposeName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.IsInputKey = true;
                textBoxPurposeName.textBox.Select();
                textBoxPurposeName.textBox.Focus();
            }
        }

        private void textBoxPurposeDescription_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.IsInputKey = true;
                textBoxPurposeDescription.textBox.Select();
                textBoxPurposeDescription.textBox.Focus();
            }
        }
        
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
    }
}
