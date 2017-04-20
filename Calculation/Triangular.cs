using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class MyTriangular
    {
        public int triangular { get; set; }
        public MyPoint point { get; set; }

        public MyTriangular(int n)
        {
            this.triangular = n;
            point = new MyPoint(0,0);
        }
    }
}
