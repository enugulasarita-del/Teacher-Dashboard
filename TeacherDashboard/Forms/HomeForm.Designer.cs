namespace TeacherDashboard.Forms
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.flowLayoutMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlQuickStats = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAnnouncements = new System.Windows.Forms.Panel();
            this.lblAnnTitle = new System.Windows.Forms.Label();
            this.lstAnnouncements = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(30, 40, 60);
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.Text = "Dashboard Hub";

            // pnlQuickStats (Horizontal list of cards)
            this.pnlQuickStats.Location = new System.Drawing.Point(30, 80);
            this.pnlQuickStats.Size = new System.Drawing.Size(1080, 160);
            this.pnlQuickStats.TabIndex = 1;
            this.pnlQuickStats.WrapContents = false;
            this.pnlQuickStats.AutoScroll = true;

            // flowLayoutMenu (Main Grid)
            this.flowLayoutMenu.AutoScroll = true;
            this.flowLayoutMenu.Location = new System.Drawing.Point(30, 260);
            this.flowLayoutMenu.Size = new System.Drawing.Size(750, 400);
            this.flowLayoutMenu.TabIndex = 2;
            this.flowLayoutMenu.Padding = new System.Windows.Forms.Padding(10);

            // pnlAnnouncements (Side panel for news)
            this.pnlAnnouncements.BackColor = System.Drawing.Color.FromArgb(225, 232, 245);
            this.pnlAnnouncements.Location = new System.Drawing.Point(800, 260);
            this.pnlAnnouncements.Size = new System.Drawing.Size(310, 400);
            this.pnlAnnouncements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlAnnouncements.Controls.Add(this.lstAnnouncements);
            this.pnlAnnouncements.Controls.Add(this.lblAnnTitle);

            this.lblAnnTitle.Text = "🔔 Recent Activity";
            this.lblAnnTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnnTitle.Location = new System.Drawing.Point(15, 15);
            this.lblAnnTitle.AutoSize = true;

            this.lstAnnouncements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAnnouncements.BackColor = System.Drawing.Color.FromArgb(225, 232, 245);
            this.lstAnnouncements.ForeColor = System.Drawing.Color.FromArgb(40, 50, 80);
            this.lstAnnouncements.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstAnnouncements.Location = new System.Drawing.Point(15, 50);
            this.lstAnnouncements.Size = new System.Drawing.Size(280, 330);

            // HomeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(210, 218, 230); // Steel Sapphire Mid-tone
            this.ClientSize = new System.Drawing.Size(1144, 670);
            this.Controls.Add(this.pnlAnnouncements);
            this.Controls.Add(this.flowLayoutMenu);
            this.Controls.Add(this.pnlQuickStats);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMenu;
        private System.Windows.Forms.FlowLayoutPanel pnlQuickStats;
        private System.Windows.Forms.Panel pnlAnnouncements;
        private System.Windows.Forms.Label lblAnnTitle;
        private System.Windows.Forms.ListBox lstAnnouncements;
    }
}
