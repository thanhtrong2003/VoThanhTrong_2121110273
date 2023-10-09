using System;
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
    public partial class Form23 : Form
    {

        int x = 0;
        int y = 0;
        public Form23()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog pb = new OpenFileDialog();

            pb.Title = "Open Image";
            pb.Filter = "JPEG files (*.jpg) |*.jpg";
            if (pb.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = pb.FileName;
            }

        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10;
            pbImage.Location = new Point(x, y);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10;
            pbImage.Location = new Point(x, y);
        }
    }
}
