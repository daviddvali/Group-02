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

    public override bool Equals(object? obj)
    {
        if (obj is SuperDog otherSuperDog)
        {
            return this.Name == otherSuperDog.Name && 
                   this.Weight == otherSuperDog.Weight;
        }
        return false;
    }

    protected override void Breath()
    {
        base.Breath();
        Console.WriteLine("SuperDog is breathing with lungs");
    }
}