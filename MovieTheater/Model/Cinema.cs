using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.Model
{
    class Cinema
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string ScreenTypeID { get; set; }

        public string Status { get; set; }
        public int numberrow { get; set; }
        public int numberseatofrow { get; set; }

        public Cinema(string iD, string name, string screenType, int numberrow,int numberseatofrow,
          string status)
        {
            this.ID = iD;
            this.Name = name;
            this.ScreenTypeID = screenType;
            this.numberrow = numberrow;
            this.numberseatofrow = numberseatofrow;
            this.Status = status;
        }
        public Cinema(DataRow row)
        {
            this.ID = row["iD"].ToString();
            this.Name = row["tenPhong"].ToString();
            this.ScreenTypeID = row["idManHinh"].ToString();
            this.numberrow = (int)row["soHangGhe"];
            this.numberseatofrow = (int)row["soGheMotHang"];
            this.Status = row["tinhTrang"].ToString();
        }
    }
}
