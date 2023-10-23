using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTrain
{
    class _3sum
    {

        public static bool isAvailable(IList<IList<int>> list,List<int> target) {
            int flag = 0, OuterCount = 0 ;
            foreach (var outer in list) {
                int InnerCount = 0;
                var sortedNumbers = outer.OrderBy(x => x).ToList();
                target.Sort();
                //if (outer.Count == target.Count)
                //{

                if (sortedNumbers.SequenceEqual(target))
                {
                    Console.WriteLine("true");
                    return true;
                }

                    
                    /*Console.WriteLine(InnerCount);
                    Console.Write("{");
                    foreach (var value in outer) {
                        Console.Write(value+" " );
                    }
                    Console.WriteLine("}");
                    Console.Write("{");
                    foreach (var value in target)
                    {
                        Console.Write(value + " ");
                    }
                    Console.WriteLine("}");
                    if (InnerCount == outer.Count)
                    {
                        flag = 1;
                        OuterCount++;
                    }
                }*/
            }
            /*if (OuterCount > 0)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }*/
            Console.WriteLine("false");
            return false;
        }

        public static void checkSum() {
            IList<IList<int>> list = new List<IList<int>>();
            int[] a = new int[] { 0, 14, -7, 2, 7, 11, -9, 11, -12, 6, -10, -8, 9, -3, 7, -6, 3, 4, 14, -10, -8, 5, -1, 6, 12, 9, 12, -11, -15, -5, 5, 0, -6, 13, 9, 9, 10, 7, 5, 13, -2, 11, -10, -15, -15, 4, -14, -4, -15, 7, -7, -15, -3, 8, -2, -13, -6, -5, -9, -14, 5, 12, 1, 6, 2, -12, -8, -11, 10, 13, -13, -14, 1, 14, 8, 1, -4, 9, 4, -12, -6, 13, 10, 6, 6, -7, 8, 7, 3, 7, 8, -15, -4, -14, -1, 13, -11, 6, -12, -15, 4, 12, 8, -10, 4, 1, -1, 7, -13, -12, 10, -4, 8, 6, 10, -1, 6, -5, 13, -13, 9, 6, -13, -10 };
            int len = a.Length;
            int flag = 0;
            Array.Sort(a);
            loop1:
            for (int i=0;i<len;i++) {
                if (a[i] > 0)
                    break;
                if (a[i] < 0 && a[i + 2] < 0) {
                    continue;
                }
                for (int j=i+1; j<len;j++) {
                    if (a[i]==0 && a[j]>0) {
                        goto end;
                    }
                    for (int k=j+1;k<len;k++) {
                        if (a[k]< 0)
                            break;
                        Console.WriteLine("i,j,k====" + a[i] + "  " + a[j] + "  " + a[k]);
                        if (a[i]+a[j]+a[k]==0) {
                            Console.WriteLine("----------yes----------");
                            List<int> newList = new List<int> { a[i], a[j], a[k] };
                            if (!isAvailable(list,newList)) {
                                list.Add(newList);
                            }
                            flag = 1;
                        }
                    }
                }
            }
            end:
            if (flag == 0)
            {
                foreach (var inner in list)
                {
                    Console.Write("[");
                    foreach (var value in inner)
                    {
                        Console.Write(value + " ");
                    }
                    Console.Write("]");
                }
            }
            else
            {
                foreach (var inner in list)
                {
                    Console.Write("[");
                    foreach (var value in inner)
                    {
                        Console.Write(value + " ");
                    }
                    Console.Write("]");
                }
            }
        }
    }
}
