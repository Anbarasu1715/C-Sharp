using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Square:IRegularPolygon
    {
        int length { get; set; }
        int sides { get; set; }

        public Square(int len) {
            length = len;
            sides = 4;
        }

        public double Area()
        {
            return sides* length;
        }

        public double Perimeter()
        {
            return length * length * (2+2*Math.Sqrt(2));
        }
    }
}