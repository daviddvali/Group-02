namespace Fauna;

public class Bee : Insect
{
    public Bee()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bee was created!");
        Console.ResetColor();
    }

    public void Fly()
    {
        Console.WriteLine("Bee is flying");
    }
}