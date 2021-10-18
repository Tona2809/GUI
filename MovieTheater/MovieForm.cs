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
        myDB mydb;
        BindingSource movieList = new BindingSource();
        public MovieForm()
        {
            InitializeComponent();
            LoadMovie();
        }
        public MovieForm(DataTable item)
        {
            InitializeComponent();
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            string phimID = MaphimTB.Text;
            string moviename = TenphimTB.Text;
            string movieDesc = moTaTB.Text;
            float movieLength = float.Parse(thoiluongTB.Text);
            DateTime startDate = dtpkc.Value;
            DateTime endDate = dtpkt.Value;
            string productor = sanxuatTB.Text;
            string director = daoDienTB.Text;
            int year = int.Parse(namSXTB.Text);
            if (moviePIC.Image == null)
            {
                MessageBox.Show("Bạn chưa thêm áp phích trước");
                return;
            }
            else
            if(MovieDB.insertMovie(phimID, moviename, movieDesc, movieLength, startDate, endDate, productor, director, year, MovieDB.imageToByteArray(moviePIC.Image)))
            {   
               
                  MessageBox.Show("Thêm phim thành công");
            }
            else
            {
                MessageBox.Show("Thêm phim thất bại");
            }
            InsertMoviebyGenre(phimID, clbmovie);
            loadpage();
        }
        void InsertMoviebyGenre(string movieID, CheckedListBox checkedListBox)
        {
            List<Genre> checkedGenreList = new List<Genre>();
            foreach (Genre checkedItem in checkedListBox.CheckedItems)
            {
                checkedGenreList.Add(checkedItem);
            }
            MovieByGenreDB.InsertMoviebyGenre(movieID, checkedGenreList);
        }
        void loadpage()
        {
            movieList.DataSource = MovieDB.GetMovie();
        }
        void LoadMovie()
        {
            dtvMovie.DataSource = movieList;
            loadpage();
            addMovieBinding();
        }
        void addMovieBinding()
        {
            MaphimTB.DataBindings.Add("Text", dtvMovie.DataSource, "Mã phim", true, DataSourceUpdateMode.Never);
            TenphimTB.DataBindings.Add("Text", dtvMovie.DataSource, "Tên phim", true, DataSourceUpdateMode.Never);
            moTaTB.DataBindings.Add("Text", dtvMovie.DataSource, "Mô tả", true, DataSourceUpdateMode.Never);
            thoiluongTB.DataBindings.Add("Text", dtvMovie.DataSource, "Thời lượng", true, DataSourceUpdateMode.Never);
            dtpkc.DataBindings.Add("Value", dtvMovie.DataSource, "Ngày khởi chiếu", true, DataSourceUpdateMode.Never);
            dtpkt.DataBindings.Add("Value", dtvMovie.DataSource, "Ngày kết thúc", true, DataSourceUpdateMode.Never);
            sanxuatTB.DataBindings.Add("Text", dtvMovie.DataSource, "Nơi sản xuất", true, DataSourceUpdateMode.Never);
            daoDienTB.DataBindings.Add("Text", dtvMovie.DataSource, "Đạo diễn", true, DataSourceUpdateMode.Never);
            namSXTB.DataBindings.Add("Text", dtvMovie.DataSource, "Năm SX", true, DataSourceUpdateMode.Never);
            LoadGenreIntoCheckedList(clbmovie);
        }
        void LoadGenreIntoCheckedList(CheckedListBox checkedList)
        {
            List<Genre> genreList = GenreDB.GetListGenre();
            checkedList.DataSource = genreList;
            checkedList.DisplayMember = "Name";
        }

        private void MaphimTB_TextChanged(object sender, EventArgs e)
        {
            moviePIC.Image = null;
            for (int i = 0; i< clbmovie.Items.Count; i++)
            {
                clbmovie.SetItemChecked(i, false);
            }
            List<Genre> listGenreofMovie = MovieByGenreDB.GetListGenreByMovie(MaphimTB.Text);
            for( int i = 0; i< clbmovie.Items.Count;i++)
            {
                Genre genre = (Genre)clbmovie.Items[i];
                foreach (Genre item in listGenreofMovie)
                {
                    if(genre.ID == item.ID)
                    {
                        clbmovie.SetItemChecked(i, true);
                            break;
                    }    
                }    
            }

            Movie movie = MovieDB.GetMovieByID(MaphimTB.Text);
            if (movie == null)
                return;
            if(movie.Poster != null)
            {
                moviePIC.Image = MovieDB.byteArrayToImage(movie.Poster);
            }    


        }

        private void XoaBT_Click(object sender, EventArgs e)
        {
            string movieID = MaphimTB.Text;
            if (MovieDB.DeleleMovie(movieID))
            {
                MessageBox.Show("Xóa phim thành công");
            }    
            else
            {
                MessageBox.Show("Xóa phim thất bại");
            }
            loadpage();
        }

        private void editBT_Click(object sender, EventArgs e)
        {
            string phimID = MaphimTB.Text;
            string moviename = TenphimTB.Text;
            string movieDesc = moTaTB.Text;
            float movieLength = float.Parse(thoiluongTB.Text);
            DateTime startDate = dtpkc.Value;
            DateTime endDate = dtpkt.Value;
            string productor = sanxuatTB.Text;
            string director = daoDienTB.Text;
            int year = int.Parse(namSXTB.Text);
            if(moviePIC.Image==null)
            {
                MessageBox.Show("Mời bạn thêm ảnh cho phim");
                return;
            }
            if (MovieDB.UpdateMovie(phimID, moviename, movieDesc, movieLength, startDate, endDate, productor, director, year, MovieDB.imageToByteArray(moviePIC.Image)))
            {
                MessageBox.Show("Edit phim thành công");
            }else
            {
                MessageBox.Show("Edit phim thất bại");
            }    
        }
    }
}
