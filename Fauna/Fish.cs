namespace Fauna;

public class Fish : Creature
{
    public Fish()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Fish was created!");
        Console.ResetColor();
    }

    public void Swim()
    {
        Console.WriteLine("Fish is swimming");
    }

    public override void Move()
    {
        Swim();
    }

    protected override void Breath()
    {
        Console.WriteLine("Fish is breathing with gills");
    }  
}