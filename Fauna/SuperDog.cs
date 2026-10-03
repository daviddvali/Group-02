namespace Fauna;

public class SuperDog : Dog
{
    public SuperDog()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("SuperDog was created!");
        Console.ResetColor();
    }

    public void Fly()
    {
        Console.WriteLine("SuperDog is flying");
    }
}