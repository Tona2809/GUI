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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void phimBT_Click(object sender, EventArgs e)
        {
            pnmain.Controls.Clear();
            MovieForm dbf = new MovieForm();
            dbf.TopLevel = false;
            pnmain.Controls.Add(dbf);
            dbf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dbf.Dock = DockStyle.Fill;
            dbf.Show();
        }

        private void theloaiBT_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
