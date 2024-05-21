public static class RandomNumber
{
  private readonly static Random _random = new Random();
  public static int Generate(int min, int max)
  {
    return _random.Next(min, max + 1);
  }
}