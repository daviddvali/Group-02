namespace Fauna;

public class Plane : Vehicle, IFlyable
{
    public override void Move()
    {
        Console.WriteLine("The plane is moving");
    }

    public void Fly()
    {
        Console.WriteLine("The plane is flying");
    }
}