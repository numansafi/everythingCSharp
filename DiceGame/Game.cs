

public static class Game
{
  public static int GetUserInput()
  {
    bool userGuess;
    int number;
    do
    {
      Console.WriteLine("Enter a number: ");
      var userInput = Console.ReadLine()!;
      userGuess = StringValidation.ValidateStringAsNumber(userInput, out number);
    } while (!userGuess);

    return number;
  }
  public static bool IsGuessCorrect(int userGuess, int diceRoll )
  {
    return userGuess == diceRoll;
  }
}
