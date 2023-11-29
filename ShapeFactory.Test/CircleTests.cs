using ShapeFactory.Exceptions;
using ShapeFactory.Shapes;
using Xunit;

namespace ShapeFactory.Test;

public class CircleTests
{
    [Fact]
    public void CreateThrowsRadiusIsNegativeExceptionTest()
    {
        var radius = -1.4;
        
        Assert.Throws<RadiusIsNegativeException>(() => Circle.CreateInstance(radius));
    }

    [Fact]
    public void CreateTest()
    {
        var radius = 20.1;

        var exception = Record.Exception(() => Circle.CreateInstance(radius));
        
        Assert.Null(exception);
    }

    [Fact]
    public void GetAreaTest()
    {
        var radius = 5;
        var expectationArea = Math.PI * Math.Pow(radius, 2);
        var cicrle = Circle.CreateInstance(radius);

        var area = cicrle.GetArea();
        
        Assert.Equal(expectationArea, area);
    }
}