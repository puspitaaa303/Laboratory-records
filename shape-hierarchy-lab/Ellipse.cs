using System;
public class Ellipse : Shape
{
    private double a, b;
    public Ellipse(string colour, double a, double b) : base(colour)
    {
        this.a = Change(a);
        this.b = Change(b);
    }
    public override double CalculateArea() => Math.PI * a * b;
    public override double CalculatePerimeter()
    {
        return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
    }
}