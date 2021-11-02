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
        public static bool insertGenre(string gerneid, string gernename, string desc)
        {
            int result = myDB.ExecuteNonQuery("EXEC themtheloai @Id , @Tentheloai , @Mota ", new object[] { gerneid, gernename, desc });
            return result > 0;
        }
        public static DataTable GetGenre()
        {
            return myDB.ExecuteQuery("SELECT iD as [Mã thể loại], tenTheLoai as [Tên thể loại], moTa as [Mô tả] FROM dbo.genre");
        }
        public static bool DeleteGenre(string id)
        {
            myDB.ExecuteNonQuery("DELETE dbo.genrebymovie WHERE idTheLoai ='" + id + "'");
            int result = myDB.ExecuteNonQuery("DELETE dbo.genre WHERE iD ='" + id + "'");
            return result > 0;
        }
        public static bool UpdateGenre(string id,string name, string desc)
        {
            string cmd = string.Format("UPDATE dbo.genre SET tenTheLoai = N'{0}' , moTa= N'{1}' WHERE iD = '{2}'", name, desc, id);
            int result = myDB.ExecuteNonQuery(cmd);
            return result > 0;
        }
    }
}
