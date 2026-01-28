using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class NoticesForm : Form
    {
        private class Notice
        {
            public DateTime Date { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
        }

        private List<Notice> notices = new List<Notice>();

        public NoticesForm()
        {
            InitializeComponent();
            panelTop.Visible = false;
            btnClose.Visible = false;
            LoadNotices();
        }

        private void LoadNotices()
        {
            // Clear existing data and add dummy data
            notices.Clear();
            notices.Add(new Notice { Date = DateTime.Parse("2026-01-26"), Title = "Republic Day Celebration", Content = "All faculty and staff to assemble at 8 AM for the flag hoisting." });
            notices.Add(new Notice { Date = DateTime.Parse("2026-02-05"), Title = "Industrial Visit - TY BScIT", Content = "Registration for the Bangalore industrial visit closes tomorrow." });
            notices.Add(new Notice { Date = DateTime.Parse("2026-02-12"), Title = "Project Viva Voce Schedule", Content = "Black Book submissions due by end of this week." });
            notices.Add(new Notice { Date = DateTime.Parse("2026-02-20"), Title = "Semester End Examinations", Content = "Hall tickets will be distributed in the department office." });
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

            if (MessageBox.Show("Are you sure you want to delete this notice?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dgvNotices.SelectedRows[0];
                DateTime dateToDelete = DateTime.Parse(selectedRow.Cells[0].Value.ToString());
                string titleToDelete = selectedRow.Cells[1].Value.ToString();

                notices.RemoveAll(n => n.Date.Date == dateToDelete.Date && n.Title == titleToDelete);
                RefreshNoticesGrid();
                ClearInputFields();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
