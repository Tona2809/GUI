
using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class MovieByGenreDB
    {
        public static void InsertMovie_Genre(string movieID,List<Genre> genreList)
        {
            foreach(Genre item in genreList)
            {
                string cmd = string.Format("INSERT dbo.genrebymovie (idPhim, idTheLoai) VALUES ('{0}', '{1}')", movieID, item.ID);
                myDB.ExecuteNonQuery(cmd);
            }    
        }
        public static void DeleteMovie_Genre(string moiveID)
        {
            myDB.ExecuteNonQuery("DELETE dbo.genrebymovie WHERE idPhim = '" + moiveID + "'");
        }
        public static void UpdateMovie_Genre(string moiveID, List<Genre> genrelist)
        {
            myDB.ExecuteNonQuery("DELETE dbo.genrebymovie WHERE idPhim = '" + moiveID + "'");
              foreach(Genre item in genrelist)
            {
                string cmd = string.Format("INSERT dbo.genrebymoive (idPhim, idTheLoai) VALUES ('{0}', '{1}'", moiveID, item.ID);
                myDB.ExecuteNonQuery(cmd);
            }    
        }
    }
}
