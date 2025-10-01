using KossanVMS.Data;
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
    public partial class VisitorForm : Form
    {
        public BindingList<Visitor> _items = new();
      //  private readonly VmsContext _db = new();

        private Visitor? CurrentItem
        {
            get
            {
                if (visitorBindingSource !=null)
                {
                    if(visitorBindingSource.Current is Visitor fromBs)
                    {
                        return fromBs;
                    }
                }
                DataGridViewRow row = null;
                if (VisitorGridView.CurrentRow != null)
                {
                    row = VisitorGridView.CurrentRow;
                }
                else if (VisitorGridView.SelectedRows.Count > 0)
                {
                    row = VisitorGridView.SelectedRows[0];
                }

                if (row != null)
                {
                    return row.DataBoundItem as Visitor;
                }
                return null; 
            }

        }
        public VisitorForm()
        {
            InitializeComponent();
            VisitorGridView.DataSource = _items;
            VisitorGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VisitorGridView.MultiSelect = false;
        }
      
        

    }
}
