using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LibrarianDashboard.Models
{
    public class Member : INotifyPropertyChanged
    {
        private string _name;
        private string _email;
        private string _status;
        private int _booksIssued;

        public string RollNumber { get; set; }
        
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(); } }
        public string Email { get { return _email; } set { _email = value; OnPropertyChanged(); } }
        public string Status { get { return _status; } set { _status = value; OnPropertyChanged(); } }
        public int BooksIssued { get { return _booksIssued; } set { _booksIssued = value; OnPropertyChanged(); } }

        public ObservableCollection<string> BorrowingHistory { get; set; } = new ObservableCollection<string>();
        public string HistorySummary => BorrowingHistory.Count > 0 ? string.Join(", ", BorrowingHistory.Take(3)) + (BorrowingHistory.Count > 3 ? "..." : "") : "No history";

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
