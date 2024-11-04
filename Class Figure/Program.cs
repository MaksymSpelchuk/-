using System;


    abstract class Figure
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }

    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("Коло:");
            Console.WriteLine($"Радіус: {circle.Radius}");
            Console.WriteLine($"Площа: {circle.CalculateArea():F2}");
            Console.WriteLine($"Периметр: {circle.CalculatePerimeter():F2}\n");

            Rectangle rectangle = new Rectangle(4, 7);
            Console.WriteLine("Прямокутник:");
            Console.WriteLine($"Ширина: {rectangle.Width}");
            Console.WriteLine($"Висота: {rectangle.Height}");
            Console.WriteLine($"Площа: {rectangle.CalculateArea():F2}");
            Console.WriteLine($"Периметр: {rectangle.CalculatePerimeter():F2}");
        }
    }


