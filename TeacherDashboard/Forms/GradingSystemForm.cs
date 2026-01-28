using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class GradingSystemForm : Form
    {
        private class GradeEntry
        {
            public string Id { get; set; }
            public string RollNo { get; set; }
            public string StudentName { get; set; }
            public string Course { get; set; }
            public string Assignment { get; set; }
            public string Grade { get; set; }
        }

        private List<GradeEntry> grades = new List<GradeEntry>();
        private int nextGradeId = 1;

        public GradingSystemForm()
        {
            InitializeComponent();
            panelTop.Visible = false;
            btnClose.Visible = false;
            PopulateComboBoxes();
            LoadGradeData();
        }

        private void PopulateComboBoxes()
        {
            cmbStudent.Items.AddRange(new object[] { 
                "RN-2026001 | Alice Johnson", 
                "RN-2026002 | Bob Smith", 
                "RN-2026003 | Charlie Brown", 
                "RN-2026004 | Diana Prince" 
            });
            cmbCourse.Items.AddRange(new object[] { "Math 101", "Physics 202", "Chemistry 301", "English 102" });
            cmbAssignment.Items.AddRange(new object[] { "Mid Term Exam", "Final Exam", "Homework 1", "Project A" });

            if(cmbStudent.Items.Count > 0) cmbStudent.SelectedIndex = 0;
            if(cmbCourse.Items.Count > 0) cmbCourse.SelectedIndex = 0;
            if(cmbAssignment.Items.Count > 0) cmbAssignment.SelectedIndex = 0;
        }

        private void LoadGradeData()
        {
            grades.Add(new GradeEntry { Id = "G" + (nextGradeId++).ToString("D3"), RollNo = "RN-2026001", StudentName = "Alice Johnson", Course = "Math 101", Assignment = "Mid Term Exam", Grade = "85" });
            grades.Add(new GradeEntry { Id = "G" + (nextGradeId++).ToString("D3"), RollNo = "RN-2026002", StudentName = "Bob Smith", Course = "Physics 202", Assignment = "Project A", Grade = "92" });
            grades.Add(new GradeEntry { Id = "G" + (nextGradeId++).ToString("D3"), RollNo = "RN-2026003", StudentName = "Charlie Brown", Course = "Math 101", Assignment = "Homework 1", Grade = "90" });
            RefreshGradesGrid();
        }

        private void RefreshGradesGrid()
        {
            dgvGrades.Rows.Clear();
            foreach (var gradeEntry in grades.OrderBy(g => g.StudentName).ThenBy(g => g.Course).ThenBy(g => g.Assignment))
            {
                dgvGrades.Rows.Add(gradeEntry.Id, gradeEntry.RollNo, gradeEntry.StudentName, gradeEntry.Course, gradeEntry.Assignment, gradeEntry.Grade);
            }
        }

        private void ClearInputFields()
        {
            if (cmbStudent.Items.Count > 0) cmbStudent.SelectedIndex = 0;
            if (cmbCourse.Items.Count > 0) cmbCourse.SelectedIndex = 0;
            if (cmbAssignment.Items.Count > 0) cmbAssignment.SelectedIndex = 0;
            txtGrade.Clear();
        }

        private void dgvGrades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvGrades.SelectedRows[0];
                string gradeId = selectedRow.Cells[0].Value?.ToString();

                GradeEntry selectedGrade = grades.FirstOrDefault(g => g.Id == gradeId);
                if (selectedGrade != null)
                {
                    cmbStudent.SelectedItem = selectedGrade.StudentName;
                    cmbCourse.SelectedItem = selectedGrade.Course;
                    cmbAssignment.SelectedItem = selectedGrade.Assignment;
                    txtGrade.Text = selectedGrade.Grade;
                }
            }
            else
            {
                ClearInputFields();
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Please enter a grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fullSelection = cmbStudent.SelectedItem?.ToString() ?? " | ";
            string[] parts = fullSelection.Split('|');
            string rollNo = parts[0].Trim();
            string studentName = parts.Length > 1 ? parts[1].Trim() : "";

            grades.Add(new GradeEntry
            {
                Id = "G" + (nextGradeId++).ToString("D3"),
                RollNo = rollNo,
                StudentName = studentName,
                Course = cmbCourse.SelectedItem?.ToString() ?? "",
                Assignment = cmbAssignment.SelectedItem?.ToString() ?? "",
                Grade = txtGrade.Text
            });
            RefreshGradesGrid();
            ClearInputFields();
        }

        private void btnEditGrade_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a grade entry to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Please enter a grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dgvGrades.SelectedRows[0];
            string gradeId = selectedRow.Cells[0].Value?.ToString();

            GradeEntry gradeToEdit = grades.FirstOrDefault(g => g.Id == gradeId);
            if (gradeToEdit != null)
            {
                string fullSelection = cmbStudent.SelectedItem?.ToString() ?? " | ";
                string[] parts = fullSelection.Split('|');
                
                gradeToEdit.RollNo = parts[0].Trim();
                gradeToEdit.StudentName = parts.Length > 1 ? parts[1].Trim() : "";
                gradeToEdit.Course = cmbCourse.SelectedItem?.ToString() ?? "";
                gradeToEdit.Assignment = cmbAssignment.SelectedItem?.ToString() ?? "";
                gradeToEdit.Grade = txtGrade.Text;
                RefreshGradesGrid();
                ClearInputFields();
            }
        }

        private void btnDeleteGrade_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a grade entry to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Delete this grade record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dgvGrades.SelectedRows[0];
                string gradeId = selectedRow.Cells[0].Value?.ToString();

                grades.RemoveAll(g => g.Id == gradeId);
                RefreshGradesGrid();
                ClearInputFields();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
