using System;
using System.Collections.Generic;

namespace ObjectOrientedProgrammingContinuation
{
    public class Shape
    {
        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimeter()
        {
            return 0;
        }
    }

    public class Triangle : Shape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double Area()
        {
            var s = Perimeter() / 2;
            return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
        }

        public override double Perimeter() => _a + _b + _c;
    }

    public class Rectangle : Shape
    {
        private readonly double _a;
        private readonly double _b;

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double Area() => _a * _b;

        public override double Perimeter() => 2 * (_a + _b);
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            var area = s.Area();
            var perimeter = s.Perimeter();

            Console.WriteLine($"Area is {area} and perimeter is {perimeter}");

            Triangle t = new Triangle(3,4,5);
            Console.WriteLine($"Area is {t.Area()} and perimeter is {t.Perimeter()}");

            Rectangle r = new Rectangle(5, 8);
            Console.WriteLine($"Area is {r.Area()} and perimeter is {r.Perimeter()}");

            Console.WriteLine("Now some more interesting ****************");

            List<Shape> myShapes = new List<Shape>();
            myShapes.Add(t);
            myShapes.Add(r);

            foreach (Shape myShape in myShapes)
            {
                Console.WriteLine($"Area is {myShape.Area()} and perimeter is {myShape.Perimeter()}");//polymorphism
            }
        }
    }
}
