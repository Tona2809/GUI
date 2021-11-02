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
    public partial class GenreForm : Form
    {
        BindingSource genreList = new BindingSource();
        public GenreForm()
        {
            InitializeComponent();
            LoadGenre();
        }
        void LoadGenre()
        {
            genreDGV.DataSource = genreList;
            Loadgenrelist();
            AddGenrebiding();

        }
        void AddGenrebiding()
        {
            maTLTB.DataBindings.Add("Text", genreDGV.DataSource, "Mã thể loại", true, DataSourceUpdateMode.Never);
            tentlTB.DataBindings.Add("Text", genreDGV.DataSource, "Tên thể loại", true, DataSourceUpdateMode.Never);
            motaTB.DataBindings.Add("Text", genreDGV.DataSource, "Mô tả", true, DataSourceUpdateMode.Never);
        }
        private void addBT_Click(object sender, EventArgs e)
        {
            string gerneid = maTLTB.Text;
            string gernename = tentlTB.Text;
            string desc = motaTB.Text;
            if(GenreDB.insertGenre(gerneid,gernename,desc))
            {
                MessageBox.Show("Thêm thể loại thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thể loại thất bại", "Thông báo");
            }
            Loadgenrelist();
        }
        void Loadgenrelist()
        {
            genreList.DataSource = GenreDB.GetGenre();
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            string genreid = maTLTB.Text;
            if(GenreDB.DeleteGenre(genreid))
            {
                MessageBox.Show("Xóa thể loại thành công", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Xóa thể loại thất bại", "Thông báo");
            }    
        }

        private void ShowBT_Click(object sender, EventArgs e)
        {
            Loadgenrelist();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            string genreid = maTLTB.Text;
            string genrename = tentlTB.Text;
            string desc = motaTB.Text;
            if(GenreDB.UpdateGenre(genreid,genrename,desc))
            {
                MessageBox.Show("Edit thể loại thành công", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Edit thể loại thất bại", "Thông báo");
            }    
        }
    }
}
