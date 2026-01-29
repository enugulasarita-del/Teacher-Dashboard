using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibrarianDashboard.Models
{
    public class Notice : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string TargetDept { get; set; }
        public int? TargetYear { get; set; }

        public string DateDisplay => Date.ToString("dd MMM");
        public string TargetYearDisplay => TargetYear.HasValue ? $"Year {TargetYear}" : "All Years";

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
