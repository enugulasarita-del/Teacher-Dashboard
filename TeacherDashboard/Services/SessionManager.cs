using TeacherDashboard.Models;

namespace TeacherDashboard.Services
{
    public static class SessionManager
    {
        public static User CurrentUser { get; set; }

        public static bool IsLoggedIn => CurrentUser != null;

        public static bool IsAdmin => CurrentUser?.Role == UserRole.Admin;

        public static bool IsTeacher => CurrentUser?.Role == UserRole.Teacher;



        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
