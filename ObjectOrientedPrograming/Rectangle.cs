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
    public int CalculateRectanglePerimeter(Rectangle rectangle )
  {
    return 2 * rectangle.Width + 2 * rectangle.Height;
  }

  public int CalculateArea(Rectangle rectangle)
  {
    return rectangle.Width * rectangle.Height;
  }
}



