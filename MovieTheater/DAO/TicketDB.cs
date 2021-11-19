using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAO
{
    class TicketDB
    {
        public static int CountTheNumberOfTicketsSoldByShowTime(string showTimesID)
        {
            string query = "Select count (iD) from ticket where idLichChieu ='" + showTimesID + "' and TrangThai = 1 ";
            return (int)myDB.ExecuteScalar(query);
        }
        public static int CountToltalTicketByShowTime(string showTimesID)
        {
            string query = "Select count (iD) from ticket where idLichChieu ='" + showTimesID + "'";
            return (int)myDB.ExecuteScalar(query);
        }
        public static int BuyTicket(string ticketID, int type, float price)
        {
            string query = "Update dbo.ticket set trangThai = 1, loaiVe = "
                + type + ", tienBanVe =" + price + " where iD = '" + ticketID + "'";
            return myDB.ExecuteNonQuery(query);
        }
        public static List<Ticket> GetListTicketsBoughtByShowTimes(string showTimesID)
        {
            List<Ticket> listTicket = new List<Ticket>();
            string query = "select * from dbo.ticket where idLichChieu = '" + showTimesID + "' and trangThai = 1";
            DataTable data = myDB.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Ticket ticket = new Ticket(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }
        public static List<Ticket> GetListTicketsByShowTimes(string showTimesID)
        {
            List<Ticket> listTicket = new List<Ticket>();
            string query = "select * from dbo.ticket where idLichChieu = '" + showTimesID + "'";
            DataTable data = myDB.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Ticket ticket = new Ticket(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }
        public static int InsertTicketByShowTimes(string showTimesID, string seatName)
        {
            string query = "themve @idlichChieu , @maGheNgoi ";
            return myDB.ExecuteNonQuery(query, new object[] { showTimesID, seatName });
        }
        public static int DeleteTicketsByShowTimes(string showTimesID)
        {
            string query = "Deleteve @idlichChieu";
            return myDB.ExecuteNonQuery(query, new object[] { showTimesID });
        }
    }
}
