using System;
using System.Drawing;
using System.Windows.Forms;
using TeacherDashboard.Controls;

namespace TeacherDashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            ShowControl(new HomeControl()); // Default view
            lblTitle.Text = "Home";
            sidePanel.Visible = true; // Ensure side panel is visible by default
        }

        private void ShowControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowControl(new HomeControl());
            lblTitle.Text = "Home";
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            ShowControl(new TimetableControl());
            lblTitle.Text = "Daily/Weekly Timetable";
        }

        private void btnNotices_Click(object sender, EventArgs e)
        {
            ShowControl(new NoticesControl());
            lblTitle.Text = "Exam Notices & Competitions";
        }

        private void btnVac_Click(object sender, EventArgs e)
        {
            ShowControl(new VacLecturesControl());
            lblTitle.Text = "VAC Lectures";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsControl settingsControl = new SettingsControl();
            ShowControl(settingsControl);
            lblTitle.Text = "Settings";
        }

        private void SettingsControl_ThemeColorSelected(object sender, Color selectedColor)
        {
            // ApplyThemeColor(selectedColor);
        }

        private void ApplyThemeColor(Color color)
        {
            // Apply the selected color to the side panel
            sidePanel.BackColor = color;

            // Optionally, apply a slightly darker shade to the logo panel for contrast
            int r = Math.Max(0, color.R - 33);
            int g = Math.Max(0, color.G - 33);
            int b = Math.Max(0, color.B - 33);
            panelLogo.BackColor = Color.FromArgb(r, g, b);

            // Update the foreground color of the title label in topPanel
            lblTitle.ForeColor = color;

            // Update button forecolors to match the new theme in topPanel
            btnMenu.ForeColor = color;
            btnClose.ForeColor = color;

            // You might need to update other elements that use the theme color
            // You might need to update other elements that use the theme color
            // For example, DataGridView headers if they exist and are using the theme color.
            foreach (Control control in mainPanel.Controls)
            {
                if (control is CourseManagementControl courseControl)
                {
                    courseControl.UpdateTheme(color);
                }
                else if (control is AssignmentManagementControl assignmentControl)
                {
                    assignmentControl.UpdateTheme(color);
                }
                else if (control is GradingSystemControl gradingControl)
                {
                    gradingControl.UpdateTheme(color);
                }
                else if (control is TimetableControl timetableControl)
                {
                    timetableControl.UpdateTheme(color);
                }
                else if (control is NoticesControl noticesControl)
                {
                    noticesControl.UpdateTheme(color);
                }
                else if (control is ReportsControl reportsControl)
                {
                    reportsControl.UpdateTheme(color);
                }
                else if (control is StudentPerformanceControl performanceControl)
                {
                    performanceControl.UpdateTheme(color);
                }
                else if (control is ResourceLibraryControl resourceControl)
                {
                    resourceControl.UpdateTheme(color);
                }
                else if (control is StudentDirectoryControl studentControl)
                {
                    studentControl.UpdateTheme(color);
                }
                else if (control is TasksControl tasksControl)
                {
                    tasksControl.UpdateTheme(color);
                }
            }
        }

        private void btnCourseManagement_Click(object sender, EventArgs e)
        {
            ShowControl(new CourseManagementControl());
            lblTitle.Text = "Course Management";
        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            ShowControl(new AssignmentManagementControl());
            lblTitle.Text = "Assignment Management";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidePanel.Visible = !sidePanel.Visible;
        }

        private void btnGrading_Click(object sender, EventArgs e)
        {
            ShowControl(new GradingSystemControl());
            lblTitle.Text = "Grading System";
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            ShowControl(new AttendanceControl());
            lblTitle.Text = "Daily Attendance";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowControl(new ReportsControl());
            lblTitle.Text = "Reports & Analytics";
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            ShowControl(new StudentPerformanceControl());
            lblTitle.Text = "Student Performance";
        }

        private void btnResourceLibrary_Click(object sender, EventArgs e)
        {
            ShowControl(new ResourceLibraryControl());
            lblTitle.Text = "Resource Library";
        }

        private void btnStudentDirectory_Click(object sender, EventArgs e)
        {
            ShowControl(new StudentDirectoryControl());
            lblTitle.Text = "Student Directory";
        }



        private void btnTasks_Click(object sender, EventArgs e)
        {
            ShowControl(new TasksControl());
            lblTitle.Text = "My Tasks";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
