namespace Fauna;

public class Spider : Insect
{
    public Spider()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Spider was created!");
        Console.ResetColor();
    }

    public void SpinWeb()
    {
        Console.WriteLine("Spider is spinning a web");
    }
}