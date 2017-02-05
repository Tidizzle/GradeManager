using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Controls;

namespace GradeManagerV4.Windows
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : MetroWindow
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private async void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(UsernameBox.Text) && !string.IsNullOrEmpty(PasswordBox.Password) && !string.IsNullOrEmpty(FirstNameBox.Text))
            {
                var NewUser = new GradeManager.User()
                {
                    Username = UsernameBox.Text,
                    Password = PasswordBox.Password,
                    Name = FirstNameBox.Text,
                    UserID = GradeManagerV4.Classes.AppState.Book.UserList.Count
                };

                Classes.AppState.Book.UserList.Add(NewUser);

                this.ShowMessageAsync("User Created", "", MessageDialogStyle.Affirmative);

                UsernameBox.Clear();
                PasswordBox.Clear();
                FirstNameBox.Clear();
            }
            else
            {
                await this.ShowMessageAsync("Error", "Please enter your User Info", MessageDialogStyle.Affirmative);
            }
        }
    }
}