using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortestDistanceToChar
{
    internal class Program
    {

        public static int[] ShortestToChar(string s, char c)
        {
            int[] arr=new int[s.Length];
            int index = s.IndexOf(c), arrIndex = 0,flag=0 ;
            for (int i=0;i<s.Length;i++)
            {
                if (s[i]==c && flag==0) {
                    s = s.Substring(i,s.Length-i);
                    index=s.IndexOf(c);
                    i = 0;
                    flag = 1;
                    continue;
                }
                flag = 0;
                arr[arrIndex++] = Math.Abs(i-index);
            }
            return arr;
        }

        static void Main(string[] args)
        {
            foreach (int i in ShortestToChar("loveleetcode",'e'))
            {
                Console.Write(i+" , ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
