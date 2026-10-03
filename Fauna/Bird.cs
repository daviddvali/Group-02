namespace Fauna;

public class Bird : Creature
{
    public Bird()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bird was created!");
        Console.ResetColor();
    }

    public void Fly()
    {
        Console.WriteLine("Bird is flying");
    }
}