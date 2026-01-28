using System;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            // Copy initialization logic from SettingsControl.cs
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add all methods from SettingsControl.cs here
    }
}
