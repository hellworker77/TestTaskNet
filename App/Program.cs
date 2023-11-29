using ShapeFactory.Interfaces;
using ShapeFactory.Shapes;

namespace App;

sealed class Program
{
    private static readonly List<IShape> Shapes = new();
    
    public static void Main(string[] args)
    {
        Initialize();
        Shapes.ForEach(x =>
        {
            x.PrintInfo();
            Console.WriteLine($"Area={x.GetArea()}");
            Console.WriteLine("--separator--");
        });
        
    }

    private static void Initialize()
    {
        Shapes.AddRange(new List<IShape>()
        {
            Circle.CreateInstance(4),
            Triangle.CreateInstance(2.4,3,5),
            Circle.CreateInstance(2),
            Triangle.CreateInstance(1, 2, 2.5),
            Triangle.CreateInstance(3,4,5)
        });
    }
    
}