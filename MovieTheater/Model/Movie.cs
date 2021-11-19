using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.Model
{
    class Movie
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public float Time { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Country { get; set; }
        public int YearProduction { get; set; }
        public string Director { get; set; }
        public byte[] Poster { get; set; }
        public Movie(string ID, string name, string desc, float time, DateTime startDate, DateTime endDate, string country, string director, int year, byte[] poster)
        {
            this.ID = ID;
            this.Name = name;
            this.Desc = desc;
            this.Time = time;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Country = country;
            this.Director = director;
            this.YearProduction = year;
            this.Poster = poster;
        }
        public Movie(DataRow row)
        {
            this.ID = row["iD"].ToString();
            this.Name = row["tenPhim"].ToString();
            this.Desc = row["moTa"].ToString();
            this.Time = float.Parse(row["thoiLuong"].ToString());
            this.StartDate = (DateTime)row["ngayKhoichieu"];
            this.EndDate = (DateTime)row["ngayKetthuc"];
            this.Country = row["sanXuat"].ToString();
            this.Director = row["daoDien"].ToString();
            this.YearProduction = (int)row["namSX"];
            if (row["apPhich"].ToString() == "")
                this.Poster = null;
            else
                this.Poster = (byte[])row["apPhich"];
        }

    }
}
