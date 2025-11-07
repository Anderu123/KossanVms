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
        private Contact contactModel { get; set; }
        private bool _isNew = false;
        public VisitorContactEditForm(Contact exitingContact = null)
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
                contactModel = new Contact();
                _isNew = true;

            }
            cyberTextBoxTel.textBox.Text = contactModel.ContactTel ?? "";
            cyberTextBoxAddress.textBox.Text = contactModel.ContactAddress ?? "";
            cyberTextBoxCity.textBox.Text = contactModel.ContactCity ?? "";
            cyberTextBoxPostCode.textBox.Text = contactModel.ContactPostCode ?? "";
            cyberTextBoxState.textBox.Text = contactModel.ContactState ?? "";
        }


        public bool SaveContact()
        {
            //if (_isNew)
            //    return false;
            contactModel.ContactTel = cyberTextBoxTel.textBox.Text.Trim();
            contactModel.ContactAddress = cyberTextBoxAddress.textBox.Text.Trim();
            contactModel.ContactCity = cyberTextBoxCity.textBox.Text.Trim();
            contactModel.ContactPostCode = cyberTextBoxPostCode.textBox.Text.Trim();
            contactModel.ContactState = cyberTextBoxState.textBox.Text.Trim();
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
