﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Intern_Test
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            graphics.DrawRectangle(pen, 10, 10, 100, 1000);
        }

        public override void setup(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
