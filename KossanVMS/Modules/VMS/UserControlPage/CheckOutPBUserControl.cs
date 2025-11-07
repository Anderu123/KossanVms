using KossanVMS.Data;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
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
            // ---- parent grids ----
            tableLayoutPanel1.AutoSize = false;
            tableLayoutPanel4.AutoSize = false;
            tableLayoutPanel2.AutoSize = false;
            tableLayoutPanel3.AutoSize = false;
            tableLayoutPanel5.AutoSize = false;

            tableLayoutPanel4.RowStyles.Clear();
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50f)); // top grid
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));  // details area

            dataGridViewCheckOut.Dock = DockStyle.Fill;
            panel3.Dock = DockStyle.Fill;

            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel2.Dock = DockStyle.Fill;

            // ---------- LEFT (tableLayoutPanel3) ----------
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel3.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel3.ColumnCount = 2;

            tableLayoutPanel3.RowStyles.Clear();
            tableLayoutPanel3.RowCount = 7; // 6 data rows + 1 footer (NO filler)
            for (int i = 0; i < 6; i++)
                tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f)); // rows 0..5
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));   // row 6 footer

            //if (tableLayoutPanel3.Controls.Contains(thunderLabel1))
            //    tableLayoutPanel3.Controls.Remove(thunderLabel1);

            //tableLayoutPanel3.SetRow(thunderLabel2, 6);
            //tableLayoutPanel3.SetColumn(thunderLabel2, 1);
            //tableLayoutPanel3.SetColumnSpan(thunderLabel2, 1);
            tableLayoutPanel3.ResumeLayout();

            // ---------- RIGHT (tableLayoutPanel5) ----------
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel5.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel5.ColumnCount = 2;

            tableLayoutPanel5.RowStyles.Clear();
            tableLayoutPanel5.RowCount = 7; // 6 data rows + 1 footer (NO filler)
            for (int i = 0; i < 6; i++)
                tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f)); // rows 0..5
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));     // row 6 buttons

            tableLayoutPanel5.SetRow(thunderLabel8, 6); tableLayoutPanel5.SetColumn(thunderLabel8, 0);
            tableLayoutPanel5.SetRow(panel2, 6); tableLayoutPanel5.SetColumn(panel2, 1);
            tableLayoutPanel5.ResumeLayout();

            // scroll safety (if content ever exceeds)
            panel3.AutoScroll = true;
            panel3.AutoScrollMargin = new Size(0, 8);

            // consistent heights for cyber textboxes
            foreach (var t in new[] { textboxTagNo, textboxRegisterType, textboxName, textboxIdNo, textboxCompany, textboxContact,
                               textboxVehicleNo, textboxCategory, textboxGatePass, textboxPerson, textboxDoNo, textboxRemark })
            {
                t.AutoSize = false;
                t.Dock = DockStyle.Fill;
                t.MinimumSize = new Size(0, 35);
                t.Height = 35;
            }

            panel2.Padding = new Padding(0, 0, 0, 2);
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
                textboxTagNo.textBox.Text = v.VisitRecordTagNo;
                textboxRegisterType.textBox.Text = v.VisitRecordRegisterType?.RegisterTypeName;
                textboxName.textBox.Text = v.VisitRecordVisitor.VisitorFullName;
                textboxIdNo.textBox.Text = v.VisitRecordVisitor.VisitorContact.ContactCompany;
                textboxContact.textBox.Text = v.VisitRecordVisitor.VisitorContact.ContactTel;
                textboxVehicleNo.textBox.Text = v.VisitRecordVehicleNo;
                textboxCategory.textBox.Text = v.VisitRecordCategory.CategoryName;
                textboxGatePass.textBox.Text = v.VisitRecordGatePass;



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
