using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class MyPoint3D : MyPoint
    {
        public double Z { get; }

        public MyPoint3D(double x, double y, double z) : base(x,y)
        {
            Z = z;
        }
    }
}
