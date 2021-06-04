using System;

namespace Geometry
{
    public interface IReflectable
    {
        void Reflect();
    }

    public class Point : IReflectable
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Point() : this(1, 0) { }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public void Reflect()
        {
            _x = -_x;
            _y = -_y;
        }

        public virtual double Distance => Math.Sqrt(X * X + Y * Y);
    }

    public class ColorfulPoint : Point
    {
        private readonly Color _color;

        public Color Color => _color;

        public ColorfulPoint(Color color) => _color = color;

        public ColorfulPoint(double x, double y, Color color) : base(x,y) => 
            _color = color;

        public override double Distance => 
            _color == Color.Black || _color == Color.White ? 0 : base.Distance;
    }

    public enum Color
    {
        Black,
        White,
        Red,
        Green,
        Blue
    }
}
