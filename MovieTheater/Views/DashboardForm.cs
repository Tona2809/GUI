using MovieTheater.Views;
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
    public partial class DashboardFrm : Form
    {
        public DashboardFrm()
        {
            InitializeComponent();
        }

        private void phimBT_Click(object sender, EventArgs e)
        {
            pnmain.Controls.Clear();
            MovieForm mvf = new MovieForm();
            mvf.TopLevel = false;
            pnmain.Controls.Add(mvf);
            mvf.Dock = DockStyle.Fill;
            mvf.Show();
        }

        private void theloaiBT_Click(object sender, EventArgs e)
        {
            pnmain.Controls.Clear();
            GenreForm mvf = new GenreForm();
            mvf.TopLevel = false;
            pnmain.Controls.Add(mvf);
            mvf.Dock = DockStyle.Fill;
            mvf.Show();
        }

        private void phongchieuBT_Click(object sender, EventArgs e)
        {

            pnmain.Controls.Clear();
            RoomForm mvf = new RoomForm();
            mvf.TopLevel = false;
            pnmain.Controls.Add(mvf);
            mvf.Dock = DockStyle.Fill;
            mvf.Show();
        }

        private void screentypeBT_Click(object sender, EventArgs e)
        {
            pnmain.Controls.Clear();
            ScreenTypeForm mvf = new ScreenTypeForm();
            mvf.TopLevel = false;
            pnmain.Controls.Add(mvf);
            mvf.Dock = DockStyle.Fill;
            mvf.Show();
        }

        private void DinhdangBT_Click(object sender, EventArgs e)
        {
            pnmain.Controls.Clear();
            FormatMovieForm mvf = new FormatMovieForm();
            mvf.TopLevel = false;
            pnmain.Controls.Add(mvf);
            mvf.Dock = DockStyle.Fill;
            mvf.Show();
        }

        private void LichchieuBt_Click(object sender, EventArgs e)
        {
            pnmain.Controls.Clear();
            ShowTimeForm mvf = new ShowTimeForm();
            mvf.TopLevel = false;
            pnmain.Controls.Add(mvf);
            mvf.Dock = DockStyle.Fill;
            mvf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnmain.Controls.Clear();
            TicketForm mvf = new TicketForm();
            mvf.TopLevel = false;
            pnmain.Controls.Add(mvf);
            mvf.Dock = DockStyle.Fill;
            mvf.Show();
        }
    }
}
