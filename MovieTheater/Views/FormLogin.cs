using MovieTheater.DAO;
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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            cbbsqlconnect.Items.Add(@"LAPTOP-T093R9G6\SQLEXPRESS");
        }
        public static string DataSource;
        public static string InitialCatalog;
        public static string UserID;
        public static string pwd;
        public static string connectionSTR;

        private void LoginBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTB.Text))
            {
                MessageBox.Show("Tên đăng nhập không thể bỏ trống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameTB.Focus();
            }
            else if (string.IsNullOrEmpty(PasswordTB.Text))
            {
                MessageBox.Show("Mật khẩu không thể bỏ trống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTB.Focus();
            }
            else
            {
                string connectionSTR = "Data Source=" + cbbsqlconnect.Text
                   + ";Initial Catalog=RapPhim"
                   + ";Integrated Security=True";
                if((myDB.connectiontest(connectionSTR)))
                {
                    int result = Login(UsernameTB.Text, PasswordTB.Text);
                    if(result == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        Account account = AccountDB.GetAccount(UsernameTB.Text);
                        if(account.Type == 1)    
                        {
                            this.Hide();
                            MainForm mf = new MainForm();
                            mf.ShowDialog();
                            this.Show();                          
                        }   
                        else
                        {
                            MessageBox.Show("Nhan vien ban ve", "Thông báo");
                        }
                    }else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                    }    
                }    
            }
        }
        private int Login(string username, string passoword)
        {
            return AccountDB.Login(username, passoword);
        }
    }
}
