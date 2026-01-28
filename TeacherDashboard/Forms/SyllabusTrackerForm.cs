using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class SyllabusTrackerForm : Form
    {
        public SyllabusTrackerForm()
        {
            InitializeComponent();
            panelTop.Visible = false;
            LoadMockData();
        }

        private void LoadMockData()
        {
            cmbCourse.Items.AddRange(new object[] { "Math 101", "Physics 202", "Chemistry 301" });
            if (cmbCourse.Items.Count > 0) cmbCourse.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;

            dgvSyllabus.Rows.Add("Math 101", "Algebra Fundamentals", "Completed", "2026-01-01", "2026-01-15");
            dgvSyllabus.Rows.Add("Math 101", "Calculus I", "In Progress", "2026-01-16", "-");
            dgvSyllabus.Rows.Add("Physics 202", "Newtonian Mechanics", "Completed", "2026-01-05", "2026-01-20");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModule.Text))
            {
                MessageBox.Show("Please enter a module name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvSyllabus.Rows.Add(cmbCourse.Text, txtModule.Text, cmbStatus.Text, DateTime.Now.ToShortDateString(), "-");
            txtModule.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSyllabus.SelectedRows.Count > 0)
            {
                var row = dgvSyllabus.SelectedRows[0];
                row.Cells[2].Value = cmbStatus.Text;
                if (cmbStatus.Text == "Completed")
                    row.Cells[4].Value = DateTime.Now.ToShortDateString();
                else
                    row.Cells[4].Value = "-";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSyllabus.SelectedRows.Count > 0)
            {
                dgvSyllabus.Rows.RemoveAt(dgvSyllabus.SelectedRows[0].Index);
            }
        }
    }
}
