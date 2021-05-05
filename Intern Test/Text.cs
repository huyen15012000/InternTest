using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Intern_Test
{
    public class Text : Drawing
    {
        private String str;
        private Font font;

        public String Str
        {
            get { return str;  }
            set { str = value; }
        }
        public Font Font
        {
            get { return font; }
            set { font = value; }
        }
        public override void setup(int a, int b)
        {
            x = a;
            y= b;
        }

        public void Draw()
        {
            base.Draw();
            graphics.DrawString(str, font, pen.Brush, new Point(base.getX(), base.getY()));

        }

        
    }
}
