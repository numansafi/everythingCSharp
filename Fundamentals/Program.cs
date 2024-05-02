namespace Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var a = 5;
        var b = 10;
        Console.WriteLine(a + b);

        var seeTodos = "[S]ee all Todo items";
        PrintSelectedOption(seeTodos);
        var userInput = Console.ReadLine();
        Console.WriteLine($"User input: {userInput}");
        
    }

    private static void PrintSelectedOption(string selectedOption)
    {
        Console.WriteLine($"Selected Option: {selectedOption}");
    }
}