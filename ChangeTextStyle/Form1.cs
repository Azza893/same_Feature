using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeTextStyle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = domainUpDown1.SelectedItem.ToString();
            if (color == "green") label3.ForeColor = Color.Green;
            else if (color == "red") label3.ForeColor = Color.Red;
            else if (color == "blue") label3.ForeColor = Color.Blue;
            else if (color == "black") label3.ForeColor = Color.Black;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string size = numericUpDown1.Value.ToString();
            int size1 = int.Parse(size);
            label3.Font = new Font("Arial", size1, FontStyle.Bold);
            label3.Font = new Font("Arial", size1, FontStyle.Bold);
        }
    }
}
