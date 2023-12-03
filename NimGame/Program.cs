using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame
{
    internal class Program
    {

        public static bool CanWinNim(int n)
        {
            if (n%2!=0) { 
                return true;
            }
            if ((n/2)%2!=0) {
                return true;
            }
            //Console.WriteLine((n / 3) % 2);
            
            return false;
        }

        static void Main(string[] args)
        {
            int n = 28;
            Console.WriteLine(CanWinNim(n));
            Console.ReadLine();
        }
    }
}
