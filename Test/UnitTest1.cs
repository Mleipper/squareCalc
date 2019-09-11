using System;
using Xunit;
using squareCalc;
namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestTriangleArea()
        {
            var actualArea = triangle.calcArea(24, 18, 30);
            var expected = 216;
            Assert.True(actualArea == expected);
        }
        [Fact]
        public void testNotvalid()
        {
            var invalid= triangle.notValid(3,1,1);
            Assert.True(invalid);

        }
        [Fact]
        public void testValid()
        {
            var validTri = triangle.notValid(24, 18, 30);
            Assert.False(validTri);
        }
    }
}
