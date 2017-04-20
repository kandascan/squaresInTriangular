using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;
using NUnit.Framework;


namespace CalculationTests
{
    [TestFixture]
    public class CalculationTests
    {
        [Test]
        public void ShouldCreateSquare()
        {
            var a = new MyPoint(3, 0);
            var b = new MyPoint(3, 3);
            var c = new MyPoint(6, 0);
            var d = new MyPoint(6, 3);

            var m = 3;
            var tmpPoint = new MyPoint(3, 0);
            var square = Calculation.Calculation.CreateSquare(tmpPoint, m);

            Assert.AreEqual(square.a.x, a.x);
            Assert.AreEqual(square.a.y, a.y);

            Assert.AreEqual(square.b.x, b.x);
            Assert.AreEqual(square.b.y, b.y);

            Assert.AreEqual(square.c.x, c.x);
            Assert.AreEqual(square.c.y, c.y);

            Assert.AreEqual(square.d.x, d.x);
            Assert.AreEqual(square.d.y, d.y);
        }


        [Test]
        public void TraingularShouldContainSquare()
        {
            var n = 10;
            var m = 3;
            var tmpPoint = new MyPoint(0, 4);

            var triangular = new MyTriangular(n);
            var square = Calculation.Calculation.CreateSquare(tmpPoint, m);
            var result = Calculation.Calculation.CheckSquareInTriangular(square, triangular);

            Assert.IsTrue(result);
        }

        [TestCase(10, 3, 3)]
        [TestCase(10, 4, 1)]
        [TestCase(10, 1, 45)]
        public void ShouldReturNumbersOfSquareInTriangular(int n, int m, int result)
        {
            Assert.AreEqual(result, Calculation.Calculation.Process(n, m));
        }
    }
}
