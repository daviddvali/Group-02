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

    public override void Move()
    {
        base.Move();
        Fly();
    }

    protected override void Breath()
    {
        base.Breath();
        Console.WriteLine("SuperDog is breathing with lungs");
    }
}