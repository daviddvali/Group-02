namespace Fauna;

public class Creature
{
    public Creature()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Creature was created!");
        Console.ResetColor();
        Breath();
    }

    public string Name { get; set; }

    public double Weight { get; set; }

    public void Move()
    {
        Console.WriteLine("Creature is moving");
    }

    protected void Breath()
    {
        Console.WriteLine("Creature is breathing");
    }
}
