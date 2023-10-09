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
    public partial class Form26 : Form
    {
        private int eggSpeed = 5;
        public Form26()
        {
            InitializeComponent();
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();
        }

        private void Form26_Load(object sender, EventArgs e)
        {

        }

        private void tmEgg_Tick(object sender, EventArgs e)
        {
            pbEgg.Top += eggSpeed;

            if (pbEgg.Top + pbEgg.Height > this.Height)
            {
                tmEgg.Stop();
                MessageBox.Show("Quả trứng đã bể!");
                pbEgg.Top = 0;
            }
        }
    }
}
