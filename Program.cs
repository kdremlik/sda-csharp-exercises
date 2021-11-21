using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Square square = new Square(3);

            Circle circle = new Circle(4);

            shapes.Add(square);
            shapes.Add(circle);

            double totalArea = 0;
            foreach (var s in shapes)
            {
                totalArea += s.GetArea();
            }

            Console.WriteLine(totalArea);
        }
    }
}
