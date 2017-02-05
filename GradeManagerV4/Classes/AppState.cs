using GradeManager;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.IO;

namespace GradeManagerV4.Classes
{
    internal static class AppState
    {
        private static readonly SQLiteConnection DbCon = new SQLiteConnection("Data Source=gradeManagerDependencies.sqlite; version=3");
        public static DataSet DS = new DataSet();
        public static string currentUser;
        public static bool DevModeEnabled;
        public static bool AdminModeEnabled;
        public static GradeBook Book = new GradeBook();

        public static readonly string AdminPass = "admin";
        public static readonly string DevPass = "developer";

        public static async void LoadData()
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            if (!File.Exists("gradeManagerDependencies.sqlite"))
            {
                SQLiteConnection.CreateFile("gradeManagerDependencies.sqlite");

                DbCon.Open();

                string query = @"CREATE TABLE `grades` ( `Owner`	TEXT NOT NULL, `Class`	TEXT NOT NULL, `Letter`	TEXT NOT NULL, `Percentage`	INTEGER NOT NULL); ";
                var cmd = new SQLiteCommand(query, DbCon);
                cmd.ExecuteNonQuery();

                query = @"CREATE TABLE `users` (`ID`	INTEGER NOT NULL, `Username`	TEXT NOT NULL, `Password`	TEXT NOT NULL, `Name`	TEXT NOT NULL, `GPA`	INTEGER DEFAULT 0, `LastPaid`	INTEGER DEFAULT 0, `TotalPaid`	INTEGER DEFAULT 0, `AmmountA`	INTEGER DEFAULT 0, `AmmountB`	INTEGER DEFAULT 0, `AmmountC`	INTEGER DEFAULT 0, `AmmountD`	INTEGER DEFAULT 0, `AmmountF`	INTEGER DEFAULT 0 );";
                cmd = new SQLiteCommand(query, DbCon);
                cmd.ExecuteNonQuery();

                query = @"INSERT INTO `users`(`ID`,`Username`,`Password`,`Name`) VALUES (0,'User','User','User');";
                cmd = new SQLiteCommand(query, DbCon);
                cmd.ExecuteNonQuery();

                DbCon.Close();
            }

            await Task.Factory.StartNew(() =>
           {
               string sql = "SELECT * FROM users";
               string table = "loader";

               dataAdapter = new SQLiteDataAdapter(sql, DbCon);
               dataAdapter.Fill(DS, table);

               if (DS.Tables[0].Rows.Count > 0)
               {
                   for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                   {
                       var newUser = new User();

                       newUser.UserID = int.Parse(DS.Tables[0].Rows[i]["ID"].ToString());
                       newUser.Username = DS.Tables[0].Rows[i]["Username"].ToString();
                       newUser.Password = DS.Tables[0].Rows[i]["Password"].ToString();
                       newUser.Name = DS.Tables[0].Rows[i]["Name"].ToString();

                       newUser.Gpa = double.Parse(DS.Tables[0].Rows[i]["GPA"].ToString());
                       newUser.Lastpaid = double.Parse(DS.Tables[0].Rows[i]["LastPaid"].ToString());
                       newUser.Totalpaid = double.Parse(DS.Tables[0].Rows[i]["TotalPaid"].ToString());
                       newUser.A = int.Parse(DS.Tables[0].Rows[i]["AmmountA"].ToString());
                       newUser.B = int.Parse(DS.Tables[0].Rows[i]["AmmountB"].ToString());
                       newUser.C = int.Parse(DS.Tables[0].Rows[i]["AmmountC"].ToString());
                       newUser.D = int.Parse(DS.Tables[0].Rows[i]["AmmountD"].ToString());
                       newUser.F = int.Parse(DS.Tables[0].Rows[i]["AmmountF"].ToString());

                       Book.UserList.Add(newUser);
                   }
               }
           });
        }
    }
}