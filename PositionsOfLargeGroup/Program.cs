using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionsOfLargeGroup
{
    internal class Program
    {

        public static int counting(char c,string s,int index) {
            int count=0;
            for (int i = index;i<s.Length;i++) {
                if (s[i]==c) {
                    count++;
                }
                else
                    return count;
            }
            return count;
        }

        public static IList<IList<int>> LargeGroupPositions(string s)
        {
            List<List<int>> result=new List<List<int>>();
            List<int> list=new List<int>();
            for (int i = 0; i < s.Length; i++) {
                int count = counting(s[i],s,i);
                if (count>2) {
                    list.Add(i);
                    list.Add(Math.Abs(i+count-1));
                    i += count-2;
                    result.Add(new List<int>(list));
                    list.Clear();
                }
            }
            return result.Cast<IList<int>>().ToList();
        }

        static void Main(string[] args)
        {
            string s = "abbxxxxzzy";
            foreach (var i in LargeGroupPositions(s)) {
                foreach (var j in i) {
                    Console.Write(j+",");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
