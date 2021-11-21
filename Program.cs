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

        }
    }
}
