using KossanVMS.Data;
using KossanVMS.UserControlPage;
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
    public partial class VisitBranchEditForm : Form


    {
        public Branch visitBranchModel { get; set; }
        private bool _updatingStatus;
        private bool _syncing;
        public VisitBranchEditForm(Branch existingVisitBranch = null)
        {
            InitializeComponent();
            if (existingVisitBranch != null)
            {
                Text = "Edit Branch";
                visitBranchModel = existingVisitBranch;
            }
            else
            {
                Text = "Add Branch";
                visitBranchModel = new Branch();
            }

            textBoxBranchName.textBox.Text = visitBranchModel.BranchName;
            textBoxBranchDescription.textBox.Text = visitBranchModel.BranchDescription ?? "";
            HideRow(tableLayoutPanel1, 3, false);
            //textBoxBranchConnStr.textBox.Hide();
            //textBoxBranchConnStr.textBox.Text = visitBranchModel.BranchConnectionString ?? "";
            // buttonBranchActive.A= false;
            //buttonBranchInactive.AutoCheck = false; ;
            if (visitBranchModel.BranchStatus)
            {
                rbActive.Checked = true;
                rbInactive.Checked = false;
            }
            else
            {
                rbActive.Checked = true;
                rbInactive.Checked = false;
            }

        }
        private bool SaveResults()
        {
            var branchName = (textBoxBranchName.textBox.Text.Trim());
            if (string.IsNullOrEmpty(branchName))
            {
                MessageBox.Show("Please fill in branch name");
                textBoxBranchName.Focus();
                return false;
            }
            visitBranchModel.BranchName = branchName;
            visitBranchModel.BranchDescription = textBoxBranchDescription.textBox.Text.Trim();
            visitBranchModel.BranchConnectionString = textBoxBranchConnStr.textBox.Text.Trim();
            visitBranchModel.BranchStatus = rbActive.Checked;

            return true;



        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!SaveResults())
            {
                return;

            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        public void HideRow(TableLayoutPanel panel, int rowIndex, bool showRow)
        {
            
            foreach (Control control in panel.Controls)
            {
                
                if (panel.GetRow(control) == rowIndex)
                {
                    control.Visible = showRow;
                }
            }

            
            if (rowIndex < panel.RowStyles.Count)
            {
               
                panel.SuspendLayout();

                if (showRow)
                {
                  
                    panel.RowStyles[rowIndex].SizeType = SizeType.AutoSize;
                }
                else 
                {
                    
                    panel.RowStyles[rowIndex].SizeType = SizeType.Absolute;
                    panel.RowStyles[rowIndex].Height = 1F; 
                }

                
                panel.ResumeLayout(true);
                panel.PerformLayout();
            }
        }
        //private void buttonBranchActive_Click(object sender, EventArgs e)
        //{
        //    if (_syncing) return;
        //    _syncing = true;
        //    buttonBranchActive.Checked = true;   // force the pair
        //    buttonBranchInactive.Checked = false;
        //    _syncing = false;
        //}

        //private void buttonBranchInactive_Click(object sender, EventArgs e)
        //{
        //    if (_syncing) return;
        //    _syncing = true;
        //    buttonBranchActive.Checked = false;
        //    buttonBranchInactive.Checked = true;
        //    _syncing = false;
        //}
    }
}
