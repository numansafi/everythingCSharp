namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello There!");
        var num1 = decimal.Parse(GetNumber("Input the first number: ")!);
        var num2 = decimal.Parse(GetNumber("Input second number: ")!);
        
        OperationResults(num1, num2);


    }
    // Get userInput
    private static string? GetNumber(string question)
    {
        Console.WriteLine(question);
        var userInput = Console.ReadLine();
        return userInput;
    }
    
    // Operation to excecute
    private static void OperationResults(decimal num1, decimal num2)
    {
        var operationKeys = new string[] { "A", "S", "M", "E" };
        string operationKey;
        
        do
        {
            DisplayOperation();
            operationKey = Console.ReadLine()!;
        } while (!operationKeys.Contains(operationKey.ToUpper()));

        if (operationKey == "E") return;
        
        var result = operationKey.ToUpper() switch
        {
            "A" => Add(num1, num1),
            "S" => Subtraction(num1, num2),
            "M" => Multiplication(num1, num1),
        };

        Console.WriteLine(result);
    }
    
    // Display operations
    private static void DisplayOperation()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[A]dd numbers");
        Console.WriteLine("[S]ubtract numbers");
        Console.WriteLine("[M]ultiply numbers");
        Console.WriteLine("[E]ixt");
    }
    
    // Create addition, subtraction, multiplication functions
    private static decimal Add(decimal num1, decimal num2)
    {
        return num1 + num2;
    }

    private static decimal Subtraction(decimal num1, decimal num2)
    {
        return num1 - num2;
    }

    private static decimal Multiplication(decimal num1, decimal num2)
    {
        return num1 * num2;
    }
}