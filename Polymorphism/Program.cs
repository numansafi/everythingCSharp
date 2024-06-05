// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cheddar cheddar = new Cheddar();
Console.WriteLine(cheddar.Name);

Ingredient ingredient = new Cheddar();
Console.WriteLine(ingredient.Name);

var numbers = new List<int> {1, 4, 6, -1, 12, 44, -8, -19};

var allNumberCalculator = new NumbersSumCalculator();
System.Console.WriteLine(allNumberCalculator.Calculate(numbers));

var positiveNumberCalculator = new PositiveNumbersSumCalculator();
Console.WriteLine(positiveNumberCalculator.Calculate(numbers));

// Inheritance

public class Ingredient
{
  public virtual string Name { get; set; } = "Some ingredient";
}

public class Cheddar : Ingredient
{
  public override string Name => "Cheddar Cheese";
  public int AgeForMonths {get;}
}

public class TomatoSauce : Ingredient
{
  public override string Name => "Tomato sauce";
  public int TomatoesIn100Grams {get;}
}

public class Mozzarella : Ingredient
{
  public override string Name => "Mozzarella";
  public bool IsLight {get;}
}

public class Pizza
{
  private readonly List<Ingredient> _ingredients = new();

  public void AddIngredient(Ingredient ingredient)
  {
    _ingredients.Add(ingredient);
  }

  public string Describe()
  {
    return $"This is a pizza with {string.Join(", ", _ingredients)}";
  }
}

public class NumbersSumCalculator
{
  public int Calculate(List<int> numbers)
  {
    int sum = 0;
    foreach (int number in numbers)
    {
      if (ShallBeAdded(number))
      {
        sum += number;
      }
    }
    return sum;
  }

  protected virtual bool ShallBeAdded(int number)
  {
    return true;
  }
}

public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
      return number > 0;
    }
}

