using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class ShowTimeDB
    {
        public static DataTable GetListShowtime()
        {
            return myDB.ExecuteQuery("EXEC laylichchieu");
        }
        public static bool InsertShowtime(string id, string cinemaID, string formatMovieID, DateTime time, float ticketPrice)
        {
            int result = myDB.ExecuteNonQuery("EXEC themlichchieu @id , @idPhong , @idDinhDang , @thoiGianChieu , @giaVe ", new object[] { id, cinemaID, formatMovieID, time, ticketPrice });
            return result > 0;
        }
    }
}
