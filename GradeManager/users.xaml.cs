using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro;

namespace GradeManager
{
    /// <summary>
    /// Interaction logic for users.xaml
    /// </summary>
    public partial class users : MetroWindow
    {
        public users()
        {
            InitializeComponent();
            addusr.Content = new adduser();
            usersBack.Visibility = System.Windows.Visibility.Hidden;
        }

        private void viewusers_Click(object sender, RoutedEventArgs e)
        {
            viewusers.Visibility = System.Windows.Visibility.Hidden;
            usersBack.Visibility = System.Windows.Visibility.Visible;

            addusr.Content = new viewuser();

        }

        private void usersBack_Click(object sender, RoutedEventArgs e)
        {
            addusr.Content = new adduser();
            viewusers.Visibility = System.Windows.Visibility.Visible;
            usersBack.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
