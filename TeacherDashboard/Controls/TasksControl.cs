using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Controls
{
    public partial class TasksControl : UserControl
    {
        private const string PlaceholderText = "Enter a new task...";

        public TasksControl()
        {
            InitializeComponent();
            LoadMockTasks();
            InitializePlaceholder();
        }

        private void InitializePlaceholder()
        {
            txtTask.Text = PlaceholderText;
            txtTask.ForeColor = Color.Gray;
            txtTask.Enter += RemovePlaceholder;
            txtTask.Leave += SetPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtTask.Text == PlaceholderText)
            {
                txtTask.Text = "";
                txtTask.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTask.Text))
            {
                txtTask.Text = PlaceholderText;
                txtTask.ForeColor = Color.Gray;
            }
        }

        private void LoadMockTasks()
        {
            clbTasks.Items.Add("Grade Math Midterms");
            clbTasks.Items.Add("Prepare Physics Lab Equipment");
            clbTasks.Items.Add("Email Principal regarding field trip", true); // Checked
            clbTasks.Items.Add("Update Attendance Records");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text) && txtTask.Text != PlaceholderText)
            {
                clbTasks.Items.Add(txtTask.Text);
                txtTask.Text = ""; // Clear first
                // Re-apply placeholder by moving focus or manually calling SetPlaceholder if focus remains
                // Since clicking the button might keep focus on the button or return it, let's manually reset
                txtTask.Focus(); // This will trigger Enter/RemovePlaceholder, so we must be careful.
                
                // Better: Just reset to empty. If the user clicks away, Leave will trigger. 
                // If they want to type another task immediately, they are already focused.
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Iterate backwards to remove safely
            for (int i = clbTasks.Items.Count - 1; i >= 0; i--)
            {
                if (clbTasks.GetItemChecked(i))
                {
                    clbTasks.Items.RemoveAt(i);
                }
            }
        }

        public void UpdateTheme(Color themeColor)
        {
            lblHeader.ForeColor = themeColor;
            btnAdd.BackColor = themeColor;
        }
    }
}
