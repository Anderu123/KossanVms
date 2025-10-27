using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KossanVMS.Modules.VMS.UserControlPage
{

    public partial class CheckOutPBUserControl : UserControl
    {
        public CheckOutPBUserControl()
        {
            InitializeComponent();


        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }
    }
}
