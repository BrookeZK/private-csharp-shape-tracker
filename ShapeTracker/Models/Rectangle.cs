namespace ShapeTracker.Models 
{
  public class Rectangle 
  {
    public int Side1 { get; }
    public int Side2 { get; }

    public Rectangle(int length1, int length2) 
    {
      Side1 = length1;
      Side2 = length2;
    }

    public int GetArea() 
    {
      return Side1 * Side2;
    }
  }
}