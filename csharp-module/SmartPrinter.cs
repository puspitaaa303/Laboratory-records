using System;

public interface IPrintable
{
    void Print(string doc);
}
public interface IFaxable
{
    void Fax(string doc,string number);
}
public interface IScannable
{
    void Scan(string doc);
}
public class BasicPrinter:IPrintable
{
    public void Print(string doc)
    {
        Console.WriteLine(doc);
    }
}
public class SmartPrinter : IPrintable, IFaxable, IScannable
{
    public void Print(string doc)
    {
        Console.WriteLine($"Printing : {doc}");
    }
    public void Fax(string doc,string number)
    {
        Console.WriteLine($"Faxing {doc} to {number}");
    }
    public void Scan(string doc)
    {
        Console.WriteLine($"Scanning : {doc}");
    }
}