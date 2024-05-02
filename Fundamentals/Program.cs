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

        Console.WriteLine(Add(1,2));
        
    }

    private static void PrintSelectedOption(string selectedOption)
    {
        Console.WriteLine($"Selected Option: {selectedOption}");
    }
    private static int Add(int a, int b)
    {
        return a + b;
    }
}