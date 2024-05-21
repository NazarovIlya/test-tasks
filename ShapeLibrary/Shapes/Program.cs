using System.Globalization;

using ShapeLibrary;

double radius = 5,
       fisrtSide = 3,
       secondSide = 4,
       thirdSide = 5;


Circl circl = new(radius);
Triangle triangle = new Triangle(fisrtSide, secondSide, thirdSide);


Console.WriteLine(circl.ToString());
Console.WriteLine(triangle.ToString());
Console.WriteLine();

Console.WriteLine(triangle.IsRightAngledString());
Console.WriteLine();


List<Shape> shapeList = new List<Shape>
{
  new Triangle(3, 4, 5),
  new Circl(78),
  new Triangle(6, 7, 8),
  new Triangle(4, 12, 9),
  new Circl(45),
  new Circl(40)
};

foreach (Shape shape in shapeList)
{
  Console.WriteLine(string.Format("Площадь фигуры типа {0} равна {1:f2}", shape.GetType().Name, shape.GetArea()));
  
  if (shape is Triangle)
  {
    Triangle triangleFromList = (Triangle)shape;
    Console.WriteLine(triangleFromList.IsRightAngledString());
  }
  Console.WriteLine();
}


