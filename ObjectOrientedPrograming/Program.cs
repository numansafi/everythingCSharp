// OOP

// An object(instance) of class DateTime has created
var pizzaDay23 = new DateTime(2023, 02, 09);
//Console.WriteLine(pizzaDay23.DayOfWeek);

var pizzaDay24 = pizzaDay23.AddYears(1);
//Console.WriteLine(pizzaDay24.DayOfWeek);

// First class

var rectangle = new Rectangle(10, 5);
System.Console.WriteLine(rectangle.Height);

class Rectangle
{
  // Fields of a class
  public int Width;
  public int Height;

  // Constructor
  public Rectangle(int width, int height)
  {
    Width = width;
    Height = height;
  }
}



