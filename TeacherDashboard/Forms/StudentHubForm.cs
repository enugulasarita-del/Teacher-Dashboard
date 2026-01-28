using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class StudentHubForm : Form
    {
        public StudentHubForm()
        {
            InitializeComponent();
            SetupHub();
        }

        private void SetupHub()
        {
            this.Text = "Student Records";
            this.BackColor = Color.FromArgb(210, 218, 230);

            Panel pageSheet = new Panel {
                Size = new Size(this.Width - 60, this.Height - 60),
                Location = new Point(30, 30),
                BackColor = Color.FromArgb(242, 246, 252),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            pageSheet.BorderStyle = BorderStyle.None;
            pageSheet.Paint += (s, e) => {
                for (int i = 0; i < 15; i++) {
                    e.Graphics.FillEllipse(Brushes.LightGray, 10, 40 + (i * 30), 10, 10);
                }
                ControlPaint.DrawBorder(e.Graphics, pageSheet.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
            };

            Label title = new Label { 
                Text = "STUDENT RECORDS & DATA HUB", 
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
            
            AddMenuCard(flow, "✅ Attendance", "Daily presence tracking.", () => new AttendanceForm(), Color.FromArgb(40, 167, 69));
            AddMenuCard(flow, "🎓 Grading", "Exam scores and reports.", () => new GradingSystemForm(), Color.FromArgb(0, 123, 255));
            AddMenuCard(flow, "👥 Directory", "Contact info and student files.", () => new StudentDirectoryForm(), Color.FromArgb(106, 27, 154));
            AddMenuCard(flow, "📊 Performance", "Analytics and growth charts.", () => new StudentPerformanceForm(), Color.FromArgb(220, 53, 69));

            pageSheet.Controls.Add(flow);
            this.Controls.Add(pageSheet);
        }

        private void AddMenuCard(FlowLayoutPanel p, string title, string desc, Func<Form> factory, Color c)
        {
            // Large Premium Cards
            Panel card = new Panel { Size = new Size(300, 220), Margin = new Padding(30), BackColor = Color.FromArgb(250, 252, 255), Cursor = Cursors.Hand };
            card.Click += (s, e) => { if (this.ParentForm is MainDashboardForm dash) dash.OpenChildForm(factory()); };

            Label lblTitle = new Label { Text = title, Font = new Font("Segoe UI", 18, FontStyle.Bold), Location = new Point(25, 30), ForeColor = Color.FromArgb(20, 30, 50), AutoSize = true, Enabled = false };
            Label lblDesc = new Label { Text = desc, Font = new Font("Segoe UI", 12), Location = new Point(25, 75), Size = new Size(250, 100), ForeColor = Color.FromArgb(90, 100, 120), Enabled = false };
            Panel line = new Panel { Dock = DockStyle.Top, Height = 4, BackColor = c };
            card.Controls.Add(lblTitle); card.Controls.Add(lblDesc); card.Controls.Add(line);
            p.Controls.Add(card);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Name = "StudentHubForm";
            this.ResumeLayout(false);
        }
    }
}
