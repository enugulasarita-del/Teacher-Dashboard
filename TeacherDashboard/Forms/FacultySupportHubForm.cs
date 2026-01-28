using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class FacultySupportHubForm : Form
    {
        public FacultySupportHubForm()
        {
            InitializeComponent();
            SetupHub();
        }

        private void SetupHub()
        {
            this.Text = "Faculty Support Hub";
            this.BackColor = Color.FromArgb(210, 218, 230); // Steel Sapphire Mid-tone

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
                ControlPaint.DrawBorder(e.Graphics, pageSheet.ClientRectangle, Color.FromArgb(180, 190, 210), ButtonBorderStyle.Solid);
            };

            Label title = new Label { 
                Text = "FACULTY SUPPORT & AMENITIES", 
                ForeColor = Color.FromArgb(173, 22, 37), 
                Font = new Font("Segoe UI", 32, FontStyle.Bold), 
                Location = new Point(50, 40), 
                AutoSize = true 
            };
            pageSheet.Controls.Add(title);

            FlowLayoutPanel flowHub = new FlowLayoutPanel {
                Location = new Point(50, 120),
                Size = new Size(pageSheet.Width - 100, pageSheet.Height - 150),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                AutoScroll = true
            };

            AddMenuCard(flowHub, "My Portfolio", "View and update your academic bio, achievements, and contact info.", () => new HomeForm(), Color.FromArgb(0, 150, 136));
            AddMenuCard(flowHub, "Salary & Slips", "Download monthly pay slips and view reimbursement status.", () => new HomeForm(), Color.FromArgb(63, 81, 181));
            AddMenuCard(flowHub, "Facility Booking", "Request lab slots, seminar halls, or auditorium bookings.", () => new HomeForm(), Color.FromArgb(255, 152, 0));
            AddMenuCard(flowHub, "Inventory Request", "Submit requests for stationeries, lab chemicals, or tech hardware.", () => new HomeForm(), Color.FromArgb(96, 125, 139));
            AddMenuCard(flowHub, "Helpdesk", "Raise tickets for technical, custodial, or administrative support.", () => new HomeForm(), Color.FromArgb(233, 30, 99));

            pageSheet.Controls.Add(flowHub);
            this.Controls.Add(pageSheet);
        }

        private void AddMenuCard(FlowLayoutPanel p, string title, string desc, Func<Form> factory, Color c)
        {
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
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Name = "FacultySupportHubForm";
            this.ResumeLayout(false);
        }
    }
}
