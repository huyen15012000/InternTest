using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Intern_Test
{
    public class Text : Drawing
    {
        public TextBox tb;
        private String str;
        private FormattableString format;
        public FontDialog fontDialog;

        public String Str
        {
            get { return str;  }
            set { str = value; }
        }
        public override void setup(int a, int b)
        {
            tb = new TextBox();
            tb.BorderStyle = BorderStyle.None;
            base.setPosition(a, b);
            tb.Location = new System.Drawing.Point(base.getX(), base.getY());
        }

        public override void Draw()
        {

            tb.Text = str;
        }

        
    }
}
