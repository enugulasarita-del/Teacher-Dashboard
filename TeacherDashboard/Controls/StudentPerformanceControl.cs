using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TeacherDashboard.Controls
{
    public partial class StudentPerformanceControl : UserControl
    {
        public StudentPerformanceControl()
        {
            InitializeComponent();
            LoadMockData();
        }

        private void LoadMockData()
        {
            // Mock Students
            cmbStudent.Items.Add("Alice Smith");
            cmbStudent.Items.Add("Bob Johnson");
            cmbStudent.Items.Add("Charlie Brown");
            cmbStudent.Items.Add("Diana Prince");
            if (cmbStudent.Items.Count > 0) cmbStudent.SelectedIndex = 0;

            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;

            // Mock Records
            dgvPerformance.Rows.Add(DateTime.Now.AddDays(-5).ToShortDateString(), "Alice Smith", "Behavior", "Exhibited excellent leadership during group project.");
            dgvPerformance.Rows.Add(DateTime.Now.AddDays(-3).ToShortDateString(), "Bob Johnson", "Missing Homework", "Did not submit Math worksheet chapter 3.");
            dgvPerformance.Rows.Add(DateTime.Now.AddDays(-1).ToShortDateString(), "Diana Prince", "Participation", "Volunteered for class presentation.");
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNote.Text))
            {
                MessageBox.Show("Please enter a note content.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvPerformance.Rows.Add(
                dtpDate.Value.ToShortDateString(),
                cmbStudent.Text,
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
                        sw.WriteLine("Date,Student,Category,Note");

                        // Rows
                        foreach (DataGridViewRow row in dgvPerformance.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string date = row.Cells[0].Value?.ToString() ?? "";
                                string student = row.Cells[1].Value?.ToString() ?? "";
                                string category = row.Cells[2].Value?.ToString() ?? "";
                                string note = "\"" + (row.Cells[3].Value?.ToString() ?? "").Replace("\"", "\"\"") + "\""; // CSV escape

                                sw.WriteLine($"{date},{student},{category},{note}");
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

        public void UpdateTheme(Color themeColor)
        {
            dgvPerformance.ColumnHeadersDefaultCellStyle.BackColor = themeColor;
            btnAddNote.BackColor = themeColor;
            lblHeader.ForeColor = themeColor;
        }
    }
}
