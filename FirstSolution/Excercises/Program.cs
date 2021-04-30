using System;

namespace Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            // Console.WriteLine("Hello");

            //Task 2
            // var name = "Marcin";
            // Console.WriteLine(name);

            //Task 3
            var name = "Marcin";
            Console.WriteLine("Hello {0}", name); //This is old school
            Console.WriteLine("Hello " + name); //Don't use it
            Console.WriteLine(string.Format("Hello {0}", name)); // This is crappy old school
            Console.WriteLine($"Hello {name}");  //Use this 

        }
    }
}
