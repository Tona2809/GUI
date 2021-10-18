using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class GenreDB
    {
        public static List<Genre> GetListGenre()
        {
            List<Genre> genreList = new List<Genre>();
            DataTable table = myDB.ExecuteQuery("SELECT * FROM dbo.theLoai");
            foreach (DataRow item in table.Rows)
            {
                Genre genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }
    }
}
