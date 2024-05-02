namespace Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var a = 5;
        var b = 10;
        Console.WriteLine(a + b);

        Console.WriteLine("[S]ee all Todo items");
        var userInput = Console.ReadLine();
        Console.WriteLine($"User input: {userInput}");

    }
}