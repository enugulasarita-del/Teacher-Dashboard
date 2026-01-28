using System;
using System.Windows.Forms;
using TeacherDashboard.Models;

namespace TeacherDashboard.Forms
{
    public partial class UserEditForm : Form
    {
        public User EditedUser { get; private set; }

        public UserEditForm() : this(null)
        {
        }

        public UserEditForm(User user)
        {
            InitializeComponent();
            
            if (user != null)
            {
                EditedUser = user;
                LoadUserData();
                this.Text = "Edit User";
            }
            else
            {
                EditedUser = new User();
                this.Text = "Add New User";
            }

            // Populate role combo box
            cmbRole.Items.Clear();
            cmbRole.Items.Add(UserRole.Admin.ToString());
            cmbRole.Items.Add(UserRole.Teacher.ToString());

        }

        private void LoadUserData()
        {
            txtUsername.Text = EditedUser.Username;
            txtPassword.Text = EditedUser.Password;
            txtFullName.Text = EditedUser.FullName;
            txtEmail.Text = EditedUser.Email;
            cmbRole.SelectedItem = EditedUser.Role.ToString();
            chkIsActive.Checked = EditedUser.IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required!", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required!", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required!", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role!", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return;
            }

            // Save data
            EditedUser.Username = txtUsername.Text.Trim();
            EditedUser.Password = txtPassword.Text;
            EditedUser.FullName = txtFullName.Text.Trim();
            EditedUser.Email = txtEmail.Text.Trim();
            EditedUser.Role = (UserRole)Enum.Parse(typeof(UserRole), cmbRole.SelectedItem.ToString());
            EditedUser.IsActive = chkIsActive.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
