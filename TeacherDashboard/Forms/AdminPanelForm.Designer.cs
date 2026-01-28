using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    partial class AdminPanelForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowStats = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.lblTotalUsersTitle = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.pnlFinancials = new System.Windows.Forms.Panel();
            this.lblFeesTitle = new System.Windows.Forms.Label();
            this.lblFeesCollected = new System.Windows.Forms.Label();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.lblInvTitle = new System.Windows.Forms.Label();
            this.lblInventoryStatus = new System.Windows.Forms.Label();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.lblSystemHealth = new System.Windows.Forms.Label();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.btnUserMgmt = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.flowStats.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            this.pnlFinancials.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1000, 70);

            this.lblTitle.Text = "🔐 Management Control Center";
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescription.Text = "Use this area to manage school members, track fees, and monitor system activity.";
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.LightGray;
            this.lblDescription.Location = new System.Drawing.Point(22, 50);
            this.lblDescription.AutoSize = true;
            this.panelTop.Controls.Add(this.lblDescription);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.AutoSize = true;

            // flowStats (Top Metrics)
            this.flowStats.Controls.Add(this.pnlUsers);
            this.flowStats.Controls.Add(this.pnlFinancials);
            this.flowStats.Controls.Add(this.pnlInventory);
            this.flowStats.Location = new System.Drawing.Point(20, 90);
            this.flowStats.Size = new System.Drawing.Size(960, 120);

            // Metric Card: Users
            this.pnlUsers.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.pnlUsers.Size = new System.Drawing.Size(300, 100);
            this.lblTotalUsersTitle.Text = "Total Active Users"; this.lblTotalUsersTitle.Location = new Point(15, 15);
            this.lblTotalUsers.Text = "24"; this.lblTotalUsers.Font = new Font("Segoe UI", 20, FontStyle.Bold); this.lblTotalUsers.Location = new Point(15, 40);
            this.pnlUsers.Controls.Add(this.lblTotalUsersTitle); this.pnlUsers.Controls.Add(this.lblTotalUsers);

            // Metric Card: Fin
            this.pnlFinancials.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.pnlFinancials.Size = new System.Drawing.Size(300, 100);
            this.lblFeesTitle.Text = "Fee Collection Status"; this.lblFeesTitle.Location = new Point(15, 15);
            this.lblFeesCollected.Text = "₹ 12,45,000"; this.lblFeesCollected.Font = new Font("Segoe UI", 20, FontStyle.Bold); this.lblFeesCollected.Location = new Point(15, 40);
            this.pnlFinancials.Controls.Add(this.lblFeesTitle); this.pnlFinancials.Controls.Add(this.lblFeesCollected);

            // Metric Card: Inv
            this.pnlInventory.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.pnlInventory.Size = new System.Drawing.Size(300, 100);
            this.lblInvTitle.Text = "School Assets Tracking"; this.lblInvTitle.Location = new Point(15, 15);
            this.lblInventoryStatus.Text = "85% Optimal"; this.lblInventoryStatus.Font = new Font("Segoe UI", 20, FontStyle.Bold); this.lblInventoryStatus.Location = new Point(15, 40);
            this.pnlInventory.Controls.Add(this.lblInvTitle); this.pnlInventory.Controls.Add(this.lblInventoryStatus);

            // tabControlAdmin
            this.tabControlAdmin.Controls.Add(this.tabOverview);
            this.tabControlAdmin.Controls.Add(this.tabLogs);
            this.tabControlAdmin.Location = new System.Drawing.Point(20, 230);
            this.tabControlAdmin.Size = new System.Drawing.Size(960, 350);

            this.tabOverview.Controls.Add(this.lblSystemHealth);
            this.tabOverview.Text = "System Status";
            this.lblSystemHealth.Text = "🚀 The application is running smoothly | App Version: 1.0.4 | Connection: Active";
            this.lblSystemHealth.Location = new Point(20, 20);

            this.tabLogs.Controls.Add(this.dgvLogs);
            this.tabLogs.Text = "Activity Diary";
            this.dgvLogs.Dock = DockStyle.Fill;
            this.dgvLogs.BorderStyle = BorderStyle.None;
            this.dgvLogs.BackgroundColor = Color.White;
            this.dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Global Actions
            this.btnUserMgmt.Text = "Manage Members (Teachers/Students) 👥"; this.btnUserMgmt.Location = new Point(25, 600); this.btnUserMgmt.Size = new Size(350, 45);
            this.btnUserMgmt.BackColor = Color.FromArgb(0, 123, 255); this.btnUserMgmt.ForeColor = Color.White; this.btnUserMgmt.FlatStyle = FlatStyle.Flat;
            this.btnUserMgmt.Click += new System.EventHandler(this.btnUserManagement_Click);

            this.btnSettings.Text = "App Settings ⚙️"; this.btnSettings.Location = new Point(390, 600); this.btnSettings.Size = new Size(200, 45);
            this.btnSettings.BackColor = Color.FromArgb(108, 117, 125); this.btnSettings.ForeColor = Color.White; this.btnSettings.FlatStyle = FlatStyle.Flat;
            this.btnSettings.Click += new System.EventHandler(this.btnSystemSettings_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnUserMgmt);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.flowStats);
            this.Controls.Add(this.panelTop);
            this.Name = "AdminPanelForm";
            this.Text = "Admin Command Center";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.flowStats.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.pnlFinancials.ResumeLayout(false);
            this.pnlInventory.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowStats;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Label lblTotalUsersTitle;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Panel pnlFinancials;
        private System.Windows.Forms.Label lblFeesTitle;
        private System.Windows.Forms.Label lblFeesCollected;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Label lblInvTitle;
        private System.Windows.Forms.Label lblInventoryStatus;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.Label lblSystemHealth;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnUserMgmt;
        private System.Windows.Forms.Button btnSettings;
    }
}
