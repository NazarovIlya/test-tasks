using ShapeLibrary;

double radius = 5,
       fisrtSide = 3,
       secondSide = 4,
       thirdSide = 5;

Circl circl = new(radius);
Triangle triangle = new(fisrtSide, secondSide, thirdSide);


double squareOfCircl = circl.GetArea();
double squareOfTriangle = circl.GetArea();


Console.WriteLine(circl.ToString());
Console.WriteLine(triangle.ToString());
