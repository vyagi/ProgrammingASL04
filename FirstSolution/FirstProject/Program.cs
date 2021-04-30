using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime myBirthDay = new DateTime(1978, 11, 10);

            TimeSpan timeSpan = today - myBirthDay;
            Console.WriteLine(timeSpan.Days);

            TimeSpan tenThousandDays = new TimeSpan(10000, 0, 0, 0);

            DateTime celebration =  myBirthDay + tenThousandDays;
            Console.WriteLine(celebration);

        }

        void Method3()
        {
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType()); //type us System.Int32
            Console.WriteLine(System.Int32.MaxValue);
            Console.WriteLine(System.Int32.MinValue);

            string b = "marcin";
            Console.WriteLine(b);
            Console.WriteLine(b.Length);
            Console.WriteLine(b.Contains("a"));
            Console.WriteLine(b.EndsWith("w"));
            Console.WriteLine(b.ToUpper());

            int[] c = new int[10];
            Console.WriteLine(c);
            Console.WriteLine(c.Length);

            object e = new object();

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            DateTime dt1 = dt.AddDays(25);
            Console.WriteLine(dt1);
            Console.WriteLine(dt1.Month);
            Console.WriteLine(dt1.Year);
            Console.WriteLine(dt1.DayOfWeek);
            //Everything in c# is an object !!!
        }

        void Method2()
        {
            Console.WriteLine("Whats your name?");
            var name = Console.ReadLine();
            if (name == "Marcin")
            {
                Console.WriteLine("Hello " + name);
            }
            else
            {
                Console.WriteLine("I dont know you, " + name);
            }
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
