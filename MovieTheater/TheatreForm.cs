using MovieTheater.DAO;
using MovieTheater.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class TheatreForm : Form
    {
        int SIZE = 30;//Size của ghế
        int GAP = 7;//Khoảng cách giữa các ghế

        List<Ticket> listSeat = new List<Ticket>();

        //dùng lưu vết các Ghế đang chọn
        List<Button> listSeatSelected = new List<Button>();

        float displayPrice = 0;//Hiện thị giá vé
        float ticketPrice = 0;//Lưu giá vé gốc  
        float total = 0;//Tổng giá tiền
        float discount = 0;//Tiền được giảm
        float payment = 0;//Tiền phải trả

        ShowTimes Times = new ShowTimes() ;
        Movie Movie = new Movie();
        public TheatreForm(ShowTimes showTimes, Movie movie)
        {
            InitializeComponent();
            Times = showTimes;
            Movie = movie;
        }

        private void TheatreForm_Load(object sender, EventArgs e)
        {

            ticketPrice = Times.TicketPrice;

            label1.Text = "Rạp phim CLE | " + Times.CinemaName + " | " + Times.MovieName;
            label2.Text = Times.Time.ToShortDateString() + " | "
                + Times.Time.ToShortTimeString() + " - "
                + Times.Time.AddMinutes(Movie.Time).ToShortTimeString();
            if (Movie.Poster != null)
                picFilm.Image = MovieDB.bytetoimage(Movie.Poster);
            rdoAdult.Checked = true;
            grpLoaiVe.Enabled = false;
            LoadDataCinema(Times.CinemaName);

            listSeat = TicketDB.GetListTicketsByShowTimes(Times.ID);
            LoadSeats(listSeat);
        }
        private void LoadSeats(List<Ticket> list)
        {
            flpSeat.Controls.Clear();         
            for (int i = 0; i < list.Count; i++)
            {
                Button btnSeat = new Button() 
                { Width = SIZE + 20, Height = SIZE };
                btnSeat.Text = list[i].SeatName;
                if (list[i].Status == 1)
                    btnSeat.BackColor = Color.Red;
                else
                    btnSeat.BackColor = Color.White;
                btnSeat.Click += BtnSeat_Click;
                flpSeat.Controls.Add(btnSeat);
                btnSeat.Tag = list[i];
            
            }
        }
        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            if (btnSeat.BackColor == Color.White)
            {
                grpLoaiVe.Enabled = true;
                rdoAdult.Checked = true;
                btnSeat.BackColor = Color.Yellow;
                Ticket ticket = btnSeat.Tag as Ticket;
                ticket.Price = ticketPrice;
                displayPrice = ticket.Price;
                total += ticketPrice;
                payment = total - discount;
                ticket.Type = 1;

                listSeatSelected.Add(btnSeat);
            }
            else if (btnSeat.BackColor == Color.Yellow)
            {
                btnSeat.BackColor = Color.White;
                Ticket ticket = btnSeat.Tag as Ticket;
                total -= ticket.Price;
                payment = total - discount;
                ticket.Price = 0;
                displayPrice = ticket.Price;
                ticket.Type = 0;

                listSeatSelected.Remove(btnSeat);
                grpLoaiVe.Enabled = false;
            }
            else if (btnSeat.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế số [" + btnSeat.Text + "] đã có người mua");
            }
            LoadBill();
        }
        private void LoadBill()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            //Đổi culture vùng quốc gia để đổi đơn vị tiền tệ 

            //Thread.CurrentThread.CurrentCulture = culture;
            //dùng thread để chuyển cả luồng đang chạy về vùng quốc gia đó

            lblTicketPrice.Text = displayPrice.ToString("c", culture);
            lblTotal.Text = total.ToString("c", culture);
            lblDiscount.Text = discount.ToString("c", culture);
            lblPayment.Text = payment.ToString("c", culture);

            //Đổi đơn vị tiền tệ
            //gán culture chỗ này thì chỉ có chỗ này sd culture này còn
            //lại sài mặc định
        }
        private void LoadDataCinema(string cinemaName)
        {
            Cinema cinema = CinemaDB.GetCinemaByName(cinemaName);
            int Row = cinema.numberrow;
            int Column = cinema.numberseatofrow;
            flpSeat.Size = new Size((SIZE + 20 + GAP) * Column, (SIZE + GAP) * Row);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn hủy tất cả những vé đã chọn ko?",
             "Hủy Mua Vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            foreach (Button btn in listSeatSelected)
            {
                btn.BackColor = Color.White;
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }
        private void RestoreDefault()
        {
            listSeatSelected.Clear();

            rdoAdult.Checked = true;
            grpLoaiVe.Enabled = false;
            total = 0;
            displayPrice = 0;
            discount = 0;
            payment = 0;
              LoadBill();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (listSeatSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé trước khi thanh toán!");
                return;
            }
            string message = "Bạn có chắc chắn mua những vé: \n";
            foreach (Button btn in listSeatSelected)
            {
                message += "[" + btn.Text + "] ";
            }
            message += "\nKhông?";
            DialogResult result = MessageBox.Show(message, "Hỏi Mua",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int ret = 0;

                    foreach (Button btn in listSeatSelected)
                    {
                        Ticket ticket = btn.Tag as Ticket;

                        ret += TicketDB.BuyTicket(ticket.ID, ticket.Type, ticket.Price);
                    }
                if (ret == listSeatSelected.Count)
                {
                    MessageBox.Show("Bạn đã mua vé thành công!");
                }
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        private void rdoStudent_Click(object sender, EventArgs e)
        {
            if (rdoStudent.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                Ticket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as Ticket;
                ticket.Type = 2;

                float oldPrice = ticket.Price;
                ticket.Price = 0.8f * ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }

        private void rdoAdult_Click(object sender, EventArgs e)
        {
            if (rdoAdult.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                Ticket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as Ticket;
                ticket.Type = 1;

                float oldPrice = ticket.Price;
                ticket.Price = ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }

        private void rdoChild_Click(object sender, EventArgs e)
        {
            if (rdoChild.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                Ticket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as Ticket;
                ticket.Type = 3;

                float oldPrice = ticket.Price; 
                ticket.Price = 0.7f * ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
