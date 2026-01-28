using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class ResourceHubForm : Form
    {
        public ResourceHubForm()
        {
            InitializeComponent();
            SetupHub();
        }

        private void SetupHub()
        {
            this.Text = "Digital Resource Hub";
            this.BackColor = Color.FromArgb(210, 218, 230); // Steel Sapphire Mid-tone

            // Wrapper for premium book-page aesthetic
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
                Text = "KNOWLEDGE & RESOURCE CENTER", 
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

            AddMenuCard(flowHub, "E-Library", "Access digital books, journals, and reference materials.", () => new ResourceLibraryForm(), Color.FromArgb(76, 175, 80));
            AddMenuCard(flowHub, "Subject Notes", "Download and share lecture slides, handouts, and notes.", () => new ResourceLibraryForm(), Color.FromArgb(33, 150, 243));
            AddMenuCard(flowHub, "Sample Papers", "Archive of previous year questions and practice assignments.", () => new ResourceLibraryForm(), Color.FromArgb(156, 39, 176));
            AddMenuCard(flowHub, "Research Desk", "Dedicated portal for tracking faculty research and publications.", () => new HomeForm(), Color.FromArgb(255, 87, 34));

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
            this.Name = "ResourceHubForm";
            this.ResumeLayout(false);
        }
    }
}
