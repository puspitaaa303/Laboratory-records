using System;
public class Pentagon : Shape
{
    private double side;
    public Pentagon(string colour, double side) : base(colour)
    {
        this.side = Change(side);
    }
    public override double CalculateArea()
    {
        return (1.0 / 4.0) * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side;
    }
    public override double CalculatePerimeter() => 5 * side;
}
