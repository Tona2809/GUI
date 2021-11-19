using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.Model
{
    class Ticket
    {
        public string ID { get; set; }

        public int Type { get; set; }

        public string ShowTimesID { get; set; }

        public string SeatName { get; set; }


        public float Price { get; set; }

        public int Status { get; set; }
        public Ticket(string iD, int type, string showTimesID, string seatName
          , string customerID, string promotionID, float price,
          int status)
        {
            this.ID = iD;
            this.Type = type;
            this.ShowTimesID = showTimesID;
            this.SeatName = seatName;
            this.Status = status;
            this.Price = price;
        }
        public Ticket(DataRow row)
        {
            this.ID = row["iD"].ToString();
            this.Type = (int)row["loaiVe"];
            this.ShowTimesID = row["idLichChieu"].ToString();
            this.SeatName = row["maGheNgoi"].ToString();
            this.Status = (int)row["trangThai"];
            if (row["tienBanVe"].ToString() == "")
                this.Price = 0;
            else
                this.Price = float.Parse(row["tienBanVe"].ToString());
        }
    }
}
