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
    public partial class RoomForm : Form
    {
        BindingSource cinemaList = new BindingSource();

        public RoomForm()
        {
            InitializeComponent();
            loadroom();
        }

        private void sochongoiTB_TextChanged(object sender, EventArgs e)
        {

        }

        void loadroom()
        {
            dtvcinema.DataSource = cinemaList;
            LoadCinemaList();
            AddCinemaBinding();
        }
        void AddCinemaBinding()
        {
            MaphongTB.DataBindings.Add("Text", dtvcinema.DataSource, "Mã phòng", true, DataSourceUpdateMode.Never);
            tenphongTB.DataBindings.Add("Text", dtvcinema.DataSource, "Tên phòng", true, DataSourceUpdateMode.Never);
            tinhtrangTB.DataBindings.Add("Text", dtvcinema.DataSource, "Tình trạng", true, DataSourceUpdateMode.Never);
            sohanggheTB.DataBindings.Add("Text", dtvcinema.DataSource, "Số hàng ghế", true, DataSourceUpdateMode.Never);
            soghemoihangTB.DataBindings.Add("Text", dtvcinema.DataSource, "Ghế mỗi hàng", true, DataSourceUpdateMode.Never);
            LoadScreenTypeIntoComboBox(cbbManhinh);
        }
        void LoadCinemaList()
        {
            cinemaList.DataSource = CinemaDB.GetListCinema();
        }
        void LoadScreenTypeIntoComboBox(ComboBox cbo)
        {
            cbo.DataSource = ScreenTypeDB.GetListScreenType();
            cbo.DisplayMember = "Name";
            cbo.ValueMember = "ID";
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            string cinemaID = MaphongTB.Text;
            string cinemaName = tenphongTB.Text;
            string screenTypeID = cbbManhinh.SelectedValue.ToString();
            int cinemaStatus = int.Parse(tinhtrangTB.Text);
            int numberOfRows = int.Parse(sohanggheTB.Text);
            int seatsPerRows = int.Parse(soghemoihangTB.Text);
            if (CinemaDB.Insertcinema(cinemaID, cinemaName, screenTypeID, cinemaStatus, numberOfRows, seatsPerRows))
            {
                MessageBox.Show("Thêm phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm phòng chiếu thất bại");
            }
            LoadCinemaList();
        }

        private void DelBT_Click(object sender, EventArgs e)
        {
            string cinemaID = MaphongTB.Text;
            if (CinemaDB.DeleteCinema(cinemaID))
            {
                MessageBox.Show("Xóa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Xóa phòng chiếu thất bại");
            }
            LoadCinemaList();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            string cinemaID = MaphongTB.Text;
            string cinemaName = tenphongTB.Text;
            string screenTypeID = cbbManhinh.SelectedValue.ToString();
            int cinemaStatus = int.Parse(tinhtrangTB.Text);
            int numberOfRows = int.Parse(sohanggheTB.Text);
            int seatsPerRows = int.Parse(soghemoihangTB.Text);
            if (CinemaDB.Updatecinema(cinemaID, cinemaName, screenTypeID, cinemaStatus, numberOfRows, seatsPerRows))
            {
                MessageBox.Show("Sửa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Sửa phòng chiếu thất bại");
            }
            LoadCinemaList();
        }

        private void showBT_Click(object sender, EventArgs e)
        {
            LoadCinemaList();
        }
    }
}
