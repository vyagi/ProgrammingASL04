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
            // var name = "Marcin";
            // Console.WriteLine("Hello {0}", name); //This is old school
            // Console.WriteLine("Hello " + name); //Don't use it
            // Console.WriteLine(string.Format("Hello {0}", name)); // This is crappy old school
            // Console.WriteLine($"Hello {name}");  //Use this 

            //Task 4
            // var name = Console.ReadLine();
            // Console.WriteLine($"Hello {name}");

            //Task 5
            // var radius = Convert.ToDouble(Console.ReadLine());
            // var area = Math.PI * radius * radius;
            // Console.WriteLine($"Area is {area}");

            //Task 6
            var radius = Convert.ToDouble(Console.ReadLine());
            var area = Math.PI * radius * radius;
            var circumference = 2 * Math.PI * radius;
            Console.WriteLine($"Area is {area} and the circumference is {circumference}");

        }
    }
}
