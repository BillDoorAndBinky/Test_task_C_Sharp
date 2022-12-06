using System;

namespace ShapeAreaLib.Shapes.Triangles
{
    public class Triangle : IShape, ITriangle
    {
        public Triangle(double a, double b, double c)
        {
            //Проверка условий создания треугольника
            if (a <= 0
                ||
                b <= 0
                ||
                c <= 0
                ||
                a > b + c
                ||
                b > a + c
                ||
                c > a + b)
                throw new ArgumentException("Invalid sides of the triangle");
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        ///     Первая сторона
        /// </summary>
        public double A { get; protected set; }

        /// <summary>
        ///     Вторая сторона
        /// </summary>
        public double B { get; protected set; }

        /// <summary>
        ///     Третья сторона
        /// </summary>
        public double C { get; protected set; }

        /// <summary>
        /// Прямоугольный ли треугольник
        /// </summary>
        public bool IsRight()
        {
            var poweredA = Math.Pow(A, 2);
            var poweredB = Math.Pow(B, 2);
            var poweredC = Math.Pow(C, 2);

            return Math.Abs(poweredA - (poweredB + poweredC)) < double.Epsilon
                      ||
                      Math.Abs(poweredB - (poweredA + poweredC)) < double.Epsilon
                      ||
                      Math.Abs(poweredC - (poweredA + poweredB)) < double.Epsilon;
        }

        public double GetArea()
        {
            //Для вычисления используется формула Герона
            var s = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(s * (s - A) * (s - B) * (s - C)));
        }
    }
}