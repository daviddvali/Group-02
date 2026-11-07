namespace Fauna;

class Program
{
    static void Main()
    {
        Dog dog1 = new Dog();
        Dog dog2 = new Dog();
        SuperDog superDog = new SuperDog();
        Cat cat = new Cat();
        Shark shark = new Shark();

        CallMove(dog1);
        CallMove(dog2);
        CallMove(superDog);
        CallMove(cat);
        CallMove(shark);
    }

    static void CallMove(Creature creature)
    {
        creature.Move();
        if (creature is Dog dog)
        {
            dog.Bark();
            dog.Bark();
            dog.Bark();
        }
        //if (creature is Dog)
        //{
        //    Dog dog = (Dog)creature;
        //    //Dog dog = creature as Dog;
        //    dog.Bark();
        //    dog.Bark();
        //    dog.Bark();
        //}
    }
}