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

namespace MovieTheater.Views
{
    public partial class ScreenTypeForm : Form
    {
        BindingSource screenTypeList = new BindingSource();
        public ScreenTypeForm()
        {
            InitializeComponent();
            LoadScreenType();
        }
        void LoadScreenType()
        {
            dgvscreen.DataSource = screenTypeList;
            LoadScreenTypeList();
            AddScreenTypeBinding();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void AddScreenTypeBinding()
        {
            maIDTB.DataBindings.Add("Text", dgvscreen.DataSource, "Mã màn hình", true, DataSourceUpdateMode.Never);
            nameTB.DataBindings.Add("Text", dgvscreen.DataSource, "Tên màn hình", true, DataSourceUpdateMode.Never);
        }

        private void ADDBT_Click(object sender, EventArgs e)
        {
            string screenId = maIDTB.Text;
            string screenname = nameTB.Text;
            if(ScreenTypeDB.InsertScreenType(screenId,screenname))
            {
                MessageBox.Show("Thêm loại màn hình thành công", "Thông báo");
            }  
            else
            {
                MessageBox.Show("Thêm loại màn hình thất bại", "Thông báo");
            }
            LoadScreenTypeList();
        }
        void LoadScreenTypeList()
        {
            screenTypeList.DataSource = ScreenTypeDB.GetScreenType();
        }

        private void editBT_Click(object sender, EventArgs e)
        {
            string screenId = maIDTB.Text;
            string screenname = nameTB.Text;
            if(ScreenTypeDB.UpdateScreenType(screenId,screenname))
            {
                MessageBox.Show("Sửa loại màn hình thành công", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Sửa loại màn hình thất bại", "Thông báo");
            }    
        }

        private void delBT_Click(object sender, EventArgs e)
        {
            string screenid = maIDTB.Text;
            if(ScreenTypeDB.DeleteScreenType(screenid))
            {
                MessageBox.Show("Xóa loại màn hình thành công", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Xóa loại màn hình thất bại", "Thông báo");
            }    
        }

        private void showBT_Click(object sender, EventArgs e)
        {
            LoadScreenTypeList();
        }
    }
}
