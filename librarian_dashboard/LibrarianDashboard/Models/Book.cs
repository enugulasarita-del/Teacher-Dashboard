using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibrarianDashboard.Models
{
    public class Book : INotifyPropertyChanged
    {
        private string _status;
        private string _title; 
        private string _author;
        private string _category;
        private string _borrowedBy;
        private DateTime? _dueDate;

        public string Title { get { return _title; } set { _title = value; OnPropertyChanged(); } }
        public string Author { get { return _author; } set { _author = value; OnPropertyChanged(); } }
        public string ISBN { get; set; }
        public string Category { get { return _category; } set { _category = value; OnPropertyChanged(); } }
        public string ShelfLocation { get; set; }
        public string Condition { get; set; } // Excellent, Good, Fair, Damaged
        
        public string BorrowedBy { get { return _borrowedBy; } set { _borrowedBy = value; OnPropertyChanged(); } }
        public DateTime? DueDate { get { return _dueDate; } set { _dueDate = value; OnPropertyChanged(); OnPropertyChanged("DueDateDisplay"); OnPropertyChanged("FineDisplay"); } }

        public string DueDateDisplay => DueDate.HasValue ? DueDate.Value.ToString("dd MMM yyyy") : "-";

        public string FineDisplay 
        {
            get
            {
                 if(Status == "Overdue" || (DueDate.HasValue && DateTime.Now > DueDate.Value))
                 {
                      int days = (DateTime.Now - DueDate.Value).Days;
                      if(days > 0) return $"${(days * 0.50):0.00} Fine";
                 }
                 return "No Fine";
            }
        }

        public string Status 
        { 
            get { return _status; } 
            set { _status = value; OnPropertyChanged(); OnPropertyChanged("ActionLabel"); OnPropertyChanged("ActionColor"); OnPropertyChanged("FineDisplay"); } 
        }

        public string ActionLabel => Status == "Available" ? "Issue" : "Return";
        public string ActionColor => Status == "Available" ? "#B91C1C" : "#EF4444";

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
