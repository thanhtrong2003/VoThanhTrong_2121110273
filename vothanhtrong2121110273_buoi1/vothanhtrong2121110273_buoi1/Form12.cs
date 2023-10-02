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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = cbFaculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ : " + index.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string item = cbFaculty.SelectedIndex.ToString();
            tbDisplay.Text = "Bạn là sinh viên khoa :" + item;
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
