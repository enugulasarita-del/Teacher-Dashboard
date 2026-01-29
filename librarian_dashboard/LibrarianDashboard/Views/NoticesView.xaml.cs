using System.Windows;
using System.Windows.Controls;

namespace LibrarianDashboard.Views
{
    public partial class NoticesView : UserControl
    {
        public NoticesView()
        {
            InitializeComponent();
        }

        private void BtnPostNotice_Click(object sender, RoutedEventArgs e) 
        { 
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 if(string.IsNullOrWhiteSpace(TxtNoticeTitle.Text) || string.IsNullOrWhiteSpace(TxtNoticeBody.Text))
                 {
                      mw.ShowNotification("Please fill title and message", false);
                      return;
                 }
                 
                 var notice = new LibrarianDashboard.Models.Notice
                 {
                      Title = TxtNoticeTitle.Text,
                      Message = TxtNoticeBody.Text,
                      Date = System.DateTime.Now,
                      TargetDept = CmbNoticeDept.SelectedIndex > 0 ? (CmbNoticeDept.SelectedItem as ComboBoxItem).Content.ToString() : null
                      // TargetYear logic skipped for brevity
                 };
                 mw.PostNotice(notice);
                 
                 // Clear form
                 TxtNoticeTitle.Text = "";
                 TxtNoticeBody.Text = "";
                 CmbNoticeDept.SelectedIndex = 0;
             }
        }

        private void BtnDeleteNotice_Click(object sender, RoutedEventArgs e) 
        { 
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 var btn = sender as Button;
                 var notice = btn?.DataContext as LibrarianDashboard.Models.Notice;
                 mw.DeleteNotice(notice);
             }
        }
    }
}
