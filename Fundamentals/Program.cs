namespace Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // var a = 5;
        // var b = 10;
        // Console.WriteLine(a + b);
        //
        // var seeTodos = "[S]ee all Todo items";
        // PrintSelectedOption(seeTodos);
        // var userInput = Console.ReadLine();
        // Console.WriteLine($"User input: {userInput}");
        //
        // Console.WriteLine(Add(1,2));
        
        // Parsing
        // Console.WriteLine("Provide a number: ");
        // var userInput = Console.ReadLine()!;
        // var number = int.Parse(userInput);
        // Console.WriteLine(number);

        //LOOPS
        // int number = 0;
        // while (number < 10)
        // {
        //     number++;
        //     Console.WriteLine($"Number: {number}");
        
        // }

        for (int i = 1; i < 20; i++)
        {
            if (i % 4 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }


    }

     public static int Factorial(int number)
    {
        int sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum *= i;
        }

        return sum;
    }

    public static string RepeatCharacter(char character, int targetLength)
    {
        string str = "";
        int count = 0;
        do
        {
            str += character;
            count++;
        } while (count < targetLength);
            
            return str;
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