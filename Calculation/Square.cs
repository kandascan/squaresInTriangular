using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class MySquare
    {
        public MyPoint a { get; set; }
        public MyPoint b { get; set; }
        public MyPoint c { get; set; }
        public MyPoint d { get; set; }

        public MyPoint[] points;

        public MySquare(MyPoint a, MyPoint b, MyPoint c, MyPoint d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            points = new []{ a, b, c, d };
        }
    }
}
