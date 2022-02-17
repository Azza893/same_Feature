using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool darg=false;
        int _x;
        int _y;
        public Form1()
        {
            InitializeComponent();
        }

        Rectangle rec = new Rectangle(30, 30, 100, 100);

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Aquamarine, rec);
        }
        private void OnRecMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
        rec = new Rectangle(e.X, e.Y, 100, 100);
            darg = true;
            _x = e.X;
            _y = e.Y;
        }
        private void onMouseMove(object sender,MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            rec.X = e.X;
            rec.Y = e.Y;
            Invalidate();
        }
//        protected override void OnMouseDown(MouseEventArgs e)
//        {
//            if (e.Button == MouseButtons.Left)
//            {

//                rec.Width = e.X - rec.X;
//                rec.Height = e.Y - rec.Y;
//                Invalidate();
//            }
               
//}
//        protected override void OnMouseMove(MouseEventArgs e)
//        {
//            if (e.Button == MouseButtons.Left)
//            {
//                rec.Width = e.X - rec.X;
//                rec.Height = e.Y - rec.Y;
//                Invalidate();
//            }

//        }

//        private void Form1_MouseClick(object sender, MouseEventArgs e)
//        {

//            //rec.Width = e.X - rec.X;
//            //rec.Height = e.Y - rec.Y;
//            //Invalidate();


//            //if (e.Button == MouseButtons.Left)
//            //{
//            //    rec.Width = e.X - rec.X;
//            //    rec.Height = e.Y - rec.Y;
//            //    Invalidate();
//            //}
//        }

//        private void Form1_DragDrop(object sender, DragEventArgs e)
//        {
//        }
    }
}
