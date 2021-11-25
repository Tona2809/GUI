using MovieTheater.DTO;
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
        public MainForm(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        void ChangeAccount(int type)
        {
            if (loginAccount.Type == 1 || loginAccount.Type == 2)
            lblAccountInfo.Text += LoginAccount.Username;
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

        private void NVBT_Click(object sender, EventArgs e)
        {
            if (Globals.Globaltypeusn == 2)
            {
                NVBT.Enabled = false;
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo");
            }
            else
            {
                pnMain.Controls.Clear();
                StaffForm mvf = new StaffForm();
                mvf.TopLevel = false;
                pnMain.Controls.Add(mvf);
                mvf.Dock = DockStyle.Fill;
                mvf.Show();
            }
        }

        private void AccountBT_Click(object sender, EventArgs e)
        {
            if (Globals.Globaltypeusn == 2)
            {
                NVBT.Enabled = false;
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo");
            }
            else
            {
                pnMain.Controls.Clear();
                AccountForm mvf = new AccountForm();
                mvf.TopLevel = false;
                pnMain.Controls.Add(mvf);
                mvf.Dock = DockStyle.Fill;
                mvf.Show();
            }
        }

        private void TicketBT_Click(object sender, EventArgs e)
        {
            SellerForm mf = new SellerForm();
            mf.Show();
        }

        private void DoanhthuBt_Click(object sender, EventArgs e)
        {
            if (Globals.Globaltypeusn == 2)
            {
                NVBT.Enabled = false;
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo");
            }
            else
            {
                pnMain.Controls.Clear();
                RevenueForm mvf = new RevenueForm();
                mvf.TopLevel = false;
                pnMain.Controls.Add(mvf);
                mvf.Dock = DockStyle.Fill;
                mvf.Show();
            }
        }

        private void changePWBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePassWordForm frm = new UpdatePassWordForm(loginAccount);
            frm.ShowDialog();
            this.Show();
        }
    }
}
