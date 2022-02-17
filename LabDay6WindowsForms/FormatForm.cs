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
    public partial class FormatForm : Form
    {
        Style style;
     

        public  Style Result => style;

        public FormatForm()
        {
            InitializeComponent();
            foreach (var fontFamily in FontFamily.Families)
            {
                comboBox.Items.Add(fontFamily.Name);

            }
            this.style = new Style();
            comboBox.SelectedIndex = 0;

        }

       

      

        private void Okbtn_Click(object sender, EventArgs e)
        {
            
            int size_textbox =int.Parse(numericUpDown1.Text);
            style.font = new Font(new FontFamily(comboBox.Text),size_textbox,GetFontStyle());
           DialogResult = DialogResult.OK;
            this.Close();
        }

        private FontStyle GetFontStyle()
        {
            FontStyle font = FontStyle.Regular;
            font |= (BoldCheck.Checked?FontStyle.Bold:FontStyle.Regular);
            font |= (ItalicBtn.Checked ? FontStyle.Italic : FontStyle.Regular);
            font |= (UnderLineBtn.Checked ? FontStyle.Underline : FontStyle.Regular);

            return font;
        }

        private void RedRadio_CheckedChanged(object sender, EventArgs e)
        {
            style.color = Color.FromName((sender as RadioButton).Text);
        }

        private void GreenRadio_CheckedChanged(object sender, EventArgs e)
        {
            style.color = Color.FromName((sender as RadioButton).Text);
        }

        private void BlueRadio_CheckedChanged(object sender, EventArgs e)
        {
            style.color = Color.FromName((sender as RadioButton).Text);
        }
    }
}
