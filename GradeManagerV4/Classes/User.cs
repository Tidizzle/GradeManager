using System.Collections.Generic;

namespace GradeManager
{
    internal class User
    {
        #region Private Member variables

        private string username;
        private string password;
        private int userID;
        private string name;

        private double gpa;
        private double totalpaid;
        private double lastpaid;
        private int a;
        private int b;
        private int c;
        private int d;
        private int f;

        #endregion Private Member variables

        #region Properties

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

        public double Gpa
        {
            get
            {
                return gpa;
            }

            set
            {
                gpa = value;
            }
        }

        public double Totalpaid
        {
            get
            {
                return totalpaid;
            }

            set
            {
                totalpaid = value;
            }
        }

        public double Lastpaid
        {
            get
            {
                return lastpaid;
            }

            set
            {
                lastpaid = value;
            }
        }

        public int A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public int B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        public int C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public int D
        {
            get
            {
                return d;
            }

            set
            {
                d = value;
            }
        }

        public int F
        {
            get
            {
                return f;
            }

            set
            {
                f = value;
            }
        }

        #endregion Properties

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

        private List<GradeManagerV4.Classes.Grade> GradeList = new List<GradeManagerV4.Classes.Grade>();
    }
}