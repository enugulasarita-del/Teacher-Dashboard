using System.Windows;
using System.Windows.Controls;

namespace LibrarianDashboard.Views
{
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Forward to Main Window or handle via ViewModel command
            // For now, simpler refactor:
            if (Window.GetWindow(this) is MainWindow mw)
            {
                 // Filter logic not fully implemented in MW yet for global search, 
                 // but we can at least log or try.
                 // mw.FilterGlobal(TxtDashSearch.Text); 
            }
        }

        private void BtnOpenAddBook_Click(object sender, RoutedEventArgs e)
        {
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 mw.OpenAddBookOverlay(); 
             }
        }

        private void BtnOpenAddMember_Click(object sender, RoutedEventArgs e)
        {
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 mw.OpenAddMemberOverlay(); 
             }
        }

        private void BtnSendReminder_Click(object sender, RoutedEventArgs e)
        {
             // This event logic needs to be handled. 
             // Ideally bind Command in ViewModel.
             // For refactor, we can route it up.
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 var btn = sender as Button;
                 var book = btn?.DataContext as LibrarianDashboard.Models.Book;
                 if (book != null) mw.SendReminder(book);
             }
        }
    }
}
