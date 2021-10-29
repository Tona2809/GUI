using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DTO
{
    class Account
    {
        public string Username { get; set; }
        public string StaffID { get; set; }
        public int Type { get; set; }
        public string Password { get; set;}

        public Account(string userName, string staffID, int type, string password=null)
        {
            this.Username = userName;
            this.Password = password;
            this.Type = type;
            this.StaffID = staffID;
        }
        public Account(DataRow row)
        {
            this.Username = row["userName"].ToString();
            this.Password = row["Pass"].ToString();
            this.Type = (int)row["loaiTK"];
            this.StaffID = row["idNV"].ToString();
        }    
    }
}
