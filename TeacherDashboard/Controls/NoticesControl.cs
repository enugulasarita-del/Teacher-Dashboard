using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq; // Added for LINQ operations

namespace TeacherDashboard.Controls
{
    public partial class NoticesControl : UserControl
    {
        private class Notice
        {
            public DateTime Date { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
        }

        private List<Notice> notices = new List<Notice>();

        public NoticesControl()
        {
            InitializeComponent();
            LoadNotices();
            dgvNotices.SelectionChanged += dgvNotices_SelectionChanged; // Hook up selection changed event
        }

        private void LoadNotices()
        {
            // Clear existing dummy data from designer and add programmatic dummy data
            notices.Clear();
            notices.Add(new Notice { Date = DateTime.Parse("2026-01-26"), Title = "Republic Day Celebration", Content = "All staff and students to assemble at 8 AM." });
            notices.Add(new Notice { Date = DateTime.Parse("2026-02-01"), Title = "Math Olympiad", Content = "Registration closes on 30th Jan." });
            notices.Add(new Notice { Date = DateTime.Parse("2026-02-10"), Title = "Annual Science Fair", Content = "Project submissions due by 5th Feb." });
            notices.Add(new Notice { Date = DateTime.Parse("2026-02-15"), Title = "Mid-Term Exams", Content = "Schedule to be released soon." });
            RefreshNoticesGrid();
        }

        private void RefreshNoticesGrid()
        {
            dgvNotices.Rows.Clear();
            foreach (var notice in notices.OrderByDescending(n => n.Date))
            {
                dgvNotices.Rows.Add(notice.Date.ToShortDateString(), notice.Title, notice.Content);
            }
        }

        private void ClearInputFields()
        {
            dtpNoticeDate.Value = DateTime.Today;
            txtNoticeTitle.Clear();
            txtNoticeContent.Clear();
        }

        private void dgvNotices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNotices.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNotices.SelectedRows[0];
                dtpNoticeDate.Value = DateTime.Parse(selectedRow.Cells[0].Value.ToString());
                txtNoticeTitle.Text = selectedRow.Cells[1].Value.ToString();
                txtNoticeContent.Text = selectedRow.Cells[2].Value.ToString();
            }
            else
            {
                ClearInputFields();
            }
        }

        private void btnAddNotice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoticeTitle.Text) || string.IsNullOrWhiteSpace(txtNoticeContent.Text))
            {
                MessageBox.Show("Please fill in all notice details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            notices.Add(new Notice { Date = dtpNoticeDate.Value.Date, Title = txtNoticeTitle.Text, Content = txtNoticeContent.Text });
            RefreshNoticesGrid();
            ClearInputFields();
        }

        private void btnEditNotice_Click(object sender, EventArgs e)
        {
            if (dgvNotices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a notice to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNoticeTitle.Text) || string.IsNullOrWhiteSpace(txtNoticeContent.Text))
            {
                MessageBox.Show("Please fill in all notice details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dgvNotices.SelectedRows[0];
            DateTime originalDate = DateTime.Parse(selectedRow.Cells[0].Value.ToString());
            string originalTitle = selectedRow.Cells[1].Value.ToString();

            Notice noticeToEdit = notices.FirstOrDefault(n => n.Date.Date == originalDate.Date && n.Title == originalTitle);
            if (noticeToEdit != null)
            {
                noticeToEdit.Date = dtpNoticeDate.Value.Date;
                noticeToEdit.Title = txtNoticeTitle.Text;
                noticeToEdit.Content = txtNoticeContent.Text;
                RefreshNoticesGrid();
                ClearInputFields();
            }
        }

        private void btnDeleteNotice_Click(object sender, EventArgs e)
        {
            if (dgvNotices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a notice to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dgvNotices.SelectedRows[0];
            DateTime dateToDelete = DateTime.Parse(selectedRow.Cells[0].Value.ToString());
            string titleToDelete = selectedRow.Cells[1].Value.ToString();

            notices.RemoveAll(n => n.Date.Date == dateToDelete.Date && n.Title == titleToDelete);
            RefreshNoticesGrid();
            ClearInputFields();
        }

        public void UpdateTheme(System.Drawing.Color themeColor)
        {
            dgvNotices.ColumnHeadersDefaultCellStyle.BackColor = themeColor;
            dgvNotices.Invalidate(); // Redraw the DataGridView to apply the new style
        }
    }
}
