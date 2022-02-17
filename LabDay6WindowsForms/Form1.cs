using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabDay6WindowsForms
{
    public partial class Form1 : Form
    {
        FormatForm format=new FormatForm();
 
        public Form1()
        {
            InitializeComponent();

        }
     
       
           

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
               

        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1 = format.ShowDialog();
            if (richTextBox1.Text == "" || richTextBox1.Text == " ")
            {
                MessageBox.Show("Enter a word...");
            }
            
            else if(dialogResult1==DialogResult.OK)
            {
               
                formatTaxt();
            }
            else
            {
                MessageBox.Show("Format not correct...");
            }
        }
        private void formatTaxt()
        {
            richTextBox1.Font = format.Result.font;
            richTextBox1.ForeColor = format.Result.color;
        }
    }
    }

