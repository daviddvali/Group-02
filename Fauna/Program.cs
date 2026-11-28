namespace Fauna;

class Program
{
    static void Main()
    {
        Bird bird = new Bird();
        Eagle eagle = new Eagle();
        Chicken chicken = new Chicken();
        Bee bee = new Bee();
        SuperDog superDog = new SuperDog();
        Plane plane = new Plane();

        CallFly(bird);
        CallFly(eagle);
        CallFly(chicken);
        CallFly(bee);
        CallFly(superDog);
        CallFly(plane);
    }

    static void CallFly(IFlyable flyable)
    {
        flyable.Fly();
    }
}