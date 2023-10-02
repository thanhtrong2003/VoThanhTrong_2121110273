using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vothanhtrong2121110273;


namespace vothanhtrong2121110273_buoi1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 objForm2 = new Form2();
            objForm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 objForm3 = new Form3();
            objForm3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 objForm9 = new Form9();
            objForm9.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 objForm10 = new Form10();
            objForm10.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 objForm11 = new Form11();
            objForm11.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form12 objForm12 = new Form12();
            objForm12.ShowDialog();
        }

    

        private void button8_Click(object sender, EventArgs e)
        {
            Form13 objForm13 = new Form13();
            objForm13.ShowDialog();
        }

    }
}
