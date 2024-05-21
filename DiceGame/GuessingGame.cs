public class GuessingGame
{
  private readonly Dice _dice;
  private readonly User _user;

    public GuessingGame(Dice dice, User user)
    {
        _dice = dice;
        _user = user;
    }
    public void Play()
  {
    Console.WriteLine("Dice rolled, Guess what number it shows in 3 tries");

    bool userGuessCorrect;
    var diceRoll = _dice.Roll();
    do
    {
      var userGuess = GetUserInput();
      userGuessCorrect = IsGuessCorrect(userGuess, diceRoll);

      if (userGuessCorrect)
      {
        Console.WriteLine("You Win!");
        break;
      }

      _user.DecreaseTries();
      Console.WriteLine("Wrong Number");
      
      if ( _user.TriesLeft == 0)
      {
        Console.WriteLine("You Lose");
        break;
      }

    } while (!userGuessCorrect);
  }
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
