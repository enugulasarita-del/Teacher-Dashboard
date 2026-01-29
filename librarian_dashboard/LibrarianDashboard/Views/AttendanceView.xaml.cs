using System.Windows;
using System.Windows.Controls;
using LibrarianDashboard.Models;

namespace LibrarianDashboard.Views
{
    public partial class AttendanceView : UserControl
    {
        public AttendanceView()
        {
            InitializeComponent();
        }

        private void BtnMarkEntry_Click(object sender, RoutedEventArgs e) 
        { 
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 var btn = sender as Button;
                 var member = btn?.DataContext as Member; // Note: Quick Action binds to Member
                 mw.MarkAttendance(member, true);
             }
        }

        private void BtnMarkExit_Click(object sender, RoutedEventArgs e) 
        { 
             // Logic slightly tricky as this binds to AttendanceRecord
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 var btn = sender as Button;
                 var record = btn?.DataContext as LibrarianDashboard.Models.AttendanceRecord;
                 if(record != null)
                 {
                      // Convert record back to Member look-up or overload MarkAttendance
                      // For now, simple hack:
                      var dummyMember = new LibrarianDashboard.Models.Member { Name = record.StudentName, RollNumber = record.RollNumber };
                      mw.MarkAttendance(dummyMember, false);
                 }
             }
        }
    }
}
