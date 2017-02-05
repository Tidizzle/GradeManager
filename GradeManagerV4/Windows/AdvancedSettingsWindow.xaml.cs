using GradeManagerV4.Classes;
using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;

namespace GradeManagerV4.Windows
{
    /// <summary>
    /// Interaction logic for AdvancedSettingsWindow.xaml
    /// </summary>
    public partial class AdvancedSettingsWindow : MetroWindow
    {
        public CheckBox Devbox;
        public CheckBox AdminBox;

        public AdvancedSettingsWindow()
        {
            InitializeComponent();
            Devbox = DeveloperBox;
            AdminBox = AdministratorBox;
        }

        private void DevCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.DevModeEnabled)
            {
                Devbox.IsChecked = false;
                AppState.DevModeEnabled = false;
            }
            else
            {
                Devbox.IsChecked = false;
                var win = new PasswordEnterWindow(PasswordEnterWindow.Type.Developer, this);
                win.Show();
            }
        }

        private void AdminCheckBox_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void DeveloperBox_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void AdministratorBox_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.AdminModeEnabled)
            {
                AdminBox.IsChecked = false;
                AppState.AdminModeEnabled = false;
            }
            else
            {
                AdminBox.IsChecked = false;
                var win = new PasswordEnterWindow(PasswordEnterWindow.Type.Administrator, this);
                win.Show();
            }
        }
    }
}