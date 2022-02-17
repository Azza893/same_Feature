using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Day7WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y, h, w;
        Pen pen = new Pen(Color.Red, 3);
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button1.BackColor = colorDialog1.Color;
            pen.Color = colorDialog1.Color;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
            Graphics graphics = this.CreateGraphics();
            Rectangle rectangle = new Rectangle(20, 20, h, w);
            if (radioButton1.Checked)
            {
                graphics.DrawEllipse(pen, rectangle);
            }
            if (radioButton2.Checked)
            {
                graphics.DrawRectangle(pen, rectangle);
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Graphics graphics = this.CreateGraphics();
            Rectangle rectangle = new Rectangle(x, y, h, w);
            if (radioButton1.Checked)
            {
                graphics.DrawEllipse(pen, rectangle);
            }
            if (radioButton2.Checked)
            {
                graphics.DrawRectangle(pen, rectangle);
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x;
            w = e.Y - y;
            Graphics graphics = this.CreateGraphics();
            Rectangle rectangle = new Rectangle(x, y, h, w);
            if (radioButton1.Checked)
            {
            graphics.DrawEllipse(pen,rectangle);
            }
            if (radioButton2.Checked)
            {
                graphics.DrawRectangle(pen, rectangle);
            }
           
        }
    }
}
