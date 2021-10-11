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
        public static int Login(string Username, string PassWord)
        {
            string query = "CheckLog_in @username , @password";
            DataTable table = myDB.ExecuteQuery(query, new object[] { Username, PassWord });
            if (table == null)
            {
                return -1;
            }
            else
            {
                if(table.Rows.Count>0)
                {
                    return 1;
                }    
                else
                {
                    return 0;
                }    
            }
        }
    }
}
