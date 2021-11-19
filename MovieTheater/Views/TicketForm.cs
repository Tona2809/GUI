using MovieTheater.DAO;
using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
            LoadAllListShowTimes();
        }

        private void btnAddTicketsByShowTime_Click(object sender, EventArgs e)
        {
            if (listAllListShowTime.SelectedItems.Count > 0)
            {
                ShowTimes showTimes = listAllListShowTime.SelectedItems[0].Tag as ShowTimes;
                if (showTimes.Status == 1)
                {
                    MessageBox.Show("LỊCH CHIẾU NÀY ĐÃ ĐƯỢC TẠO VÉ!!!", "THÔNG BÁO");
                    return;
                }
                AutoCreateTicketsByShowTimes(showTimes);
                LoadAllListShowTimes();
                LoadTicketsByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ TẠO!!!", "THÔNG BÁO");
            }
        }
        void LoadTicketsByShowTimes(string showTimesID)
        {
            List<Ticket> listTicket = TicketDB.GetListTicketsByShowTimes(showTimesID);
            ticketDGV.DataSource = listTicket;
        }
        void LoadAllListShowTimes()
        {
            listAllListShowTime.Items.Clear();

            List<ShowTimes> allListShowTime = ShowTimeDB.GetAllListShowTimes();
            foreach (ShowTimes showTimes in allListShowTime)
            {
                ListViewItem lvi = new ListViewItem(showTimes.CinemaName);
                lvi.SubItems.Add(showTimes.MovieName);
                lvi.SubItems.Add(showTimes.Time.ToString("HH:mm:ss dd/MM/yyyy"));
                lvi.Tag = showTimes;

                if (showTimes.Status == 1)
                {
                    lvi.SubItems.Add("Đã tạo");
                }
                else
                {
                    lvi.SubItems.Add("Chưa Tạo");
                }
                listAllListShowTime.Items.Add(lvi);
            }
        }
        void AutoCreateTicketsByShowTimes(ShowTimes showTimes)
        {
            int result = 0;
            Cinema cinema = CinemaDB.GetCinemaByName(showTimes.CinemaName);
            int Row = cinema.numberrow;
            int Column = cinema.numberseatofrow;
            for (int i = 0; i < Row; i++)
            {
                int temp = i + 65;
                char nameRow = (char)(temp);
                for (int j = 1; j <= Column; j++)
                {
                    string seatName = nameRow.ToString() + j;
                    result += TicketDB.InsertTicketByShowTimes(showTimes.ID, seatName);
                }
            }
            if (result == Row * Column)
            {
                int ret = ShowTimeDB.UpdateStatusShowTimes(showTimes.ID, 1);
                if (ret > 0)
                    MessageBox.Show("TẠO VÉ TỰ ĐỘNG THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
                MessageBox.Show("TẠO VÉ TỰ ĐỘNG THẤT BẠI!", "THÔNG BÁO");
        }

        private void btnDeleteTicketsByShowTime_Click(object sender, EventArgs e)
        {
            if (listAllListShowTime.SelectedItems.Count > 0)
            {
                ShowTimes showTimes = listAllListShowTime.SelectedItems[0].Tag as ShowTimes;
                if (showTimes.Status == 0)
                {
                    MessageBox.Show("LỊCH CHIẾU NÀY CHƯA ĐƯỢC TẠO VÉ!!!", "THÔNG BÁO");
                    return;
                }
                DeleteTicketsByShowTimes(showTimes);
                LoadAllListShowTimes();
                LoadTicketsByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XÓA!!!", "THÔNG BÁO");
            }
        }
        private void DeleteTicketsByShowTimes(ShowTimes showTimes)
        {
            Cinema cinema = CinemaDB.GetCinemaByName(showTimes.CinemaName);
            int Row = cinema.numberrow;
            int Column = cinema.numberseatofrow;
            int result = TicketDB.DeleteTicketsByShowTimes(showTimes.ID);
            if (result == Row * Column)
            {
                int ret = ShowTimeDB.UpdateStatusShowTimes(showTimes.ID, 0);
                if (ret > 0)
                    MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA LỊCH CHIẾU ID=" + showTimes.ID + " THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
                MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA LỊCH CHIẾU ID=" + showTimes.ID + " THẤT BẠI!", "THÔNG BÁO");
        }

        private void btnShowAllTicketsBoughtByShowTime_Click(object sender, EventArgs e)
        {
            if (listAllListShowTime.SelectedItems.Count > 0)
            {
                ShowTimes showTimes = listAllListShowTime.SelectedItems[0].Tag as ShowTimes;
                LoadTicketsBoughtByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XEM!!!", "THÔNG BÁO");
            }
        }
        void LoadTicketsBoughtByShowTimes(string showTimesID)
        {
            List<Ticket> listTicket = TicketDB.GetListTicketsBoughtByShowTimes(showTimesID);
            ticketDGV.DataSource = listTicket;
        }

        private void btnShowAllTicketsByShowTime_Click(object sender, EventArgs e)
        {
            if (listAllListShowTime.SelectedItems.Count > 0)
            {
                ShowTimes showTimes = listAllListShowTime.SelectedItems[0].Tag as ShowTimes;
                LoadTicketsByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XEM!!!", "THÔNG BÁO");
            }
        }

        private void btnShowShowTimeNotCreateTickets_Click(object sender, EventArgs e)
        {
            LoadListShowTimesNotCreateTickets();
        }
        private void LoadListShowTimesNotCreateTickets()
        {
            listAllListShowTime.Items.Clear();

            List<ShowTimes> allListShowTime = ShowTimeDB.GetListShowTimesNotCreateTickets();
            foreach (ShowTimes showTimes in allListShowTime)
            {
                ListViewItem lvi = new ListViewItem(showTimes.CinemaName);
                lvi.SubItems.Add(showTimes.MovieName);
                lvi.SubItems.Add(showTimes.Time.ToString("HH:mm:ss dd/MM/yyyy"));
                lvi.Tag = showTimes;

                if (showTimes.Status == 1)
                {
                    lvi.SubItems.Add("Đã tạo");
                }
                else
                {
                    lvi.SubItems.Add("Chưa Tạo");
                }
                listAllListShowTime.Items.Add(lvi);
            }
        }

        private void btnAllListShowTimes_Click(object sender, EventArgs e)
        {
            LoadAllListShowTimes();
        }
    }
}
