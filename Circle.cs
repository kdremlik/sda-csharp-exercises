using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Circle : Shape
    {
        private double Radius { get; set; }

        const double Pi = 3.14;
        public override double GetArea()
        {
            return Pi * (Radius * Radius);
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

    }



}
