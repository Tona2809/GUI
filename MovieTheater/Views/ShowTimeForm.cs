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
    public partial class ShowTimeForm : Form
    {
        BindingSource showtimeList = new BindingSource();
        public ShowTimeForm()
        {
            InitializeComponent();
            LoadShowtime();
        }
        void LoadShowtimeList()
        {
            showtimeList.DataSource = ShowTimeDB.GetListShowtime();
        }
        void LoadFormatMovieIntoComboBox()
        {
            cbbformat.DataSource = FormatMovieDB.GetFormatMovie();
            cbbformat.DisplayMember = "ID";
        }
        void AddShowtimeBinding()
        {
            malichchieuTB.DataBindings.Add("Text", dgvshowtime.DataSource, "Mã lịch chiếu", true, DataSourceUpdateMode.Never);
            dtpshowdate.DataBindings.Add("Value", dgvshowtime.DataSource, "Thời gian chiếu", true, DataSourceUpdateMode.Never);
            dtpshowtime.DataBindings.Add("Value", dgvshowtime.DataSource, "Thời gian chiếu", true, DataSourceUpdateMode.Never);
            ticketpriceTB.DataBindings.Add("Text", dgvshowtime.DataSource, "Giá vé", true, DataSourceUpdateMode.Never);
        }
        void LoadShowtime()
        {
            dgvshowtime.DataSource = showtimeList;
            LoadShowtimeList();
            LoadFormatMovieIntoComboBox();
            AddShowtimeBinding();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            string showtimeID = malichchieuTB.Text;
            string cinemaID = ((Cinema)cbbcinemaID.SelectedItem).ID;
            string formatMovieID = ((FormatMovie)cbbformat.SelectedItem).ID;
            DateTime time = new DateTime(dtpshowdate.Value.Year, dtpshowdate.Value.Month, dtpshowdate.Value.Day, dtpshowtime.Value.Hour, dtpshowtime.Value.Minute, dtpshowtime.Value.Second);
            //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
            float ticketPrice = float.Parse(ticketpriceTB.Text);
            if (ShowTimeDB.InsertShowtime(showtimeID, cinemaID, formatMovieID, time, ticketPrice))
            {
                MessageBox.Show("Thêm lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm lịch chiếu thất bại");
            }
            LoadShowtimeList();
        }

        private void cbbformat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbformat.SelectedIndex != -1)
            {
                FormatMovie formatMovieSelecting = (FormatMovie)cbbformat.SelectedItem;
                tenphimTB.Text = formatMovieSelecting.MovieName;
                manhinhTB.Text = formatMovieSelecting.ScreenTypeName;

                cbbcinemaID.DataSource = null;
                ScreenType screenType = ScreenTypeDB.GetScreenTypeByName(formatMovieSelecting.ScreenTypeName);
                cbbcinemaID.DataSource = CinemaDB.GetCinemaByScreenTypeID(screenType.ID);
                cbbcinemaID.DisplayMember = "Name";
            }
        }
    }
}
