using MovieTheater.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class AccountDB
    {
        public static int Login(string username, string password)
        {
            string query = "CheckLog_in @userName ,  @passWord";
            DataTable table = myDB.ExecuteQuery(query, new object[] { username, password });
            if (table == null)
                return -1;
            else if (table.Rows.Count > 0)
                return 1;
            else
                return 0;
        }
        public static Account GetAccount(string username)
        {
            DataTable table = myDB.ExecuteQuery("Select * from Account where userName = '" + username + "'");

            foreach (DataRow row in table.Rows)
            {
                return new Account(row);
            }
            return null;
        }
    }
}
