namespace Fauna;

public class Alf : Alien
{
    public Alf()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Alf was created!");
        Console.ResetColor();
    }

    public void EatCats()
    {
        Console.WriteLine("Alf is eating cats!");
    }

    protected override void Breath()
    {
        Console.WriteLine("Alf is breathing with alien lungs");
    }
}