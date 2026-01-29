using System.Windows;
using System.Windows.Controls;

namespace LibrarianDashboard.Views
{
    public partial class BooksView : UserControl
    {
        public BooksView()
        {
            InitializeComponent();
        }

        private void BtnOpenAddBook_Click(object sender, RoutedEventArgs e)
        {
             if (Window.GetWindow(this) is MainWindow mw) mw.OpenAddBookOverlay(); 
        }

        private void BtnEditBook_Click(object sender, RoutedEventArgs e) 
        { 
             if (Window.GetWindow(this) is MainWindow mw) mw.ShowNotification("Edit Book coming soon", false);
        }

        private void BtnDeleteBook_Click(object sender, RoutedEventArgs e) 
        { 
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 var btn = sender as Button;
                 var book = btn?.DataContext as LibrarianDashboard.Models.Book;
                 mw.DeleteBook(book);
             }
        }

        private void BtnAction_Click(object sender, RoutedEventArgs e) 
        { 
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 var btn = sender as Button;
                 var book = btn?.DataContext as LibrarianDashboard.Models.Book;
                 mw.ProcessBookAction(book);
             }
        }
    }
}
