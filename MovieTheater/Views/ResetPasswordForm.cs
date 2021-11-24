using MovieTheater.DAO;
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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void sentBT_Click(object sender, EventArgs e)
        {
            string username = usernameBT.Text;
            ResetPassword(username);
        }
        void ResetPassword(string username)
        {
            string connectionSTR = @"Data Source=LAPTOP-T093R9G6\SQLEXPRESS"
                  + ";Initial Catalog=RapPhim"
                  + ";Integrated Security=True";
            if ((myDB.connectiontest(connectionSTR)))
            {
                if (AccountDB.ResetPassword(username))
                {
                    MessageBox.Show("Reset mật khẩu thành công, mật khẩu mặc định : 123456");
                }
                else
                {
                    MessageBox.Show("Reset mật khẩu thất bại");
                }
            }
        }
    }
}
