using System;

namespace ObjectOrientedProgrammingInterfaces
{
    public interface IShape //old school interfaces do not allow for any implementation and the do not allow for public keyword
    //just return type, name and list of parameters.
    {
        double Area();
        
    }

    public interface ICreature
    {
        void Breathe();
    }

    public class LivingSquare : IShape, ICreature
    {
        public double Area()
        {
            return 10;
        }

        public void Breathe()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
