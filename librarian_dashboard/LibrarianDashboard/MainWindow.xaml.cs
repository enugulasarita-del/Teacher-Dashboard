using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using LibrarianDashboard.Models;
using LibrarianDashboard.Services;

namespace LibrarianDashboard
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private readonly LibraryDataService _dataService;

        // --- DASHBOARD DATA ---
        public int TotalBooksCount => AllBooks.Count;
        public ObservableCollection<Book> IssuedBooksList { get; set; }
        public int OverdueBooksCount => OverdueBooks.Count;
        public ObservableCollection<Book> OverdueBooks { get; set; } = new ObservableCollection<Book>();
        public decimal PendingFines => 125.50m; // Mock for now
        
        // --- COLLECTIONS ---
        public ObservableCollection<Book> AllBooks { get; set; }
        public ObservableCollection<Book> FilteredBooks { get; set; } // For BooksView
        
        public ObservableCollection<Book> FilteredIssuedBooks { get; set; } // For IssuedView

        public ObservableCollection<Member> AllMembers { get; set; }
        public ObservableCollection<Member> FilteredMembers { get; set; }

        public ObservableCollection<AttendanceRecord> AttendanceRecords { get; set; }
        public ObservableCollection<AttendanceRecord> TodaysAttendance { get; set; }

        public ObservableCollection<Notice> AllNotices { get; set; }
        public ObservableCollection<ActivityLog> RecentActivities { get; set; }
        
        // --- LEADERBOARD & ANALYTICS ---
        public ObservableCollection<StudentRanking> TopReaders { get; set; } = new ObservableCollection<StudentRanking>();
        public ObservableCollection<StudentClassification> StudentClassifications { get; set; } = new ObservableCollection<StudentClassification>();
        public ObservableCollection<DeptTopper> DepartmentToppers { get; set; } = new ObservableCollection<DeptTopper>();

        public int TotalLibraryVisits { get; set; } = 12450;
        public string PeakHour { get; set; } = "11:00 AM";
        public string BusiestDay { get; set; } = "Wednesday";
        public string MostPopularPurpose { get; set; } = "Study Area";
        public double AvgDailyFootfall { get; set; } = 450;
        public ObservableCollection<FootfallDailyStat> FootfallStats { get; set; } = new ObservableCollection<FootfallDailyStat>();

        // Sidebar
        // Dependency Property "SidebarPercent" is defined below to support animation


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            _dataService = new LibraryDataService();

            InitializeData();
            
            // Set default view
            UC_Dashboard.Visibility = Visibility.Visible;
        }

        public void SetUser(string name, string role)
        {
            // Update UI with user details if we had binding for it
            // For now, we just store it or log it
            // Properties like "Welcome, {Name}" in DashboardView could bind to this.
            // Since we don't have direct bindings for User Profile in the Refactor yet, we'll just store it.
            // Ideally, update a ViewModel property that 'DashboardView' binds to.
        }

        private void InitializeData()
        {
            // Load from Service
            AllBooks = _dataService.GetBooks();
            FilteredBooks = new ObservableCollection<Book>(AllBooks); // Init filtered
            
            IssuedBooksList = new ObservableCollection<Book>(AllBooks.Where(b => b.Status == "Issued" || b.Status == "Overdue"));
            FilteredIssuedBooks = new ObservableCollection<Book>(IssuedBooksList);

            OverdueBooks = new ObservableCollection<Book>(AllBooks.Where(b => b.Status == "Overdue"));

            AllMembers = _dataService.GetMembers();
            FilteredMembers = new ObservableCollection<Member>(AllMembers);

            AttendanceRecords = _dataService.GetAttendance();
            TodaysAttendance = new ObservableCollection<AttendanceRecord>(AttendanceRecords);

            // Hook up auto-updates
            AllBooks.CollectionChanged += (s, e) => {
                OnPropertyChanged(nameof(TotalBooksCount));
                OnPropertyChanged(nameof(OverdueBooksCount));
            };
            
            AllNotices = _dataService.GetNotices();
            RecentActivities = _dataService.GetRecentActivity();

           
            // Init Analytics/Leaderboards (Mocked here for simplicity as they weren't in service fully)
            TopReaders.Add(new StudentRanking { Rank=1, Name="Ananya Sharma", Department="CS", VisitCount=45 });
            TopReaders.Add(new StudentRanking { Rank=2, Name="Vikram Rathore", Department="IT", VisitCount=42 });
            
            StudentClassifications.Add(new StudentClassification { Category="Readers", Percentage=45, Description="Issue books regularly" });
            StudentClassifications.Add(new StudentClassification { Category="Studious", Percentage=30, Description="Use Study Area" });
            
            FootfallStats.Add(new FootfallDailyStat { Day="Mon", Height=80, BarColor=Brushes.Orange });
            FootfallStats.Add(new FootfallDailyStat { Day="Tue", Height=120, BarColor=Brushes.Orange });
            FootfallStats.Add(new FootfallDailyStat { Day="Wed", Height=150, BarColor=Brushes.Orange });
            FootfallStats.Add(new FootfallDailyStat { Day="Thu", Height=100, BarColor=Brushes.Orange });
            FootfallStats.Add(new FootfallDailyStat { Day="Fri", Height=90, BarColor=Brushes.Orange });

             OnPropertyChanged(nameof(TotalBooksCount));
             OnPropertyChanged(nameof(OverdueBooksCount));
        }

        // --- NAVIGATION ---
        private void HideAllViews()
        {
            if (UC_Dashboard == null) return; // Prevent NullRef during InitializeComponent
            UC_Dashboard.Visibility = Visibility.Collapsed;
            UC_Books.Visibility = Visibility.Collapsed;
            UC_Issued.Visibility = Visibility.Collapsed;
            UC_Members.Visibility = Visibility.Collapsed;
            UC_Attendance.Visibility = Visibility.Collapsed;
            UC_Analytics.Visibility = Visibility.Collapsed;
            UC_Notices.Visibility = Visibility.Collapsed;
            UC_Leaderboards.Visibility = Visibility.Collapsed;
        }

        private void FadeInView(UIElement view)
        {
            if (view == null) return;
            view.Visibility = Visibility.Visible;
            var fade = new DoubleAnimation(0, 1, new Duration(TimeSpan.FromMilliseconds(300)));
            view.BeginAnimation(UIElement.OpacityProperty, fade);
        }

        private void Menu_Dashboard_Checked(object sender, RoutedEventArgs e) { HideAllViews(); FadeInView(UC_Dashboard); }
        private void Menu_Books_Checked(object sender, RoutedEventArgs e) { HideAllViews(); FadeInView(UC_Books); }
        private void Menu_Issued_Checked(object sender, RoutedEventArgs e) { HideAllViews(); FadeInView(UC_Issued); }
        private void Menu_Members_Checked(object sender, RoutedEventArgs e) { HideAllViews(); FadeInView(UC_Members); }
        private void Menu_Attendance_Checked(object sender, RoutedEventArgs e) { HideAllViews(); FadeInView(UC_Attendance); }
        private void Menu_Analytics_Checked(object sender, RoutedEventArgs e) { HideAllViews(); FadeInView(UC_Analytics); }
        private void Menu_Notices_Checked(object sender, RoutedEventArgs e) { HideAllViews(); FadeInView(UC_Notices); }
        private void Menu_Leaderboards_Checked(object sender, RoutedEventArgs e) { HideAllViews(); FadeInView(UC_Leaderboards); }


        // --- WINDOW CONTROLS ---
        private void CloseButton_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
        private void MinimizeButton_Click(object sender, RoutedEventArgs e) => this.WindowState = WindowState.Minimized;
        private void TopBar_MouseDown(object sender, MouseButtonEventArgs e) { if (e.ChangedButton == MouseButton.Left) this.DragMove(); }

        private bool _isSidebarOpen = true;
        public bool IsSidebarOpen
        {
            get { return _isSidebarOpen; }
            set 
            { 
                if (_isSidebarOpen != value)
                {
                    _isSidebarOpen = value;
                    OnPropertyChanged();
                    ToggleSidebarVisuals();
                }
            }
        }

        private void BtnToggleSidebar_Click(object sender, RoutedEventArgs e)
        {
            IsSidebarOpen = !IsSidebarOpen;
        }

        private void ToggleSidebarVisuals()
        {
            double targetWidth = IsSidebarOpen ? 260 : 70;

            // Animate Width
            var anim = new DoubleAnimation(targetWidth, new Duration(TimeSpan.FromMilliseconds(200))) { EasingFunction = new QuadraticEase() };
            this.BeginAnimation(SidebarPercentProperty, anim, HandoffBehavior.SnapshotAndReplace);
            
            // Note: We now rely on DataBinding for the text visibility in XAML
        }

        // Add DependencyProperty for SidebarPercent to allow Animation
        public static readonly DependencyProperty SidebarPercentProperty = DependencyProperty.Register(
            "SidebarPercent", typeof(double), typeof(MainWindow), new PropertyMetadata(260.0));


        private void ThemeToggle_Click(object sender, RoutedEventArgs e)
        {
            var cb = sender as CheckBox;
            bool isDark = cb.IsChecked ?? false;
            if (isDark)
            {
                Resources["MainBgBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#020617"));
                Resources["PanelBg"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0F172A"));
                Resources["DeepText"] = new SolidColorBrush(Colors.White);
                Resources["CardBg"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E293B"));
                Resources["CardBorderBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E293B"));
            }
            else
            {
                Resources["MainBgBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8FAFC"));
                 Resources["PanelBg"] = new SolidColorBrush(Colors.White);
                Resources["DeepText"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0F172A"));
                Resources["CardBg"] = new SolidColorBrush(Colors.White);
                Resources["CardBorderBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E2E8F0"));
            }
        }

        // --- GLOBAL ACTIONS (Called from UserControls) ---
        public void OpenAddBookOverlay()
        {
            Overlay_AddBook.Visibility = Visibility.Visible;
        }

        public void OpenAddMemberOverlay()
        {
            // Implement overlay logic
             ShowNotification("Feature coming soon", false);
        }

        private void Overlay_AddBook_MouseDown(object sender, MouseButtonEventArgs e) => Overlay_AddBook.Visibility = Visibility.Collapsed;
        private void Card_MouseDown(object sender, MouseButtonEventArgs e) => e.Handled = true;
        private void Overlay_AddBook_Close(object sender, RoutedEventArgs e) => Overlay_AddBook.Visibility = Visibility.Collapsed;

         private void BtnExportData_Click(object sender, RoutedEventArgs e)
         {
             ShowNotification("Data Exported to CSV", true);
         }

        public void PostNotice(Notice notice)
        {
             if(notice == null) return;
             AllNotices.Insert(0, notice);
             LogActivity($"Posted notice: {notice.Title}", "Add");
             ShowNotification("Notice Published", true);
        }

        public void DeleteNotice(Notice notice)
        {
             if(notice == null) return;
             AllNotices.Remove(notice);
             LogActivity($"Deleted notice: {notice.Title}", "Delete");
             ShowNotification("Notice Removed", true);
        }

        public void ShowNotification(string message, bool success)
        {
            TxtNotification.Text = message;
            Overlay_Notification.Opacity = 1;
            var fadeOut = new DoubleAnimation(1, 0, new Duration(TimeSpan.FromSeconds(2))) { BeginTime = TimeSpan.FromSeconds(2) };
            Overlay_Notification.BeginAnimation(UIElement.OpacityProperty, fadeOut);
        }

        public void LogActivity(string message, string type)
        {
            RecentActivities.Insert(0, new ActivityLog 
            { 
                Message = message, 
                Time = "Just now", 
                Type = type 
            });
        }

        // --- PUBLIC ACTIONS (Called from UserControls) ---
        
        public void SendReminder(Book book)
        {
             if (book == null) return;
             // Logic to send email would go here
             LogActivity($"Sent reminder to {book.BorrowedBy} for '{book.Title}'", "Issue");
             ShowNotification($"Email sent to {book.BorrowedBy}", true);
        }

        public void ProcessBookAction(Book book)
        {
            if (book == null) return;
            if (book.Status == "Available")
            {
                // Issue Logic (Simplified)
                book.Status = "Issued";
                book.BorrowedBy = "Student " + new Random().Next(100, 999); // Mock
                book.DueDate = DateTime.Now.AddDays(7);
                LogActivity($"Issued '{book.Title}'", "Issue");
                ShowNotification("Book Issued Successfully", true);
            }
            else
            {
                // Return Logic
                book.Status = "Available";
                book.BorrowedBy = null;
                book.DueDate = null;
                LogActivity($"Returned '{book.Title}'", "Return");
                ShowNotification("Book Returned Successfully", true);
            }
        }

        public void DeleteBook(Book book)
        {
            if (book == null) return;
            AllBooks.Remove(book);
            FilteredBooks.Remove(book); // Ensure it's removed from view too
            LogActivity($"Deleted '{book.Title}'", "Delete");
            ShowNotification("Book permanently deleted", true);
        }

        public void ProcessMemberAction(Member member, string action)
        {
            if(member == null) return;
            if(action == "Delete")
            {
                 AllMembers.Remove(member);
                 FilteredMembers.Remove(member);
                 LogActivity($"Removed member {member.Name}", "Delete");
                 ShowNotification("Member removed", true);
            }
            else if (action == "Edit")
            {
                 // Mock edit
                 ShowNotification($"Editing {member.Name}...", true);
            }
        }

        public void MarkAttendance(Member member, bool isEntry)
        {
             if(member == null) return;
             if(isEntry)
             {
                 if(TodaysAttendance.Any(a => a.RollNumber == member.RollNumber && !a.ExitTime.HasValue))
                 {
                      ShowNotification("Member already entered", false);
                      return;
                 }
                 var record = new AttendanceRecord { StudentName = member.Name, RollNumber = member.RollNumber, EntryTime = DateTime.Now };
                 TodaysAttendance.Insert(0, record);
                 LogActivity($"{member.Name} entered", "Entry");
                 ShowNotification("Entry Marked", true);
             }
             else 
             {
                 // Exit Logic would require passing the AttendanceRecord, not Member, or finding it
                 var record = TodaysAttendance.FirstOrDefault(a => a.RollNumber == member.RollNumber && !a.ExitTime.HasValue);
                 if(record != null)
                 {
                     record.ExitTime = DateTime.Now;
                     LogActivity($"{member.Name} exited", "Exit");
                     ShowNotification("Exit Marked", true);
                 }
             }
        }


        // INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
