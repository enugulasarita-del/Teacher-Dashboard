using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class HolidayCalendarForm : Form
    {
        public HolidayCalendarForm()
        {
            InitializeComponent();
            panelTop.Visible = false;
            LoadMockData();
        }

        private void LoadMockData()
        {
            dgvHolidays.Rows.Add("2026-01-26", "Republic Day", "National Holiday");
            dgvHolidays.Rows.Add("2026-03-25", "Holi", "Public Holiday");
            dgvHolidays.Rows.Add("2026-08-15", "Independence Day", "National Holiday");
            dgvHolidays.Rows.Add("2026-10-02", "Gandhi Jayanti", "National Holiday");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoliday.Text))
            {
                MessageBox.Show("Please enter a holiday name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvHolidays.Rows.Add(dtpDate.Value.ToString("yyyy-MM-dd"), txtHoliday.Text, "Custom Holiday");
            txtHoliday.Clear();
        }
    }
}
