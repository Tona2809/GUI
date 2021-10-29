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
        public static bool InsertMovie(string id, string name, string desc, float length, DateTime startdate, DateTime enddate, string productor, string director, int year, byte[] image)
        {
            int result = myDB.ExecuteNonQuery("EXEC themphim @id , @tenphim , @Mota , @thoiluong , @ngaykhoichieu , @ngayketthuc , @sanxuat , @daodien , @namsx , @apphich ", new object[] { id, name, desc, length, startdate, enddate, productor, director, year, image });
            return result > 0;
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
            myDB.ExecuteNonQuery("DELETE dbo.formatmovie WHERE idPhim= '" + id + "'");
            MovieByGenreDB.DeleteMovie_Genre(id);
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
