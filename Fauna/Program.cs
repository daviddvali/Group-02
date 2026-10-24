namespace Fauna;

class Program
{
    static void Main()
    {
        //Object x = new SuperDog();
        //x.ToString();
        //x.Move();
        //x.Run();
        //x.Bark();
        //x.Fly();

        SuperDog superDog1 = new SuperDog(); 
        superDog1.Name = "SuperDog1";
        superDog1.Weight = 15;

        SuperDog superDog2 = new SuperDog(); 
        superDog2.Name = "SuperDog2";
        superDog2.Weight = 15;

        Console.WriteLine(superDog1.Equals(superDog2)); 
    }
}