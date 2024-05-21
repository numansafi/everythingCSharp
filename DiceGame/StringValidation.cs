


public static class StringValidation
{
  public static bool ValidateStringAsNumber(string input, out int result)
  {
    return int.TryParse(input, out result);
  }
}