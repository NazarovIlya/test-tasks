using ShapeLibrary.Exceptions;

namespace ShapeLibrary
{
  public class Circl : Shape
  {
    private double _radius;

    public Circl(double radius)
    {
      _ = (radius <= 0)
        ? throw new ArgumentNotPositiveValueException("The radius value is not valid and must be greater than zero.")
        : _radius = radius;
    }
    public override double GetArea()
    {
      return Math.PI * _radius * _radius;
    }
  }
}
