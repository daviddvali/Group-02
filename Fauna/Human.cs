namespace Fauna;

public class Human : Creature
{
    public Human()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Human was created!");
        Console.ResetColor();
    }

    public void Speak()
    {
        Console.WriteLine("Human is speaking");
    }
}