using System;
public class Vehicle
{
    public virtual void StartEngine(){
        Console.WriteLine("Engine Started");
    }
}
public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car: Vroom vroom!");
    }
}
public class Motorcycle : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike: Vrrrr!");
    }
}