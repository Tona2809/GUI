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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardBT_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            DashboardForm dbf = new DashboardForm();
            dbf.TopLevel = false;
            pnMain.Controls.Add(dbf);
            dbf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dbf.Dock = DockStyle.Fill;
            dbf.Show();      
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
