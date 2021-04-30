using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name");

            var name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
        }

        void Method1()
        {
            var a = 10;
            var b = 'a';
            var c = "marcin";
            var d = new int[10];

            for (var i = 0; i < 10; i++)
            {
                d[i] = i + 7;
            }

            foreach (var element in d)
            {
                Console.WriteLine(element);
            }

            var x = 0;
            while (x < 10)
            {
                Console.WriteLine(d[x++]);
            }

            // do
            // {
            //     //works in the same way
            // } while (true);

            if (c == "marcin")
            {
                Console.WriteLine("Your name is Marcin");
            }
            else if (c == "Andrew")
            {
                Console.WriteLine("Your name is Andrew");
            }
            else
            {
                Console.WriteLine("I don't know your name");
            }

            var flag = 1 < -5;
            Console.WriteLine(flag);

            if (c == "Marcin")
            {

            }
        }
    }
}
