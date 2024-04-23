using System;

public interface IPlayable
{
    void Play();
}

public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Guitar is now Playing");
    }
}

public class Piano : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Piano is now playing");
    }

    public static void Main(string[] args)
    {
        // Create instances of Guitar and Piano
        var guitar = new Guitar();
        var piano = new Piano();

        // Play the instruments
        guitar.Play();
        piano.Play();

        
       
    }
}
