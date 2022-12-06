using ShapeAreaLib.Shapes;

namespace ShapeAreaLib.Calculators;

public class ShapeAreaCalculator : IShapeAreaCalculator
{
    public double CalculateShapeArea(IShape shape)
    {
        return shape.GetArea();
    }
}