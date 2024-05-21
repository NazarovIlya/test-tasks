using ShapeLibrary;

using Tests.Exceptions;

namespace Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleCalculate()
    {
      Triangle triangle = new(3, 3, 3);
      Assert.AreEqual(3.8971, Math.Round(triangle.GetArea(), 4));

      triangle = new Triangle(5, 5, 5);
      Assert.AreEqual(10.8253, triangle.GetArea(), 4);

      triangle = new Triangle(5, 8, 10);
      Assert.AreEqual(19.81, triangle.GetArea(), 2);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentSideLengthException))]
    public void IsArgumentExeption()
    {
      Triangle triangle = new(2, 2, 5);
      triangle.GetArea();

      triangle = new Triangle(5, 5, 11);
      triangle.GetArea();

      triangle = new Triangle(10, 10, 21);
      triangle.GetArea();
    }

    [TestMethod]
    public void IsRightAngle()
    {
      Triangle triangle = new(3, 4, 5);
      Assert.AreEqual(true, triangle.IsRightAngled());

      triangle = new(5, 5, 5);
      Assert.AreEqual(false, triangle.IsRightAngled());
    }
  }
}
