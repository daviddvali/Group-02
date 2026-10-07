namespace Fauna;

public class Animal : Creature
{
	//public Animal()
	//{
	//	Console.ForegroundColor = ConsoleColor.Green;
	//	Console.WriteLine("Animal was created!");
	//	Console.ResetColor();
	//}

	public Animal(string name)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"Animal with name {name} was created!");
		Console.ResetColor();
		Name = name;
    }

	public void Run()
	{
		if(string.IsNullOrEmpty(Name))
		{
			Console.WriteLine("Animal is running");
			return;
        }
		Console.WriteLine($"Animal with name {Name} is running");
    }
}
