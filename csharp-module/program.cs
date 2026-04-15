using System;
class Program
{
    public static void Main(string[] args)
    {
        var sp=new SmartPrinter();
        IPrintable p=sp;
        p.Print("Report.pdf");
        IFaxable f=sp;
        f.Fax("Invoice","555-1234");
        IScannable s=sp;
        s.Scan("Photo.jpg");
    }
}