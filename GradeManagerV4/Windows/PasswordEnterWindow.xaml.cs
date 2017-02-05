using GradeManagerV4.Classes;
using MahApps.Metro.Controls;
using System.Windows;

namespace GradeManagerV4.Windows
{
    /// <summary>
    /// Interaction logic for PasswordEnterWindow.xaml
    /// </summary>
    public partial class PasswordEnterWindow : MetroWindow
    {
        public enum Type { Developer, Administrator }

        private Type WindowType;
        private AdvancedSettingsWindow ParentWin;

        public PasswordEnterWindow(Type winType, AdvancedSettingsWindow parent)
        {
            InitializeComponent();
            WindowType = winType;
            ParentWin = parent;

            if (winType == Type.Developer)
            {
                Title = "Dev Password";
            }
            else
            {
                Title = "Admin Password";
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(passbox.Password))
            {
                if (WindowType == Type.Developer)
                {
                    if (passbox.Password == AppState.DevPass)
                    {
                        LoginAccepted();
                    }
                    else
                    {
                        LoginDenied();
                    }
                }
                else if (WindowType == Type.Administrator)
                {
                    if (passbox.Password == AppState.AdminPass)
                    {
                        LoginAccepted();
                    }
                    else
                    {
                        LoginDenied();
                    }
                }
                else
                {
                    LoginDenied();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Password", "Login Error", MessageBoxButton.OK);
            }
        }

        public void LoginAccepted()
        {
            if (WindowType == Type.Developer)
            {
                ParentWin.Devbox.IsChecked = true;
                AppState.DevModeEnabled = true;
                this.Close();
            }
            else
            {
                ParentWin.AdminBox.IsChecked = true;
                AppState.AdminModeEnabled = true;
                this.Close();
            }
        }

        public void LoginDenied()
        {
            if (WindowType == Type.Developer)
            {
                ParentWin.Devbox.IsChecked = false;
                AppState.DevModeEnabled = false;
                this.Close();
            }
            else
            {
                ParentWin.AdminBox.IsChecked = false;
                AppState.AdminModeEnabled = false;
                this.Close();
            }
        }
    }
}