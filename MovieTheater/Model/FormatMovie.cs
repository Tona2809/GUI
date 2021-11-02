using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.Model
{
    class FormatMovie
    {
        public string ID { get; set; }

        public string MovieName { get; set; }
        public string ScreenTypeName { get; set; }
        public FormatMovie(string iD, string movieName, string screenTypeName)
        {
            this.ID = iD;
            this.MovieName = movieName;
            this.ScreenTypeName = screenTypeName;
        }
        public FormatMovie(DataRow row)
        {
            this.ID = row["iD"].ToString();
            this.MovieName = row["tenPhim"].ToString();
            this.ScreenTypeName = row["tenMH"].ToString();
        }
    }
}
