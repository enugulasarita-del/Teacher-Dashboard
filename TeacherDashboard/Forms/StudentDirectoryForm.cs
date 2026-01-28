using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class StudentDirectoryForm : Form
    {
        public StudentDirectoryForm()
        {
            InitializeComponent();
            panelTop.Visible = false;
            btnClose.Visible = false;
            LoadMockData();
        }

        private void LoadMockData()
        {
            dgvStudents.Rows.Add("RN-2026001", "Alice Smith");
            dgvStudents.Rows.Add("RN-2026002", "Bob Johnson");
            dgvStudents.Rows.Add("RN-2026003", "Charlie Brown");
            dgvStudents.Rows.Add("RN-2026004", "Diana Prince");
            dgvStudents.Rows.Add("RN-2026005", "Evan Wright");
            dgvStudents.Rows.Add("RN-2026006", "Fiona Green");
            dgvStudents.Rows.Add("RN-2026007", "George Hall");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.ToLower();
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvStudents.DataSource];
            if (currencyManager != null)
            {
                currencyManager.SuspendBinding();
            }

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                bool visible = false;
                // Check all cells
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(filter))
                    {
                        visible = true;
                        break;
                    }
                }
                row.Visible = visible;
            }

             if (currencyManager != null)
            {
                currencyManager.ResumeBinding();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
