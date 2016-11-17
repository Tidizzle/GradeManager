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

namespace GradeManager
{
    /// <summary>
    /// Interaction logic for viewuser.xaml
    /// </summary>
    public partial class viewuser : Page
    {
        public viewuser()
        {
            InitializeComponent();
            userDataGrid.ItemsSource = LoadCollectionData(); 
        }


        private List<GridUser> LoadCollectionData()
        {
            List<GridUser> users = new List<GridUser>();
            users.Add(new GridUser()
            {
                Username = "zstaylor",
                Password = "zstaylor",
                UserId = 0
            });
            users.Add(new GridUser()
            {
                Username = User.usersarray[1,0],
                Password = User.usersarray[1,1],
                UserId = 1
            });
            users.Add(new GridUser()
            {
                Username = User.usersarray[2,0],
                Password = User.usersarray[2,1],
                UserId = 2
            });
            users.Add(new GridUser()
            {
                Username = User.usersarray[3, 0],
                Password = User.usersarray[3, 1],
                UserId = 3
            });
            users.Add(new GridUser()
            {
                Username = User.usersarray[4, 0],
                Password = User.usersarray[4, 1],
                UserId = 4
            });
            return users;
        }
    }
}
