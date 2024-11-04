using System;


    class Fruit
    {
        public string Name { get; set; }

        public Fruit(string name)
        {
            Name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Назва фрукта: {Name}");
        }
    }

    class Apple : Fruit
    {
        public string Variety { get; set; } 
        public string Color { get; set; }   

        public Apple(string name, string variety, string color) : base(name)
        {
            Variety = variety;
            Color = color;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Сорт: {Variety}");
            Console.WriteLine($"Колір: {Color}");
        }
    }

    class Pear : Fruit
    {
        public Pear(string name) : base(name)
        {
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit("Загальний фрукт");
            fruit.DisplayInfo();
            Console.WriteLine();

            Apple apple = new Apple("Яблуко", "Гала", "Червоний");
            apple.DisplayInfo();
            Console.WriteLine();

            Pear pear = new Pear("Груша");
            pear.DisplayInfo();
        }
    }

