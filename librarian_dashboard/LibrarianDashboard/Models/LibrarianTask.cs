using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibrarianDashboard.Models
{
    public class LibrarianTask : INotifyPropertyChanged
    {
        private bool _isDone;
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone 
        { 
            get { return _isDone; } 
            set { _isDone = value; OnPropertyChanged(); } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
