namespace Fauna;

public abstract class Vehicle
{
    public int Weight { get; set; }

    public abstract void Move();
}