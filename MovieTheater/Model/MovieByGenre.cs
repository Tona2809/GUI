using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.Model
{
    class MovieByGenre
    {
        public string MovieID { get; set; }
        public string Genre { get; set; }
        public MovieByGenre(string MovieID, string Genre)
        {
            this.MovieID = MovieID;
            this.Genre = Genre; 
        }
        public MovieByGenre(DataRow row)
        {
            this.MovieID = row["idPhim"].ToString();
            this.Genre = row["idTheloai"].ToString();
        }
    }
}
