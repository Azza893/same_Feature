using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed
{
    public partial class Form1 : Form
    {
        int track = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value<trackBar1.Maximum)
            {
                timer1.Interval=2000;
                this.progressBar1.Increment ( 3);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            track++;
            progressBar1.Value = track;
            if (track == 100)
            {
                timer1.Enabled = false;
                track = 0;
            }
        }
    }
}
