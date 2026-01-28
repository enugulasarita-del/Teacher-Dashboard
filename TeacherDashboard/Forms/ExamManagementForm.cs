using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class ExamManagementForm : Form
    {
        public ExamManagementForm()
        {
            InitializeComponent();
            SetupExamDashboard();
        }

        private void SetupExamDashboard()
        {
            this.Text = "Exam Management Center";
            this.BackColor = Color.FromArgb(245, 245, 235); // Paper/Ivory color

            // Wrapper to give "sheet of paper" look
            Panel pageSheet = new Panel {
                Size = new Size(this.Width - 60, this.Height - 60),
                Location = new Point(30, 30),
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            pageSheet.BorderStyle = BorderStyle.None;
            pageSheet.Paint += (s, e) => {
                // Binding dots on the left
                for (int i = 0; i < 15; i++) {
                    e.Graphics.FillEllipse(Brushes.LightGray, 10, 40 + (i * 30), 10, 10);
                }
                // Shadow/Border
                ControlPaint.DrawBorder(e.Graphics, pageSheet.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
            };

            Label title = new Label { 
                Text = "CHAPTER 1: EXAM ADMINISTRATION", 
                ForeColor = Color.DimGray, 
                Font = new Font("Georgia", 18, FontStyle.Italic | FontStyle.Bold), 
                Location = new Point(40, 20), 
                AutoSize = true 
            };
            pageSheet.Controls.Add(title);

            FlowLayoutPanel flow = new FlowLayoutPanel { 
                Location = new Point(30, 80), 
                Size = new Size(pageSheet.Width - 60, pageSheet.Height - 120),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Padding = new Padding(10) 
            };
            
            AddFeatureCard(flow, "Schedules", "📅 View and manage upcoming examinations.", Color.FromArgb(0, 123, 255));
            AddFeatureCard(flow, "Result Entry", "📝 Enter and update student marks.", Color.FromArgb(40, 167, 69));
            AddFeatureCard(flow, "Hall Tickets", "🆔 Generate admit cards for students.", Color.FromArgb(255, 193, 7));
            AddFeatureCard(flow, "Reports", "📊 Term-wise performance analysis.", Color.FromArgb(108, 117, 125));

            pageSheet.Controls.Add(flow);
            this.Controls.Add(pageSheet);
        }

        private void AddFeatureCard(FlowLayoutPanel p, string title, string desc, Color topColor)
        {
            Panel card = new Panel { Size = new Size(240, 150), Margin = new Padding(10), BackColor = Color.FromArgb(245, 245, 245) };
            card.Paint += (s, e) => {
                e.Graphics.FillRectangle(new SolidBrush(topColor), 0, 0, card.Width, 5);
            };

            Label lblTitle = new Label { Text = title, Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(15, 20), AutoSize = true };
            Label lblDesc = new Label { Text = desc, Font = new Font("Segoe UI", 9), Location = new Point(15, 50), Size = new Size(210, 60), ForeColor = Color.Gray };
            Button btn = new Button { Text = "Open", Location = new Point(15, 110), Size = new Size(80, 30), FlatStyle = FlatStyle.Flat, BackColor = topColor, ForeColor = Color.White };
            btn.FlatAppearance.BorderSize = 0;

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblDesc);
            card.Controls.Add(btn);
            p.Controls.Add(card);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Name = "ExamManagementForm";
            this.ResumeLayout(false);
        }
    }
}
