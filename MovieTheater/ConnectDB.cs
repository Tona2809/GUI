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

    public partial class ConnectDB : Form
    {
        public ConnectDB()
        {
            InitializeComponent();

            if (Properties.Settings.Default.DataSource != string.Empty && Properties.Settings.Default.InitialCatalog != string.Empty)
            {
                SnameTB.Text = Properties.Settings.Default.DataSource;
                DNameTB.Text = Properties.Settings.Default.InitialCatalog;
                UsernameTB.Text = Properties.Settings.Default.UserID;
                PasswordTB.Text = Properties.Settings.Default.pass;
            }
        }

        public static string DataSource;
        public static string UserID;
        public static string pass;
        public static string connectionSTR;
        public static string InitialCatalog;
        private void ConnectdbBT_Click(object sender, EventArgs e)
        {
            ConnectdbBT.Enabled = false;
            if(PasswordTB.Text !="")
            {
                connectionSTR = "Data Source=" + SnameTB.Text
                   + ";Initial Catalog=" + DNameTB.Text
                   + ";User ID=" + UsernameTB.Text
                   + ";pwd=" + PasswordTB.Text;
            }
            else
            {
                connectionSTR = "Data Source=" + SnameTB.Text
                  + ";Initial Catalog=" + DNameTB.Text
                  + ";Integrated Security=True";
            }    
        
            Properties.Settings.Default.DataSource = SnameTB.Text;
            Properties.Settings.Default.InitialCatalog = DNameTB.Text;
            Properties.Settings.Default.UserID = UsernameTB.Text;
            Properties.Settings.Default.pass = PasswordTB.Text;
            Properties.Settings.Default.connectionSTR = connectionSTR;
            Properties.Settings.Default.Save();

            bool result = myDB.connectiontest(connectionSTR);
            if (result)
            {
                MessageBox.Show("KẾT NỐI THÀNH CÔNG", "THÔNG BÁO");
            }
            else
                MessageBox.Show("KẾT NỐI THẤT BẠI", "THÔNG BÁO");
            ConnectdbBT.Enabled = true;
        }
    }
}
