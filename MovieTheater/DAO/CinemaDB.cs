using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class CinemaDB
    {
        public static Cinema GetCinemaByName(string cinemaName)
        {
            string query = "select * from dbo.cinema where tenPhong = '" + cinemaName + "'";
            DataTable data = myDB.ExecuteQuery(query);
            return new Cinema(data.Rows[0]);
        }
        public static List<Cinema> GetCinemaByScreenTypeID(string screenTypeID)
        {
            List<Cinema> cinemaList = new List<Cinema>();
            DataTable data = myDB.ExecuteQuery("SELECT * FROM dbo.cinema where idManHinh ='" + screenTypeID + "'");
            foreach (DataRow item in data.Rows)
            {
                Cinema cinema = new Cinema(item);
                cinemaList.Add(cinema);
            }
            return cinemaList;
        }
        public static bool Insertcinema(string id, string name, string idMH, int status, int numberofRows, int seatPerRow)
        {
            int results = myDB.ExecuteNonQuery("EXEC themcinema @iD , @tenphong , @iDManHinh , @tinhtrang , @sohangghe , @soghemothang ", new object[] { id, name, idMH, status, numberofRows, seatPerRow });
            return results > 0;
        }
        public static bool Updatecinema(string id,string name,string idMH, int status,int numberofRows,int seatPerRow)
        {
            string command = string.Format("UPDATE dbo.cinema SET tenPhong = N'{0}', idManHinh = '{1}', tinhTrang = {2}, soHangGhe = {3}, soGheMotHang = {4} WHERE iD = '{5}'", name, idMH, status, numberofRows, seatPerRow, id);
            int result = myDB.ExecuteNonQuery(command);
            return result > 0;
        }
        public static bool DeleteCinema(string id)
        {
           

            int result = myDB.ExecuteNonQuery("DELETE dbo.cinema WHERE id = '" + id + "'");
            return result > 0;
        }
        public static DataTable GetListCinema()
        {
            return myDB.ExecuteQuery("EXEC laycinema");
        }
    }
}
