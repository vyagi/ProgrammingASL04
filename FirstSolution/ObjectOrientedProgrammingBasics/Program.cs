using System;

namespace ObjectOrientedProgrammingBasics
{
    class Point
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Point() : this(1,1) { }

        public double Distance() => Math.Sqrt(X * X + Y * Y);

        public double Distance(Point another) => 
            Math.Sqrt(Math.Pow(X - another.X, 2) + Math.Pow(Y - another.Y, 2));
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(4,3);
            Console.WriteLine(p1.X);
            Console.WriteLine(p1.Y);
            Console.WriteLine(p1.Distance());
            
            var p2 = new Point();
            Console.WriteLine(p2.X);
            Console.WriteLine(p2.Y);
            Console.WriteLine(p2.Distance());

            Console.WriteLine(p1.Distance(p2));
        }
    }
}
