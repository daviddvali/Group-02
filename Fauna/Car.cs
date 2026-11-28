namespace Fauna;

public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("The car is moving");
    }

    public void Drive()
    {
        Console.WriteLine("The car is driving");
    }
}