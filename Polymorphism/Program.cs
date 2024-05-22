// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozzarella());

// Inheritance

public class Ingredient
{
  
}

public class Cheddar : Ingredient
{
  public string Name => "Cheddar Cheese";
  public int AgeForMonths {get;}
}

public class TomatoSauce : Ingredient
{
  public string Name => "Tomato sauce";
  public int TomatoesIn100Grams {get;}
}

public class Mozzarella : Ingredient
{
  public string Name => "Mozzarella";
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