using MovieTheater.Model;
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
        public static DataTable GetListShowTimeByFormatMovie(string formatMovieID, DateTime date)
        {
            string query = "exec laylichchieutheoformat @ID , @Date";
            return myDB.ExecuteQuery(query, new object[] { formatMovieID, date });
        }
        public static List<ShowTimes> GetListShowTimesNotCreateTickets()
        {
            List<ShowTimes> listShowTimes = new List<ShowTimes>();
            DataTable data = myDB.ExecuteQuery("exec laylichchieuchuataove");
            foreach (DataRow row in data.Rows)
            {
                ShowTimes showTimes = new ShowTimes(row);
                listShowTimes.Add(showTimes);
            }
            return listShowTimes;
        }
        public static int UpdateStatusShowTimes(string showTimesID, int status)
        {
            string query = "exec updatestatuslichchieu @idLichChieu , @status";
            return myDB.ExecuteNonQuery(query, new object[] { showTimesID, status });
        }
        public static DataTable GetListShowtime()
        {
            return myDB.ExecuteQuery("EXEC laylichchieu");
        }
        public static List<ShowTimes> GetAllListShowTimes()
        {
            List<ShowTimes> listShowTimes = new List<ShowTimes>();
            DataTable data = myDB.ExecuteQuery("exec getalllistshowtime");
            foreach (DataRow row in data.Rows)
            {
                ShowTimes showTimes = new ShowTimes(row);
                listShowTimes.Add(showTimes);
            }
            return listShowTimes;
        }
        public static bool InsertShowtime(string id, string cinemaID, string formatMovieID, DateTime time, float ticketPrice)
        {
            int result = myDB.ExecuteNonQuery("EXEC themlichchieu @id , @idPhong , @idDinhDang , @thoiGianChieu , @giaVe ", new object[] { id, cinemaID, formatMovieID, time, ticketPrice });
            return result > 0;
        }
        public static bool UpdateShowtime(string id, string cinemaID, string formatMovie, DateTime time, float ticketPrice)
        {
            string cmd = string.Format("exec updateshowtime @id , @idphong , @iddinhdang , @thoigianchieu , @giave ");
            int result = myDB.ExecuteNonQuery(cmd, new object[] { id, cinemaID, formatMovie, time, ticketPrice });
            return result > 0;
        }
        public static bool Deleteshowtime(string id)
        {
            int result = myDB.ExecuteNonQuery("DELETE dbo.showtime WHERE id= '" + id +"'");
            return result > 0;
        }   
    }
}
