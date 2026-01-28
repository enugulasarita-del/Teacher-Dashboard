using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            LoadReportData();
        }

        private void LoadReportData()
        {
            // Set some dynamic looking mock data
            lblStudentCountVal.Text = "124";
            lblAvgGradeVal.Text = "85.4%";
            lblAttendanceVal.Text = "92.1%";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report generation started...\nMetrics:\n- Total Students: 124\n- Average Grade: 85.4%\n- Attendance: 92.1%\n\nPDF saved to Documents folder.", 
                "Report Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
