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

class ShapeMeasurementCalculator()
{
  public int CalculateRectanglePerimeter(Rectangle rectangle ) =>  2 * rectangle.Width + 2 * rectangle.Height;

  public int CalculateArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;
}



