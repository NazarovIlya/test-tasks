using ShapeLibrary; 

namespace Tests
{
  [TestClass]
  public class ShapeTests
  {
    [TestMethod]
    public void IsTriangle()
    {
      Triangle triangle = new(3, 3, 3);
      Assert.AreEqual(3.897114317029974, triangle.GetArea());
    }
  }
}
