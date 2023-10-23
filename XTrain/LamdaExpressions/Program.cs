using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressions
{

    public class factory {

        public int BranchCode;
        public string Factname;
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<factory> list = new List<factory> {
                new factory{ BranchCode=187,Factname="Iron and steel"},
                new factory{BranchCode=121,Factname="Gse Tech" },
                new factory{BranchCode=100,Factname="Vi Tele" }
            };

            //List<int> nums = new List<int> {1,2,3,4,5,6,7,8,9 };

            //Func<int,int> g=x => x*x;

            int[] a = {1,2,3 };
            int[] b = { 3, 2, 1 };

            List<List<int>> list1 = new List<List<int>>();

            for (int i=0;i<a.Length;i++) {
                for (int j=0;j<b.Length;j++) {
                    list1.Add(new List<int> {a[i],b[j] });
                }
            }

            //Func<List<int>, bool> checkSum = list1.Any(x => x==3);
            
            foreach (var i in list1) {
                //int sum = 0;
                Console.Write("{");
                if ( i.Sum()==3) {
                    i.ForEach(x => Console.Write(x));
                }
                Console.WriteLine("}");
                
            }
            int n = 123;

            var branch = list.Count(x => x.Factname.StartsWith("I"));

            //var sort = list.OrderBy(a => a.BranchCode);
            var range = list.FindAll(x => x.BranchCode>101);
            foreach (var fact in range) {
                Console.WriteLine(fact.Factname);
            }
            Console.WriteLine(branch);
            Console.ReadKey();
        }
    }
}
