using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class FormatMovieDB
    {
        public static bool DeleteDinhdangMovie(string id)
        {
            myDB.ExecuteNonQuery("DELETE dbo.showtime WHERE idDinhDang ='" + id + "'");
            int result = myDB.ExecuteNonQuery("DELETE dbo.formatmovie WHERE id= '" + id + "'");
            return result > 0;
        }
    }
}
