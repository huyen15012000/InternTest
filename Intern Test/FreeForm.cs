using System;
using System.Collections.Generic;
using System.Text;

namespace Intern_Test
{
    class FreeForm : Drawing
    {
        int u, z;
        public bool down;
        public bool move;
        public void Draw()
        {
            base.Draw();
            graphics.DrawLine(pen, new System.Drawing.Point(x, y), new System.Drawing.Point(u, z));
            setup(u, z);
        }
        public void CreatePoint(int a, int b)
        {
            u = a;
            z = b;
        }
        public override void setup(int a, int b)
        {
            x = a;
            y = b;
        }
    }
}
