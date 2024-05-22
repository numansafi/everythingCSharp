// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cheddar cheddar = new Cheddar();
Console.WriteLine(cheddar.Name);

Ingredient ingredient = new Cheddar();
Console.WriteLine(ingredient.Name);

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