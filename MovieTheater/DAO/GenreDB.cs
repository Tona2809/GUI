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
        public static List<GenreForm> GetListGenre()
        {
            List<GenreForm> genreList = new List<GenreForm>();
            DataTable table = myDB.ExecuteQuery("SELECT * FROM dbo.TheLoai");
            foreach (DataRow item in table.Rows)
            {
                GenreForm genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }
    }
}
