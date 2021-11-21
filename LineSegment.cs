using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class LineSegment 
    {
        public double X1 { get; }
        public double Y1 { get; }
        public double X2 { get; }
        public double Y2 { get; }

        private List<MyPoint> points = new List<MyPoint>();
        public LineSegment(MyPoint a, MyPoint b)
        {
            points.Add(a);
            points.Add(b);
        }

        public LineSegment(int x1, int y1, int x2, int y2)
        {
            points.Add(new MyPoint(x1, y1));
            points.Add(new MyPoint(x2, y2));
        }



        public double Length()
        {
            return Math.Sqrt(Math.Pow(points[1].X - points[0].X, 2) + Math.Pow(points[1].Y - points[0].Y, 2));
        }


    }
}
