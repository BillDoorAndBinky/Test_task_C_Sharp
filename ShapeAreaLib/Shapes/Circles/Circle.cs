using System;

namespace ShapeAreaLib.Shapes.Circles;

public class Circle : ICircle
{
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Invalid radius");

        Radius = radius;
    }

    public double Diameter => Radius * 2;

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double Radius { get; protected set; }
}