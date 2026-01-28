using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class LeaveManagementForm : Form
    {
        public LeaveManagementForm()
        {
            InitializeComponent();
            SetupLeaveHub();
        }

        private void SetupLeaveHub()
        {
            this.Text = "Leave Tracker";
            this.BackColor = Color.White;

            Panel header = new Panel { Dock = DockStyle.Top, Height = 80, BackColor = Color.FromArgb(0, 150, 136) };
            Label title = new Label { 
                Text = "🏖️ Leave & Absence Tracker", 
                ForeColor = Color.White, 
                Font = new Font("Segoe UI", 18, FontStyle.Bold), 
                Location = new Point(20, 20), 
                AutoSize = true 
            };
            header.Controls.Add(title);
            this.Controls.Add(header);

            FlowLayoutPanel flowStats = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 120, Padding = new Padding(20) };
            AddStatCard(flowStats, "Sick Leave", "4/12", "REMAINING", Color.FromArgb(220, 53, 69));
            AddStatCard(flowStats, "Casual Leave", "8/15", "REMAINING", Color.FromArgb(0, 123, 255));
            AddStatCard(flowStats, "Earned Leave", "20/30", "REMAINING", Color.FromArgb(40, 167, 69));
            this.Controls.Add(flowStats);

            Panel formArea = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20) };
            Label lblReq = new Label { Text = "Submit New Leave Request", Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(20, 10), AutoSize = true };
            
            Label lblDate = new Label { Text = "Pick Date range:", Location = new Point(20, 45), AutoSize = true };
            DateTimePicker dtFrom = new DateTimePicker { Location = new Point(20, 65), Width = 150 };
            DateTimePicker dtTo = new DateTimePicker { Location = new Point(180, 65), Width = 150 };

            Button btnSubmit = new Button { 
                Text = "Apply for Leave", 
                Location = new Point(20, 110), 
                Size = new Size(150, 40), 
                FlatStyle = FlatStyle.Flat, 
                BackColor = Color.FromArgb(0, 150, 136), 
                ForeColor = Color.White 
            };
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Click += (s, e) => MessageBox.Show("Leave Request Submitted to HR.", "Pending Approval");

            formArea.Controls.Add(lblReq);
            formArea.Controls.Add(lblDate);
            formArea.Controls.Add(dtFrom);
            formArea.Controls.Add(dtTo);
            formArea.Controls.Add(btnSubmit);
            this.Controls.Add(formArea);
        }

        private void AddStatCard(FlowLayoutPanel p, string title, string val, string sub, Color c)
        {
            Panel card = new Panel { Size = new Size(180, 80), Margin = new Padding(0, 0, 20, 0), BackColor = Color.FromArgb(240, 240, 240) };
            Label l1 = new Label { Text = title, Font = new Font("Segoe UI", 8), Location = new Point(10, 10), AutoSize = true };
            Label l2 = new Label { Text = val, Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = c, Location = new Point(10, 25), AutoSize = true };
            Label l3 = new Label { Text = sub, Font = new Font("Segoe UI", 7), ForeColor = Color.Gray, Location = new Point(10, 55), AutoSize = true };
            card.Controls.AddRange(new Control[] { l1, l2, l3 });
            p.Controls.Add(card);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Name = "LeaveManagementForm";
            this.ResumeLayout(false);
        }
    }
}
