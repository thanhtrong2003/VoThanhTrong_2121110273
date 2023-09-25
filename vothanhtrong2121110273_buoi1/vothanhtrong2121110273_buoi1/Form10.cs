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
    public partial class Form10 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(textBox1.Text);
            if (opr == "+")
                textBox1.Text = (workingMemory + secondValue).ToString();
            if (opr == "*")
                textBox1.Text = (workingMemory * secondValue).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            opr = button5.Text;
            workingMemory = decimal.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
