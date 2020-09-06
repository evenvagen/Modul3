using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class TwoValues
    {
        public int X;
        public int Y;

        public TwoValues(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}
