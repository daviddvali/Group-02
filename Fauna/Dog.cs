namespace Fauna;

public class Dog : Animal
{
    public Dog()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dog was created!");
        Console.ResetColor();
    }

    public Dog(string name) : base(name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Dog with name {name} was created!");
        Console.ResetColor();
    }

    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}
