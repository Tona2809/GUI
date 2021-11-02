using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class ScreenTypeDB
    {
        public static ScreenType GetScreenTypeByName(string screenName)
        {
            ScreenType screenType = null;
            DataTable data = myDB.ExecuteQuery("SELECT * FROM dbo.screentype WHERE tenMH = N'" + screenName + "'");
            foreach (DataRow item in data.Rows)
            {
                screenType = new ScreenType(item);
                return screenType;
            }
            return screenType;
        }    
        public static List<ScreenType> GetListScreenType()
        {
            List<ScreenType> screenTypeList = new List<ScreenType>();
            DataTable data = myDB.ExecuteQuery("SELECT * FROM dbo.screentype");
            foreach (DataRow item in data.Rows)
            {
                ScreenType screenType = new ScreenType(item);
                screenTypeList.Add(screenType);
            }
            return screenTypeList;
        }
        public static bool InsertScreenType(string id, string name)
        {
            int result = myDB.ExecuteNonQuery("EXEC themloaimanhinh @id , @tenmh ", new object[] { id, name });
            return result > 0;
        }
        public static bool DeleteScreenType(string id)
        {
            int result = myDB.ExecuteNonQuery("DELETE dbo.screentype WHERE id = '" + id + "'");
            return result > 0;
        }
        public static DataTable GetScreenType()
        {
            return myDB.ExecuteQuery("SELECT iD AS [Mã màn hình], tenMH AS [Tên màn hình] FROM dbo.screentype");
        }
        public static bool UpdateScreenType(string id, string name)
        {
            string cmd = string.Format("UPDATE dbo.screentype SET tenMH = N'{0}' WHERE iD = '{1}'", name, id);
            int result = myDB.ExecuteNonQuery(cmd);
            return result > 0;
        }
    }
}
