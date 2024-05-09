using Microsoft.VisualBasic;

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

        // for (int i = 1; i < 20; i++)
        // {
        //     if (i % 4 == 0)
        //     {
        //         continue;
        //     }
        //     Console.WriteLine(i);
        // }

        // arrays
        var numbers = new int[] { 1, 2, 3, 4 };

        // Lists
        var words = new List<string> {"one", "two", "three", "four", "five"};
        words.Add("SIX");
        words.Add("SIX");
        words.Add("EIght");
        words.RemoveAt(0);
        words.Remove("two");

        var upCase = GetOnlyUpperCaseWords(words);
        foreach (var word in upCase)
        {
            System.Console.WriteLine(word);
        }
    }
    public static List<string> GetOnlyUpperCaseWords(List<string> words)
    {
        var uppercaseWords = new List<string>();

        foreach (var word in words)
        {
            if (!uppercaseWords.Contains(word) && word.All(char.IsLetter) && word.All(char.IsUpper))
            {
                uppercaseWords.Add(word);
            }
        }

        return uppercaseWords;
    }
    public static bool IsAnyWordLongerThan(int length, string[] words)
    {
        foreach (var word in words)
        {
            if (word.Length > length) return true;
        }

        return false;
    }

    public static int FindMax(int[,] numbers)
    {
        var arr1 = numbers.GetLength(0);
        var arr2 = numbers.GetLength(1);

        if ( arr1 == 0 || arr2 == 0) return -1;

        int max = numbers[0,0];

        for (int i = 0; i < arr1; i++)
        {
            for (int j = 0; j < arr2; j++)
            {
                if (numbers[i,j] > max) max = numbers[i,j];
            }
        }

        return max;
    }

    public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
    {
        foreach (var word in words)
        {
            if ( word == wordToBeChecked) return true;
        }

        return false;
    }
    public static string BuildHelloString()
    {
        var letters = new char[] { 'h','e','l','l','o'};
        var result = "";
        for (int i = 0; i < letters.Length; ++i)
        {
           result += letters[i];
        }
        return result;
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