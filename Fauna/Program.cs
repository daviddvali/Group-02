namespace Fauna;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal("lomi");
        Console.WriteLine();
        Dog dog = new Dog("rexi");
        Console.WriteLine();
        Cat cat = new Cat();
        Console.WriteLine();
        Shark shark = new Shark();
        Console.WriteLine();
        SuperDog superDog = new SuperDog();
    }
}