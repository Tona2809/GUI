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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void ConnectBT_Click(object sender, EventArgs e)
        {
            ConnectDB formConnection = new ConnectDB();
            formConnection.ShowDialog();
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            string password = PasswordTB.Text;
            int check = CheckLogin(username, password);
            if(check == 1)
            {
                MessageBox.Show("Đăng nhập thành công!!!!", "THÔNG BÁO");
            }
            else if(check ==0)
            {
                MessageBox.Show("SAI TÊN TÀI KHOẢN HOẶC MẬT KHẨU!!!!", "THÔNG BÁO");
            }    
            else
            {
                MessageBox.Show("KẾT NỐI THẤT BẠI", "THÔNG BÁO");
            }    
        }
        private int CheckLogin(string userName,string password)
        {
            return AccountDB.Login(userName, password);
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
