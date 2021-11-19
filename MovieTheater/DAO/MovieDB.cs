using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class MovieDB
    {
        public static List<Movie> GetListMovieByDate(DateTime date)
        {
            List<Movie> listMovie = new List<Movie>();
            DataTable data = myDB.ExecuteQuery("select * from movie where @Date <= NgayKetThuc", new object[] { date });
            foreach (DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                listMovie.Add(movie);
            }
            return listMovie;
        }
        public static Movie GetMovieByID(string id)
        {
            Movie movie = null;
            DataTable data = myDB.ExecuteQuery("SELECT * FROM dbo.movie WHERE iD = '" + id + "'");
            foreach (DataRow item in data.Rows)
            {
                movie = new Movie(item);
                return movie;
            }
            return movie;
        }    
        public static bool InsertMovie(string id, string name, string desc, float length, DateTime startdate, DateTime enddate, string productor, string director, int year, byte[] image)
        {
            int result = myDB.ExecuteNonQuery("EXEC themphim @id , @tenphim , @Mota , @thoiluong , @ngaykhoichieu , @ngayketthuc , @sanxuat , @daodien , @namsx , @apphich ", new object[] { id, name, desc, length, startdate, enddate, productor, director, year, image });
            return result > 0;
        }
        public static List<Movie> GetListMovie()
        {
            List<Movie> listMovie = new List<Movie>();
            DataTable data = myDB.ExecuteQuery("SELECT * FROM dbo.movie");
            foreach (DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                listMovie.Add(movie);
            }
            return listMovie;
        }
        public static DataTable GetMovie()
        {
            return myDB.ExecuteQuery("EXEC laydanhsachphim");
        }
        public static byte[] imagetobyte(Image imageLn)
        {
            MemoryStream ms = new MemoryStream();
            imageLn.Save(ms, ImageFormat.Gif);
            return ms.ToArray();
        }
        public static Image bytetoimage(byte[] byteIn)
        {
            MemoryStream ms = new MemoryStream(byteIn);
            Image returnimage = Image.FromStream(ms);
            return returnimage;
        }
        public static bool DeleteMovie(string id)
        {
            int result = myDB.ExecuteNonQuery("DELETE dbo.movie WHERE iD= '" + id + "'");
            return result > 0;
        }
        public static bool UpdateMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            int result = myDB.ExecuteNonQuery("EXEC updatephim @id , @tenphim , @Mota , @thoiluong , @ngaykhoichieu , @ngayketthuc , @sanxuat , @daodien , @namsx , @apphich ", new object[] { id, name, desc, length, startDate, endDate, productor, director,year, image });
            return result > 0;
        }
    }
}
