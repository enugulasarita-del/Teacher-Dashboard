using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TeacherDashboard.Controls
{
    public partial class StudentManagementControl : UserControl
    {
        private class Student
        {
            public string StudentID { get; set; }
            public string StudentName { get; set; }
            public string StudentClass { get; set; }
        }

        private List<Student> students = new List<Student>();

        public StudentManagementControl()
        {
            InitializeComponent();
            LoadStudentData();
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
        }

        private void LoadStudentData()
        {
            students.Add(new Student { StudentID = "S001", StudentName = "Alice Smith", StudentClass = "10A" });
            students.Add(new Student { StudentID = "S002", StudentName = "Bob Johnson", StudentClass = "10B" });
            students.Add(new Student { StudentID = "S003", StudentName = "Charlie Brown", StudentClass = "11C" });
            RefreshStudentGrid();
        }

        private void RefreshStudentGrid()
        {
            dgvStudents.Rows.Clear();
            foreach (var student in students)
            {
                dgvStudents.Rows.Add(student.StudentID, student.StudentName, student.StudentClass);
            }
        }

        private void ClearInputFields()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtStudentClass.Clear();
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudents.SelectedRows[0];
                txtStudentID.Text = selectedRow.Cells[0].Value.ToString();
                txtStudentName.Text = selectedRow.Cells[1].Value.ToString();
                txtStudentClass.Text = selectedRow.Cells[2].Value.ToString();
            }
            else
            {
                ClearInputFields();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtStudentName.Text) || string.IsNullOrWhiteSpace(txtStudentClass.Text))
            {
                MessageBox.Show("Please fill in all student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (students.Exists(s => s.StudentID == txtStudentID.Text))
            {
                MessageBox.Show("Student with this ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            students.Add(new Student { StudentID = txtStudentID.Text, StudentName = txtStudentName.Text, StudentClass = txtStudentClass.Text });
            RefreshStudentGrid();
            ClearInputFields();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtStudentName.Text) || string.IsNullOrWhiteSpace(txtStudentClass.Text))
            {
                MessageBox.Show("Please fill in all student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string originalStudentID = dgvStudents.SelectedRows[0].Cells[0].Value.ToString();
            Student studentToEdit = students.Find(s => s.StudentID == originalStudentID);
            if (studentToEdit != null)
            {
                studentToEdit.StudentID = txtStudentID.Text;
                studentToEdit.StudentName = txtStudentName.Text;
                studentToEdit.StudentClass = txtStudentClass.Text;
                RefreshStudentGrid();
                ClearInputFields();
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentIDToDelete = dgvStudents.SelectedRows[0].Cells[0].Value.ToString();
            students.RemoveAll(s => s.StudentID == studentIDToDelete);
            RefreshStudentGrid();
            ClearInputFields();
        }
    }
}

