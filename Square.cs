using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Square : Shape
    {
        private double Side { get; set; }

        public override double  GetArea(double side)
        {
            return side * side;
        }

        public Square(double side)
        {
            Side = side;
        }
    }
}
