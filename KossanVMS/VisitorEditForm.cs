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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace KossanVMS
{
    public partial class VisitorEditForm : Form
    {
        public Visitor visitorModel { get; set; }

        public VisitorEditForm(Visitor existingVisitor = null)
        {
            InitializeComponent();
            if (existingVisitor == null)
            {
                Text = "Add Visitor";
                visitorModel = new Visitor();
            }
            else
            {
                Text = "Edit Visitor";
                visitorModel = existingVisitor;
            }
            labelUpdateID.Text = visitorModel.VisitorID.ToString();
            textboxVisitorIC.textBox.Text = visitorModel.ICNo ?? "";
            textboxVisitorFullName.textBox.Text = visitorModel.FullName ?? "";
            labelUpdateContact.Text = visitorModel.Contact?.Tel ?? "";


        }
        private bool SaveResults()
        {
            var ic = (textboxVisitorIC.textBox.Text ?? "").Trim();   // trim!
            System.Diagnostics.Debug.WriteLine($"DBG name={textboxVisitorIC.Name}, text='{textboxVisitorIC.textBox.Text}', len={textboxVisitorIC.Text?.Length ?? -1}");

            if (ic.Length == 0)
            {
                MessageBox.Show("Please fill in the Visitor IC.");
                textboxVisitorIC.Focus();
                return false;
            }
            // push values back into the model (if you’re not using data-binding)
            visitorModel.ICNo = textboxVisitorIC.textBox.Text.Trim();
            visitorModel.FullName = textboxVisitorFullName.textBox.Text.Trim();
            visitorModel.Contact ??= new VisitorContact();
            visitorModel.Contact.Tel =labelUpdateContact.Text?.Trim();

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!SaveResults()) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
