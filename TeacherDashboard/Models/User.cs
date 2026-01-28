using System;

namespace TeacherDashboard.Models
{
    public enum UserRole
    {
        Admin,
        Teacher
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public User()
        {
            IsActive = true;
            CreatedDate = DateTime.Now;
        }
    }
}
