using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibrarianDashboard.Models
{
    public class AttendanceRecord : INotifyPropertyChanged
    {
        private DateTime? _exitTime;
        private string _status;

        public string StudentName { get; set; }
        public string RollNumber { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime 
        { 
            get => _exitTime; 
            set { _exitTime = value; OnPropertyChanged(); OnPropertyChanged("Duration"); OnPropertyChanged("Status"); } 
        }
        public DateTime Date => EntryTime.Date;
        public string Status 
        { 
            get => _status ?? (_exitTime.HasValue ? "Exited" : "Present"); 
            set { _status = value; OnPropertyChanged(); } 
        }

        public string EntryTimeDisplay => EntryTime.ToString("hh:mm tt");
        public string ExitTimeDisplay => ExitTime?.ToString("hh:mm tt") ?? "-";
        public string DateDisplay => Date.ToString("dd MMM yyyy");
        public string Duration => ExitTime.HasValue ? 
            $"{(ExitTime.Value - EntryTime).TotalHours:F1} hrs" : 
            $"{(DateTime.Now - EntryTime).TotalHours:F1} hrs";

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
