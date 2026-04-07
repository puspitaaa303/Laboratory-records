using System;
public class Circle : Shape
{
    private double radius;
    public Circle(string colour, double radius) : base(colour)
    {
        this.radius = Change(radius);
    }
    public override double CalculateArea() => Math.PI * radius * radius;
    public override double CalculatePerimeter() => 2 * Math.PI * radius;
}
