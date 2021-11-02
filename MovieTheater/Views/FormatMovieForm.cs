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
    public partial class FormatMovieForm : Form
    {
        BindingSource formatList = new BindingSource();
        public FormatMovieForm()
        {
            InitializeComponent();
            LoadFormatMovie();
        }
        void LoadFormatMovie()
        {
            formatmovieDTV.DataSource = formatList;
            LoadFormatMovieList();
            LoadMovieIDIntoCombobox(maphimCBB);
            LoadScreenIDIntoCombobox(mamanhinhCBB);
            AddFormatBinding();
        }
        void AddFormatBinding()
        {
            madinhdangTB.DataBindings.Add("Text", formatmovieDTV.DataSource, "Mã định dạng", true, DataSourceUpdateMode.Never);
        }
        void LoadFormatMovieList()
        {
            formatList.DataSource = FormatMovieDB.GetListFMovie();
        }
        void LoadScreenIDIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = ScreenTypeDB.GetListScreenType();
            comboBox.DisplayMember = "ID";
            comboBox.ValueMember = "ID";
        }

        void LoadMovieIDIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = MovieDB.GetListMovie();
            comboBox.DisplayMember = "iD";
            comboBox.ValueMember = "iD";
        }
        private void AddBT_Click(object sender, EventArgs e)
        {
            string formatID = madinhdangTB.Text;
            string movieID = maphimCBB.SelectedValue.ToString();
            string screenID = mamanhinhCBB.SelectedValue.ToString();
            if (FormatMovieDB.InsertFormatMovie(formatID, movieID, screenID))
            {
                MessageBox.Show("Thêm định dạng thành công");
            }
            else
            {
                MessageBox.Show("Thêm định dạng thất bại");
            }
            LoadFormatMovieList();
        }

        private void maphimCBB_SelectedValueChanged(object sender, EventArgs e)
        {
            Movie movieSelected = maphimCBB.SelectedItem as Movie;
            tenphimTB.Text = movieSelected.Name;
        }

        private void mamanhinhCBB_SelectedIndexChanged(object sender, EventArgs e)
        {

            ScreenType screenTypeSelected = mamanhinhCBB.SelectedItem as ScreenType;
            tenmanhinhTB.Text = screenTypeSelected.Name;
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            string formatID = madinhdangTB.Text;
            string movieID = maphimCBB.SelectedValue.ToString();
            string screenID = mamanhinhCBB.SelectedValue.ToString();
            if(FormatMovieDB.UpdateFormatMovie(formatID,movieID,screenID))
            {
                MessageBox.Show("Sửa định dạng phim thành công", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Sửa định dạng phim thất bại", "Thông báo");
            }    

        }

        private void DelBT_Click(object sender, EventArgs e)
        {
            string formatid = madinhdangTB.Text;
            if(FormatMovieDB.DeleteDinhdangMovie(formatid))
            {
                MessageBox.Show("Xóa định dạng phim thành công", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Xóa định dạng phim thất bại", "Thông báo");
            }    
        }

        private void madinhdangTB_TextChanged(object sender, EventArgs e)
        {
            string movieID = (string)formatmovieDTV.SelectedCells[0].OwningRow.Cells["Mã phim"].Value;
            Movie movieSelecting = MovieDB.GetMovieByID(movieID);
            //This is the Movie that we're currently selecting in dtgv

            if (movieSelecting == null)
                return;

            //cboFormat_MovieID.SelectedItem = movieSelecting;

            int indexMovie = -1;
            int iMovie = 0;
            foreach (Movie item in maphimCBB.Items)
            {
                if (item.Name == movieSelecting.Name)
                {
                    indexMovie = iMovie;
                    break;
                }
                iMovie++;
            }
            maphimCBB.SelectedIndex = indexMovie;


            string screenName = (string)formatmovieDTV.SelectedCells[0].OwningRow.Cells["Tên MH"].Value;
            ScreenType screenTypeSelecting = ScreenTypeDB.GetScreenTypeByName(screenName);
            //This is the ScreenType that we're currently selecting in dtgv

            if (screenTypeSelecting == null)
                return;

            //cboFormat_ScreenID.SelectedItem = screenTypeSelecting;

            int indexScreen = -1;
            int iScreen = 0;
            foreach (ScreenType item in mamanhinhCBB.Items)
            {
                if (item.Name == screenTypeSelecting.Name)
                {
                    indexScreen = iScreen;
                    break;
                }
                iScreen++;
            }
            mamanhinhCBB.SelectedIndex = indexScreen;
        }

        private void ShowBT_Click(object sender, EventArgs e)
        {
            LoadFormatMovieList();
        }
    }
}
