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
    public partial class Form13 : Form
    {

        public Form13()
        {
            InitializeComponent();
        }

        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "KO1";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "KO2";
            f.Name = "Ngoại Ngữ";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "KO3";
            f.Name = "Quản tri kinh doanh";
            f.Quantity = 5200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "KO4";
            f.Name = "Cơ khí";
            f.Quantity = 6200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "KO5";
            f.Name = "Điện";
            f.Quantity = 7200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "KO6";
            f.Name = "Cơ khí động lực";
            f.Quantity = 8200;
            lst.Add(f);


            return lst;
        }

        private void Form13_Load_1(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            comboBox1.DataSource = lst;
            comboBox1.DisplayMember = "Name";
        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {


            comboBox1.ValueMember = "Id";
            string id = string.Empty;

            if (comboBox1.SelectedValue != null)
            {
                id = comboBox1.SelectedValue.ToString();
            }
            textBox1.Text = "Bạn đã chọn khoa có mã :" + id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "Name";
            string name = string.Empty;

            if (comboBox1.SelectedValue != null)
            {
                name = comboBox1.SelectedValue.ToString();
            }
            textBox1.Text = "Bạn đã chọn khoa có tên:" + name;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "Id";
            string id = string.Empty;

            if (comboBox1.SelectedValue != null)
            {
                id = comboBox1.SelectedValue.ToString();
            }
            textBox1.Text = "Bạn đã chọn khoa có mã :" + id;
        }


    }
}
