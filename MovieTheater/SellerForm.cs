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
using System.Timers;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            LoadMovie(dateTimePicker1.Value);
        }
        private void LoadMovie(DateTime date)
        {
            movieCBB.DataSource = MovieDB.GetListMovieByDate(date);
            movieCBB.DisplayMember = "Name";
        }  
        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                timer1.Stop();
                ShowTimes showTimes = listView1.SelectedItems[0].Tag as ShowTimes;
                Movie movie = movieCBB.SelectedItem as Movie;
                TheatreForm frm = new TheatreForm();
                this.Hide();
                frm.ShowDialog();
                this.OnLoad(null);
                this.Show();
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            LoadMovie(dateTimePicker1.Value);
            timer1.Start();
        }

        private void movieCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (movieCBB.SelectedIndex != -1)
            {
                listView1.Items.Clear();
                Movie movie = movieCBB.SelectedItem as Movie;
                comboBox2.DataSource = FormatMovieDB.GetListFormatMovieByMovie(movie.ID);
                comboBox2.DisplayMember = "ScreenTypeName";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                listView1.Items.Clear();
                FormatMovie format = comboBox2.SelectedItem as FormatMovie;
                LoadListShowTimeByFilm(format.ID);
            }
        }
        private void LoadListShowTimeByFilm(string formatMovieID)
        {
           
            DataTable data = ShowTimeDB.GetListShowTimeByFormatMovie(formatMovieID, dateTimePicker1.Value);
            if (data == null) MessageBox.Show("null");
            foreach (DataRow row in data.Rows)
            {
                ShowTimes showTimes = new ShowTimes(row);
                ListViewItem lvi = new ListViewItem("");
                lvi.SubItems.Add(showTimes.CinemaName);
                lvi.SubItems.Add(showTimes.MovieName);
                lvi.SubItems.Add(showTimes.Time.ToShortTimeString());
                lvi.Tag = showTimes;

                string statusShowTimes = TicketDB.CountTheNumberOfTicketsSoldByShowTime(showTimes.ID)
                    + "/" + TicketDB.CountToltalTicketByShowTime(showTimes.ID);

                lvi.SubItems.Add(statusShowTimes);

                float status = (float)TicketDB.CountTheNumberOfTicketsSoldByShowTime(showTimes.ID)
                    / TicketDB.CountToltalTicketByShowTime(showTimes.ID);
          listView1.Items.Add(lvi);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.OnLoad(null);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadMovie(dateTimePicker1.Value);
        }
    }
}
