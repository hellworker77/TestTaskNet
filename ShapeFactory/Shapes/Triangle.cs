using ShapeFactory.Exceptions;
using ShapeFactory.Interfaces;

namespace ShapeFactory.Shapes;

public sealed class Triangle : IShape
{
    private readonly double[] _sides;

    private Triangle(double sideA,
        double sideB,
        double sideC)
    {
        _sides = new[] {sideA, sideB, sideC};
    }

    public static Triangle CreateInstance(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0) throw new TriangleSidesAreNegativeException();
        if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)) throw new TriangleWrongSidesLengthException();

        return new Triangle(sideA, sideB, sideC);
    }

    public double GetArea()
    {
        var semiPerimeter = _sides.Sum() / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - _sides[0]) *
                         (semiPerimeter - _sides[1]) *
                         (semiPerimeter - _sides[2]));
    }

    public bool IsRectangular()
    {
        Array.Sort(_sides);

        return (Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2)).Equals(Math.Pow(_sides[2], 2));
    }
    public void PrintInfo()
    {
        var rectangularInfo = IsRectangular() ? "Yes" : "No";
        Console.WriteLine($"Triangle\nsides=[{string.Join(",", _sides)}]\nrectangular={rectangularInfo}");
    }
}