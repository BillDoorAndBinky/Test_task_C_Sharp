using ShapeAreaLib.Shapes.Triangles;
using Xunit;


namespace ShapeAreaTest
{

    public class TriangleTest
    {
        [Fact]
        public void Creating_CorrectTriangle()
        {
            var triangle = new Triangle(3,4,5);
        }
        
        [Fact]
        public void Creating_TriangleWithMatchBiggerSide_ThrowsArgumentException()
        {
            void CreateTriangle() => new Triangle(100, 4, 5);
            Assert.Throws<ArgumentException>((Action)CreateTriangle);
        }
        
        [Fact]
        public void Creating_TriangleWithNegativeSide_ThrowsArgumentException()
        {
            void CreateTriangle() => new Triangle(-1, 4, 5);
            Assert.Throws<ArgumentException>((Action)CreateTriangle);
        }
        
        [Fact]
        public void Creating_TriangleWithZeroSide_ThrowsArgumentException()
        {
            void CreateTriangle() => new Triangle(0, 4, 5);
            Assert.Throws<ArgumentException>((Action)CreateTriangle);
        }
        
        [Fact]
        public void CheckIsRight_RightTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(0.5, 0.4, 0.3);
            Assert.True(triangle.IsRight());
        }
        
        [Fact]
        public void CheckIsRight_NotRightTriangle_ReturnsFalse()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRight());
        }
        
        [Fact]
        public void CheckGetArea_OfTriangle_ReturnsRealArea()
        {
            var triangle = new Triangle(0.3,0.4,0.5);
            Assert.Equal(0.06,triangle.GetArea());
        }
    }
}