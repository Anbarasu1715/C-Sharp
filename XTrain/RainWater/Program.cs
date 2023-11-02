using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainWater
{
    class Program
    {
        static void Main() {
            Console.Write("Enter the Array Length:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Height of the Buildings.....");
            int[] heights = new int[n];
            for (int i=0;i<n;i++) {
                heights[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("-----__--__--__WELCOME__--__--__-----");
            Console.ReadKey();
        }
    }
}