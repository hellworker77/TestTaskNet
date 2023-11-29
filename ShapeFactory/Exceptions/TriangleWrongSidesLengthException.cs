namespace ShapeFactory.Exceptions;

public class TriangleWrongSidesLengthException : Exception
{
    public TriangleWrongSidesLengthException() : base("Triangle sides must be correct")
    {
        
    }
}