namespace ObjectOrientedPrograming;

public class Names
{
  private readonly NameValidator _nameValidator = new();
  public List<string> AllNames {get;} = new();

  public void AddNames(List<string> stingsFromFile)
  {
    foreach (var name in stingsFromFile)
    {
      AddName(name);
    }
  }
  public void AddName(string name)
  {
    if (_nameValidator.IsValidName(name)){
      AllNames.Add(name);
    }
  }
}
 