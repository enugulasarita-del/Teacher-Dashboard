using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibrarianDashboard.Models
{
    public class Reservation : INotifyPropertyChanged
    {
        private string _status;

        public string BookTitle { get; set; }
        public string MemberName { get; set; }
        public string RollNumber { get; set; }
        public DateTime ReservedDate { get; set; }
        public string Status 
        { 
            get { return _status; } 
            set { _status = value; OnPropertyChanged(); OnPropertyChanged("StatusColor"); } 
        }

        public string StatusColor => Status == "Pending" ? "#FFB74D" : "#00E676";
        public string ReservedDateDisplay => ReservedDate.ToString("dd MMM yyyy");

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
