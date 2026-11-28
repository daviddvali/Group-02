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

        Dog[] dogs = new Dog[]
        {
            new Dog("Rex", 25),
            new Dog("Bobi", 8),
            new Dog("Max", 32),
            new Dog("Luna", 12),
            new Dog("Toby", 5)
        };

        SortDogs(dogs);

        Console.WriteLine("\nDogs by weight (ascending):");
        for (int i = 0; i < dogs.Length; i++)
        {
            Console.WriteLine($"{dogs[i].Name}: {dogs[i].Weight} kg");
        }
    }

    public static void SortDogs(Dog[] dogs)
    {
        for (int i = 0; i < dogs.Length - 1; i++)
        {
            for (int j = 0; j < dogs.Length - i - 1; j++)
            {
                if (dogs[j].Weight > dogs[j + 1].Weight)
                {
                    Dog temp = dogs[j];
                    dogs[j] = dogs[j + 1];
                    dogs[j + 1] = temp;
                }
            }
        }
    }
}
