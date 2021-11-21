using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class LineSegment 
    {
        private double X1 { get; }
        private double Y1 { get; }
        private double Z1 { get; }
        private double X2 { get; }
        private double Y2 { get; }
        private double Z2 { get; }
        //private List<MyPoint> points = new List<MyPoint>();
        //public LineSegment(MyPoint a, MyPoint b)
        //{
        //    points.Add(a);
        //    points.Add(b);
        //}

        public LineSegment(MyPoint a, MyPoint b)
        {
            X1 = a.X;
            Y1 = a.Y;
            X2 = b.X;
            Y2 = b.Y;
        }
        //public LineSegment(int x1, int y1, int x2, int y2)
        //{
        //    points.Add(new MyPoint(x1, y1));
        //    points.Add(new MyPoint(x2, y2));
        //}
        public LineSegment(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public LineSegment(MyPoint3D a, MyPoint3D b)
        {
            X1 = a.X;
            Y1 = a.Y;
            Z1 = a.Z;
            X2 = b.X;
            Y2 = b.Y;
            Z2 = b.Z;

        }



        public double Length()
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }

        public double Length3D()
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
        }

        

    }
}
