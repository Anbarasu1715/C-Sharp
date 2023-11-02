using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Square obj = new Square(8);
            
            Console.WriteLine(obj.Area());
            Console.Read();
        }

        List<int> obj = new List<int>();
    }
}
