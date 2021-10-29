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
            List<Genre> genrelist = new List<Genre>();
            DataTable data = myDB.ExecuteQuery("SELECT * FROM dbo.genre");
            foreach(DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                genrelist.Add(genre);
            }
            return genrelist;
        }
    }
}
