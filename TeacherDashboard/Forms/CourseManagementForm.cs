using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class CourseManagementForm : Form
    {
        private class Course
        {
            public string CourseID { get; set; }
            public string CourseName { get; set; }
            public string CourseDepartment { get; set; }
            public string Credits { get; set; }
            public string Instructor { get; set; }
        }

        private List<Course> courses = new List<Course>();

        public CourseManagementForm()
        {
            InitializeComponent();
            LoadCourseData();
        }

        private void LoadCourseData()
        {
            courses.Add(new Course { CourseID = "C101", CourseName = "Introduction to Programming", CourseDepartment = "Computer Science", Credits = "4", Instructor = "Dr. Smith" });
            courses.Add(new Course { CourseID = "C102", CourseName = "Calculus I", CourseDepartment = "Mathematics", Credits = "3", Instructor = "Prof. Johnson" });
            courses.Add(new Course { CourseID = "C103", CourseName = "English Literature", CourseDepartment = "Humanities", Credits = "2", Instructor = "Mrs. Davis" });
            courses.Add(new Course { CourseID = "C104", CourseName = "Physics I", CourseDepartment = "Science", Credits = "4", Instructor = "Dr. Brown" });
            RefreshCourseGrid();
        }

        private void RefreshCourseGrid()
        {
            dgvCourses.Rows.Clear();
            string searchText = txtSearch.Text.ToLower();

            var filteredCourses = courses.Where(c => 
                c.CourseName.ToLower().Contains(searchText) || 
                c.CourseID.ToLower().Contains(searchText) ||
                c.CourseDepartment.ToLower().Contains(searchText) ||
                c.Instructor.ToLower().Contains(searchText)).ToList();

            foreach (var course in filteredCourses)
            {
                dgvCourses.Rows.Add(course.CourseID, course.CourseName, course.CourseDepartment, course.Credits, course.Instructor);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshCourseGrid();
        }

        private void ClearInputFields()
        {
            txtCourseID.Clear();
            txtCourseName.Clear();
            txtDepartment.Clear();
            txtCredits.Clear();
            txtInstructor.Clear();
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCourses.SelectedRows[0];
                txtCourseID.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
                txtCourseName.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                txtDepartment.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                txtCredits.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                txtInstructor.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
            }
            else
            {
                ClearInputFields();
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseID.Text) || string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please fill in at least Course ID and Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (courses.Exists(c => c.CourseID == txtCourseID.Text))
            {
                MessageBox.Show("Course with this ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            courses.Add(new Course { 
                CourseID = txtCourseID.Text, 
                CourseName = txtCourseName.Text, 
                CourseDepartment = txtDepartment.Text,
                Credits = txtCredits.Text,
                Instructor = txtInstructor.Text
            });
            RefreshCourseGrid();
            ClearInputFields();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string originalCourseID = dgvCourses.SelectedRows[0].Cells[0].Value.ToString();
            Course courseToEdit = courses.Find(c => c.CourseID == originalCourseID);

            if (courseToEdit != null)
            {
                courseToEdit.CourseID = txtCourseID.Text;
                courseToEdit.CourseName = txtCourseName.Text;
                courseToEdit.CourseDepartment = txtDepartment.Text;
                courseToEdit.Credits = txtCredits.Text;
                courseToEdit.Instructor = txtInstructor.Text;

                RefreshCourseGrid();
                ClearInputFields();
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string courseIDToDelete = dgvCourses.SelectedRows[0].Cells[0].Value.ToString();
                courses.RemoveAll(c => c.CourseID == courseIDToDelete);
                RefreshCourseGrid();
                ClearInputFields();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
