using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vothanhtrong2121110273_buoi1
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 1;
            s.Name = "Chúng ta của hiện tại";
            s.Author = "Sơn tùng MPT";
            lst.Add(s);

            s = new Song();
            s.Id = 2;
            s.Name = "Chúng ta không thuộc về nhau";
            s.Author = "Sơn tùng MPT";
            lst.Add(s);

            s = new Song();
            s.Id = 3;
            s.Name = "Đom đóm";
            s.Author = "Jack";
            lst.Add(s);

            s = new Song();
            s.Id = 4;
            s.Name = "Tiền nhiều để làm gì";
            s.Author = "Gdugky";
            lst.Add(s);

            s = new Song();
            s.Id = 5;
            s.Name = "Đau để trưởng thành";
            s.Author = "OnlyC";
            lst.Add(s);

            return lst;
        }
        private void Form18_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            lbSong.DataSource = lst;
            lbSong.DisplayMember = "Name";

        }
        private void btSelect_Click(object sender, EventArgs e)
        {
            Song song = (Song)lbSong.SelectedItem;
            string id = song.Id.ToString();
            string name = song.Name;
            string author = song.Author;
            lbFavorite.Items.Add(id + "-" + name + "-" + author);

        }



        private void btDeselect_Click(object sender, EventArgs e)
        {
            Song song = (Song)lbFavorite.SelectedItem;
            string id = song.Id.ToString();
            string name = song.Name;
            string author = song.Author;
            lbSong.Items.Add(name);

        }
    }
}
