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

  public int CalculatePerimeter()
  {
    return 2 * Width + 2 * Height;
  }

  public int CalculateArea()
  {
    return Width * Height;
  }

} 



