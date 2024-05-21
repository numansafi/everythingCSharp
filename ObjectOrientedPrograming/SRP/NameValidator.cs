namespace ObjectOrientedPrograming;

public class NameValidator
{
  public bool IsValidName(string name)
  {
    return name.Length > 0 &&
    name.Length < 25 &&
    char.IsUpper(name[0]) &&
    name.All(char.IsLetter);
  }
}
