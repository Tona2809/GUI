using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.Model
{
    class Genre
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public Genre(string iD, string name, string desc = null)
        {
            this.ID = iD;
            this.Name = name;
            this.Desc = desc;
        }
        public Genre(DataRow row)
        {
            this.ID = row["iD"].ToString();
            this.Name = row["tenTheLoai"].ToString();
            if (row["moTa"].ToString() != "")
                this.Desc = row["moTa"].ToString();
            else
                this.Desc = "";
        }
    }
}
