using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public static class Calculation
    {
        public static MySquare CreateSquare(MyPoint tmpPoint, int m)
        {
            return new MySquare(
                tmpPoint,
                new MyPoint(tmpPoint.x, tmpPoint.y + m),
                new MyPoint(tmpPoint.x + m, tmpPoint.y),
                new MyPoint(tmpPoint.x + m, tmpPoint.y + m)
                );
        }

        public static bool CheckSquareInTriangular(MySquare square, MyTriangular trinagular)
        {
            trinagular.point.x = square.d.x;
            trinagular.point.y = trinagular.triangular - trinagular.point.x;

            foreach (var point in square.points)
            {
                if (point.x > trinagular.point.x || point.y > trinagular.point.y)
                    return false;
            }
            return true;
        }

        public static int Process(int n, int m)
        {
            if (n == 0 || m == 0)
                throw new Exception("Input value cannot be 0");
            var counter = n / m;

            var tmpPoint = new MyPoint(0, 0);

            var triangular = new MyTriangular(n);

            var squareNumbers = 0;

            var tmpHeight = 0;
            for (var i = 0; i < counter; i++)
            {
                for (var j = 0; j < counter; j++)
                {
                    var square = CreateSquare(tmpPoint, m);
                    tmpPoint = new MyPoint(square.c.x, square.c.y);

                    var containSquare = CheckSquareInTriangular(square, triangular);
                    if (containSquare)
                        squareNumbers += 1;
                    else
                        break;
                }
                tmpPoint.x = 0;
                tmpHeight += m;
                tmpPoint.y = tmpHeight;
            }

            return squareNumbers;
        }
    }
}
