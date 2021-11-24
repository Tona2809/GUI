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
        public static bool UpdatePasswordForAccount(string userName, string passWord, string newPassWord)
        {


            int result = myDB.ExecuteNonQueryforlogin("EXEC updatepassword @username , @pass , @newPass", new object[] { userName, passWord, newPassWord });

            return result > 0;
        }
        public static DataTable SearchAccountByStaffName(string name)
        {
            return myDB.ExecuteQuery("EXEC SearchAccount @hoten ", new object[] { name });
        }
        public static bool ResetPassword(string username)
        {
            int result = myDB.ExecuteNonQueryforlogin("resetpassword @username", new object[] { username });
            return result > 0;
        }
        public static int Login(string username, string password)
        {
            string query = "CheckLog_in @userName ,  @passWord";
            DataTable table = myDB.ExecuteQueryforlogin(query, new object[] { username, password });
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
        public static void UpdateAccountRole(string username, int accountType)
        {
             myDB.ExecuteQueryforlogin("EXEC rolechange @username , @loaiTK ", new object[] { username, accountType });
        }
        public static DataTable GetAccountList()
        {
            return myDB.ExecuteQuery("exec laydsaccount");
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
        public static void InsertAccountSQL(string username,string password, int accountype)
        {
            myDB.ExecuteQueryforlogin("EXEC createuserinsql @username , @loaiTK , @idNV ", new object[] { username, password, accountype });
        }
        public static bool DeleteAccount(string username)
        {
            int result = myDB.ExecuteNonQuery("DELETE dbo.account WHERE userName= '" + username + "' ");
            return result > 0;
        }
        public static void DeleteAccountsql(string username)
        {
           myDB.ExecuteQueryforlogin("drop login " + username + " drop user if exists "+username);
            
        }
    }
}
