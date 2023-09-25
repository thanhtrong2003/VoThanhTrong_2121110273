using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vothanhtrong2121110273_buoi1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoy.Text);
            int kq = x * y;
            tbkqua.Text = tbkqua.Text + x.ToString() + "*" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoy.Text);
            int kq = x + y;
            tbkqua.Text = tbkqua.Text + x.ToString() + "+" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Caculator.txt", true);
            sw.Write(tbkqua.Text);
            sw.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
