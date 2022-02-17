using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay6WindowsForms
{
   public class Style
    {
        public Color color;
        public Font font;
        public Style()
        {
            this.font = new Font(new FontFamily("arial"),12, FontStyle.Regular);
            this.color =Color.Red;
        }

        
    }
    
}
