using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using LibrarianDashboard.Models;

namespace LibrarianDashboard.Views
{
    public partial class MembersView : UserControl
    {
        public MembersView()
        {
            InitializeComponent();
        }

        private void BtnOpenAddMember_Click(object sender, RoutedEventArgs e)
        {
             if (Window.GetWindow(this) is MainWindow mw) mw.OpenAddMemberOverlay(); 
        }

        private void BtnShowIdCard_Click(object sender, RoutedEventArgs e)
        {
             var button = sender as Button;
             var member = button.DataContext as Member;
             if (member == null) return;
             
             // Populate Card
             TxtCardName.Text = member.Name.ToUpper();
             TxtCardID.Text = "ROLL NO: " + member.RollNumber;
             TxtCardRole.Text = "COLLEGE STUDENT";
             
             // Show Overlay (Internal)
             Overlay_MemberCard.Visibility = Visibility.Visible;
        }

        private void OverlayCard_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Overlay_MemberCard.Visibility = Visibility.Collapsed;
        }

        private void Card_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            e.Handled = true; // Prevent closing when clicking card
        }

        private void BtnPrintCard_Click(object sender, RoutedEventArgs e)
        {
            // Simulate Print
            Overlay_MemberCard.Visibility = Visibility.Collapsed;
        }

        private void BtnEditMember_Click(object sender, RoutedEventArgs e) 
        { 
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 var btn = sender as Button;
                 var member = btn?.DataContext as Member;
                 mw.ProcessMemberAction(member, "Edit");
             }
        }

        private void BtnDeleteMember_Click(object sender, RoutedEventArgs e) 
        { 
             if (Window.GetWindow(this) is MainWindow mw)
             {
                 var btn = sender as Button;
                 var member = btn?.DataContext as Member;
                 mw.ProcessMemberAction(member, "Delete");
             }
        }
    }
}
