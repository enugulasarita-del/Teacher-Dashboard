using System.Windows;
using System.Windows.Controls;

namespace LibrarianDashboard.Views
{
    public partial class IssuedBooksView : UserControl
    {
        public IssuedBooksView()
        {
            InitializeComponent();
        }

        private void BtnAction_Click(object sender, RoutedEventArgs e)
        {
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 var btn = sender as Button;
                 var book = btn?.DataContext as LibrarianDashboard.Models.Book;
                 mw.ProcessBookAction(book); // Re-use ProcessBookAction which handles return
             }
        }
    }
}
