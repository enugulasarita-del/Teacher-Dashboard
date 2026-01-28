using System;
using System.Collections.Generic;
using System.Linq;
using TeacherDashboard.Models;

namespace TeacherDashboard.Services
{
    public class UserService
    {
        private static List<User> users = new List<User>();
        private static int nextId = 1;

        static UserService()
        {
            // Initialize with default users
            users.Add(new User
            {
                Id = nextId++,
                Username = "admin",
                Password = "admin123",
                FullName = "System Administrator",
                Email = "admin@vsit.edu",
                Role = UserRole.Admin,
                IsActive = true
            });

            users.Add(new User
            {
                Id = nextId++,
                Username = "teacher",
                Password = "teacher123",
                FullName = "John Doe",
                Email = "john.doe@vsit.edu",
                Role = UserRole.Teacher,
                IsActive = true
            });

            // Student user removed

        }

        public User Authenticate(string username, string password)
        {
            var user = users.FirstOrDefault(u => 
                u.Username == username && 
                u.Password == password && 
                u.IsActive);

            if (user != null)
            {
                user.LastLoginDate = DateTime.Now;
            }

            return user;
        }

        public List<User> GetAllUsers()
        {
            return users.ToList();
        }

        public User GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }

        public bool AddUser(User user)
        {
            if (users.Any(u => u.Username == user.Username))
                return false;

            user.Id = nextId++;
            user.CreatedDate = DateTime.Now;
            users.Add(user);
            return true;
        }

        public bool UpdateUser(User user)
        {
            var existingUser = users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser == null)
                return false;

            // Check if username is being changed to an existing username
            if (existingUser.Username != user.Username && 
                users.Any(u => u.Username == user.Username))
                return false;

            existingUser.Username = user.Username;
            existingUser.Password = user.Password;
            existingUser.FullName = user.FullName;
            existingUser.Email = user.Email;
            existingUser.Role = user.Role;
            existingUser.IsActive = user.IsActive;

            return true;
        }

        public bool DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null || user.Role == UserRole.Admin)
                return false; // Don't allow deleting admin users

            users.Remove(user);
            return true;
        }

        public List<User> GetUsersByRole(UserRole role)
        {
            return users.Where(u => u.Role == role).ToList();
        }
    }
}
