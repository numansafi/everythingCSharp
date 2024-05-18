class Rectangle
{
  // Fields of a class
  public int Width;
  private int _height;

  // Constructor
  public Rectangle(int width, int height)
  {
    Width = width;
    _height = height;
  }

  public int GetHeight() => _height;
  public void setHeight(int value) => _height = value;
} 

class ShapeMeasurementCalculator()
{
  public int CalculateRectanglePerimeter(Rectangle rectangle ) =>  2 * rectangle.Width + 2 * rectangle.GetHeight();

  public int CalculateArea(Rectangle rectangle) => rectangle.Width * rectangle.GetHeight();
}
 


