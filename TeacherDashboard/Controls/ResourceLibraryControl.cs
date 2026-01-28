using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Controls
{
    public partial class ResourceLibraryControl : UserControl
    {
        public ResourceLibraryControl()
        {
            InitializeComponent();
            LoadMockData();
        }

        private void LoadMockData()
        {
            dgvResources.Rows.Add("Syllabus_Math101.pdf", "PDF", "1.2 MB", "2026-01-10");
            dgvResources.Rows.Add("Lecture1_Algebra.pptx", "PPTX", "5.4 MB", "2026-01-12");
            dgvResources.Rows.Add("Homework_Week2.docx", "DOCX", "0.5 MB", "2026-01-15");
            dgvResources.Rows.Add("Physics_Lab_Manual.pdf", "PDF", "3.0 MB", "2026-01-20");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String fileName = System.IO.Path.GetFileName(ofd.FileName);
                String ext = System.IO.Path.GetExtension(ofd.FileName).ToUpper().Replace(".", "");
                String size = "2.1 MB"; // Mock size
                dgvResources.Rows.Add(fileName, ext, size, DateTime.Now.ToShortDateString());
                MessageBox.Show("File uploaded successfully to the library!", "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvResources.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this resource?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dgvResources.Rows.RemoveAt(dgvResources.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a resource to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void UpdateTheme(Color themeColor)
        {
            lblHeader.ForeColor = themeColor;
            dgvResources.ColumnHeadersDefaultCellStyle.BackColor = themeColor;
            btnUpload.BackColor = themeColor;
            btnDelete.BackColor = themeColor;
        }
    }
}
