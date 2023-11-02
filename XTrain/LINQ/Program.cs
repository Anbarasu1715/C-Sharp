using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr= {14,2,4,563,1235,12,789,56,90,32,6 };
            //var brr = from i in arr where i > 40 orderby i descending select i;


            //var brr = from i in arr where i % 2 == 0 orderby i select i;
            //var brr = arr.Where(i => i%2!=0);
            var brr = arr.Where(i=>i>40);

            Console.WriteLine(brr.GetType());
            Console.WriteLine(brr);
            foreach(var i in brr){
                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
