namespace ShapeLibrary
{
  public class Circl(double Radius) : Shape
  {
    public override double GetArea()
    {
      return Math.PI * Radius * Radius;
    }
  }
}
