using MahApps.Metro.Controls;
using System.Windows;
using System.Threading.Tasks;

namespace GradeManagerV4.Windows
{
    /// <summary>
    /// Interaction logic for SplashWindow.xaml
    /// </summary>
    public partial class SplashWindow : MetroWindow
    {
        private Flyout Flyer;
        public System.Windows.Controls.Frame Frame;

        public SplashWindow()
        {
            InitializeComponent();
            Flyer = ProfileFlyout;
            splashframe.Content = new StartScreen("", Flyer, this);
            Frame = splashframe;
            logoutButton.IsEnabled = false;
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            GradeManager.MainWindow main_win = new GradeManager.MainWindow();
            this.Close();
            main_win.Show();
        }
    }
}