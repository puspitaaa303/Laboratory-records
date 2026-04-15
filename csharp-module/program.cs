using System;
class Program
{
    public static void Main(string[] args)
    {
        IPlayable[] band={new Piano(),new Guitar(),new Drums()};
        foreach(var inst in band)
        {
            inst.Play();
        }
    }
}