using CSharpOOP4;

#region Ierarchy classes exemplares

Cylinder cyl = new Cylinder("cylinder", 23, 10);
cyl.ShapeInfo();
Ball smallBall = new Ball("ball", 10);
smallBall.ShapeInfo();

Console.WriteLine($"Square of ball:{smallBall.GetSquare()}");
Pyramid egiptPyramid = new Pyramid("Faraoh", 10, 10);
egiptPyramid.ShapeInfo();
var pyramidHeight = egiptPyramid.Height;
Console.WriteLine();

#endregion
