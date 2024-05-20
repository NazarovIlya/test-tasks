﻿using ShapeLibrary;
using Tests;

TriangleTests shapeTests = new();

//shapeTests.IsTriangle();

double radius = 5,
       fisrtSide = 3,
       secondSide = 3,
       thirdSide = 3;

Circl circl = new(radius);
Triangle triangle = new(fisrtSide, secondSide, thirdSide);


double squareOfCircl = circl.GetArea();
double squareOfTriangle = triangle.GetArea();
bool isRight = triangle.IsRightAngled();


Console.WriteLine(circl.ToString());
Console.WriteLine(triangle.ToString());

triangle.IsRightAngledString();
