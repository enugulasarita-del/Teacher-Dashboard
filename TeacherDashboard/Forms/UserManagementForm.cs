using System;
using System.Drawing;
using System.Windows.Forms;
using TeacherDashboard.Services;
using TeacherDashboard.Models;
using System.Linq;

namespace TeacherDashboard.Forms
{
    public partial class UserManagementForm : Form
    {
        private UserService userService;

        public UserManagementForm()
        {
            InitializeComponent();
            userService = new UserService();
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.Rows.Clear();
            var users = userService.GetAllUsers();

            foreach (var user in users)
            {
                int rowIndex = dgvUsers.Rows.Add();
                DataGridViewRow row = dgvUsers.Rows[rowIndex];
                row.Cells["colId"].Value = user.Id;
                row.Cells["colUsername"].Value = user.Username;
                row.Cells["colFullName"].Value = user.FullName;
                row.Cells["colEmail"].Value = user.Email;
                row.Cells["colRole"].Value = user.Role.ToString();
                row.Cells["colStatus"].Value = user.IsActive ? "Active" : "Inactive";
                row.Cells["colCreatedDate"].Value = user.CreatedDate.ToString("yyyy-MM-dd");
                row.Cells["colLastLogin"].Value = user.LastLoginDate?.ToString("yyyy-MM-dd HH:mm") ?? "Never";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserEditForm editForm = new UserEditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                if (userService.AddUser(editForm.EditedUser))
                {
                    MessageBox.Show("User added successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Username already exists!", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["colId"].Value);
            var user = userService.GetUserById(userId);

            if (user != null)
            {
                UserEditForm editForm = new UserEditForm(user);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    if (userService.UpdateUser(editForm.EditedUser))
                    {
                        MessageBox.Show("User updated successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user!", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["colId"].Value);
            string username = dgvUsers.SelectedRows[0].Cells["colUsername"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to delete user '{username}'?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (userService.DeleteUser(userId))
                {
                    MessageBox.Show("User deleted successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Cannot delete admin users!", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            var users = userService.GetAllUsers();

            if (!string.IsNullOrEmpty(searchText))
            {
                users = users.Where(u => 
                    u.Username.ToLower().Contains(searchText) ||
                    u.FullName.ToLower().Contains(searchText) ||
                    u.Email.ToLower().Contains(searchText)
                ).ToList();
            }

            dgvUsers.Rows.Clear();
            foreach (var user in users)
            {
                int rowIndex = dgvUsers.Rows.Add();
                DataGridViewRow row = dgvUsers.Rows[rowIndex];
                row.Cells["colId"].Value = user.Id;
                row.Cells["colUsername"].Value = user.Username;
                row.Cells["colFullName"].Value = user.FullName;
                row.Cells["colEmail"].Value = user.Email;
                row.Cells["colRole"].Value = user.Role.ToString();
                row.Cells["colStatus"].Value = user.IsActive ? "Active" : "Inactive";
                row.Cells["colCreatedDate"].Value = user.CreatedDate.ToString("yyyy-MM-dd");
                row.Cells["colLastLogin"].Value = user.LastLoginDate?.ToString("yyyy-MM-dd HH:mm") ?? "Never";
            }
        }

        private void cmbFilterRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterRole.SelectedIndex == 0) // "All Roles"
            {
                LoadUsers();
                return;
            }

            UserRole selectedRole = (UserRole)Enum.Parse(typeof(UserRole), cmbFilterRole.SelectedItem.ToString());
            var users = userService.GetUsersByRole(selectedRole);

            dgvUsers.Rows.Clear();
            foreach (var user in users)
            {
                int rowIndex = dgvUsers.Rows.Add();
                DataGridViewRow row = dgvUsers.Rows[rowIndex];
                row.Cells["colId"].Value = user.Id;
                row.Cells["colUsername"].Value = user.Username;
                row.Cells["colFullName"].Value = user.FullName;
                row.Cells["colEmail"].Value = user.Email;
                row.Cells["colRole"].Value = user.Role.ToString();
                row.Cells["colStatus"].Value = user.IsActive ? "Active" : "Inactive";
                row.Cells["colCreatedDate"].Value = user.CreatedDate.ToString("yyyy-MM-dd");
                row.Cells["colLastLogin"].Value = user.LastLoginDate?.ToString("yyyy-MM-dd HH:mm") ?? "Never";
            }
        }
    }
}
