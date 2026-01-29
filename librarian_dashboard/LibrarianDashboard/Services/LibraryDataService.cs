using System;
using System.Collections.ObjectModel;
using System.Linq;
using LibrarianDashboard.Models;

namespace LibrarianDashboard.Services
{
    public class LibraryDataService
    {
        private static readonly Random _random = new Random();

        public ObservableCollection<Book> GetBooks()
        {
            return new ObservableCollection<Book>
            {
                new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", ISBN = "978-0-7432-7356-5", Category = "Fiction", Status = "Available", ShelfLocation = "A-102" },
                new Book { Title = "Clean Code", Author = "Robert C. Martin", ISBN = "978-0-13-235088-4", Category = "Technology", Status = "Issued", BorrowedBy = "Alice Johnson", DueDate = DateTime.Now.AddDays(5), ShelfLocation = "T-401" },
                new Book { Title = "Design Patterns", Author = "Erich Gamma", ISBN = "978-0-201-63361-0", Category = "Technology", Status = "Available", ShelfLocation = "T-202" },
                new Book { Title = "1984", Author = "George Orwell", ISBN = "978-0-452-28423-4", Category = "Fiction", Status = "Overdue", BorrowedBy = "Charlie Brown", DueDate = DateTime.Now.AddDays(-2), ShelfLocation = "A-305" }, 
                new Book { Title = "The Pragmatic Programmer", Author = "Andrew Hunt", ISBN = "978-0-201-61622-4", Category = "Technology", Status = "Available", ShelfLocation = "T-105" },
                new Book { Title = "Harry Potter", Author = "J.K. Rowling", ISBN = "978-0-545-01022-1", Category = "Fantasy", Status = "Issued", BorrowedBy = "Diana Prince", DueDate = DateTime.Now.AddDays(12), ShelfLocation = "K-901" }
            };
        }

        public ObservableCollection<Member> GetMembers()
        {
            return new ObservableCollection<Member>
            {
                new Member { Name = "Alice Johnson", RollNumber = "21XX1A0501", Email = "alice.210501@college.edu", Status = "Active", BooksIssued = 2 },
                new Member { Name = "Bob Smith", RollNumber = "21XX1A0502", Email = "bob.210502@college.edu", Status = "Active", BooksIssued = 0 },
                new Member { Name = "Charlie Brown", RollNumber = "22XX1A0410", Email = "charlie.220410@college.edu", Status = "Expired", BooksIssued = 1 },
                new Member { Name = "Diana Prince", RollNumber = "20XX5A1205", Email = "diana.201205@college.edu", Status = "Active", BooksIssued = 5 }
            };
        }

        public ObservableCollection<LibrarianTask> GetTasks()
        {
            return new ObservableCollection<LibrarianTask>
            {
                new LibrarianTask { Title = "Morning Restock", Description = "Move returned books to shelf T-401", IsDone = false },
                new LibrarianTask { Title = "Verify Membership", Description = "Call Charlie regarding expired ID", IsDone = false },
                new LibrarianTask { Title = "Clean Station", Description = "Organize the front desk", IsDone = true }
            };
        }

        public ObservableCollection<ActivityLog> GetRecentActivity()
        {
            return new ObservableCollection<ActivityLog>
            {
                new ActivityLog { Message = "Alice borrowed 'Clean Code'", Time = "10 mins ago", Type = "Issue" },
                new ActivityLog { Message = "New Book 'Harry Potter' added", Time = "2 hours ago", Type = "Add" },
                new ActivityLog { Message = "Charlie returned '1984'", Time = "Yesterday", Type = "Return" }
            };
        }

        public ObservableCollection<Reservation> GetReservations()
        {
            return new ObservableCollection<Reservation>
            {
                new Reservation { BookTitle = "The Great Gatsby", MemberName = "Bob Smith", RollNumber = "21XX1A0502", ReservedDate = DateTime.Now.AddDays(-1), Status = "Pending" },
                new Reservation { BookTitle = "Design Patterns", MemberName = "Alice Johnson", RollNumber = "21XX1A0501", ReservedDate = DateTime.Now.AddDays(-3), Status = "Pending" }
            };
        }

        public ObservableCollection<FineRecord> GetFines()
        {
            return new ObservableCollection<FineRecord>
            {
                new FineRecord { MemberName = "Charlie Brown", RollNumber = "22XX1A0410", BookTitle = "1984", Amount = 1.00m, DueDate = DateTime.Now.AddDays(-2), IsPaid = false },
                new FineRecord { MemberName = "Diana Prince", RollNumber = "20XX5A1205", BookTitle = "To Kill a Mockingbird", Amount = 2.50m, DueDate = DateTime.Now.AddDays(-5), IsPaid = true }
            };
        }

        public ObservableCollection<AttendanceRecord> GetAttendance()
        {
            return new ObservableCollection<AttendanceRecord>
            {
                new AttendanceRecord { StudentName = "Alice Johnson", RollNumber = "21XX1A0501", EntryTime = DateTime.Now.AddHours(-4), ExitTime = DateTime.Now.AddHours(-1) },
                new AttendanceRecord { StudentName = "Bob Smith", RollNumber = "21XX1A0502", EntryTime = DateTime.Now.AddHours(-3), ExitTime = null },
                new AttendanceRecord { StudentName = "Charlie Brown", RollNumber = "22XX1A0410", EntryTime = DateTime.Now.AddHours(-2), ExitTime = DateTime.Now.AddHours(-0.5) },
                new AttendanceRecord { StudentName = "Diana Prince", RollNumber = "20XX5A1205", EntryTime = DateTime.Now.AddHours(-5), ExitTime = DateTime.Now.AddHours(-2) }
            };
        }

        public ObservableCollection<Notice> GetNotices()
        {
            return new ObservableCollection<Notice>
            {
                new Notice { Title = "Library Closed on Republic Day", Message = "The library will remain closed on 26th Jan for Republic Day celebrations.", Date = DateTime.Today.AddDays(-1), TargetDept = null },
                new Notice { Title = "CS Final Year Project Submission", Message = "All final year CS students must submit their project documentation by Friday.", Date = DateTime.Today, TargetDept = "CS", TargetYear = 4 }
            };
        }

        public ObservableCollection<ReissueRequest> GetReissueRequests()
        {
            return new ObservableCollection<ReissueRequest>
            {
                new ReissueRequest { BookTitle = "Clean Code", MemberName = "Alice Johnson" },
                new ReissueRequest { BookTitle = "1984", MemberName = "Charlie Brown" }
            };
        }
    }
}
