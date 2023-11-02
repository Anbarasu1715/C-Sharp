using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfFirstOccurrenceString
{
    class Program
    {
        public static int StrStr(string haystack, string needle)
        {
            int n = 1, index = -1;
            if (haystack.Contains(needle))
            {
                for (int i = 0; i < haystack.Length; i++)
                {
                    if (needle[0] == haystack[i])
                    {
                        for (int j = i + 1; j < haystack.Length; j++)
                        {
                            if(n<needle.Length)
                                if (needle[n] == haystack[j])
                                {
                                    n++;
                                    if (n==needle.Length) {
                                        return i;
                                    }
                                }
                        }
                        if (n != needle.Length)
                        {
                            n = 1;
                        }
                        else
                        {
                            index = i;
                            break;
                        }
                    }
                }
                return index;
            }
            else
            {
                return index;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(StrStr("aaa", "a"));
            Console.ReadKey();
        }
    }
}
