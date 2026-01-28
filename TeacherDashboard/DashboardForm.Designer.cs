namespace TeacherDashboard
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.btnResourceLibrary = new System.Windows.Forms.Button();
            this.btnStudentDirectory = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnGrading = new System.Windows.Forms.Button();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnAssignments = new System.Windows.Forms.Button();
            this.btnCourseManagement = new System.Windows.Forms.Button(); // New button for Course Management
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnVac = new System.Windows.Forms.Button();
            this.btnNotices = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            
            // Adding images to ImageList. Order defines the index.
            // It is CRITICAL that these images are embedded as resources in your project.
            // If you encounter 'Object reference not set to an instance of an object' here,
            // it means the resources are not correctly embedded.
            // You MUST add these images as 'Embedded Resources' via Project Properties -> Resources.

            System.Drawing.Image homeImage = ((System.Drawing.Image)(resources.GetObject("home.png")));
            if (homeImage != null) { this.imageListIcons.Images.Add(homeImage); } // Index 0

            System.Drawing.Image timetableImage = ((System.Drawing.Image)(resources.GetObject("timetable.png")));
            if (timetableImage != null) { this.imageListIcons.Images.Add(timetableImage); } // Index 1

            System.Drawing.Image noticesImage = ((System.Drawing.Image)(resources.GetObject("notices.png")));
            if (noticesImage != null) { this.imageListIcons.Images.Add(noticesImage); } // Index 2

            System.Drawing.Image lecturesImage = ((System.Drawing.Image)(resources.GetObject("lectures.png")));
            if (lecturesImage != null) { this.imageListIcons.Images.Add(lecturesImage); } // Index 3

            System.Drawing.Image settingsImage = ((System.Drawing.Image)(resources.GetObject("settings.png")));
            if (settingsImage != null) { this.imageListIcons.Images.Add(settingsImage); } // Index 4
            
            // Note: students.png is removed.
            // A new icon for course management (e.g., 'courses.png') would be ideal here at index 5.
            // For now, let's use a generic icon if 'courses.png' is not found as an embedded resource.
            System.Drawing.Image coursesImage = ((System.Drawing.Image)(resources.GetObject("courses.png"))); // Placeholder for courses.png
            System.Drawing.Image genericIconImage = ((System.Drawing.Image)(resources.GetObject("generic_icon.png"))); // Ensure generic is also Image
            
            if (coursesImage != null) 
            { 
                this.imageListIcons.Images.Add(coursesImage); 
            } 
            else if (genericIconImage != null) 
            { 
                this.imageListIcons.Images.Add(genericIconImage); 
            }
            else
            {
                 // Create a placeholder bitmap to maintain the image index order if both resources are missing
                 this.imageListIcons.Images.Add(new System.Drawing.Bitmap(1, 1));
            }

            // Added for Assignment Management
            System.Drawing.Image assignmentsImage = ((System.Drawing.Image)(resources.GetObject("assignments.png")));
            if (assignmentsImage != null) { this.imageListIcons.Images.Add(assignmentsImage); } // Index 6

            // Added for Grading System
            System.Drawing.Image gradesImage = ((System.Drawing.Image)(resources.GetObject("grades.png")));
            if (gradesImage != null) { this.imageListIcons.Images.Add(gradesImage); } // Index 7

            // Added for Attendance
            System.Drawing.Image attendanceImage = ((System.Drawing.Image)(resources.GetObject("attendance.png")));
            if (attendanceImage != null) { this.imageListIcons.Images.Add(attendanceImage); } 
            else if (genericIconImage != null) { this.imageListIcons.Images.Add(genericIconImage); }
            else { this.imageListIcons.Images.Add(new System.Drawing.Bitmap(1, 1)); } // Index 8

            // Added for Reports
            System.Drawing.Image reportsImage = ((System.Drawing.Image)(resources.GetObject("reports.png")));
            if (reportsImage != null) { this.imageListIcons.Images.Add(reportsImage); }
            else if (genericIconImage != null) { this.imageListIcons.Images.Add(genericIconImage); }
            else { this.imageListIcons.Images.Add(new System.Drawing.Bitmap(1, 1)); } // Index 9

            // Added for Performance
            System.Drawing.Image performanceImage = ((System.Drawing.Image)(resources.GetObject("performance.png")));
            if (performanceImage != null) { this.imageListIcons.Images.Add(performanceImage); }
            else if (genericIconImage != null) { this.imageListIcons.Images.Add(genericIconImage); }
            else { this.imageListIcons.Images.Add(new System.Drawing.Bitmap(1, 1)); } // Index 10

            // Added for Resource Library and Student Directory (Using generic for now if specific icons missing)
            if (genericIconImage != null) { 
                this.imageListIcons.Images.Add(genericIconImage); // Index 11
                this.imageListIcons.Images.Add(genericIconImage); // Index 12
            } 
            else { 
                this.imageListIcons.Images.Add(new System.Drawing.Bitmap(1, 1)); 
                this.imageListIcons.Images.Add(new System.Drawing.Bitmap(1, 1)); 
            }

            // Added for Tasks
            if (genericIconImage != null) { 
                this.imageListIcons.Images.Add(genericIconImage); // Index 13
            } 
            else { 
                this.imageListIcons.Images.Add(new System.Drawing.Bitmap(1, 1)); 
            }

            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true; // Enable scrolling for many buttons
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.sidePanel.Controls.Add(this.btnTasks);
            this.sidePanel.Controls.Add(this.btnStudentDirectory);
            this.sidePanel.Controls.Add(this.btnResourceLibrary);
            this.sidePanel.Controls.Add(this.btnPerformance);
            this.sidePanel.Controls.Add(this.btnReports);
            this.sidePanel.Controls.Add(this.btnAttendance);
            this.sidePanel.Controls.Add(this.btnGrading);
            this.sidePanel.Controls.Add(this.btnCourseManagement); // Ensure this is added
            this.sidePanel.Controls.Add(this.btnAssignments);
            this.sidePanel.Controls.Add(this.btnSettings);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.btnVac);
            this.sidePanel.Controls.Add(this.btnNotices);
            this.sidePanel.Controls.Add(this.btnTimetable);
            this.sidePanel.Controls.Add(this.panelLogo);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(240, 750); // Increased Size
            this.sidePanel.TabIndex = 0;
            // 
            // btnGrading
            // 
            this.btnGrading.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrading.FlatAppearance.BorderSize = 0;
            this.btnGrading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrading.ForeColor = System.Drawing.Color.White;
            this.btnGrading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrading.ImageIndex = 7; // Corresponds to grades.png
            this.btnGrading.ImageList = this.imageListIcons;
            this.btnGrading.Location = new System.Drawing.Point(0, 500);
            this.btnGrading.Name = "btnGrading";
            this.btnGrading.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGrading.Size = new System.Drawing.Size(220, 60);
            this.btnGrading.TabIndex = 8;
            this.btnGrading.Text = "Grading System";
            this.btnGrading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrading.UseVisualStyleBackColor = true;
            this.btnGrading.Click += new System.EventHandler(this.btnGrading_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.ImageIndex = 8; // Corresponds to attendance.png or generic
            this.btnAttendance.ImageList = this.imageListIcons;
            this.btnAttendance.Location = new System.Drawing.Point(0, 560);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAttendance.Size = new System.Drawing.Size(220, 60);
            this.btnAttendance.TabIndex = 9;
            this.btnAttendance.Text = "Daily Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.ImageIndex = 9; // Corresponds to reports.png or generic
            this.btnReports.ImageList = this.imageListIcons;
            this.btnReports.Location = new System.Drawing.Point(0, 620);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(220, 60);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "Reports & Analytics";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnPerformance
            // 
            this.btnPerformance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerformance.FlatAppearance.BorderSize = 0;
            this.btnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformance.ForeColor = System.Drawing.Color.White;
            this.btnPerformance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformance.ImageIndex = 10; // Corresponds to performance.png or generic
            this.btnPerformance.ImageList = this.imageListIcons;
            this.btnPerformance.Location = new System.Drawing.Point(0, 680);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPerformance.Size = new System.Drawing.Size(220, 60);
            this.btnPerformance.TabIndex = 11;
            this.btnPerformance.Text = "Student Performance";
            this.btnPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerformance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerformance.UseVisualStyleBackColor = true;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // btnResourceLibrary
            // 
            this.btnResourceLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResourceLibrary.FlatAppearance.BorderSize = 0;
            this.btnResourceLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourceLibrary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResourceLibrary.ForeColor = System.Drawing.Color.White;
            this.btnResourceLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResourceLibrary.ImageIndex = 11; // Generic icon
            this.btnResourceLibrary.ImageList = this.imageListIcons;
            this.btnResourceLibrary.Location = new System.Drawing.Point(0, 740);
            this.btnResourceLibrary.Name = "btnResourceLibrary";
            this.btnResourceLibrary.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnResourceLibrary.Size = new System.Drawing.Size(220, 60);
            this.btnResourceLibrary.TabIndex = 12;
            this.btnResourceLibrary.Text = "Resource Library";
            this.btnResourceLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResourceLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResourceLibrary.UseVisualStyleBackColor = true;
            this.btnResourceLibrary.Click += new System.EventHandler(this.btnResourceLibrary_Click);
            // 
            // btnStudentDirectory
            // 
            this.btnStudentDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentDirectory.FlatAppearance.BorderSize = 0;
            this.btnStudentDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentDirectory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentDirectory.ForeColor = System.Drawing.Color.White;
            this.btnStudentDirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentDirectory.ImageIndex = 12; // Generic icon
            this.btnStudentDirectory.ImageList = this.imageListIcons;
            this.btnStudentDirectory.Location = new System.Drawing.Point(0, 800);
            this.btnStudentDirectory.Name = "btnStudentDirectory";
            this.btnStudentDirectory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStudentDirectory.Size = new System.Drawing.Size(220, 60);
            this.btnStudentDirectory.TabIndex = 13;
            this.btnStudentDirectory.Text = "Student Directory";
            this.btnStudentDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentDirectory.UseVisualStyleBackColor = true;
            this.btnStudentDirectory.Click += new System.EventHandler(this.btnStudentDirectory_Click);

            // 
            // btnTasks
            // 
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.ImageIndex = 13; // Adjusted Index to 13 (since Comm is removed)
            this.btnTasks.ImageList = this.imageListIcons;
            this.btnTasks.Location = new System.Drawing.Point(0, 920);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTasks.Size = new System.Drawing.Size(220, 60);
            this.btnTasks.TabIndex = 15;
            this.btnTasks.Text = "My Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnAssignments
            // 
            this.btnAssignments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignments.FlatAppearance.BorderSize = 0;
            this.btnAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignments.ForeColor = System.Drawing.Color.White;
            this.btnAssignments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignments.ImageIndex = 6; // Corresponds to assignments.png
            this.btnAssignments.ImageList = this.imageListIcons;
            this.btnAssignments.Location = new System.Drawing.Point(0, 440);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAssignments.Size = new System.Drawing.Size(220, 60);
            this.btnAssignments.TabIndex = 7;
            this.btnAssignments.Text = "Assignment Management";
            this.btnAssignments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnCourseManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourseManagement.ImageIndex = 5; // Corresponds to courses.png (or generic_icon.png if not found)
            this.btnCourseManagement.ImageList = this.imageListIcons;
            this.btnCourseManagement.Location = new System.Drawing.Point(0, 380);
            this.btnCourseManagement.Name = "btnCourseManagement";
            this.btnCourseManagement.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCourseManagement.Size = new System.Drawing.Size(220, 60);
            this.btnCourseManagement.TabIndex = 6;
            this.btnCourseManagement.Text = "Course Management";
            this.btnCourseManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourseManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.ImageIndex = 4; // Corresponds to settings.png
            this.btnSettings.ImageList = this.imageListIcons;
            this.btnSettings.Location = new System.Drawing.Point(0, 320);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.ImageIndex = 0; // Corresponds to home.png
            this.btnHome.ImageList = this.imageListIcons;
            this.btnHome.Location = new System.Drawing.Point(0, 260);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnVac
            // 
            this.btnVac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVac.FlatAppearance.BorderSize = 0;
            this.btnVac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVac.ForeColor = System.Drawing.Color.White;
            this.btnVac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVac.ImageIndex = 3; // Corresponds to lectures.png
            this.btnVac.ImageList = this.imageListIcons;
            this.btnVac.Location = new System.Drawing.Point(0, 200);
            this.btnVac.Name = "btnVac";
            this.btnVac.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnVac.Size = new System.Drawing.Size(220, 60);
            this.btnVac.TabIndex = 3;
            this.btnVac.Text = "VAC Lectures";
            this.btnVac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVac.UseVisualStyleBackColor = true;
            this.btnVac.Click += new System.EventHandler(this.btnVac_Click);
            // 
            // btnNotices
            // 
            this.btnNotices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotices.FlatAppearance.BorderSize = 0;
            this.btnNotices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotices.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotices.ForeColor = System.Drawing.Color.White;
            this.btnNotices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotices.ImageIndex = 2; // Corresponds to notices.png
            this.btnNotices.ImageList = this.imageListIcons;
            this.btnNotices.Location = new System.Drawing.Point(0, 140);
            this.btnNotices.Name = "btnNotices";
            this.btnNotices.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNotices.Size = new System.Drawing.Size(220, 60);
            this.btnNotices.TabIndex = 2;
            this.btnNotices.Text = "Exam Notices";
            this.btnNotices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotices.UseVisualStyleBackColor = true;
            this.btnNotices.Click += new System.EventHandler(this.btnNotices_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimetable.FlatAppearance.BorderSize = 0;
            this.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimetable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimetable.ForeColor = System.Drawing.Color.White;
            this.btnTimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimetable.ImageIndex = 1; // Corresponds to timetable.png
            this.btnTimetable.ImageList = this.imageListIcons;
            this.btnTimetable.Location = new System.Drawing.Point(0, 80);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTimetable.Size = new System.Drawing.Size(220, 60);
            this.btnTimetable.TabIndex = 1;
            this.btnTimetable.Text = "Timetable";
            this.btnTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimetable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimetable.UseVisualStyleBackColor = true;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            try {
                this.pictureBoxLogo.Image = System.Drawing.Image.FromFile("logo.png"); // Assuming logo.png is in the executable directory
            } catch { }
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(60, 20);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(46, 21);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "VSIT";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Controls.Add(this.btnMenu);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(220, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(764, 80);
            this.topPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.lblTitle.Location = new System.Drawing.Point(80, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
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
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnClose.Location = new System.Drawing.Point(714, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 80);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(220, 80);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(764, 501);
            this.mainPanel.TabIndex = 2;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 700);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Dashboard";
            this.sidePanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnVac;
        private System.Windows.Forms.Button btnNotices;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Button btnAssignments;
        private System.Windows.Forms.Button btnGrading;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPerformance;
        private System.Windows.Forms.Button btnResourceLibrary;
        private System.Windows.Forms.Button btnStudentDirectory;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnCourseManagement; // New Course Management button
    }
}
