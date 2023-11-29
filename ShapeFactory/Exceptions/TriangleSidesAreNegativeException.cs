namespace ShapeFactory.Exceptions;

public class TriangleSidesAreNegativeException : Exception
{
    public TriangleSidesAreNegativeException() : base("Unable to create triangle, sides must be positive")
    {
        
    }
}