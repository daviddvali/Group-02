namespace Fauna;

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.Move();
        Console.WriteLine();
        Dog dog = new Dog();
        dog.Move();
        Console.WriteLine();
        Cat cat = new Cat();
        cat.Move();
        Console.WriteLine();
        Shark shark = new Shark();
        shark.Move();
        Console.WriteLine();
        SuperDog superDog = new SuperDog();
        superDog.Move();
    }
}