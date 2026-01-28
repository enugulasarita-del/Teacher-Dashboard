using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class AcademicHubForm : Form
    {
        public AcademicHubForm()
        {
            InitializeComponent();
            SetupHub();
        }

        private void SetupHub()
        {
            this.Text = "Academic Center";
            this.BackColor = Color.FromArgb(210, 218, 230); // Steel Sapphire Mid-tone

            // Wrapper to give "sheet of paper" look
            Panel pageSheet = new Panel {
                Size = new Size(this.Width - 60, this.Height - 60),
                Location = new Point(30, 30),
                BackColor = Color.FromArgb(242, 246, 252), // Diamond Slate Frost
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            pageSheet.BorderStyle = BorderStyle.None;
            pageSheet.Paint += (s, e) => {
                // Binding dots on the left
                for (int i = 0; i < 15; i++) {
                    e.Graphics.FillEllipse(Brushes.LightGray, 10, 40 + (i * 30), 10, 10);
                }
                ControlPaint.DrawBorder(e.Graphics, pageSheet.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
            };

            Label title = new Label { 
                Text = "ACADEMIC MANAGEMENT HUB", 
                ForeColor = Color.FromArgb(173, 22, 37), 
                Font = new Font("Segoe UI", 32, FontStyle.Bold), 
                Location = new Point(50, 40), 
                AutoSize = true 
            };
            pageSheet.Controls.Add(title);

            FlowLayoutPanel flow = new FlowLayoutPanel { 
                Location = new Point(50, 120), 
                Size = new Size(pageSheet.Width - 100, pageSheet.Height - 160),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Padding = new Padding(10) 
            };
            
            AddMenuCard(flow, "📅 Timetable", "View daily class schedules.", () => new TimetableForm(), Color.FromArgb(0, 123, 255));
            AddMenuCard(flow, "🎥 VAC Lectures", "Digital learning & video library.", () => new VacLecturesForm(), Color.FromArgb(40, 167, 69));
            AddMenuCard(flow, "📖 Syllabus Tracker", "Track curriculum progress.", () => new SyllabusTrackerForm(), Color.FromArgb(255, 193, 7));
            AddMenuCard(flow, "📑 Exam Center", "Marks & Exam schedules.", () => new ExamManagementForm(), Color.FromArgb(173, 22, 37));
            AddMenuCard(flow, "💡 Quiz Builder", "Interactive classroom quizzes.", () => new QuizBuilderForm(), Color.FromArgb(106, 27, 154));
            AddMenuCard(flow, "✍️ Lesson Plan", "Prepare teaching strategies.", () => new LessonPlanForm(), Color.FromArgb(230, 81, 0));

            pageSheet.Controls.Add(flow);
            this.Controls.Add(pageSheet);
        }

        private void AddMenuCard(FlowLayoutPanel p, string title, string desc, Func<Form> factory, Color c)
        {
            // Larger premium cards
            Panel card = new Panel { Size = new Size(300, 220), Margin = new Padding(30), BackColor = Color.FromArgb(250, 252, 255), Cursor = Cursors.Hand };
            card.Click += (s, e) => OpenChild(factory());

            Label lblTitle = new Label { Text = title, Font = new Font("Segoe UI", 18, FontStyle.Bold), Location = new Point(25, 30), ForeColor = Color.FromArgb(20, 30, 50), AutoSize = true, Enabled = false };
            Label lblDesc = new Label { Text = desc, Font = new Font("Segoe UI", 12), Location = new Point(25, 75), Size = new Size(250, 100), ForeColor = Color.FromArgb(90, 100, 120), Enabled = false };
            
            Panel line = new Panel { Dock = DockStyle.Top, Height = 4, BackColor = c };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblDesc);
            card.Controls.Add(line);
            p.Controls.Add(card);
        }

        private void OpenChild(Form f)
        {
            if (this.ParentForm is MainDashboardForm dash) dash.OpenChildForm(f);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Name = "AcademicHubForm";
            this.ResumeLayout(false);
        }
    }
}
