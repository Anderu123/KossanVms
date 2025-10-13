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

namespace KossanVMS
{
    public partial class VisitorPreEditForm : Form
    {
        public Visitor  visitorModel { get; set; }
        
        public VisitorPreEditForm()
        {
            InitializeComponent();
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
        #endregion
    }
}
