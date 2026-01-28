using System;
using System.Drawing;
using System.Windows.Forms;
using TeacherDashboard.Services;

namespace TeacherDashboard.Forms
{
    public partial class LoginForm : Form
    {
        private UserService userService;

        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = userService.Authenticate(username, password);

            if (user != null)
            {
                SessionManager.CurrentUser = user;
                MessageBox.Show($"Welcome, {user.FullName}!", "Login Successful", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the main dashboard
                MainDashboardForm dashboard = new MainDashboardForm();
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void linkShowPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            linkShowPassword.Text = txtPassword.UseSystemPasswordChar ? "Show Password" : "Hide Password";
        }
    }
}
