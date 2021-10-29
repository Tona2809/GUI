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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DashboardBT_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            DashboardFrm mvf = new DashboardFrm();
            mvf.TopLevel = false;
            pnMain.Controls.Add(mvf);
            mvf.Dock = DockStyle.Fill;
            mvf.Show();
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
