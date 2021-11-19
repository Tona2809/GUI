using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class StaffDB
    {
        public static bool InsertStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            int result = myDB.ExecuteNonQuery("EXEC themnhanvien @idStaff , @hoTen , @ngaySinh , @diaChi , @sdt , @cmnd ", new object[] { id, hoTen, ngaySinh, diaChi, sdt, cmnd });
            return result > 0;
        }
        public static List<Staff> GetStaff()
        {
            List<Staff> staffList = new List<Staff>();
            DataTable data = myDB.ExecuteQuery("SELECT * FROM dbo.staff");
            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                staffList.Add(staff);
            }
            return staffList;
        }
        public static DataTable GetListStaff()
        {
            return myDB.ExecuteQuery("EXEC laynhanvien");
        }
        public static bool UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            string command = string.Format("UPDATE dbo.staff SET hoTen = N'{0}', ngaySinh = '{1}', diaChi = N'{2}', SDT = '{3}', CMND = {4} WHERE iD = '{5}'", hoTen, ngaySinh, diaChi, sdt, cmnd, id);
            int result = myDB.ExecuteNonQuery(command);
            return result > 0;
        }
        public static bool DeleteStaff(string id)
        {
            int result = myDB.ExecuteNonQuery("DELETE dbo.staff WHERE iD = '" + id + "'");
            return result > 0;
        }
        public static DataTable SearchStaffByName(string name)
        {
            DataTable data = myDB.ExecuteQuery("EXEC SearchNhanVien @hoTen", new object[] { name });
            return data;
        }

    }
}
