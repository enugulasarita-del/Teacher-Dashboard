using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics; // Added for Process.Start

namespace TeacherDashboard.Controls
{
    public partial class VacLecturesControl : UserControl
    {
        private class Lecture
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public DateTime Date { get; set; }
            public string Time { get; set; }
            public string Faculty { get; set; }
            public string Venue { get; set; }
            public string Link { get; set; }
        }

        private List<Lecture> lectures = new List<Lecture>();
        private int nextLectureId = 1;

        public VacLecturesControl()
        {
            InitializeComponent();
            LoadVacData();
            dgvVac.SelectionChanged += dgvVac_SelectionChanged; // Hook up selection changed event
        }

        private void LoadVacData()
        {
            // Clear existing dummy data and add programmatic dummy data
            lectures.Clear();
            lectures.Add(new Lecture { Id = nextLectureId++, Title = "Intro to AI", Date = DateTime.Parse("2026-01-28"), Time = "10:00 AM", Faculty = "Dr. Smith", Venue = "Auditorium", Link = "https://example.com/ai" });
            lectures.Add(new Lecture { Id = nextLectureId++, Title = "Environmental Studies", Date = DateTime.Parse("2026-01-29"), Time = "11:30 AM", Faculty = "Prof. Green", Venue = "Room 304", Link = "https://example.com/environmental" });
            lectures.Add(new Lecture { Id = nextLectureId++, Title = "Yoga and Health", Date = DateTime.Parse("2026-01-30"), Time = "07:00 AM", Faculty = "Mrs. Sharma", Venue = "Gym", Link = "https://example.com/yoga" });
            RefreshLecturesGrid();
        }

        private void RefreshLecturesGrid()
        {
            dgvVac.Rows.Clear();
            foreach (var lecture in lectures.OrderBy(l => l.Date).ThenBy(l => l.Time))
            {
                dgvVac.Rows.Add(lecture.Id, lecture.Title, lecture.Date.ToShortDateString(), lecture.Time, lecture.Faculty, lecture.Venue, lecture.Link);
            }
        }

        private void ClearInputFields()
        {
            txtLectureTitle.Clear();
            dtpLectureDate.Value = DateTime.Today;
            txtLectureTime.Clear();
            txtFaculty.Clear();
            txtVenue.Clear();
            txtLectureLink.Clear();
        }

        private void dgvVac_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVac.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvVac.SelectedRows[0];
                // Using TryParse to handle potential formatting issues, although unlikely with current data
                if (int.TryParse(selectedRow.Cells[0].Value?.ToString(), out int id))
                {
                    Lecture selectedLecture = lectures.FirstOrDefault(l => l.Id == id);
                    if (selectedLecture != null)
                    {
                        txtLectureTitle.Text = selectedLecture.Title;
                        dtpLectureDate.Value = selectedLecture.Date;
                        txtLectureTime.Text = selectedLecture.Time;
                        txtFaculty.Text = selectedLecture.Faculty;
                        txtVenue.Text = selectedLecture.Venue;
                        txtLectureLink.Text = selectedLecture.Link;
                    }
                }
            }
            else
            {
                ClearInputFields();
            }
        }

        private void btnAddLecture_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLectureTitle.Text) || string.IsNullOrWhiteSpace(txtFaculty.Text) ||
                string.IsNullOrWhiteSpace(txtLectureTime.Text) || string.IsNullOrWhiteSpace(txtVenue.Text))
            {
                MessageBox.Show("Please fill in all lecture details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lectures.Add(new Lecture
            {
                Id = nextLectureId++,
                Title = txtLectureTitle.Text,
                Date = dtpLectureDate.Value.Date,
                Time = txtLectureTime.Text,
                Faculty = txtFaculty.Text,
                Venue = txtVenue.Text,
                Link = txtLectureLink.Text
            });
            RefreshLecturesGrid();
            ClearInputFields();
        }

        private void btnEditLecture_Click(object sender, EventArgs e)
        {
            if (dgvVac.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a lecture to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLectureTitle.Text) || string.IsNullOrWhiteSpace(txtFaculty.Text) ||
                string.IsNullOrWhiteSpace(txtLectureTime.Text) || string.IsNullOrWhiteSpace(txtVenue.Text))
            {
                MessageBox.Show("Please fill in all lecture details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dgvVac.SelectedRows[0];
            if (int.TryParse(selectedRow.Cells[0].Value?.ToString(), out int idToEdit))
            {
                Lecture lectureToEdit = lectures.FirstOrDefault(l => l.Id == idToEdit);
                if (lectureToEdit != null)
                {
                    lectureToEdit.Title = txtLectureTitle.Text;
                    lectureToEdit.Date = dtpLectureDate.Value.Date;
                    lectureToEdit.Time = txtLectureTime.Text;
                    lectureToEdit.Faculty = txtFaculty.Text;
                    lectureToEdit.Venue = txtVenue.Text;
                    lectureToEdit.Link = txtLectureLink.Text;
                    RefreshLecturesGrid();
                    ClearInputFields();
                }
            }
        }

        private void btnDeleteLecture_Click(object sender, EventArgs e)
        {
            if (dgvVac.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a lecture to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dgvVac.SelectedRows[0];
            if (int.TryParse(selectedRow.Cells[0].Value?.ToString(), out int idToDelete))
            {
                lectures.RemoveAll(l => l.Id == idToDelete);
                RefreshLecturesGrid();
                ClearInputFields();
            }
        }

        private void dgvVac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVac.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                string link = dgvVac.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                if (!string.IsNullOrEmpty(link))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Could not open link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
