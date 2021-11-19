using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class FormatMovieDB
    {
        public static List<FormatMovie> GetListFormatMovieByMovie(string movieID)
        {
            List<FormatMovie> listFormat = new List<FormatMovie>();
            string query = "select d.iD, p.tenPhim, m.tenMH " +
                "from movie p, formatmovie d, screentype m " +
                "where p.iD = d.idPhim and d.idLoaiManHinh = m.iD "
                + "and p.iD = '" + movieID + "'";
            DataTable data = myDB.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                FormatMovie format = new FormatMovie(row);
                listFormat.Add(format);
            }
            return listFormat;
        }

        public static List<FormatMovie> GetFormatMovie()
        {
            List<FormatMovie> formatMovieList = new List<FormatMovie>();
            DataTable data = myDB.ExecuteQuery("SELECT DD.iD, P.tenPhim, MH.tenMH " +
                                                        "FROM dbo.formatmovie DD, dbo.movie P, dbo.screentype MH " +
                                                        "WHERE DD.idPhim = P.iD AND DD.idLoaiManHinh = MH.iD");
            foreach (DataRow item in data.Rows)
            {
                FormatMovie formatMovie = new FormatMovie(item);
                formatMovieList.Add(formatMovie);
            }
            return formatMovieList;
        }

        public static bool DeleteDinhdangMovie(string id)
        {
            myDB.ExecuteNonQuery("DELETE dbo.showtime WHERE idDinhDang ='" + id + "'");
            int result = myDB.ExecuteNonQuery("DELETE dbo.formatmovie WHERE id= '" + id + "'");
            return result > 0;
        }
        public static DataTable GetListFMovie()
        {
            return myDB.ExecuteQuery("EXEC laydanhsachformat");
        }
        public static bool InsertFormatMovie(string id, string moiveid, string idScreen)
        {
            int result = myDB.ExecuteNonQuery("EXEC themformat @id , @idphim , @idscreen ", new object[] { id, moiveid, idScreen });
            return result > 0;
        }
        public static bool UpdateFormatMovie(string id, string movieid,string idScreen)
        {
            string cmd = string.Format("UPDATE dbo.formatmovie SET idPhim = '{0}', idLoaiManHinh = '{1}' WHERE iD = '{2}'", movieid, idScreen, id);
                int result = myDB.ExecuteNonQuery(cmd);
            return result > 0;
        }
    }
}
