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
        public static void InsertMoviebyGenre(string movieID, List<Genre> genreList)
        {
            foreach(Genre items in genreList)
            {
                string command = string.Format("INSERT dbo.PhanLoaiPhim (idPhim, idTheLoai) VALUES  ('{0}','{1}')", movieID, items.ID);
                myDB.ExecuteNonQuery(command);
            }    
        }  
        public static void DeleteGenrebyMovieID(string movieID)
        {
            myDB.ExecuteNonQuery("DELETE dbo.phanLoaiPhim WHERE idPhim= '" + movieID + "'");
        }    
        public static List<Genre> GetListGenreByMovie(string id)
        {
            List<Genre> genreList = new List<GenreForm>();
            DataTable table = myDB.ExecuteQuery("EXEC getListGenreByMovieID @idPhim", new object[] { id });
            foreach(DataRow item in table.Rows)
            {
                Genre genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }
    }
}
