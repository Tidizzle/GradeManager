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
using GradeManager;

namespace GradeManager
{
    /// <summary>
    /// Interaction logic for startscreen.xaml
    /// </summary>
    public partial class startscreen : MetroWindow
    {
        public startscreen()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main_win = new MainWindow();
            this.Close();
            main_win.Show();
        }
        
        public enum pages {splashwin, gpa, money, manage, hype, profile, stats};
        public startscreen(pages page)
        {
            switch (page)
            {
                case pages.splashwin:
                    InitializeComponent();
                    splashframe.Content = new splash();
                    break;
                case pages.gpa:
                    
                    break;
                case pages.money:
                    
                    break;
                case pages.manage:
                    
                    break;
                case pages.hype:
                    
                    break;
                case pages.profile:
                    
                    break;
                case pages.stats:
                    
                    break;
                default:
                    InitializeComponent();
                    errlabel.Visibility = System.Windows.Visibility.Visible;
                    break;
            }
            

        }

        private static void toGPA()
        {
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
