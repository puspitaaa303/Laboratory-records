using System;
public abstract class Shape
{
    private string colour;
    public Shape(string colour)
    {
        this.colour = colour;
    }
    public string Colour { get { return colour; } }
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    public virtual void Describe()
    {
        Console.WriteLine($"Shape: {this.GetType().Name} | Color: {Colour} | Area: {CalculateArea():F2} | Perimeter: {CalculatePerimeter():F2}");
    }
    protected double Change(double x)
    {
        return (x <= 0) ? 1 : x;
    }
}