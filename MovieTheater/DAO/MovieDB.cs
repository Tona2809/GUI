using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class MovieDB
    {
        public static bool insertMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            int result = myDB.ExecuteNonQuery("EXEC InsertMovie @id, @tenPhim,@moTa, @thoiLuong, @ngayKhoiChieu, @ngayKetThuc, @sanXuat, @daoDien, @namSX, @apPhich ", new object[] { id, name, desc, length, startDate, endDate, productor, director, year, image });
            return result > 0;
        }
        //ảnh -> byte[]
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //byte[] -> ảnh
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public static Movie GetMovieByID(string id)
        {
            Movie movie = null;
            DataTable table = myDB.ExecuteQuery("SELECT * FROM dbo.Phim WHERE iD= '" + id + "'");
            foreach(DataRow item in table.Rows)
            {
                movie = new Movie(item);
                return movie;
            }
            return movie;
        }
        public static DataTable GetMovie()
        {
            return myDB.ExecuteQuery("EXEC GetMovie");
        }
        public static bool DeleleMovie(string id)
        {
            myDB.ExecuteNonQuery("DELETE dbo.phanLoaiphim WHERE idPhim= '" + id + "'");
            myDB.ExecuteNonQuery("DELETE dbo.dinhDangphim WHERE idPhim= '" + id + "'");
            MovieByGenreDB.DeleteGenrebyMovieID(id);
            int result = myDB.ExecuteNonQuery("DELETE dbo.Phim WHERE Id = '" + id + "'");
            return result > 0;
        }  
        public static bool UpdateMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            int result = myDB.ExecuteNonQuery("EXEC UpdateMovie @iD, @tenPhim, @moTa, @thoiLuong, @ngayKhoichieu, @ngayKetthuc, @sanXuat, @daoDien, @namSX, @apPhich", new object[] { id, name, desc, length, startDate, endDate, productor, director, year, image });
            return result > 0;
        }    
    }
}
