using GradeManagerV4.Classes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Windows;
using System.Windows.Controls;
using GradeManagerV4.Views;

namespace GradeManagerV4.Windows
{
    /// <summary>
    /// Interaction logic for StartScreen.xaml
    /// </summary>
    public partial class StartScreen : Page
    {
        public Flyout ProfileFlyout;
        public SplashWindow Window;

        public StartScreen(string User, Flyout Flyer, SplashWindow Screen)
        {
            InitializeComponent();
            AppState.LoadData();
            ProfileFlyout = Flyer;
            Window = Screen;
        }

        private void gpaTile_Click(object sender, RoutedEventArgs e)
        {
            Window.Frame.Content = new GPACalculatorScreen(Window);
        }

        private void moneyTile_Click(object sender, RoutedEventArgs e)
        {
            Window.Frame.Content = new MoneyCalculatorScreen(Window);
        }

        private async void manageTile_Click(object sender, RoutedEventArgs e)
        {
            await Window.ShowMessageAsync("Coming Soon!", "Per user Grade Saving is Coming soon!");
        }

        private void profileTile_Click(object sender, RoutedEventArgs e)
        {
            Window.NameTextBox.Text = AppState.Book.UserList[0].Name;
            Window.IDTextBox.Text = AppState.Book.UserList[0].UserID.ToString();
            Window.GPATextBox.Text = AppState.Book.UserList[0].Gpa.ToString();
            Window.TotalEarnedTextBox.Text = $"${AppState.Book.UserList[0].Totalpaid.ToString()}";
            Window.LastPayoutTextBox.Text = $"${AppState.Book.UserList[0].Lastpaid.ToString()}";
            Window.TotalATextBox.Text = AppState.Book.UserList[0].A.ToString();
            Window.TotalBTextBox.Text = AppState.Book.UserList[0].B.ToString();
            Window.TotalCTextBox.Text = AppState.Book.UserList[0].C.ToString();
            Window.TotalDTextBox.Text = AppState.Book.UserList[0].D.ToString();
            Window.TotalFTextBox.Text = AppState.Book.UserList[0].F.ToString();

            ProfileFlyout.IsOpen = true;
        }

        private void statsTile_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}