using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    class User
    {
        private string username;
        private string password;
        private int userID;
        private string name;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

       // public static Stack<User> userstack = new Stack<User>();

        



        public User(string username, string password, int userid, string name)
        {
            Username = username;
            Password = password;
            UserID = userid;
            Name = name;
        }

        public User()
        {

        }

        public static string[,] usersarray;

        public static void InitArray()
        {
            usersarray = new string[5, 3];

            for(int counter = 0; counter < 4; counter++)
            {
                for(int counter2 = 0; counter2 < 2; counter2++)
                {
                    usersarray[counter, counter2] = "";
                }
            }
        }
    }
}
