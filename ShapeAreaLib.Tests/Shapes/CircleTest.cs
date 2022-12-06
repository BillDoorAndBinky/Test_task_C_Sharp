using ShapeAreaLib.Shapes.Circles;
using ShapeAreaLib.Shapes.Triangles;
using Xunit;

namespace ShapeAreaTest.Shapes;

public class CircleTest
{
    [Fact]
    public void Creating_CorrectCircle()
    {
        var circle = new Circle(3);
        Assert.NotNull(circle);
    }

    [Fact]
    public void Creating_CircleZeroRadius_ThrowsArgumentException()
    {
        void CreateCircle()
        {
            new Circle(0);
        }

        Assert.Throws<ArgumentException>((Action)CreateCircle);
    }

    [Fact]
    public void Creating_CircleWithNegativeRadius_ThrowsArgumentException()
    {
        void CreateCircle()
        {
            new Circle(-1);
        }

        Assert.Throws<ArgumentException>((Action)CreateCircle);
    }

    [Fact]
    public void GetDiameter_Circle_ReturnsRealDiameter()
    {
        var circle = new Circle(0.5);
        Assert.Equal(1,circle.Diameter);
    }

    [Fact]
    public void CheckGetArea_OfTCircle_ReturnsRealArea()
    {
        var circle = new Circle(0.3);
        Assert.Equal(Math.PI*0.3*0.3, circle.GetArea());
    }
}