using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace TeacherDashboard.Controls
{
    public partial class GradingSystemControl : UserControl
    {
        private class GradeEntry
        {
            public string Id { get; set; }
            public string StudentName { get; set; }
            public string Course { get; set; }
            public string Assignment { get; set; }
            public string Grade { get; set; }
        }

        private List<GradeEntry> grades = new List<GradeEntry>();
        private int nextGradeId = 1;

        public GradingSystemControl()
        {
            InitializeComponent();
            InitializeComboBoxes();
            LoadGrades();
            dgvGrades.SelectionChanged += dgvGrades_SelectionChanged; // Hook up selection changed event
        }

        private void InitializeComboBoxes()
        {
            // Dummy data for students
            cmbStudent.Items.Add("Alice Smith");
            cmbStudent.Items.Add("Bob Johnson");
            cmbStudent.Items.Add("Charlie Brown");
            cmbStudent.SelectedIndex = 0;

            // Dummy data for courses
            cmbCourse.Items.Add("Math 101");
            cmbCourse.Items.Add("Science 101");
            cmbCourse.Items.Add("English Literature");
            cmbCourse.SelectedIndex = 0;

            // Dummy data for assignments (these would ideally be loaded dynamically based on selected course)
            cmbAssignment.Items.Add("Math Homework 1");
            cmbAssignment.Items.Add("Science Project");
            cmbAssignment.Items.Add("English Essay");
            cmbAssignment.SelectedIndex = 0;
        }

        private void LoadGrades()
        {
            // Clear existing dummy data and add programmatic dummy data
            grades.Clear();
            grades.Add(new GradeEntry { Id = "G" + (nextGradeId++).ToString("D3"), StudentName = "Alice Smith", Course = "Math 101", Assignment = "Math Homework 1", Grade = "95" });
            grades.Add(new GradeEntry { Id = "G" + (nextGradeId++).ToString("D3"), StudentName = "Bob Johnson", Course = "Science 101", Assignment = "Science Project", Grade = "88" });
            grades.Add(new GradeEntry { Id = "G" + (nextGradeId++).ToString("D3"), StudentName = "Alice Smith", Course = "English Literature", Assignment = "English Essay", Grade = "72" });
            grades.Add(new GradeEntry { Id = "G" + (nextGradeId++).ToString("D3"), StudentName = "Charlie Brown", Course = "Math 101", Assignment = "Math Homework 1", Grade = "90" });
            RefreshGradesGrid();
        }

        private void RefreshGradesGrid()
        {
            dgvGrades.Rows.Clear();
            foreach (var gradeEntry in grades.OrderBy(g => g.StudentName).ThenBy(g => g.Course).ThenBy(g => g.Assignment))
            {
                dgvGrades.Rows.Add(gradeEntry.Id, gradeEntry.StudentName, gradeEntry.Course, gradeEntry.Assignment, gradeEntry.Grade);
            }
        }

        private void ClearInputFields()
        {
            cmbStudent.SelectedIndex = 0;
            cmbCourse.SelectedIndex = 0;
            cmbAssignment.SelectedIndex = 0;
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

            grades.Add(new GradeEntry
            {
                Id = "G" + (nextGradeId++).ToString("D3"),
                StudentName = cmbStudent.SelectedItem.ToString(),
                Course = cmbCourse.SelectedItem.ToString(),
                Assignment = cmbAssignment.SelectedItem.ToString(),
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
                gradeToEdit.StudentName = cmbStudent.SelectedItem.ToString();
                gradeToEdit.Course = cmbCourse.SelectedItem.ToString();
                gradeToEdit.Assignment = cmbAssignment.SelectedItem.ToString();
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

            DataGridViewRow selectedRow = dgvGrades.SelectedRows[0];
            string gradeId = selectedRow.Cells[0].Value?.ToString();

            grades.RemoveAll(g => g.Id == gradeId);
            RefreshGradesGrid();
            ClearInputFields();
        }

        public void UpdateTheme(Color themeColor)
        {
            dgvGrades.ColumnHeadersDefaultCellStyle.BackColor = themeColor;
            dgvGrades.Invalidate(); // Redraw the DataGridView to apply the new style
        }
    }
}
