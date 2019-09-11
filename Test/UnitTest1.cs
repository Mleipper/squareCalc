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
    }
}
