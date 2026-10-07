namespace Fauna;

public class Chicken : Bird
{
    public Chicken()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Chicken was created!");
        Console.ResetColor();
    }

    public void LayEggs()
    {
        Console.WriteLine("Chicken is laying eggs");
    }
}