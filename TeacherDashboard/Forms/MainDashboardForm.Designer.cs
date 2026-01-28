namespace TeacherDashboard.Forms
{
    partial class MainDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSystemSettings = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnLessonPlan = new System.Windows.Forms.Button();
            this.btnSyllabus = new System.Windows.Forms.Button();
            this.btnHolidayCalendar = new System.Windows.Forms.Button();
            this.btnStudentDirectory = new System.Windows.Forms.Button();
            this.btnResourceLibrary = new System.Windows.Forms.Button();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnGrading = new System.Windows.Forms.Button();
            this.btnAssignments = new System.Windows.Forms.Button();
            this.btnCourseManagement = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnVac = new System.Windows.Forms.Button();
            this.btnNotices = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnCommHub = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnQuizzes = new System.Windows.Forms.Button();
            this.btnAcademicHub = new System.Windows.Forms.Button();
            this.btnStudentHub = new System.Windows.Forms.Button();
            this.btnCommHub = new System.Windows.Forms.Button();
            this.btnResourceHub = new System.Windows.Forms.Button();
            this.btnFacultyHub = new System.Windows.Forms.Button();
            this.btnAssistant = new System.Windows.Forms.Button();
            this.lblSectionMain = new System.Windows.Forms.Label();
            this.lblSectionAcademic = new System.Windows.Forms.Label();
            this.lblSectionStudents = new System.Windows.Forms.Label();
            this.lblSectionComm = new System.Windows.Forms.Label();
            this.lblSectionResources = new System.Windows.Forms.Label();
            this.lblSectionAdmin = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtGlobalSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Controls.Add(this.btnSettings);
            this.sidePanel.Controls.Add(this.btnSystemSettings);
            this.sidePanel.Controls.Add(this.btnUserManagement);
            this.sidePanel.Controls.Add(this.btnAdminPanel);
            this.sidePanel.Controls.Add(this.lblSectionAdmin);
            this.sidePanel.Controls.Add(this.btnHolidayCalendar);
            this.sidePanel.Controls.Add(this.btnFacultyHub);
            this.sidePanel.Controls.Add(this.btnResourceHub);
            this.sidePanel.Controls.Add(this.btnCommHub);
            this.sidePanel.Controls.Add(this.btnStudentHub);
            this.sidePanel.Controls.Add(this.btnAcademicHub);
            this.sidePanel.Controls.Add(this.btnLeave);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.lblSectionMain);
            this.sidePanel.Controls.Add(this.panelLogo);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(240, 750);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.Visible = false; // Hidden by default like a phone drawer
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 1340);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(223, 60);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblSectionMain
            // 
            this.lblSectionMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSectionMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSectionMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSectionMain.Location = new System.Drawing.Point(0, 0);
            this.lblSectionMain.Name = "lblSectionMain";
            this.lblSectionMain.Padding = new System.Windows.Forms.Padding(12, 10, 0, 5);
            this.lblSectionMain.Size = new System.Drawing.Size(223, 35);
            this.lblSectionMain.Text = "MAIN CORE";
            // 
            // lblSectionAcademic
            // 
            this.lblSectionAcademic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSectionAcademic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSectionAcademic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSectionAcademic.Location = new System.Drawing.Point(0, 0);
            this.lblSectionAcademic.Name = "lblSectionAcademic";
            this.lblSectionAcademic.Padding = new System.Windows.Forms.Padding(12, 20, 0, 5);
            this.lblSectionAcademic.Size = new System.Drawing.Size(223, 45);
            this.lblSectionAcademic.Text = "ACADEMIC MANAGEMENT";
            // 
            // lblSectionStudents
            // 
            this.lblSectionStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSectionStudents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSectionStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSectionStudents.Location = new System.Drawing.Point(0, 0);
            this.lblSectionStudents.Name = "lblSectionStudents";
            this.lblSectionStudents.Padding = new System.Windows.Forms.Padding(12, 20, 0, 5);
            this.lblSectionStudents.Size = new System.Drawing.Size(223, 45);
            this.lblSectionStudents.Text = "STUDENT LOGS";
            // 
            // lblSectionComm
            // 
            this.lblSectionComm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSectionComm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSectionComm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSectionComm.Location = new System.Drawing.Point(0, 0);
            this.lblSectionComm.Name = "lblSectionComm";
            this.lblSectionComm.Padding = new System.Windows.Forms.Padding(12, 20, 0, 5);
            this.lblSectionComm.Size = new System.Drawing.Size(223, 45);
            this.lblSectionComm.Text = "COMMUNICATION";
            // 
            // lblSectionResources
            // 
            this.lblSectionResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSectionResources.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSectionResources.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSectionResources.Location = new System.Drawing.Point(0, 0);
            this.lblSectionResources.Name = "lblSectionResources";
            this.lblSectionResources.Padding = new System.Windows.Forms.Padding(12, 20, 0, 5);
            this.lblSectionResources.Size = new System.Drawing.Size(223, 45);
            this.lblSectionResources.Text = "RESOURCES & DATA";
            // 
            // lblSectionAdmin
            // 
            this.lblSectionAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSectionAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSectionAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSectionAdmin.Location = new System.Drawing.Point(0, 0);
            this.lblSectionAdmin.Name = "lblSectionAdmin";
            this.lblSectionAdmin.Padding = new System.Windows.Forms.Padding(12, 20, 0, 5);
            this.lblSectionAdmin.Size = new System.Drawing.Size(223, 45);
            this.lblSectionAdmin.Text = "CONTROL & SETTINGS";
            // 
            // btnSystemSettings
            // 
            this.btnSystemSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemSettings.FlatAppearance.BorderSize = 0;
            this.btnSystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemSettings.ForeColor = System.Drawing.Color.White;
            this.btnSystemSettings.Location = new System.Drawing.Point(0, 1280);
            this.btnSystemSettings.Name = "btnSystemSettings";
            this.btnSystemSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSystemSettings.Size = new System.Drawing.Size(223, 60);
            this.btnSystemSettings.TabIndex = 17;
            this.btnSystemSettings.Text = "⚙️ System Settings";
            this.btnSystemSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemSettings.UseVisualStyleBackColor = true;
            this.btnSystemSettings.Click += new System.EventHandler(this.btnSystemSettings_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 1220);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUserManagement.Size = new System.Drawing.Size(223, 60);
            this.btnUserManagement.TabIndex = 16;
            this.btnUserManagement.Text = "👥 User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPanel.ForeColor = System.Drawing.Color.Yellow;
            this.btnAdminPanel.Location = new System.Drawing.Point(0, 1160);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAdminPanel.Size = new System.Drawing.Size(223, 60);
            this.btnAdminPanel.TabIndex = 15;
            this.btnAdminPanel.Text = "🔐 Admin Panel";
            this.btnAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.Location = new System.Drawing.Point(0, 1100);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTasks.Size = new System.Drawing.Size(223, 60);
            this.btnTasks.TabIndex = 14;
            this.btnTasks.Text = "📋 My Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnLessonPlan
            // 
            this.btnLessonPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLessonPlan.FlatAppearance.BorderSize = 0;
            this.btnLessonPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLessonPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessonPlan.ForeColor = System.Drawing.Color.White;
            this.btnLessonPlan.Location = new System.Drawing.Point(0, 1130);
            this.btnLessonPlan.Name = "btnLessonPlan";
            this.btnLessonPlan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLessonPlan.Size = new System.Drawing.Size(223, 60);
            this.btnLessonPlan.TabIndex = 21;
            this.btnLessonPlan.Text = "✍️ Lesson Plan";
            this.btnLessonPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLessonPlan.UseVisualStyleBackColor = true;
            this.btnLessonPlan.Click += new System.EventHandler(this.btnLessonPlan_Click);
            // 
            // btnSyllabus
            // 
            this.btnSyllabus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSyllabus.FlatAppearance.BorderSize = 0;
            this.btnSyllabus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyllabus.ForeColor = System.Drawing.Color.White;
            this.btnSyllabus.Location = new System.Drawing.Point(0, 1160);
            this.btnSyllabus.Name = "btnSyllabus";
            this.btnSyllabus.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSyllabus.Size = new System.Drawing.Size(223, 60);
            this.btnSyllabus.TabIndex = 19;
            this.btnSyllabus.Text = "📖 Syllabus Tracker";
            this.btnSyllabus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSyllabus.UseVisualStyleBackColor = true;
            this.btnSyllabus.Click += new System.EventHandler(this.btnSyllabus_Click);
            // 
            // btnHolidayCalendar
            // 
            this.btnHolidayCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHolidayCalendar.FlatAppearance.BorderSize = 0;
            this.btnHolidayCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHolidayCalendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHolidayCalendar.ForeColor = System.Drawing.Color.White;
            this.btnHolidayCalendar.Location = new System.Drawing.Point(0, 1220);
            this.btnHolidayCalendar.Name = "btnHolidayCalendar";
            this.btnHolidayCalendar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHolidayCalendar.Size = new System.Drawing.Size(223, 60);
            this.btnHolidayCalendar.TabIndex = 20;
            this.btnHolidayCalendar.Text = "📅 Holiday Calendar";
            this.btnHolidayCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHolidayCalendar.UseVisualStyleBackColor = true;
            this.btnHolidayCalendar.Click += new System.EventHandler(this.btnHolidayCalendar_Click);
            // 
            // btnStudentDirectory
            // 
            this.btnStudentDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentDirectory.FlatAppearance.BorderSize = 0;
            this.btnStudentDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentDirectory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentDirectory.ForeColor = System.Drawing.Color.White;
            this.btnStudentDirectory.Location = new System.Drawing.Point(0, 1040);
            this.btnStudentDirectory.Name = "btnStudentDirectory";
            this.btnStudentDirectory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStudentDirectory.Size = new System.Drawing.Size(223, 60);
            this.btnStudentDirectory.TabIndex = 13;
            this.btnStudentDirectory.Text = "📖 Student Directory";
            this.btnStudentDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentDirectory.UseVisualStyleBackColor = true;
            this.btnStudentDirectory.Click += new System.EventHandler(this.btnStudentDirectory_Click);
            // 
            // btnResourceLibrary
            // 
            this.btnResourceLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResourceLibrary.FlatAppearance.BorderSize = 0;
            this.btnResourceLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourceLibrary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResourceLibrary.ForeColor = System.Drawing.Color.White;
            this.btnResourceLibrary.Location = new System.Drawing.Point(0, 980);
            this.btnResourceLibrary.Name = "btnResourceLibrary";
            this.btnResourceLibrary.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnResourceLibrary.Size = new System.Drawing.Size(223, 60);
            this.btnResourceLibrary.TabIndex = 12;
            this.btnResourceLibrary.Text = "📚 Resource Library";
            this.btnResourceLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResourceLibrary.UseVisualStyleBackColor = true;
            this.btnResourceLibrary.Click += new System.EventHandler(this.btnResourceLibrary_Click);
            // 
            // btnPerformance
            // 
            this.btnPerformance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerformance.FlatAppearance.BorderSize = 0;
            this.btnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformance.ForeColor = System.Drawing.Color.White;
            this.btnPerformance.Location = new System.Drawing.Point(0, 920);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPerformance.Size = new System.Drawing.Size(223, 60);
            this.btnPerformance.TabIndex = 11;
            this.btnPerformance.Text = "📊 Student Performance";
            this.btnPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformance.UseVisualStyleBackColor = true;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 860);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(223, 60);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "📈 Reports \u0026 Analytics";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(0, 800);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAttendance.Size = new System.Drawing.Size(223, 60);
            this.btnAttendance.TabIndex = 9;
            this.btnAttendance.Text = "✅ Daily Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnGrading
            // 
            this.btnGrading.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrading.FlatAppearance.BorderSize = 0;
            this.btnGrading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrading.ForeColor = System.Drawing.Color.White;
            this.btnGrading.Location = new System.Drawing.Point(0, 740);
            this.btnGrading.Name = "btnGrading";
            this.btnGrading.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGrading.Size = new System.Drawing.Size(223, 60);
            this.btnGrading.TabIndex = 8;
            this.btnGrading.Text = "🎓 Grading System";
            this.btnGrading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrading.UseVisualStyleBackColor = true;
            this.btnGrading.Click += new System.EventHandler(this.btnGrading_Click);
            // 
            // btnAssignments
            // 
            this.btnAssignments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignments.FlatAppearance.BorderSize = 0;
            this.btnAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignments.ForeColor = System.Drawing.Color.White;
            this.btnAssignments.Location = new System.Drawing.Point(0, 680);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAssignments.Size = new System.Drawing.Size(223, 60);
            this.btnAssignments.TabIndex = 7;
            this.btnAssignments.Text = "📝 Assignment Management";
            this.btnAssignments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignments.UseVisualStyleBackColor = true;
            this.btnAssignments.Click += new System.EventHandler(this.btnAssignments_Click);
            // 
            // btnCourseManagement
            // 
            this.btnCourseManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourseManagement.FlatAppearance.BorderSize = 0;
            this.btnCourseManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseManagement.ForeColor = System.Drawing.Color.White;
            this.btnCourseManagement.Location = new System.Drawing.Point(0, 620);
            this.btnCourseManagement.Name = "btnCourseManagement";
            this.btnCourseManagement.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCourseManagement.Size = new System.Drawing.Size(223, 60);
            this.btnCourseManagement.TabIndex = 6;
            this.btnCourseManagement.Text = "📚 Course Management";
            this.btnCourseManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourseManagement.UseVisualStyleBackColor = true;
            this.btnCourseManagement.Click += new System.EventHandler(this.btnCourseManagement_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 560);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(223, 60);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "⚙️ Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAcademicHub
            // 
            this.btnAcademicHub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcademicHub.FlatAppearance.BorderSize = 0;
            this.btnAcademicHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcademicHub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAcademicHub.ForeColor = System.Drawing.Color.White;
            this.btnAcademicHub.Location = new System.Drawing.Point(0, 380);
            this.btnAcademicHub.Name = "btnAcademicHub";
            this.btnAcademicHub.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAcademicHub.Size = new System.Drawing.Size(223, 60);
            this.btnAcademicHub.TabIndex = 22;
            this.btnAcademicHub.Text = "📖 Academic Center";
            this.btnAcademicHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcademicHub.UseVisualStyleBackColor = true;
            this.btnAcademicHub.Click += new System.EventHandler(this.btnAcademicHub_Click);
            // 
            // btnStudentHub
            // 
            this.btnStudentHub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentHub.FlatAppearance.BorderSize = 0;
            this.btnStudentHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentHub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStudentHub.ForeColor = System.Drawing.Color.White;
            this.btnStudentHub.Location = new System.Drawing.Point(0, 440);
            this.btnStudentHub.Name = "btnStudentHub";
            this.btnStudentHub.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStudentHub.Size = new System.Drawing.Size(223, 60);
            this.btnStudentHub.TabIndex = 23;
            this.btnStudentHub.Text = "👥 Student Records";
            this.btnStudentHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentHub.UseVisualStyleBackColor = true;
            this.btnStudentHub.Click += new System.EventHandler(this.btnStudentHub_Click);
            // 
            this.btnResourceHub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResourceHub.FlatAppearance.BorderSize = 0;
            this.btnResourceHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourceHub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnResourceHub.ForeColor = System.Drawing.Color.White;
            this.btnResourceHub.Location = new System.Drawing.Point(0, 500);
            this.btnResourceHub.Name = "btnResourceHub";
            this.btnResourceHub.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnResourceHub.Size = new System.Drawing.Size(223, 60);
            this.btnResourceHub.TabIndex = 24;
            this.btnResourceHub.Text = "📁 Resource Hub";
            this.btnResourceHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResourceHub.UseVisualStyleBackColor = true;
            this.btnResourceHub.Click += new System.EventHandler(this.btnResourceHub_Click);
            // 
            // btnCommHub
            // 
            this.btnCommHub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCommHub.FlatAppearance.BorderSize = 0;
            this.btnCommHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommHub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCommHub.ForeColor = System.Drawing.Color.White;
            this.btnCommHub.Location = new System.Drawing.Point(0, 560);
            this.btnCommHub.Name = "btnCommHub";
            this.btnCommHub.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCommHub.Size = new System.Drawing.Size(223, 60);
            this.btnCommHub.TabIndex = 25;
            this.btnCommHub.Text = "💬 Communication Hub";
            this.btnCommHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommHub.UseVisualStyleBackColor = true;
            this.btnCommHub.Click += new System.EventHandler(this.btnCommHub_Click);
            // 
            // btnFacultyHub
            // 
            this.btnFacultyHub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacultyHub.FlatAppearance.BorderSize = 0;
            this.btnFacultyHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacultyHub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFacultyHub.ForeColor = System.Drawing.Color.White;
            this.btnFacultyHub.Location = new System.Drawing.Point(0, 620);
            this.btnFacultyHub.Name = "btnFacultyHub";
            this.btnFacultyHub.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFacultyHub.Size = new System.Drawing.Size(223, 60);
            this.btnFacultyHub.TabIndex = 26;
            this.btnFacultyHub.Text = "🎗️ Faculty Support Hub";
            this.btnFacultyHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacultyHub.UseVisualStyleBackColor = true;
            this.btnFacultyHub.Click += new System.EventHandler(this.btnFacultyHub_Click);

            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(223, 320);
            this.panelLogo.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(50, 140);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(93, 45);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "VSIT";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.topPanel.Paint += (s, e) => {
                e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.FromArgb(200, 210, 230), 1), 0, this.topPanel.Height - 1, this.topPanel.Width, this.topPanel.Height - 1);
            };
            this.topPanel.Controls.Add(this.btnAssistant);
            this.topPanel.Controls.Add(this.panelUserInfo);
            this.topPanel.Controls.Add(this.txtGlobalSearch);
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Controls.Add(this.btnBack);
            this.topPanel.Controls.Add(this.btnMenu);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(240, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1144, 75);
            this.topPanel.TabIndex = 1;
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.lblUserRole);
            this.panelUserInfo.Controls.Add(this.lblUserName);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUserInfo.Location = new System.Drawing.Point(844, 0);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(250, 80);
            this.panelUserInfo.TabIndex = 3;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblUserRole.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserRole.Location = new System.Drawing.Point(10, 45);
            this.lblUserRole.Text = "Role";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lblUserName.Location = new System.Drawing.Point(10, 20);
            this.lblUserName.Text = "User Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(80, 25);
            this.lblTitle.Text = "VSIT Dashboard";
            // 
            // txtGlobalSearch
            // 
            this.txtGlobalSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtGlobalSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGlobalSearch.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtGlobalSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.txtGlobalSearch.Location = new System.Drawing.Point(400, 25);
            this.txtGlobalSearch.Multiline = false;
            this.txtGlobalSearch.Name = "txtGlobalSearch";
            this.txtGlobalSearch.Size = new System.Drawing.Size(380, 25);
            this.txtGlobalSearch.TabIndex = 4;
            this.txtGlobalSearch.Text = "  🔍 Search keywords for instant results...";
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(70, 80);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "☰";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnBack.Location = new System.Drawing.Point(70, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 80);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "⬅";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAssistant
            // 
            this.btnAssistant.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAssistant.FlatAppearance.BorderSize = 0;
            this.btnAssistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssistant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAssistant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btnAssistant.Location = new System.Drawing.Point(1030, 0);
            this.btnAssistant.Name = "btnAssistant";
            this.btnAssistant.Size = new System.Drawing.Size(64, 75);
            this.btnAssistant.TabIndex = 6;
            this.btnAssistant.Text = "🤖";
            this.btnAssistant.UseVisualStyleBackColor = true;
            this.btnAssistant.Click += (s, e) => System.Windows.Forms.MessageBox.Show("Digital AI Assistant: 'Hello! How can I help you today?'", "VSIT Assistant");

            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnClose.Location = new System.Drawing.Point(1094, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 75);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.lblWelcome);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(240, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1144, 670);
            this.panelMain.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.lblWelcome.Location = new System.Drawing.Point(300, 250);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(544, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome! Select a menu item to begin.";
            // 
            // MainDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1384, 750);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VSIT Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidePanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnNotices;
        private System.Windows.Forms.Button btnVac;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCourseManagement;
        private System.Windows.Forms.Button btnAssignments;
        private System.Windows.Forms.Button btnGrading;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPerformance;
        private System.Windows.Forms.Button btnResourceLibrary;
        private System.Windows.Forms.Button btnStudentDirectory;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnLessonPlan;
        private System.Windows.Forms.Button btnSyllabus;
        private System.Windows.Forms.Button btnHolidayCalendar;
        private System.Windows.Forms.Label lblSectionMain;
        private System.Windows.Forms.Label lblSectionAcademic;
        private System.Windows.Forms.Label lblSectionStudents;
        private System.Windows.Forms.Label lblSectionComm;
        private System.Windows.Forms.Label lblSectionResources;
        private System.Windows.Forms.Label lblSectionAdmin;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnCommHub;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnQuizzes;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnSystemSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAcademicHub;
        private System.Windows.Forms.Button btnStudentHub;
        private System.Windows.Forms.Button btnResourceHub;
        private System.Windows.Forms.Button btnFacultyHub;
        private System.Windows.Forms.Button btnAssistant;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtGlobalSearch;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
    }
}
