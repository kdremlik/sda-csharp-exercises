using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            LineSegment line = new LineSegment(5, 1, 10, 15);
            Console.WriteLine(line.Length());

            MyPoint point1 = new MyPoint(5, 1);
            MyPoint point2 = new MyPoint(10, 15);

            LineSegment line2 = new LineSegment(point1, point2);

            Console.WriteLine(line2.Length());


            MyPoint3D point3 = new MyPoint3D(5, 10, 15);
            MyPoint3D point4 = new MyPoint3D(10, 15, 25);
            LineSegment line3 = new LineSegment(point3, point4);
            Console.WriteLine(line3.Length3D());

        }
    }
}
