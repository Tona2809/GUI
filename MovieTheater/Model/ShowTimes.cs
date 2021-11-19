using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.Model
{
    class ShowTimes
    {
        public string ID { get; set; }

        public DateTime Time { get; set; }

        public string CinemaName { get; set; }

        public string FormatMovieID { get; set; }

        public string MovieName { get; set; }

        public float TicketPrice { get; set; }

        public int Status { get; set; }
        public ShowTimes(string iD, DateTime time, string cinemaName,
          string formatMovieID, string movieName, float ticketPrice, int status)
        {
            this.ID = iD;
            this.CinemaName = cinemaName;
            this.MovieName = movieName;
            this.Time = time;
            this.FormatMovieID = formatMovieID;
            this.TicketPrice = ticketPrice;
            this.Status = status;
        }
        public ShowTimes(DataRow row)
        {
            this.ID = row["iD"].ToString();
            this.CinemaName = row["tenPhong"].ToString();
            this.MovieName = row["tenPhim"].ToString();
            this.Time = (DateTime)row["thoiGianChieu"];
            this.FormatMovieID = row["idDinhDang"].ToString();
            if (row["GiaVe"].ToString() == "")
                this.TicketPrice = 0;
            else
                this.TicketPrice = float.Parse(row["giaVe"].ToString());
            this.Status = (int)row["trangThai"];
        }
    }
}
