using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace LibrarianDashboard
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            StartSplashSequence();
        }

        private async void StartSplashSequence()
        {
            // 1. Wait for splash
            await Task.Delay(2500);

            // 2. Fade Out Splash
            var fadeOut = (Storyboard)FindResource("FadeOut");
            fadeOut.Begin(SplashGrid);

            // 3. Fade In Login
            var fadeIn = (Storyboard)FindResource("FadeIn");
            LoginGrid.Visibility = Visibility.Visible;
            fadeIn.Begin(LoginGrid);

            // 4. Hide Splash completely after animation
            await Task.Delay(500);
            SplashGrid.Visibility = Visibility.Collapsed;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Simple validation for demo
            if (string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtPass.Password))
            {
                MessageBox.Show("Please enter valid credentials.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Extract Name from Email (e.g. admin@vsit -> "Admin") or just use a standard one
            string userName = "Librarian Admin";
            if(TxtEmail.Text.Contains("@"))
            {
                var parts = TxtEmail.Text.Split('@')[0];
                userName = char.ToUpper(parts[0]) + parts.Substring(1);
            }

            // Open Dashboard
            MainWindow dashboard = new MainWindow();
            dashboard.SetUser(userName, "Head Librarian");
            dashboard.Show();
            this.Close();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
