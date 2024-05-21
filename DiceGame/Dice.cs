public class Dice
{
  private const int sidesCount = 6;

  public int Roll() => RandomNumber.Generate(1, sidesCount);
}
