using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TeacherDashboard.Controls
{
    public partial class AttendanceControl : UserControl
    {
        public AttendanceControl()
        {
            InitializeComponent();
            this.dgvAttendance.CellValueChanged += DgvAttendance_CellValueChanged;
            this.dgvAttendance.CurrentCellDirtyStateChanged += DgvAttendance_CurrentCellDirtyStateChanged;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string selectedClass = cmbClass.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClass))
            {
                MessageBox.Show("Please select a class first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadMockStudents(selectedClass);
            UpdateSummary();
        }

        private void LoadMockStudents(string className)
        {
            dgvAttendance.Rows.Clear();

            // Mock data generation based on class name to make it look dynamic
            int studentCount = 0;
            if (className.Contains("Physics")) studentCount = 15;
            else if (className.Contains("Chemistry")) studentCount = 12;
            else if (className.Contains("Math")) studentCount = 20;
            else studentCount = 10;

            for (int i = 1; i <= studentCount; i++)
            {
                string id = $"S{1000 + i}";
                string name = $"Student {((char)('A' + i - 1))}. Doe";
                // Default to Present (true)
                dgvAttendance.Rows.Add(id, name, true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int presentCount = 0;
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colStatus"].Value))
                {
                    presentCount++;
                }
            }

            string date = dtpDate.Value.ToShortDateString();
            string className = cmbClass.SelectedItem?.ToString() ?? "Unknown";

            MessageBox.Show($"Attendance Saved for {className} on {date}!\nPresent: {presentCount}/{dgvAttendance.Rows.Count}", 
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event to detect checkbox changes immediately to update summary
        private void DgvAttendance_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAttendance.IsCurrentCellDirty)
            {
                dgvAttendance.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DgvAttendance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
             if (e.ColumnIndex == dgvAttendance.Columns["colStatus"].Index && e.RowIndex >= 0)
            {
                UpdateSummary();
            }
        }

        private void UpdateSummary()
        {
            int total = dgvAttendance.Rows.Count;
            int present = 0;
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colStatus"].Value))
                {
                    present++;
                }
            }
            lblSummary.Text = $"Total Students: {total} | Present: {present} | Absent: {total - present}";
        }
    }
}
