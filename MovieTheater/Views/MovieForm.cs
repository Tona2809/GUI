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
    public partial class MovieForm : Form
    {
        BindingSource movieList = new BindingSource();
        public MovieForm()
        {
            InitializeComponent();
            LoadMovie();
          
        }
        void AddMoviebinding()
        {
            MaphimTB.DataBindings.Add("Text", dtvMovie.DataSource, "iD", true, DataSourceUpdateMode.Never);
            TenphimTB.DataBindings.Add("Text", dtvMovie.DataSource, "tenPhim", true, DataSourceUpdateMode.Never);
            moTaTB.DataBindings.Add("Text", dtvMovie.DataSource, "moTa", true, DataSourceUpdateMode.Never);
            thoiluongTB.DataBindings.Add("Text", dtvMovie.DataSource, "thoiLuong", true, DataSourceUpdateMode.Never);
            dtpkc.DataBindings.Add("Value", dtvMovie.DataSource, "ngayKhoiChieu", true, DataSourceUpdateMode.Never);
            dtpkt.DataBindings.Add("Value", dtvMovie.DataSource, "ngayKetThuc", true, DataSourceUpdateMode.Never);
            sanxuatTB.DataBindings.Add("Text", dtvMovie.DataSource, "sanXuat", true, DataSourceUpdateMode.Never);
            daoDienTB.DataBindings.Add("Text", dtvMovie.DataSource, "daoDien", true, DataSourceUpdateMode.Never);
            namSXTB.DataBindings.Add("Text", dtvMovie.DataSource, "namSX", true, DataSourceUpdateMode.Never);
           LoadGenreIntoCheckList(clbmovie);
        }
        void LoadGenreIntoCheckList(CheckedListBox checkedList)
        {
            List<Genre> genrelist = GenreDB.GetListGenre();
            checkedList.DataSource = genrelist;
            checkedList.DisplayMember = "Name";
        }
        void LoadMovie()
        {
            dtvMovie.DataSource = movieList;
            LoadMovieList();
            AddMoviebinding();
        }
        void LoadMovieList()
        {
            movieList.DataSource = MovieDB.GetMovie();
        }
        private void addBT_Click(object sender, EventArgs e)
        {
            string movieID = MaphimTB.Text;
            string moviename = TenphimTB.Text;
            string movieDesc = moTaTB.Text;
            float movieLength = float.Parse(thoiluongTB.Text);
            DateTime startdate = dtpkc.Value;
            DateTime enddate = dtpkt.Value;
            string productor = sanxuatTB.Text;
            string director = daoDienTB.Text;
            int year = int.Parse(namSXTB.Text);
            if(moviePIC.Image == null)
            {
                MessageBox.Show("Mời bạn thêm hình ảnh cho phim");
                return;
            }
            if (MovieDB.InsertMovie(movieID, moviename, movieDesc, movieLength, startdate, enddate, productor, director, year, MovieDB.imagetobyte(moviePIC.Image))) 
            { 
                MessageBox.Show("Thêm phim thành công");
            }    
            else
            {
                MessageBox.Show("Thêm phim thất bại");
            }
            InsertMovie_genre(movieID, clbmovie);


        }
        void InsertMovie_genre(string movieID, CheckedListBox checkedListBox)
        {
            List<Genre> checkGenrelist = new List<Genre>();
            foreach(Genre checkItem in checkedListBox.CheckedItems)
            {
                checkGenrelist.Add(checkItem);
            }
            MovieByGenreDB.InsertMovie_Genre(movieID, checkGenrelist);
        }

        private void clbmovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UploadBT_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathImage = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePathImage = openFile.FileName;
                    moviePIC.Image = Image.FromFile(filePathImage.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void editBT_Click(object sender, EventArgs e)
        {
            string movieID = MaphimTB.Text;
            string movieName = TenphimTB.Text;
            string movieDesc = moTaTB.Text;
            float movieLength = float.Parse(thoiluongTB.Text);
            DateTime startDate = dtpkc.Value;
            DateTime endDate = dtpkt.Value;
            string productor = sanxuatTB.Text;
            string director = daoDienTB.Text;
            int year = int.Parse(namSXTB.Text);
            if (moviePIC.Image == null)
            {
                MessageBox.Show("Mời bạn thêm hình ảnh cho phím trước");
                return;
            }
            if (MovieDB.UpdateMovie(movieID, movieName, movieDesc, movieLength, startDate, endDate, productor, director, year, MovieDB.imagetobyte(moviePIC.Image)))
            {
                updateMovie_Genre(movieID, clbmovie);
                MessageBox.Show("Update phim thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("update phim thất bại", "Thông báo");
            }
        }
        void updateMovie_Genre(string movieID,CheckedListBox checkedList)
        {
            List<Genre> checkgenrelist = new List<Genre>();
            foreach(Genre items in checkedList.CheckedItems)
            {
                checkgenrelist.Add(items);
            }
            MovieByGenreDB.UpdateMovie_Genre(movieID, checkgenrelist);
        }
        private void xemBT_Click(object sender, EventArgs e)
        {
            LoadMovieList();
        }

        private void XoaBT_Click(object sender, EventArgs e)
        {
            string movieId = MaphimTB.Text;
            if(MovieDB.DeleteMovie(movieId))
            {
                MessageBox.Show("Xóa phim thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa phim thất bại", "Thông báo");
            }
            LoadMovieList();
        }
    }
}
