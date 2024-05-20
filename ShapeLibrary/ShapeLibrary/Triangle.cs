namespace ShapeLibrary
{
  public class Triangle(double FirstSide, double SecondSide, double ThirdSide) : Shape
  {
    public override double GetArea()
    {
      //Расчет площади треугольника по трем сторонам (формула Герона)
      double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

      return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide)
                                     * (semiPerimeter - SecondSide)
                                     * (semiPerimeter - ThirdSide));
    }
  }
}
