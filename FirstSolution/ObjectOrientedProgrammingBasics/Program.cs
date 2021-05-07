using System;
using System.Net.Http.Headers;

namespace ObjectOrientedProgrammingBasics
{
    class Person
    {
        private int _height;
        private int _weight;
        private string _name;

        public int Height => _height;

        public int Weight
        {
            get => _weight;
            set
            {
                if (value <= 0)
                    throw new Exception("Weight should be positive");
                
                _height = value;
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



        //Java way
        // public int GetHeight()
        // {
        //     return _height;
        // }
        //
        // public void SetHeight(int newHeight)
        // {
        //     if (newHeight <= 0)
        //         throw new Exception("Height should be positive");
        //
        //     _height = newHeight;
        // }
        //
        // public int GetWeight()
        // {
        //     return _weight;
        // }
        //
        // public void SetWeight(int newWeight)
        // {
        //     if (newWeight <= 0)
        //         throw new Exception("Weight should be positive");
        //
        //     _height = newWeight;
        // }
        //
        // public string GetName()
        // {
        //     return _name;
        // }
        //
        // public void SetName(string newName)
        // {
        //     if (string.IsNullOrWhiteSpace(newName))
        //         throw new Exception("Name cannot be null");
        //
        //     _name = newName;
        // }

        public Person(string name, int weight, int height)
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
        }

        public double Bmi()
        {
            return 10000.0 * _weight / (_height * _height);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var you = new Person("Marcin", 100, 190);

            // Console.WriteLine(you.GetName());
            // you.SetName(null);
            // Console.WriteLine(you.GetName());

            Console.WriteLine(you.Name);
            you.Name = "Robert";
            you.Weight = 60;
            Console.WriteLine(you.Height);
            Console.WriteLine(you.Name);

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
