using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.Model
{
    class Staff
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public int IdentityCard { get; set; }
        public Staff(string iD, string name, DateTime birth, string address,
         string phone, int identityCard)
        {
            this.ID = iD;
            this.Name = name;
            this.BirthDate = birth;
            this.Address = address;
            this.Phone = phone;
            this.IdentityCard = identityCard;
        }
        public Staff(DataRow row)
        {
            this.ID = row["iD"].ToString();
            this.Name = row["hoTen"].ToString();
            this.BirthDate = DateTime.Parse(row["ngaySinh"].ToString());
            this.Address = row["diaChi"].ToString();
            this.Phone = row["SDT"].ToString();
            this.IdentityCard = Int32.Parse(row["CMND"].ToString());
        }
    }
}
