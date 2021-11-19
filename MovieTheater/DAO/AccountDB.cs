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
        public static DataTable SearchAccountByStaffName(string name)
        {
            return myDB.ExecuteQuery("EXEC SearchAccount @hoten ", new object[] { name });
        }
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
        public static bool UpdateAccount(string username, int accountType)
        {
            int result = myDB.ExecuteNonQuery("EXEC updatetaikhoan @username , @loaiTK ", new object[] { username, accountType });
            return result > 0;
        }
        public static DataTable GetAccountList()
        {
            return myDB.ExecuteQuery("laydsaccount");
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
        public static bool InsertAccount(string username, int accountype, string staffID)
        {
            int result = myDB.ExecuteNonQuery("EXEC themtaikhoan @username , @loaiTK , @idNV ", new object[] { username, accountype, staffID });
            return result > 0;
        }
        public static bool DeleteAccount(string username)
        {
            int result = myDB.ExecuteNonQuery("DELETE dbo.account WHERE userName= '" + username + "'");
            return result > 0;
        }
    }
}
