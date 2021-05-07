using System;

namespace ObjectOrientedProgrammingBasics
{
    class Person
    {
        private int _height;
        private int _weight;
        private string _name;
        private DateTime _dateOfBirth;

        public bool IsAdult => DateTime.Today.Year - _dateOfBirth.Year >= 18;

        public int Height => _height;

        public int Weight
        {
            get => _weight;
            set
            {
                if (value <= 0)
                    throw new Exception("Weight should be positive");

                _weight = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be null"); 
                
                _name = value;
            }
        }

        public Person(string name, int weight, int height, DateTime dateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Name cannot be null");

            if (weight <=0 )
                throw new Exception("Weight should be positive");

            if (height <= 0)
                throw new Exception("Height should be positive");

            _name = name;
            _weight = weight;
            _height = height;
            _dateOfBirth = dateOfBirth;
        }

        public double Bmi() => 
            10000.0 * _weight / (_height * _height);
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var you = new Person("Marcin", 100, 190, new DateTime(2009,01,02));

            // Console.WriteLine(you.GetName());
            // you.SetName(null);
            // Console.WriteLine(you.GetName());

            Console.WriteLine(you.Name);
            you.Name = "Robert";
            you.Weight = 60;
            Console.WriteLine(you.Height);
            Console.WriteLine(you.Name);
            Console.WriteLine(you.IsAdult);

            // you.Name = "Marcin";
            // you.Height = 180;
            // you.Weight = 70;
            //
            // Console.WriteLine(you.Name);
            // Console.WriteLine(you.Weight);
            //
            // Console.WriteLine(you.Bmi());
            //
            // you.ChangeName("Andrew");
            // Console.WriteLine(you.Name);
            //
            // var me = new Person();
            // me.Name = "John";
            // me.Height = 177;
            // me.Weight = 86;
            // me.Height = -100;
            //
            // me.Name = "    ";
        }
    }
}
