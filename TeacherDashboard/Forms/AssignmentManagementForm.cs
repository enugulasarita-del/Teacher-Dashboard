using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class AssignmentManagementForm : Form
    {
        private class Assignment
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string Course { get; set; }
            public DateTime DueDate { get; set; }
            public string Description { get; set; }
        }

        private List<Assignment> assignments = new List<Assignment>();
        private int nextId = 1;

        public AssignmentManagementForm()
        {
            InitializeComponent();
            panelTop.Visible = false;
            btnClose.Visible = false;
            PopulateCourses();
            LoadAssignments();
        }

        private void PopulateCourses()
        {
            cmbCourse.Items.AddRange(new object[] { "Math 101", "Physics 202", "Chemistry 301", "English 102" });
            if (cmbCourse.Items.Count > 0) cmbCourse.SelectedIndex = 0;
        }

        private void LoadAssignments()
        {
            assignments.Add(new Assignment { Id = "A001", Title = "Mid Term Exam", Course = "Math 101", DueDate = DateTime.Now.AddDays(5), Description = "Algebra and Calculus" });
            assignments.Add(new Assignment { Id = "A002", Title = "Lab Report 1", Course = "Physics 202", DueDate = DateTime.Now.AddDays(2), Description = "Kinematics Experiment" });
            assignments.Add(new Assignment { Id = "A003", Title = "Essay Draft", Course = "English 102", DueDate = DateTime.Now.AddDays(7), Description = "Shakespearean Analysis" });
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvAssignments.Rows.Clear();
            foreach (var a in assignments.OrderBy(x => x.DueDate))
            {
                dgvAssignments.Rows.Add(a.Id, a.Title, a.Course, a.DueDate.ToShortDateString(), a.Description);
            }
        }

        private void ClearInputFields()
        {
            txtTitle.Clear();
            if (cmbCourse.Items.Count > 0) cmbCourse.SelectedIndex = 0;
            dtpDueDate.Value = DateTime.Now;
            txtDescription.Clear();
        }

        private void dgvAssignments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAssignments.SelectedRows[0];
                string id = row.Cells[0].Value?.ToString();
                var a = assignments.FirstOrDefault(x => x.Id == id);
                if (a != null)
                {
                    txtTitle.Text = a.Title;
                    cmbCourse.SelectedItem = a.Course;
                    dtpDueDate.Value = a.DueDate;
                    txtDescription.Text = a.Description;
                }
            }
            else
            {
                ClearInputFields();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            assignments.Add(new Assignment
            {
                Id = "A" + (nextId++).ToString("D3"),
                Title = txtTitle.Text,
                Course = cmbCourse.SelectedItem?.ToString() ?? "",
                DueDate = dtpDueDate.Value,
                Description = txtDescription.Text
            });
            RefreshGrid();
            ClearInputFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an assignment to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = dgvAssignments.SelectedRows[0].Cells[0].Value?.ToString();
            var a = assignments.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                a.Title = txtTitle.Text;
                a.Course = cmbCourse.SelectedItem?.ToString() ?? "";
                a.DueDate = dtpDueDate.Value;
                a.Description = txtDescription.Text;
                RefreshGrid();
                ClearInputFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an assignment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = dgvAssignments.SelectedRows[0].Cells[0].Value?.ToString();
            assignments.RemoveAll(x => x.Id == id);
            RefreshGrid();
            ClearInputFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
