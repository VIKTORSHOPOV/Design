using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rec
    {
        public string Area(double a, double b)
        {
            return (a * b).ToString();
        }

        public string Perimeter(double a, double b)
        {
            return (2 * a + 2 * b).ToString();
        }
    }
}
