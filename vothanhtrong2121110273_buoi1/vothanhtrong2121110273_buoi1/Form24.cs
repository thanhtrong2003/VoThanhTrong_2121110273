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
    public partial class Form24 : Form
    {

        int Second = 0;
        public Form24()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopWatch.Interval = 1000;
            tmStopWatch.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopWatch.Stop();
        }

        private void tmStopWatch_Tick(object sender, EventArgs e)
        {
            Second++;
            lbDisplay.Text = Second.ToString();
        }
    }
}
