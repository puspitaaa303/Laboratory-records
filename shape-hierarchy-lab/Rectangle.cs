using System;
public class Rectangle : Shape
{
    private double width, height;
    public Rectangle(string colour, double width, double height) : base(colour)
    {
        this.width = Change(width);
        this.height = Change(height);
    }
    public override double CalculateArea() => width * height;
    public override double CalculatePerimeter() => 2 * (width + height);
}
