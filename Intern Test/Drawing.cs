using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Intern_Test
{
    public abstract class Drawing
    {
       protected int x, y;
       protected bool isDrawn;
       public Pen pen = new Pen (Color.FromArgb(255, 0, 0, 0));
       public Graphics graphics;

        public void setPosition(int a, int b)
        {
            x = a;
            y = b;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        abstract public void setup(int a, int b);
        public void Draw()
        {
            isDrawn = true;
        }
        public bool IsDrawn
        {
            get { return isDrawn; }
        }
    }
}
