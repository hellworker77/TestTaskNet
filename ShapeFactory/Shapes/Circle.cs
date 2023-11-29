using ShapeFactory.Exceptions;
using ShapeFactory.Interfaces;

namespace ShapeFactory.Shapes;

public sealed class Circle : IShape
{
    private readonly double _radius;

    private Circle(double radius)
    {
        _radius = radius;
    }

    public static Circle CreateInstance(double radius)
    {
        if (radius <= 0) throw new RadiusIsNegativeException();
        return new Circle(radius);
    }

    public double GetArea() =>
        Math.PI * Math.Pow(_radius, 2);

    public void PrintInfo()
    {
        Console.WriteLine($"Circle\nradius={_radius}");
    }
}