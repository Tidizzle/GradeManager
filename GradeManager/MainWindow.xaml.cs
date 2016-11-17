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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro;
using MahApps.Metro.Controls;
using System.IO;
using GradeManager;

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
            User.InitArray();
        }

        public string Usernames;


        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            bool Dev = true;

            User.usersarray[0, 0] = "zstaylor";
            User.usersarray[0, 1] = "zstaylor";
            User.usersarray[0, 2] = "Zach";

            string user = usernameBox.Text.ToString();
            string pass = passwordBox.Password.ToString();

            MessageBox.Show(user);

            if (User.usersarray[0, 0] == user)
            {
                if (User.usersarray[0, 1] == pass)
                {
                    loginAccepted();
                }
                else
                {
                    errormessage.Content = "Password Incorrect";
                }
            }
            else if (User.usersarray[1, 0] == user)
            {

                if (User.usersarray[1, 1] == pass)
                {
                    loginAccepted();
                }
                else
                {
                    errormessage.Content = "Password Incorrect";
                }
            }
            else if (User.usersarray[2, 0] == user)
            {

                if (User.usersarray[2, 1] == pass)
                {
                    loginAccepted();
                }
                else
                {
                    errormessage.Content = "Password Incorrect";
                }
            }
            else if (User.usersarray[3, 0] == user)
            {

                if (User.usersarray[3, 1] == pass)
                {
                    loginAccepted();
                }
                else
                {
                    errormessage.Content = "Password Incorrect";
                }
            }
            else if (User.usersarray[4, 0] == user)
            {

                if (User.usersarray[4, 1] == pass)
                {
                    loginAccepted();
                }
                else
                {
                    errormessage.Content = "Password Incorrect";
                }
            }
            else if (Dev == true)
            {
                loginAccepted();
            }
            else
            {
                errormessage.Content = "Username Not found";
            }

        }

        public void loginAccepted()
        {
            startscreen splash_win = new startscreen(startscreen.pages.splashwin);
            splash_win.Show();
            this.Close();

        }

        private void newUser_Click(object sender, RoutedEventArgs e)
        {
            users users_win = new users();
            users_win.Show();
            
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
