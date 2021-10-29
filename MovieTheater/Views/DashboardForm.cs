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
    }
}
