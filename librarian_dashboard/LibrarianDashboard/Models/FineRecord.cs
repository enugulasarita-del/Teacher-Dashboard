using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibrarianDashboard.Models
{
    public class FineRecord : INotifyPropertyChanged
    {
        private bool _isPaid;
        private decimal _amount;

        public string MemberName { get; set; }
        public string RollNumber { get; set; }
        public string BookTitle { get; set; }
        public decimal Amount 
        { 
            get { return _amount; } 
            set { _amount = value; OnPropertyChanged(); OnPropertyChanged("AmountDisplay"); } 
        }
        public DateTime DueDate { get; set; }
        public int DaysOverdue => (DateTime.Now - DueDate).Days;
        public bool IsPaid 
        { 
            get { return _isPaid; } 
            set { _isPaid = value; OnPropertyChanged(); OnPropertyChanged("StatusDisplay"); OnPropertyChanged("StatusColor"); } 
        }

        public string AmountDisplay => $"${Amount:0.00}";
        public string StatusDisplay => IsPaid ? "Paid" : "Pending";
        public string StatusColor => IsPaid ? "#00E676" : "#FF4081";

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
