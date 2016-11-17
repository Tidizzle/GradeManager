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
using MahApps.Metro.Controls.Dialogs;

namespace GradeManager
{
    /// <summary>
    /// Interaction logic for adduser.xaml
    /// </summary>
    /// 


    public partial class adduser : Page
    {
        public adduser()
        {
            InitializeComponent();
        }

        

        private void adduserSubmit_Click(object sender, RoutedEventArgs e) //ADD CLEAR TEXTBOX FEATURE
        {
            try
            {
                bool usernameentered;
                bool passwordentred;
                bool useridentered;
                bool nameentered;

                if (adduserUsername.Text == "") 
                {
                    usernameentered = false;
                }
                else
                {
                    usernameentered = true;
                }
                
                if(adduserPassword.Text == "")
                {
                    passwordentred = false;
                }
                else
                {
                    passwordentred = true;
                }

                if(adduserID.Text == "")
                {
                    useridentered = false;
                }
                else
                {
                    useridentered = true;
                }
                
                if (adduserName.Text == "")
                {
                    nameentered = false;
                }
                else
                {
                    nameentered = true;
                }

                string errormsg;

                errormsg = "You must fill in all fields!";

                bool errorshown;

                if (usernameentered == false || passwordentred == false || useridentered == false || nameentered == false)
                {
                    MessageBox.Show(errormsg);
                    errorshown = true;
                }
                else
                {
                    errorshown = false;
                }

                int result;

                int.TryParse(adduserID.Text.ToString(), out result);

                if (result == 0 && errorshown == false)
                {
                    MessageBox.Show("Invalid UserID");
                    adduserID.Clear();
                }

                string username = adduserUsername.Text.ToString();
                string password = adduserPassword.Text.ToString();
                int usrID = int.Parse(adduserID.Text);
                string name = adduserName.Text.ToString();

                User.usersarray[usrID, 0] = username;
                User.usersarray[usrID, 1] = password;
                User.usersarray[usrID, 2] = name;
                MessageBox.Show("New User Created");

                adduserPassword.Clear();
                adduserID.Clear();
                adduserName.Clear();
                adduserUsername.Clear();

            }
            catch (Exception)
            {
                
            }

        }
    }
}
