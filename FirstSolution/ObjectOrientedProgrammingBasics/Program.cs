using System;

namespace ObjectOrientedProgrammingBasics
{
    struct Vector
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }

    class Point
    {
        public static int Dummy;
        
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

        public static double Distance(Point first, Point second) => 
            first.Distance(second);

        public Point Reflect(ReflectionType reflectionType)
        {
            switch (reflectionType)
            {
                case ReflectionType.X:
                    return new Point(X, -Y);
                case ReflectionType.Y:
                    return new Point(-X, Y);
                case ReflectionType.Origin:
                    return new Point(-X, -Y);
                default:
                    throw new Exception("Invalid reflection type");
            }
        }

        public enum ReflectionType
        {
            X,
            Y,
            Origin
        }

        public override string ToString() => $"({X},{Y})";
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

            Console.WriteLine(Point.Distance(p1, p2));

            var reflectedP1 = p1.Reflect(Point.ReflectionType.X);
            Console.WriteLine(reflectedP1.X);
            Console.WriteLine(reflectedP1.Y);

            Console.WriteLine(p1);

            var a = 10;
            var b = 20;
            SomeMethod(a, b);

            int[] d = {1, 2, 7, 3};
            AnotherMethod(d);
        }

        public static void SomeMethod(int x, int u)
        {
            int temp;
            temp = u;
            u = x;
            x = temp;
        }

        public static void AnotherMethod(int[] myArray)
        {
            myArray[0] = 100;
        }
    }
}
