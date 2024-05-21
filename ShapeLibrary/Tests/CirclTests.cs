using ShapeLibrary;
using ShapeLibrary.Exceptions;

namespace Tests
{
  [TestClass]
  public class CirclTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentNotPositiveValueException))]
    public void IsCircl()
    {
      Circl circl = new Circl(-1);
      circl.GetArea();

      circl = new Circl(0);
      circl.GetArea();
    }
    [TestMethod]
    public void CirclCalculate()
    {
      Circl circl = new(57);
      Assert.AreEqual(10207, Math.Round(circl.GetArea()));

      circl = new(80);
      Assert.AreEqual(20106, Math.Round(circl.GetArea()));

      circl = new(100);
      Assert.AreEqual(31416, Math.Round(circl.GetArea()));
    }
  }
}
