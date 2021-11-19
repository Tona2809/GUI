using MovieTheater.DAO;
using MovieTheater.Model;
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

    public partial class AccountForm : Form
    {
        BindingSource accountList = new BindingSource();
        public AccountForm()
        {
            InitializeComponent();
            LoadAccount();
        }
        void LoadAccount()
        {
            dtvAccount.DataSource = accountList;
            LoadAccountList();
            AddAccountBinding();
        }
        void LoadAccountList()
        {
            accountList.DataSource = AccountDB.GetAccountList();
        }
        void AddAccountBinding()
        {
            UsernameTB.DataBindings.Add("Text", dtvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never);
            loaitkNBR.DataBindings.Add("Value", dtvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never);
            LoadStaffIntoComboBox(maNVCBB);
        }
        void LoadStaffIntoComboBox(ComboBox cbo)
        {
            cbo.DataSource = StaffDB.GetStaff();
            cbo.DisplayMember = "ID";
            cbo.ValueMember = "ID";
        }
        private void AddBT_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            int accountType = (int)loaitkNBR.Value;
            string staffID = maNVCBB.SelectedValue.ToString();
            if (AccountDB.InsertAccount(username, accountType, staffID))
            {
                MessageBox.Show("Thêm tài khoản thành công, mật khẩu mặc định : 123456");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccountList();
        }

        private void EDITBT_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            MessageBox.Show(username);
            int accountType = (int)loaitkNBR.Value;
            if (AccountDB.UpdateAccount(username, accountType))
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }
            LoadAccountList();
        }

        private void ShowBT_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        private void maNVCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff staff = maNVCBB.SelectedItem as Staff;
            if (staff == null)
                return;
            tenNVTB.Text = staff.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            if(AccountDB.DeleteAccount(username))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            LoadAccountList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string staffName = searchTB.Text;
            accountList.DataSource = AccountDB.SearchAccountByStaffName(staffName);
        }
    }
}
