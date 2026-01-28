using System;
using System.Drawing;
using System.Windows.Forms;
using TeacherDashboard.Services;
using TeacherDashboard.Models;

namespace TeacherDashboard.Forms
{
    public partial class MainDashboardForm : Form
    {
        private Form activeForm = null;

        public MainDashboardForm()
        {
            InitializeComponent();
            ConfigureMenuBasedOnRole();
            UpdateUserInfo();
            
            // Search focus effects
            txtGlobalSearch.GotFocus += (s, e) => { if(txtGlobalSearch.Text.Contains("🔍")) txtGlobalSearch.Text = ""; txtGlobalSearch.ForeColor = Color.Black; };
            txtGlobalSearch.LostFocus += (s, e) => { if(string.IsNullOrWhiteSpace(txtGlobalSearch.Text)) { txtGlobalSearch.Text = "  🔍 Search for records..."; txtGlobalSearch.ForeColor = Color.Gray; } };

            // Open Home by default
            OpenChildForm(new HomeForm());
        }

        private void ConfigureMenuBasedOnRole()
        {
            bool isAdmin = SessionManager.IsAdmin;

            // SECTION: CONTROL & SETTINGS (Admin Only)
            lblSectionAdmin.Visible = isAdmin;
            btnAdminPanel.Visible = isAdmin;
            btnUserManagement.Visible = isAdmin;
            btnSystemSettings.Visible = isAdmin;
            btnHolidayCalendar.Visible = isAdmin;

            // SECTION: CHAPTERS (Hubs) - Visible to Teachers
            btnAcademicHub.Visible = !isAdmin;
            btnStudentHub.Visible = !isAdmin;
            btnCommHub.Visible = !isAdmin;
            btnResourceHub.Visible = !isAdmin;
            btnFacultyHub.Visible = !isAdmin;

            // Hide granular buttons from sidebar (They are moved to Hub Pages)
            btnTimetable.Visible = false;
            btnVac.Visible = false;
            btnSyllabus.Visible = false;
            btnLessonPlan.Visible = false;
            btnExams.Visible = false;
            btnQuizzes.Visible = false;
            btnAssignments.Visible = false;
            btnCourseManagement.Visible = false;
            btnGrading.Visible = false;
            btnAttendance.Visible = false;
            btnStudentDirectory.Visible = false;
            btnPerformance.Visible = false;
            btnNotices.Visible = false;
            btnTasks.Visible = false;
            btnResourceLibrary.Visible = false;
            btnReports.Visible = false;

            // SECTION: MAIN CORE
            lblSectionMain.Visible = true;
            btnHome.Visible = true;
            btnLeave.Visible = !isAdmin;
            btnSettings.Visible = true;

            lblTitle.Text = isAdmin ? "VSIT Admin Console" : "VSIT Teacher Dashboard";
            panelLogo.BackColor = Color.FromArgb(140, 18, 30); // Restore Original Red Logo Box
        }

        private void btnAcademicHub_Click(object sender, EventArgs e) => OpenChildForm(new AcademicHubForm());
        private void btnStudentHub_Click(object sender, EventArgs e) => OpenChildForm(new StudentHubForm());
        private void btnResourceHub_Click(object sender, EventArgs e) => OpenChildForm(new ResourceHubForm());
        private void btnFacultyHub_Click(object sender, EventArgs e) => OpenChildForm(new FacultySupportHubForm());


        private void UpdateUserInfo()
        {
            if (SessionManager.CurrentUser != null)
            {
                lblUserName.Text = SessionManager.CurrentUser.FullName;
                lblUserRole.Text = SessionManager.CurrentUser.Role.ToString();
            }
        }

        // Navigation methods for each feature
        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            OpenChildForm(homeForm);
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            TimetableForm timetableForm = new TimetableForm();
            OpenChildForm(timetableForm);
        }

        private void btnNotices_Click(object sender, EventArgs e)
        {
            NoticesForm noticesForm = new NoticesForm();
            OpenChildForm(noticesForm);
        }

        private void btnVac_Click(object sender, EventArgs e)
        {
            VacLecturesForm vacForm = new VacLecturesForm();
            OpenChildForm(vacForm);
        }

        private void btnCourseManagement_Click(object sender, EventArgs e)
        {
            CourseManagementForm courseForm = new CourseManagementForm();
            OpenChildForm(courseForm);
        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            AssignmentManagementForm assignmentForm = new AssignmentManagementForm();
            OpenChildForm(assignmentForm);
        }

        private void btnGrading_Click(object sender, EventArgs e)
        {
            GradingSystemForm gradingForm = new GradingSystemForm();
            OpenChildForm(gradingForm);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm attendanceForm = new AttendanceForm();
            OpenChildForm(attendanceForm);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            OpenChildForm(reportsForm);
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            StudentPerformanceForm performanceForm = new StudentPerformanceForm();
            OpenChildForm(performanceForm);
        }

        private void btnResourceLibrary_Click(object sender, EventArgs e)
        {
            ResourceLibraryForm resourceForm = new ResourceLibraryForm();
            OpenChildForm(resourceForm);
        }

        private void btnStudentDirectory_Click(object sender, EventArgs e)
        {
            StudentDirectoryForm studentForm = new StudentDirectoryForm();
            OpenChildForm(studentForm);
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm();
            OpenChildForm(tasksForm);
        }

        private void btnLessonPlan_Click(object sender, EventArgs e)
        {
            LessonPlanForm lessonPlanForm = new LessonPlanForm();
            OpenChildForm(lessonPlanForm);
        }

        private void btnSyllabus_Click(object sender, EventArgs e)
        {
            SyllabusTrackerForm syllabusForm = new SyllabusTrackerForm();
            OpenChildForm(syllabusForm);
        }

        private void btnHolidayCalendar_Click(object sender, EventArgs e)
        {
            HolidayCalendarForm holidayForm = new HolidayCalendarForm();
            OpenChildForm(holidayForm);
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            ExamManagementForm examForm = new ExamManagementForm();
            OpenChildForm(examForm);
        }

        private void btnCommHub_Click(object sender, EventArgs e)
        {
            CommunicationHubForm commForm = new CommunicationHubForm();
            OpenChildForm(commForm);
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            LeaveManagementForm leaveForm = new LeaveManagementForm();
            OpenChildForm(leaveForm);
        }

        private void btnQuizzes_Click(object sender, EventArgs e)
        {
            QuizBuilderForm quizForm = new QuizBuilderForm();
            OpenChildForm(quizForm);
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminForm = new AdminPanelForm();
            OpenChildForm(adminForm);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userMgmtForm = new UserManagementForm();
            OpenChildForm(userMgmtForm);
        }

        private void btnSystemSettings_Click(object sender, EventArgs e)
        {
            SystemSettingsForm settingsForm = new SystemSettingsForm();
            OpenChildForm(settingsForm);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            OpenChildForm(settingsForm);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidePanel.Visible = !sidePanel.Visible;
            if (sidePanel.Visible) sidePanel.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Always go back to Home in this phone-like simplified flow
            OpenChildForm(new HomeForm());
        }

        public void OpenChildForm(Form childForm)
        {
            // Close any existing form in the panel
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
            // Hide sidebar like a drawer closing
            sidePanel.Visible = false;

            // Show back button if not home
            bool isHome = childForm is HomeForm;
            btnBack.Visible = !isHome;

            // Update title to match current form
            lblTitle.Text = isHome ? "VSIT Dashboard" : "VSIT - " + childForm.Text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionManager.Logout();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
