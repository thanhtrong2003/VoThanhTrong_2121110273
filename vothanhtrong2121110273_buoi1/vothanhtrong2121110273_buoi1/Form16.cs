using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace vothanhtrong2121110273_buoi1
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string msg = null;
            if (rbNam.Checked == true)
                msg += "Nam";
            if (rbNu.Checked == true)
                msg += "Nữ";

            tbStatus.Text = textBox1.ToString();
            tbStatus.Text = "Ngày sinh :" + dtpDate.Value.ToLongDateString() +"\r\n";


            //int index = cbKhoa.SelectedIndex;
            //tbStatus.Text = index.ToString();


            //string item = cbKhoa.SelectedIndex.ToString();
            //tbStatus.Text = "Bạn là sinh viên khoa :" + item + "\r\n";

          
        }
    }
}
