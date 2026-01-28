using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace TeacherDashboard.Controls
{
    public partial class AssignmentManagementControl : UserControl
    {
        private class Assignment
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string Course { get; set; }
            public DateTime DueDate { get; set; }
            public string Status { get; set; }
        }

        private List<Assignment> assignments = new List<Assignment>();
        private int nextAssignmentId = 1;

        public AssignmentManagementControl()
        {
            InitializeComponent();
            InitializeComboBoxes();
            LoadAssignments();
            dgvAssignments.SelectionChanged += dgvAssignments_SelectionChanged; // Hook up selection changed event
        }

        private void InitializeComboBoxes()
        {
            // Dummy data for courses
            cmbCourse.Items.Add("Math 101");
            cmbCourse.Items.Add("Science 101");
            cmbCourse.Items.Add("English Literature");
            cmbCourse.SelectedIndex = 0;

            // Dummy data for status
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Graded");
            cmbStatus.Items.Add("Overdue");
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadAssignments()
        {
            // Clear existing dummy data and add programmatic dummy data
            assignments.Clear();
            assignments.Add(new Assignment { Id = "A" + (nextAssignmentId++).ToString("D3"), Title = "Math Homework 1", Course = "Math 101", DueDate = DateTime.Parse("2026-02-10"), Status = "Pending" });
            assignments.Add(new Assignment { Id = "A" + (nextAssignmentId++).ToString("D3"), Title = "Science Project", Course = "Science 101", DueDate = DateTime.Parse("2026-02-15"), Status = "Pending" });
            assignments.Add(new Assignment { Id = "A" + (nextAssignmentId++).ToString("D3"), Title = "English Essay", Course = "English Literature", DueDate = DateTime.Parse("2026-02-20"), Status = "Overdue" });
            RefreshAssignmentsGrid();
        }

        private void RefreshAssignmentsGrid()
        {
            dgvAssignments.Rows.Clear();
            foreach (var assignment in assignments.OrderBy(a => a.DueDate))
            {
                dgvAssignments.Rows.Add(assignment.Id, assignment.Title, assignment.Course, assignment.DueDate.ToShortDateString(), assignment.Status);
            }
        }

        private void ClearInputFields()
        {
            txtAssignmentTitle.Clear();
            cmbCourse.SelectedIndex = 0;
            dtpDueDate.Value = DateTime.Today;
            cmbStatus.SelectedIndex = 0;
        }

        private void dgvAssignments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAssignments.SelectedRows[0];
                string assignmentId = selectedRow.Cells[0].Value?.ToString();

                Assignment selectedAssignment = assignments.FirstOrDefault(a => a.Id == assignmentId);
                if (selectedAssignment != null)
                {
                    txtAssignmentTitle.Text = selectedAssignment.Title;
                    cmbCourse.SelectedItem = selectedAssignment.Course;
                    dtpDueDate.Value = selectedAssignment.DueDate;
                    cmbStatus.SelectedItem = selectedAssignment.Status;
                }
            }
            else
            {
                ClearInputFields();
            }
        }

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAssignmentTitle.Text))
            {
                MessageBox.Show("Please enter an assignment title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            assignments.Add(new Assignment
            {
                Id = "A" + (nextAssignmentId++).ToString("D3"),
                Title = txtAssignmentTitle.Text,
                Course = cmbCourse.SelectedItem.ToString(),
                DueDate = dtpDueDate.Value.Date,
                Status = cmbStatus.SelectedItem.ToString()
            });
            RefreshAssignmentsGrid();
            ClearInputFields();
        }

        private void btnEditAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAssignmentTitle.Text))
            {
                MessageBox.Show("Please enter an assignment title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dgvAssignments.SelectedRows[0];
            string assignmentId = selectedRow.Cells[0].Value?.ToString();

            Assignment assignmentToEdit = assignments.FirstOrDefault(a => a.Id == assignmentId);
            if (assignmentToEdit != null)
            {
                assignmentToEdit.Title = txtAssignmentTitle.Text;
                assignmentToEdit.Course = cmbCourse.SelectedItem.ToString();
                assignmentToEdit.DueDate = dtpDueDate.Value.Date;
                assignmentToEdit.Status = cmbStatus.SelectedItem.ToString();
                RefreshAssignmentsGrid();
                ClearInputFields();
            }
        }

        private void btnDeleteAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dgvAssignments.SelectedRows[0];
            string assignmentId = selectedRow.Cells[0].Value?.ToString();

            assignments.RemoveAll(a => a.Id == assignmentId);
            RefreshAssignmentsGrid();
            ClearInputFields();
        }

        public void UpdateTheme(System.Drawing.Color themeColor)
        {
            dgvAssignments.ColumnHeadersDefaultCellStyle.BackColor = themeColor;
            dgvAssignments.Invalidate(); // Redraw the DataGridView to apply the new style
        }
    }
}
