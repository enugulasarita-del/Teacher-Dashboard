using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class TasksForm : Form
    {
        private const string PlaceholderText = "Enter a new task...";

        public TasksForm()
        {
            InitializeComponent();
            InitializePlaceholder();
            LoadMockTasks();
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
            clbTasks.Items.Add("Email Principal regarding field trip", CheckState.Checked);
            clbTasks.Items.Add("Update Attendance Records");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text) && txtTask.Text != PlaceholderText)
            {
                clbTasks.Items.Add(txtTask.Text);
                txtTask.Text = "";
                txtTask.Focus(); // Will trigger remove placeholder logic? No, focus stays.
                // Reset placeholder if focus is lost?
                // Logic: 
                // 1. Text becomes "".
                // 2. If focus remains, it stays empty (ready for next task). 
                // 3. If user clicks away, SetPlaceholder runs.
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
