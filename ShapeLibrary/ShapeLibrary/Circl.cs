using ShapeLibrary.Exceptions;

using Tests;

namespace ShapeLibrary
{
  public class Circl() : Shape
  {
    private double _radius;

    public Circl(double radius) : this()
    {
      if (radius <= 0)
      {
        throw new ArgumentNotPositiveValueException("The radius value is not valid and must be greater than zero.");
      }
      else
      {
        _radius = radius;
      }
    }
    public override double GetArea()
    {
      return Math.PI * _radius * _radius;
    }
  }
}
