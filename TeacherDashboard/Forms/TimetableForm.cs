using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class TimetableForm : Form
    {
        private DateTime currentDate = DateTime.Today;

        // Dummy timetable data for different days
        private Dictionary<DayOfWeek, List<ScheduleEntry>> weeklySchedule = new Dictionary<DayOfWeek, List<ScheduleEntry>>
        {
            { DayOfWeek.Monday, new List<ScheduleEntry>
                {
                    new ScheduleEntry { Time = "09:00 - 10:00", Subject = "Mathematics", Class = "10-A", Room = "Room 101" },
                    new ScheduleEntry { Time = "10:00 - 11:00", Subject = "Physics", Class = "10-B", Room = "Room 102" },
                    new ScheduleEntry { Time = "11:00 - 11:15", Subject = "BREAK", Class = "", Room = "" },
                    new ScheduleEntry { Time = "11:15 - 12:15", Subject = "Science", Class = "9-C", Room = "Lab 1" },
                    new ScheduleEntry { Time = "12:15 - 01:15", Subject = "Free Period", Class = "", Room = "" },
                    new ScheduleEntry { Time = "02:00 - 03:00", Subject = "Chemistry", Class = "11-A", Room = "Lab 2" }
                }
            },
            { DayOfWeek.Tuesday, new List<ScheduleEntry>
                {
                    new ScheduleEntry { Time = "09:00 - 10:00", Subject = "English", Class = "10-B", Room = "Room 103" },
                    new ScheduleEntry { Time = "10:00 - 11:00", Subject = "History", Class = "9-A", Room = "Room 201" },
                    new ScheduleEntry { Time = "11:00 - 11:15", Subject = "BREAK", Class = "", Room = "" },
                    new ScheduleEntry { Time = "11:15 - 12:15", Subject = "Mathematics", Class = "11-C", Room = "Room 101" }
                }
            },
            { DayOfWeek.Wednesday, new List<ScheduleEntry>
                {
                    new ScheduleEntry { Time = "09:00 - 10:00", Subject = "Computer Science", Class = "12-A", Room = "Lab 3" },
                    new ScheduleEntry { Time = "10:00 - 11:00", Subject = "Art", Class = "8-B", Room = "Art Studio" },
                    new ScheduleEntry { Time = "11:00 - 11:15", Subject = "BREAK", Class = "", Room = "" },
                    new ScheduleEntry { Time = "11:15 - 12:15", Subject = "Physics", Class = "11-B", Room = "Room 102" }
                }
            },
            { DayOfWeek.Thursday, new List<ScheduleEntry>
                {
                    new ScheduleEntry { Time = "09:00 - 10:00", Subject = "Biology", Class = "10-C", Room = "Lab 4" },
                    new ScheduleEntry { Time = "10:00 - 11:00", Subject = "Economics", Class = "12-B", Room = "Room 203" },
                    new ScheduleEntry { Time = "11:00 - 11:15", Subject = "BREAK", Class = "", Room = "" },
                    new ScheduleEntry { Time = "11:15 - 12:15", Subject = "English Literature", Class = "11-A", Room = "Room 103" }
                }
            },
            { DayOfWeek.Friday, new List<ScheduleEntry>
                {
                    new ScheduleEntry { Time = "09:00 - 10:00", Subject = "Chemistry", Class = "10-A", Room = "Lab 2" },
                    new ScheduleEntry { Time = "10:00 - 11:00", Subject = "Mathematics", Class = "9-B", Room = "Room 101" },
                    new ScheduleEntry { Time = "11:00 - 11:15", Subject = "BREAK", Class = "", Room = "" },
                    new ScheduleEntry { Time = "11:15 - 12:15", Subject = "Physical Education", Class = "All", Room = "Gym" }
                }
            },
            { DayOfWeek.Saturday, new List<ScheduleEntry>() }, // No classes on Saturday
            { DayOfWeek.Sunday, new List<ScheduleEntry>() } // No classes on Sunday
        };

        private class ScheduleEntry
        {
            public string Time { get; set; }
            public string Subject { get; set; }
            public string Class { get; set; }
            public string Room { get; set; }
        }

        public TimetableForm()
        {
            InitializeComponent();
            panelTop.Visible = false;
            btnClose.Visible = false;
            LoadTimetableData(); // Load data for the current day initially
        }

        private void LoadTimetableData()
        {
            lblCurrentDay.Text = currentDate.ToLongDateString(); // Display current date
            dgvTimetable.Rows.Clear();

            if (weeklySchedule.TryGetValue(currentDate.DayOfWeek, out List<ScheduleEntry> dailySchedule))
            {
                foreach (var entry in dailySchedule)
                {
                    dgvTimetable.Rows.Add(entry.Time, entry.Subject, entry.Class, entry.Room);
                }
            }
            else
            {
                // Display a message if no schedule for the day
                dgvTimetable.Rows.Add("", "No schedule for this day.", "", "");
            }
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(-1);
            LoadTimetableData();
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(1);
            LoadTimetableData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
