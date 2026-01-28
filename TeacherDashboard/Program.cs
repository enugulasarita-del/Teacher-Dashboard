using System;
using System.Windows.Forms;
using TeacherDashboard.Forms;

namespace TeacherDashboard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Multi-page architecture with role-based access control.
        /// Starts with LoginForm for authentication.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Changed from DashboardForm to LoginForm for authentication
            Application.Run(new LoginForm());
        }
    }
}
