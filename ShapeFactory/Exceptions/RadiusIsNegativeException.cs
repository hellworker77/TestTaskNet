namespace ShapeFactory.Exceptions;

public class RadiusIsNegativeException : Exception
{
    public RadiusIsNegativeException() : base("Unable to create circle, radius must be more than zero")
    {
        
    }
}