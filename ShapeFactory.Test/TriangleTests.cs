using ShapeFactory.Exceptions;
using ShapeFactory.Shapes;
using Xunit;

namespace ShapeFactory.Test;

public class TriangleTests
{
    [Fact]
    public void CreateThrowsTriangleSidesAreNegativeExceptionTest()
    {
        var sideA = 3;
        var sideB = -4;
        var sideC = 5;
        
        Assert.Throws<TriangleSidesAreNegativeException>(() => Triangle.CreateInstance(sideA, sideB, sideC));
    }
    [Fact]
    public void CreateThrowsTriangleWrongSidesLengthExceptionTest()
    {
        var sideA = 3;
        var sideB = 2;
        var sideC = 5;
        
        Assert.Throws<TriangleWrongSidesLengthException>(() => Triangle.CreateInstance(sideA, sideB, sideC));
    }
    [Fact]
    public void CreateTest()
    {
        var sideA = 3;
        var sideB = 4;
        var sideC = 5;

        var exception = Record.Exception(() => Triangle.CreateInstance(sideA, sideB, sideC));
        
        Assert.Null(exception);
    }
    [Fact]
    public void GetAreaTest()
    {
        var sideA = 3;
        var sideB = 4;
        var sideC = 5;
        var expectationArea = sideA * sideB / 2;
        
        var triangle = Triangle.CreateInstance(sideA, sideB, sideC);

        var area = triangle.GetArea();
        
        Assert.Equal(expectationArea, area);
    }
    [Fact]
    public void IsRectangularTest()
    {
        var expected = true;
        
        var triangle = Triangle.CreateInstance(3, 4, 5);
        var actual = triangle.IsRectangular();
        
        Assert.Equal(expected, actual);
    }
}