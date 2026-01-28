using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class StudentPerformanceForm : Form
    {
        public StudentPerformanceForm()
        {
            InitializeComponent();
            LoadMockData();
        }

        private void LoadMockData()
        {
            // Mock Students
            cmbStudent.Items.Add("RN-2026001 | Alice Smith");
            cmbStudent.Items.Add("RN-2026002 | Bob Johnson");
            cmbStudent.Items.Add("RN-2026003 | Charlie Brown");
            cmbStudent.Items.Add("RN-2026004 | Diana Prince");
            if (cmbStudent.Items.Count > 0) cmbStudent.SelectedIndex = 0;

            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;

            // Mock Records
            dgvPerformance.Rows.Add(DateTime.Now.AddDays(-5).ToShortDateString(), "RN-2026001", "Alice Smith", "Behavior", "Exhibited excellent leadership during group project.");
            dgvPerformance.Rows.Add(DateTime.Now.AddDays(-3).ToShortDateString(), "RN-2026002", "Bob Johnson", "Missing Homework", "Did not submit Math worksheet chapter 3.");
            dgvPerformance.Rows.Add(DateTime.Now.AddDays(-1).ToShortDateString(), "RN-2026004", "Diana Prince", "Participation", "Volunteered for class presentation.");
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNote.Text))
            {
                MessageBox.Show("Please enter a note content.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullSelection = cmbStudent.SelectedItem?.ToString() ?? " | ";
            string[] parts = fullSelection.Split('|');
            string rollNo = parts[0].Trim();
            string studentName = parts.Length > 1 ? parts[1].Trim() : "";

            dgvPerformance.Rows.Add(
                dtpDate.Value.ToShortDateString(),
                rollNo,
                studentName,
                cmbCategory.Text,
                txtNote.Text
            );

            txtNote.Clear();
            MessageBox.Show("Performance note added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "StudentPerformanceReport.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Header
                        sw.WriteLine("Date,RollNo,Student,Category,Note");

                        // Rows
                        foreach (DataGridViewRow row in dgvPerformance.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string date = row.Cells[0].Value?.ToString() ?? "";
                                string roll = row.Cells[1].Value?.ToString() ?? "";
                                string student = row.Cells[2].Value?.ToString() ?? "";
                                string category = row.Cells[3].Value?.ToString() ?? "";
                                string note = "\"" + (row.Cells[4].Value?.ToString() ?? "").Replace("\"", "\"\"") + "\""; // CSV escape

                                sw.WriteLine($"{date},{roll},{student},{category},{note}");
                            }
                        }
                    }
                    MessageBox.Show("Data exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
