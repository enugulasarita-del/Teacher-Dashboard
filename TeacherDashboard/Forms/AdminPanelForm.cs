using System;
using System.Drawing;
using System.Windows.Forms;
using TeacherDashboard.Services;

namespace TeacherDashboard.Forms
{
    public partial class AdminPanelForm : Form
    {
        private UserService userService;

        public AdminPanelForm()
        {
            InitializeComponent();
            userService = new UserService();
            LoadAdminDashboard();
        }

        private void LoadAdminDashboard()
        {
            // Load User Stats
            var allUsers = userService.GetAllUsers();
            lblTotalUsers.Text = allUsers.Count.ToString();

            // Mock Audit Logs
            dgvLogs.Columns.Add("Time", "Timestamp");
            dgvLogs.Columns.Add("User", "Admin User");
            dgvLogs.Columns.Add("Action", "Operation Taken");
            dgvLogs.Columns.Add("Status", "Status");

            dgvLogs.Rows.Add(DateTime.Now.AddMinutes(-5).ToString("T"), "Admin", "User RN-2026001 Created", "SUCCESS");
            dgvLogs.Rows.Add(DateTime.Now.AddHours(-1).ToString("T"), "Systems", "Automatic DB Backup initiated", "COMPLETED");
            dgvLogs.Rows.Add(DateTime.Now.AddHours(-2).ToString("T"), "Admin", "Fee structure Updated", "SUCCESS");
            dgvLogs.Rows.Add(DateTime.Now.AddDays(-1).ToString("T"), "Security", "Unauthorized login attempt blocked", "ALERT");

            // Mock Values for new cards
            lblFeesCollected.Text = "₹ 12,45,000";
            lblInventoryStatus.Text = "85% Optimal";
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userMgmt = new UserManagementForm();
            userMgmt.ShowDialog();
            var allUsers = userService.GetAllUsers();
            lblTotalUsers.Text = allUsers.Count.ToString();
        }

        private void btnSystemSettings_Click(object sender, EventArgs e)
        {
            SystemSettingsForm settings = new SystemSettingsForm();
            settings.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
