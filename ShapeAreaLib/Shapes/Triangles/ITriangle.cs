namespace ShapeAreaLib.Shapes.Triangles
{
    public interface ITriangle : IShape
    {
        /// <summary>
        ///     Первая сторона
        /// </summary>
        public double A { get; }

        /// <summary>
        ///     Вторая сторона
        /// </summary>
        public double B { get; }

        /// <summary>
        ///     Третья сторона
        /// </summary>
        public double C { get; }

        /// <summary>
        /// Прямоугольный ли треугольник
        /// </summary>
        public bool IsRight();
    }
}