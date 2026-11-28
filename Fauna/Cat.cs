namespace Fauna;

public class Cat : Animal
{
    public Cat() : base("cat")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Cat was created!");
        Console.ResetColor();
    }

    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}