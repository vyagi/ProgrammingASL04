using System;
using System.Collections.Generic;

namespace ObjectOrientedProgrammingContinuation
{
    public abstract class Shape
    {
        public abstract double Area();

        public abstract double Perimeter();
    }

    public class Rhombus : Shape
    {
        private readonly double _side;
        private readonly double _angle;

        public Rhombus(double side, double angle)
        {
            _side = side;
            _angle = angle * Math.PI / 180.0;
        }
        
        public override double Area() => _side * _side * Math.Sin(_angle);

        public override double Perimeter() => 4 * _side;
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

    public class Circle : Shape
    {
        private readonly double _r;

        public Circle(double r) => _r = r;

        public override double Area() => Math.PI * _r * _r;

        public override double Perimeter() => Math.PI * 2 * _r;
    }

    public class Square : Shape
    {
        private readonly double _a;

        public Square(double a) => _a = a;

        public override double Area() => _a * _a;

        public override double Perimeter() => _a * 4;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Shape s = new Shape();  //used to work but it does not anymore after I changed the Shape class to abstract
            // var area = s.Area();
            // var perimeter = s.Perimeter();
            //Console.WriteLine($"Area is {area} and perimeter is {perimeter}");

            Triangle t = new Triangle(3,4,5);
            Console.WriteLine($"Area is {t.Area()} and perimeter is {t.Perimeter()}");

            Rectangle r = new Rectangle(5, 8);
            Console.WriteLine($"Area is {r.Area()} and perimeter is {r.Perimeter()}");

            Console.WriteLine("Now some more interesting ****************");

            var myShapes = new List<Shape>();
            myShapes.Add(t);
            myShapes.Add(r);
            myShapes.Add(new Square(10));
            myShapes.Add(new Circle(5));
            myShapes.Add(new Rhombus(10, 90));

            foreach (var myShape in myShapes)
            {
                Console.WriteLine($"Area is {myShape.Area()} and perimeter is {myShape.Perimeter()}");//polymorphism
            }
        }
    }
}
