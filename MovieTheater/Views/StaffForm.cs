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

    public partial class StaffForm : Form
    {
        BindingSource staffList = new BindingSource();
        public StaffForm()
        {
            InitializeComponent();
            LoadStaff();
        }
        void LoadStaff()
        {
            liststaffDGV.DataSource = staffList;
            LoadStaffList();
            AddStaffBinding();
        }
        void AddStaffBinding()
        {
            maNVTB.DataBindings.Add("Text", liststaffDGV.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never);
            tenNVTB.DataBindings.Add("Text", liststaffDGV.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            ngaysinhDTP.DataBindings.Add("Text", liststaffDGV.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            diachiTB.DataBindings.Add("Text", liststaffDGV.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            SDTTB.DataBindings.Add("Text", liststaffDGV.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            CMNDTB.DataBindings.Add("Text", liststaffDGV.DataSource, "CMND", true, DataSourceUpdateMode.Never);
        }
        void LoadStaffList()
        {
            staffList.DataSource = StaffDB.GetListStaff();
        }
        private void AddBT_Click(object sender, EventArgs e)
        {
            string staffId = maNVTB.Text;
            string staffName = tenNVTB.Text;
            DateTime staffBirth = DateTime.Parse(ngaysinhDTP.Text);
            string staffAddress = diachiTB.Text;
            string staffPhone = SDTTB.Text;
            int staffINumber = Int32.Parse(CMNDTB.Text);
            if (StaffDB.InsertStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber))
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
            LoadStaffList();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            string staffId = maNVTB.Text;
            string staffName = tenNVTB.Text;
            DateTime staffBirth = DateTime.Parse(ngaysinhDTP.Text);
            string staffAddress = diachiTB.Text;
            string staffPhone = SDTTB.Text;
            int staffINumber = Int32.Parse(CMNDTB.Text);
            if (StaffDB.UpdateStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber))
            {
                MessageBox.Show("Sửa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
            LoadStaffList();
        }

        private void Delbt_Click(object sender, EventArgs e)
        {
            string staffId = maNVTB.Text;
            if (StaffDB.DeleteStaff(staffId))
            {
                MessageBox.Show("Xóa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
            LoadStaffList();
        }

        private void ShowBT_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            string staffName = txtname.Text;
            DataTable staffSearchList = StaffDB.SearchStaffByName(staffName);
            staffList.DataSource = staffSearchList;

        }
    }
}
