using GradeManagerV4.Classes;
using MahApps.Metro.Controls;
using System;
using System.Linq;
using System.Windows;

namespace GradeManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        //public static string[,] usersarray;

        public MainWindow()
        {
            InitializeComponent();
            AppState.LoadData();
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            bool dev = false;

            if (!string.IsNullOrEmpty(usernameBox.Text) || !string.IsNullOrEmpty(passwordBox.Password) || AppState.DevModeEnabled)
            {
                string username = usernameBox.Text;
                string password = passwordBox.Password;

                int count = (from user in AppState.Book.UserList where user.Username == username && user.Password == password select user).Count();
                if (count > 0)
                {
                    loginAccepted();
                }
                else if (AppState.DevModeEnabled || dev)
                {
                    loginAccepted();
                }
                else
                {
                    MessageBox.Show("User not found", "Login Error", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("You must enter your username and password", "Login Error", MessageBoxButton.OK);
            }
        }

        public void loginAccepted()
        {
            var query = from user in AppState.Book.UserList where user.Password == passwordBox.Password && user.Username == usernameBox.Text select user;
            string User = "";
            foreach (var user in query)
            {
                User = user.Name;
            }
            AppState.currentUser = User;

            if (AppState.DevModeEnabled)
            {
                AppState.currentUser = "Developer";
            }

            if (AppState.AdminModeEnabled)
            {
                AppState.currentUser = "Administrator";
            }

            var win = new GradeManagerV4.Windows.SplashWindow();
            win.Show();
            this.Close();
        }

        private void newUser_Click(object sender, RoutedEventArgs e)
        {
            var AddUserWin = new GradeManagerV4.Windows.AddUserWindow();
            AddUserWin.Show();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void AdvancedButton_Click(object sender, RoutedEventArgs e)
        {
            GradeManagerV4.Windows.AdvancedSettingsWindow win = new GradeManagerV4.Windows.AdvancedSettingsWindow();
            win.Show();
        }
    }
}