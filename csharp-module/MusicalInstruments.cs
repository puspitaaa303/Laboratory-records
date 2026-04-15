using System;
public interface IPlayable
{
    void Play();
}
public class Piano : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing piano keys...");
    }
}
public class Guitar: IPlayable
{
    public void Play()
    {
        Console.WriteLine("Strumming guitar strings...");
    }
}
public class Drums : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Beating the drums...");
    }
}