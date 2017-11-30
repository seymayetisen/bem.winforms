using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class GelismisTextBox : TextBox
    {
        public override string Text {
            get {
                return base.Text;
            }
            set {
                base.Text = value.ToUpper();
            }

        }
    }
}
