using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    public class RevenueDB
    {
        public static DataTable GetRevenue(string idMovie, DateTime fromDate, DateTime toDate)
        {
            return myDB.ExecuteQuery("EXEC Laydoanhthutheophimvangay @idMovie , @fromDate , @toDate", new object[] { idMovie, fromDate, toDate });
        }
    }
}
