using System;
public class Triangle : Shape
{
    private double length, height;
    public Triangle(string colour, double length, double height) : base(colour)
    {
        this.length = Change(length);
        this.height = Change(height);
    }
    public override double CalculateArea() => 0.5 * length * height;
    public override double CalculatePerimeter()
    {
        double hypotenuse = Math.Sqrt(length * length + height * height);
        return length + height + hypotenuse;
    }
}