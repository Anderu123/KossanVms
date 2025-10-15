using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KossanVMS.Data;
namespace KossanVMS
{
    public partial class VisitorContactEditForm : Form
    {
        private VisitorContact contactModel { get; set; }
        private bool _isNew = false;
        public VisitorContactEditForm(VisitorContact exitingContact = null)
        {
            InitializeComponent();
            if (exitingContact != null)
            {
                this.Text = "Edit Contact";
                contactModel = exitingContact;
            }
            else
            {
                this.Text = "Add Contact";
                contactModel = new VisitorContact();
                _isNew = true;

            }
            cyberTextBoxTel.textBox.Text = contactModel.Tel ?? "";
            cyberTextBoxAddress.textBox.Text = contactModel.Address ?? "";
            cyberTextBoxCity.textBox.Text = contactModel.City ?? "";
            cyberTextBoxPostCode.textBox.Text = contactModel.PostCode ?? "";
            cyberTextBoxState.textBox.Text = contactModel.State ?? "";
        }


        public bool SaveContact()
        {
            //if (_isNew)
            //    return false;
            contactModel.Tel = cyberTextBoxTel.textBox.Text.Trim();
            contactModel.Address = cyberTextBoxAddress.textBox.Text.Trim();
            contactModel.City = cyberTextBoxCity.textBox.Text.Trim();
            contactModel.PostCode = cyberTextBoxPostCode.textBox.Text.Trim();
            contactModel.State = cyberTextBoxState.textBox.Text.Trim();
            return true;

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SaveContact())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save contact. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
