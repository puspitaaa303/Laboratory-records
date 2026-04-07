using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        int ch;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Shape");
            Console.WriteLine("2. Print");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine("Choose shape: Circle, Rectangle, Triangle, Pentagon, Ellipse, Trapezium");
                string type = Console.ReadLine();
                Console.Write("Enter color: ");
                string colour = Console.ReadLine();

                switch (type)
                {
                    case "Circle":
                        Console.Write("Radius: ");
                        shapes.Add(new Circle(colour, double.Parse(Console.ReadLine())));
                        break;
                    case "Rectangle":
                        Console.Write("Width: ");
                        double w = double.Parse(Console.ReadLine());
                        Console.Write("Height: ");
                        double h = double.Parse(Console.ReadLine());
                        shapes.Add(new Rectangle(colour, w, h));
                        break;
                    case "Triangle":
                        Console.Write("Base: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Height: ");
                        double ht = double.Parse(Console.ReadLine());
                        shapes.Add(new Triangle(colour, b, ht));
                        break;
                    case "Pentagon":
                        Console.Write("Side: ");
                        shapes.Add(new Pentagon(colour, double.Parse(Console.ReadLine())));
                        break;
                    case "Ellipse":
                        Console.Write("a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("b: ");
                        double bb = double.Parse(Console.ReadLine());
                        shapes.Add(new Ellipse(colour, a, bb));
                        break;
                    case "Trapezium":
                        Console.Write("a: ");
                        double a1 = double.Parse(Console.ReadLine());
                        Console.Write("b: ");
                        double b1 = double.Parse(Console.ReadLine());
                        Console.Write("h: ");
                        double h1 = double.Parse(Console.ReadLine());
                        shapes.Add(new Trapezium(colour, a1, b1, h1));
                        break;
                }
            }
            else if (ch == 2)
            {
                double totalArea = 0, totalPerimeter = 0;
                foreach (var s in shapes)
                {
                    s.Describe();
                    totalArea += s.CalculateArea();
                    totalPerimeter += s.CalculatePerimeter();
                }
                Console.WriteLine($"Total Area: {totalArea:F2}");
                Console.WriteLine($"Total Perimeter: {totalPerimeter:F2}");
            }
            else if (ch == 3)
            {
                return;
            }
        } while (ch != 3);
    }
}