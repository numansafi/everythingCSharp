
var randomNumber = RandomNumber.Generate(1, 6);
var dice = new Dice{ DiceRoll = randomNumber };
var user = new User();

Console.WriteLine("Dice rolled, Guess what number it shows in 3 tries");

bool userGuessCorrect;
do
{
  var userGuess = Game.GetUserInput();
  userGuessCorrect = Game.IsGuessCorrect(userGuess, dice.DiceRoll);

  if (userGuessCorrect)
  {
    Console.WriteLine("You Win!");
    break;
  }

  user.DecreaseTries();
  Console.WriteLine("Wrong Number");
  
  if ( user.TriesLeft == 0)
  {
    Console.WriteLine("You Lose");
    break;
  }

} while (!userGuessCorrect);