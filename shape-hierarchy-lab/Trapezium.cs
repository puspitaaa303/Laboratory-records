using System;
public class Trapezium : Shape
{
    private double a, b, height;
    public Trapezium(string colour, double a, double b, double height) : base(colour)
    {
        this.a = Change(a);
        this.b = Change(b);
        this.height = Change(height);
    }
    public override double CalculateArea() => 0.5 * (a + b) * height;
    public override double CalculatePerimeter() => a + b + 2 * height;
}