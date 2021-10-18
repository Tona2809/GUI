using MovieTheater.Model;
using System;
using System.Collections.Generic;
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
    }
}
