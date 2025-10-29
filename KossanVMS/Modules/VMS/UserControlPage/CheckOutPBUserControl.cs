using KossanVMS.Data;
using Microsoft.EntityFrameworkCore;
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
        private VmsContext _db;
        private VisitRecord? CurrentItem => visitRecordBindingSource.Current as VisitRecord;
        public CheckOutPBUserControl(VmsContext db)
        {
            InitializeComponent();
            ApplyLayoutGuards();
            _db = db ?? throw new ArgumentNullException(nameof(db));
            dataGridViewCheckOut.DataSource = visitRecordBindingSource;
            dataGridViewCheckOut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        private void ApplyLayoutGuards()
        {
            // 1) Give the bottom form more space: fix grid height, let the form take the rest
            tableLayoutPanel4.RowStyles[0] = new RowStyle(SizeType.Absolute, 220f); // DataGridView row
            tableLayoutPanel4.RowStyles[1] = new RowStyle(SizeType.Percent, 200f);  // Form row

            // 2) Left panel (tableLayoutPanel3): fix the 1..6 input rows, last row flexible (shrinks first)
            for (int i = 0; i < 6; i++)
                tableLayoutPanel3.RowStyles[i] = new RowStyle(SizeType.Absolute, 48f);
            tableLayoutPanel3.RowStyles[6] = new RowStyle(SizeType.Percent, 100f);

            // 3) Right panel (tableLayoutPanel5): fix the 1..6 input rows, buttons row fixed a tad taller
            for (int i = 0; i < 6; i++)
                tableLayoutPanel5.RowStyles[i] = new RowStyle(SizeType.Absolute, 48f);
            tableLayoutPanel5.RowStyles[6] = new RowStyle(SizeType.Absolute, 52f);

            // 4) CyberTextBoxes: stop them from collapsing and shave some border thickness
            foreach (var t in new ReaLTaiizor.Controls.CyberTextBox[]
            {
        textboxTagNo, textboxRegisterType, textboxName, textboxIdNo, textboxCompany, textboxContact,
        textboxVehicleNo, textboxCategory, textboxGatePass, textboxPerson, textboxDoNo, textboxRemark
            })
            {
                t.AutoSize = false;
                if (t.MinimumSize.Height < 44) t.MinimumSize = new Size(0, 44);
                if (t.PenWidth > 10) t.PenWidth = 10; // optional: more inner space
            }

            // 5) Safety net: allow scrolling if space gets tight (small window, DPI, etc.)
            panel3.AutoScroll = true;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.Dock = DockStyle.Top;

            // (Optional) remove unused paint hooks to avoid redraw churn
            tableLayoutPanel2.Paint -= tableLayoutPanel2_Paint;
        }

        private async void CheckOutUserControl_Load(object? sender, EventArgs e)
        {
            try
            {
                if (_db != null)
                {
                    await _db.VisitRecords.LoadAsync();
                    visitRecordBindingSource.DataSource = _db.VisitRecords.Local.ToBindingList();

                }
            }
            catch
            {
                MessageBox.Show("Database connection error. Please contact the adminstrator.");
            }
        }

        private void CheckOutUserControl_SelectionChanged(object? sender, EventArgs e)
        {
            var v = CurrentItem;
            if (v != null)
            {
                textboxTagNo.textBox.Text = v.TagNo;
                textboxRegisterType.textBox.Text = v.RegisterType?.RegisterTypeName;
                textboxName.textBox.Text = v.Visitor.FullName;
                textboxIdNo.textBox.Text = v.Company;
                textboxContact.textBox.Text = v.Visitor.Contact.Tel;
                textboxVehicleNo.textBox.Text = v.VehicleNo;
                textboxCategory.textBox.Text = v.Category.CategoryName;
                textboxGatePass.textBox.Text = v.GatePass;



            }
        }
        private void splitContainer1_Resize(object sender, EventArgs e)
        {
          
        }

        private void CheckOutPBUserControl_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
