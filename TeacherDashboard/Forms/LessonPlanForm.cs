using System;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class LessonPlanForm : Form
    {
        public LessonPlanForm()
        {
            InitializeComponent();
            panelTop.Visible = false;
            LoadMockData();
        }

        private void LoadMockData()
        {
            dgvPlans.Rows.Add(DateTime.Now.ToShortDateString(), "Quantum Physics", "Understand wave-particle duality", "45 mins");
            dgvPlans.Rows.Add(DateTime.Now.AddDays(1).ToShortDateString(), "Thermodynamics", "Intro to Law of Entropy", "60 mins");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTopic.Text)) return;
            dgvPlans.Rows.Add(DateTime.Now.ToShortDateString(), txtTopic.Text, txtObjective.Text, "60 mins");
            txtTopic.Clear();
            txtObjective.Clear();
        }
    }
}
