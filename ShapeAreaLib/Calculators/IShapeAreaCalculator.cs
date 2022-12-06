using ShapeAreaLib.Shapes;

namespace ShapeAreaLib.Calculators;

public interface IShapeAreaCalculator
{
    double CalculateShapeArea(IShape shape);
}