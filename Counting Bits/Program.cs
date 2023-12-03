using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Bits
{
    internal class Program
    {

        public static int binary(int n) {
            List<int> list = new List<int>();
            for (int i=0;n>0;i++) { 
                list.Add(n%2);
                n /= 2;
            }
            return list.Sum();
        }

        public static int[] CountBits(int n)
        {
            int[] count = new int[n+1];    
            for (int i=0;i<=n;i++) {
                count[i] = binary(i);
            }
            return count;
        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(string.Join(",", CountBits(n)));
            Console.ReadLine();
        }
    }
}
