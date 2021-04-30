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
            // var radius = Convert.ToDouble(Console.ReadLine());
            // var area = Math.PI * radius * radius;
            // var circumference = 2 * Math.PI * radius;
            // Console.WriteLine($"Area is {area} and the circumference is {circumference}");

            //Task 7

            // Console.WriteLine("Enter the base of the triangle");
            // var triangleBase = Convert.ToDouble(Console.ReadLine());
            //
            // Console.WriteLine("Enter the height of the triangle");
            // var triangleHeight = Convert.ToDouble(Console.ReadLine());
            //
            // var area = triangleBase * triangleHeight / 2;
            // Console.WriteLine($"The area of the triangle is {area}");

            //Task 8 and 9 - homework

            //Task 10 a)
            // Console.WriteLine("Enter the first integer number");
            // var a = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Enter the first integer number");
            // var b = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Enter the first integer number");
            // var c = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Enter the first integer number");
            // var d = Convert.ToInt32(Console.ReadLine());
            //
            // var sum = a + b + c + d;
            // var average = sum / 4.0;
            //
            // Console.WriteLine($"The sum is {sum} and the average is {average}");

            //Task 10 b)

            var myArray = new int[4];
            for (var i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Enter the integer number {i+1}");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            var sum = 0;
            foreach (var element in myArray)
            {
                sum += element;
            }

            var average = 1.0 * sum / myArray.Length;
            Console.WriteLine($"The sum is {sum} and the average is {average}");
        }
    }
}
