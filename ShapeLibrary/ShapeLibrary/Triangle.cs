using Tests.Exceptions;

namespace ShapeLibrary
{
  public class Triangle(double FirstSide, double SecondSide, double ThirdSide) : Shape, IRight
  {
    public override double GetArea()
    {
      if (FirstSide <= 0 || SecondSide <= 0 || ThirdSide <= 0)
      {
        throw new ArgumentSideLengthException("The length of one or more sides is unacceptable. The lengths of all sides must be greater than zero");
      }
      else if(FirstSide > (SecondSide + ThirdSide)
            || SecondSide > (FirstSide + ThirdSide)
            || ThirdSide > (FirstSide + SecondSide))
      {
        throw new ArgumentSideLengthException("The existence of a triangle with such sides is impossible. The length of one side is greater than the sum of the other two");
      }
      else
      {
        //Расчет площади треугольника по трем сторонам (формула Герона)
        double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide)
                                       * (semiPerimeter - SecondSide)
                                       * (semiPerimeter - ThirdSide));
      }
    }

    public bool IsRightAngled()
    {
      double[] sides = { FirstSide, SecondSide, ThirdSide };

      Array.Sort(sides);

      double hypotenuse = Math.Pow(sides[2], 2);
      double legsSquaresSum = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);

      if (hypotenuse == legsSquaresSum)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public void IsRightAngledString()
    {
      if (this.IsRightAngled())
      {
        Console.WriteLine("Треугольник является прямоугольным");
      }
      else
      {
        Console.WriteLine("Треугольник не является прмоугольным");
      }
    }
  }
}
