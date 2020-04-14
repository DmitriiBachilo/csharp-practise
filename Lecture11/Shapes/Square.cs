using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        public double Side { get; set; }

        public override double CalculateArea()
        {
            double a = Side * Side;
            return a;
        }
    }
    
}
