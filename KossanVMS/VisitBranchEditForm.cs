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
      public VisitBranch visitBranchModel {  get; set; }
        public VisitBranchEditForm(VisitBranch exitingVisitBranch = null)
        {
            InitializeComponent();
            if (exitingVisitBranch != null)
            {
                Text = "Edit Branch";
                visitBranchModel = exitingVisitBranch;
            }
            else
            {
                Text = "Add Branch";
                visitBranchModel = new VisitBranch();
            }

            buttonBranchName.Text = visitBranchModel.BranchName;
            textBoxBranchDescription.textBox.Text = visitBranchModel.BranchDescription;
            textBoxBranchContract.textBox.Text = visitBranchModel.BranchConnectionString.ToString();
            textBoxBranchStatus.textBox.Text = visitBranchModel.BranchStatus.ToString();
            
        }
    }
}
