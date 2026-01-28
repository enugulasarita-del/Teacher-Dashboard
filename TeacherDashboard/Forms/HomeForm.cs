using System;
using System.Drawing;
using System.Windows.Forms;
using TeacherDashboard.Services;

namespace TeacherDashboard.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            if (SessionManager.IsLoggedIn)
                lblWelcome.Text = $"Hello, {SessionManager.CurrentUser.FullName.Split(' ')[0]} 👋";

            CreateStatsCards();
            CreateMobileMenu();
            LoadRecentActivity();
        }

        private void CreateStatsCards()
        {
            pnlQuickStats.Controls.Clear();
            
            if (SessionManager.IsAdmin)
            {
                // Admin specific dashboard stats
                AddStatCard("Total Users", "124", "Active in system", Color.FromArgb(0, 123, 255));
                AddStatCard("System Load", "12%", "Healthy", Color.FromArgb(40, 167, 69));
                AddStatCard("Pending Tasks", "5", "Action required", Color.FromArgb(220, 53, 69));
                AddStatCard("Storage", "85%", "Optimization needed", Color.FromArgb(255, 193, 7));
            }
            else
            {
                // Teacher specific dashboard stats
                AddStatCard("Attendance", "94%", "↑ 2% this week", Color.FromArgb(40, 167, 69));
                AddStatCard("Performance", "B+", "Avg. Class Grade", Color.FromArgb(0, 123, 255));
                AddStatCard("Tasks", "12", "4 overdue", Color.FromArgb(220, 53, 69));
                AddStatCard("Events", "3", "Upcoming fests", Color.FromArgb(255, 193, 7));
            }
        }

        private void AddStatCard(string title, string value, string trend, Color themeColor)
        {
            Panel card = new Panel { Size = new Size(270, 170), Margin = new Padding(0, 0, 25, 0), BackColor = Color.FromArgb(238, 243, 250) };
            card.Paint += (s, e) => {
                // Subtle "elevation" border
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle, Color.FromArgb(190, 200, 220), ButtonBorderStyle.Solid);
                // Premium accent line
                using (SolidBrush b = new SolidBrush(themeColor))
                {
                    e.Graphics.FillRectangle(b, 0, 0, 8, card.Height);
                }
            };

            Label lblTitle = new Label { Text = title, Location = new Point(30, 30), Font = new Font("Segoe UI Semibold", 12), ForeColor = Color.FromArgb(110, 120, 140), AutoSize = true };
            Label lblValue = new Label { Text = value, Location = new Point(30, 60), Font = new Font("Segoe UI", 34, FontStyle.Bold), ForeColor = Color.FromArgb(20, 30, 50), AutoSize = true };
            Label lblTrend = new Label { Text = trend, Location = new Point(30, 125), Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = themeColor, AutoSize = true };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);
            card.Controls.Add(lblTrend);
            pnlQuickStats.Controls.Add(card);
        }

        private void CreateMobileMenu()
        {
            flowLayoutMenu.Controls.Clear();

            if (SessionManager.IsAdmin)
            {
                AddSectionHeader("🏢 SYSTEM ADMINISTRATION");
                AddMenuIcon("Admin Panel", "🔐", Color.FromArgb(33, 37, 41), Color.White, () => new AdminPanelForm());
                AddMenuIcon("Manage Users", "👥", Color.FromArgb(227, 242, 253), Color.FromArgb(21, 101, 192), () => new UserManagementForm());
                AddMenuIcon("App Settings", "⚙️", Color.FromArgb(243, 229, 245), Color.FromArgb(106, 27, 154), () => new SystemSettingsForm());
                
                AddSectionHeader("📊 DATA & PLANNING");
                AddMenuIcon("Holidays", "📅", Color.FromArgb(255, 243, 224), Color.FromArgb(230, 81, 0), () => new HolidayCalendarForm());
                AddMenuIcon("Global Reports", "📈", Color.FromArgb(232, 245, 233), Color.FromArgb(46, 125, 50), () => new ReportsForm());
                AddMenuIcon("Syllabus", "📖", Color.FromArgb(255, 243, 224), Color.FromArgb(230, 81, 0), () => new SyllabusTrackerForm());
            }
            else
            {
                AddSectionHeader("📚 DAILY ACADEMICS");
                AddMenuIcon("Timetable", "📅", Color.FromArgb(232, 245, 233), Color.FromArgb(46, 125, 50), () => new TimetableForm());
                AddMenuIcon("Attendance", "✅", Color.FromArgb(232, 245, 233), Color.FromArgb(46, 125, 50), () => new AttendanceForm());
                AddMenuIcon("Grading", "🎓", Color.FromArgb(232, 245, 233), Color.FromArgb(46, 125, 50), () => new GradingSystemForm());
                
                AddSectionHeader("✍️ TEACHING & EXAMS");
                AddMenuIcon("Syllabus", "📖", Color.FromArgb(255, 243, 224), Color.FromArgb(230, 81, 0), () => new SyllabusTrackerForm());
                AddMenuIcon("Lesson Plan", "✍️", Color.FromArgb(255, 243, 224), Color.FromArgb(230, 81, 0), () => new LessonPlanForm());
                AddMenuIcon("Exams", "📑", Color.FromArgb(254, 235, 238), Color.FromArgb(198, 40, 40), () => new ExamManagementForm());
                AddMenuIcon("Quiz Builder", "💡", Color.FromArgb(254, 235, 238), Color.FromArgb(198, 40, 40), () => new QuizBuilderForm());
                
                AddSectionHeader("📢 COMMUNICATION & DATA");
                AddMenuIcon("Student Dir.", "👥", Color.FromArgb(243, 229, 245), Color.FromArgb(106, 27, 154), () => new StudentDirectoryForm());
                AddMenuIcon("Message Hub", "💬", Color.FromArgb(243, 229, 245), Color.FromArgb(106, 27, 154), () => new CommunicationHubForm());
                AddMenuIcon("Notices", "📢", Color.FromArgb(243, 229, 245), Color.FromArgb(106, 27, 154), () => new NoticesForm());
                
                AddSectionHeader("🏖️ PERSONAL & PLANNING");
                AddMenuIcon("My Tasks", "📋", Color.FromArgb(254, 235, 238), Color.FromArgb(198, 40, 40), () => new TasksForm());
                AddMenuIcon("Apply Leave", "🏖️", Color.FromArgb(254, 235, 238), Color.FromArgb(198, 40, 40), () => new LeaveManagementForm());
                AddMenuIcon("Performance", "📊", Color.FromArgb(227, 242, 253), Color.FromArgb(21, 101, 192), () => new StudentPerformanceForm());
            }
        }

        private void AddSectionHeader(string title)
        {
            Label lbl = new Label {
                Text = title,
                AutoSize = false,
                Size = new Size(flowLayoutMenu.Width - 40, 50),
                Font = new Font("Segoe UI", 15, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 70, 90),
                TextAlign = ContentAlignment.BottomLeft,
                Padding = new Padding(15, 0, 0, 8),
                Margin = new Padding(0, 30, 0, 15)
            };
            flowLayoutMenu.SetFlowBreak(lbl, true);
            flowLayoutMenu.Controls.Add(lbl);
        }

        private void AddMenuIcon(string title, string icon, Color bgColor, Color iconColor, Func<Form> factory)
        {
            Panel container = new Panel { Size = new Size(190, 220), Margin = new Padding(15) };
            
            Button btn = new Button {
                Size = new Size(135, 135),
                Location = new Point(27, 5),
                FlatStyle = FlatStyle.Flat,
                BackColor = bgColor,
                Cursor = Cursors.Hand,
                Text = icon,
                Font = new Font("Segoe UI Emoji", 52),
                ForeColor = iconColor
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(
                Math.Min(255, bgColor.R + 15), 
                Math.Min(255, bgColor.G + 15), 
                Math.Min(255, bgColor.B + 15)
            );
            btn.Click += (s, e) => OpenFeature(factory);

            Label lbl = new Label {
                Text = title,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(190, 45),
                Location = new Point(0, 150),
                Font = new Font("Segoe UI Semibold", 13),
                ForeColor = Color.FromArgb(30, 40, 60)
            };

            container.Controls.Add(btn);
            container.Controls.Add(lbl);
            flowLayoutMenu.Controls.Add(container);
        }

        private void LoadRecentActivity()
        {
            lstAnnouncements.Items.Add("📌 Mid-term schedule released");
            lstAnnouncements.Items.Add("✅ Attendance marked for CS-2A");
            lstAnnouncements.Items.Add("📝 New assignment from Admin");
            lstAnnouncements.Items.Add("🎓 Grade entry open for Finals");
            lstAnnouncements.Items.Add("🗓️ Staff meeting at 4 PM");
        }

        private void OpenFeature(Func<Form> factory)
        {
            if (this.ParentForm is MainDashboardForm dashboard)
                dashboard.OpenChildForm(factory());
        }
    }
}
