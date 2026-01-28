using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TeacherDashboard.Controls
{
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
            LoadReportData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void LoadReportData()
        {
            // Load Mock Data for Grades Chart
            chartGrades.Series["AvgGrade"].Points.Clear();
            chartGrades.Series["AvgGrade"].Points.AddXY("Math 101", 85);
            chartGrades.Series["AvgGrade"].Points.AddXY("Science 101", 78);
            chartGrades.Series["AvgGrade"].Points.AddXY("English Lit", 92);
            chartGrades.Series["AvgGrade"].Points.AddXY("Physics I", 81);
            chartGrades.Series["AvgGrade"].Points.AddXY("Chemistry", 74);

            // Style Grades Chart
            chartGrades.Series["AvgGrade"].Color = Color.FromArgb(173, 22, 37);
            chartGrades.ChartAreas[0].AxisX.Interval = 1;

            // Load Mock Data for Attendance Chart
            chartAttendance.Series["Attendance"].Points.Clear();
            DataPoint p1 = new DataPoint(0, 75);
            p1.AxisLabel = "Present";
            p1.LegendText = "Present (75%)";
            p1.Color = Color.FromArgb(46, 204, 113); // Green

            DataPoint p2 = new DataPoint(0, 15);
            p2.AxisLabel = "Absent";
            p2.LegendText = "Absent (15%)";
            p2.Color = Color.FromArgb(231, 76, 60); // Red

             DataPoint p3 = new DataPoint(0, 10);
            p3.AxisLabel = "Late";
            p3.LegendText = "Late (10%)";
            p3.Color = Color.FromArgb(243, 156, 18); // Orange

            chartAttendance.Series["Attendance"].Points.Add(p1);
            chartAttendance.Series["Attendance"].Points.Add(p2);
            chartAttendance.Series["Attendance"].Points.Add(p3);
        }

        public void UpdateTheme(Color themeColor)
        {
            lblHeader.ForeColor = themeColor;
            btnRefresh.BackColor = themeColor;
            chartGrades.Series["AvgGrade"].Color = themeColor;
        }
    }
}
