using ShapeAreaLib.Calculators;
using ShapeAreaLib.Shapes.Circles;
using ShapeAreaLib.Shapes.Triangles;
using Xunit;

namespace ShapeAreaTest.Calculators;

public class ShapeAreaCalculatorTest
{
    [Fact]
    public void CompareAreas_Calculator()
    {
        var circle = new Circle(3);
        var triangle = new Triangle(3, 4, 5);
        var calculator = new ShapeAreaCalculator();

        Assert.Equal(Math.PI * 3 * 3, calculator.CalculateShapeArea(circle));
        Assert.Equal(6, calculator.CalculateShapeArea(triangle));
    }
}