﻿using KossanVMS.Data;
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
    public partial class VisitorCategoryEditForm : Form
    {
        public VisitCategory visitCategoryModel { get; set; }
        private readonly VmsContext _db;
        public VisitorCategoryEditForm(VmsContext db, VisitCategory existingVisitCategory = null )
        {
            InitializeComponent();
            _db = db ?? throw new ArgumentNullException(nameof(db));
            if(existingVisitCategory == null)
            {
                Text = "Add New Category";
                visitCategoryModel = new VisitCategory();
                
            }
            else
            {
                Text = "Edit Category";
                visitCategoryModel = existingVisitCategory;
            }
           // buttonCategoryID.Text = existingVisitCategory?.CategoryID.ToString() ?? "";
            textBoxCategoryName.textBox.Text = visitCategoryModel.CategoryName;
            textBoxCategoryDescription.textBox.Text = visitCategoryModel.CategoryDescription;
            if (visitCategoryModel.CategoryStatus)
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
            visitCategoryModel.CategoryName = textBoxCategoryName.textBox.Text.Trim();
            if(string.IsNullOrWhiteSpace(visitCategoryModel.CategoryName))
            {
                MessageBox.Show("Category Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCategoryName.textBox.Focus();
                return false;
            }
             visitCategoryModel.CategoryDescription  = textBoxCategoryDescription.textBox.Text.Trim();
            visitCategoryModel.CategoryStatus = rbActive.Checked;
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
    }
}
