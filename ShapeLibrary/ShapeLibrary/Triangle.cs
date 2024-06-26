﻿using ShapeLibrary.Exceptions;

namespace ShapeLibrary
{
  public class Triangle : Shape, IRight
  {
    private double _firstSide;
    private double _secondSide;
    private double _thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
      Validation(firstSide, secondSide, thirdSide);

      _firstSide = firstSide;
      _secondSide = secondSide;
      _thirdSide = thirdSide;
    }

    public override double GetArea()
    {
      //Расчет площади треугольника по трем сторонам (формула Герона)
      double semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;

      return Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide)
                                     * (semiPerimeter - _secondSide)
                                     * (semiPerimeter - _thirdSide));
    }

    public bool IsRightAngled()
    {
      double[] sides = { _firstSide, _secondSide, _thirdSide };

      Array.Sort(sides);

      double hypotenuse = Math.Pow(sides[2], 2);
      double legsSquaresSum = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);

      return (hypotenuse == legsSquaresSum) ? true : false;
    }

    public string IsRightAngledString()
    {
      return (IsRightAngled())
        ? "The triangle is rectangular"
        : "The triangle is not rectangular";
    }

    private void Validation(double firstSide, double secondSide, double thirdSide)
    {
      if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        throw new ArgumentNotPositiveValueException("The length of one or more sides is unacceptable. The lengths of all sides must be greater than zero");
      
      if (firstSide > (secondSide + thirdSide)
            || secondSide > (firstSide + thirdSide)
            || thirdSide > (firstSide + secondSide))
        throw new ArgumentSideLengthException("The existence of a triangle with such sides is impossible. The length of one side is greater than the sum of the other two");
    }
  }
}
