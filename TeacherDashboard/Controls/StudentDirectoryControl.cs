using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Controls
{
    public partial class StudentDirectoryControl : UserControl
    {
        public StudentDirectoryControl()
        {
            InitializeComponent();
            LoadMockData();
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void LoadMockData()
        {
            dgvStudents.Rows.Add("1001", "Alice Smith", "John Smith", "555-0101", "john.smith@example.com");
            dgvStudents.Rows.Add("1002", "Bob Johnson", "Sarah Johnson", "555-0102", "sarah.j@example.com");
            dgvStudents.Rows.Add("1003", "Charlie Brown", "Peter Brown", "555-0103", "peter.b@example.com");
            dgvStudents.Rows.Add("1004", "Diana Prince", "Hippolyta", "555-0104", "queen@themyscira.com");
            dgvStudents.Rows.Add("1005", "Evan Wright", "Mary Wright", "555-0105", "mary.w@example.com");
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.ToLower();
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                bool visible = false;
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
        }

        public void UpdateTheme(Color themeColor)
        {
            lblHeader.ForeColor = themeColor;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = themeColor;
        }
    }
}
