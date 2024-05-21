namespace ShapeLibrary
{
  public abstract class Shape : IArea
  {
    public abstract double GetArea();

    public override string ToString()
    {
      return string.Format("Площадь {0} равна {1:f2}", this.GetType(), this.GetArea());
    }
  }
}
