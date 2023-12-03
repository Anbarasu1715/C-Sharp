using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfFour
{
    internal class Program
    {

        public static bool IsPowerOfFour(int n)
        {
            if (n%4==0 || n==1) {
                for (int i=0;i<((n>2)?n/2:n);i++) {
                    if (Math.Pow(4,i)==n) { 
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int n = 12;
            Console.WriteLine(IsPowerOfFour(n));
            Console.ReadLine();
        }
    }
}
