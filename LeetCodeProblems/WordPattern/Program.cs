using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(WordPattern("abba", "dog dog dog dog"));
            Console.ReadKey();
        }

        //public static bool WordPattern(string pattern, string s)
        //{
        //    Dictionary<char, string> dict1 = new Dictionary<char, string>();
        //    Dictionary<string, char> dict2 = new Dictionary<string, char>();
        //    string[] words = s.Split(' ');
        //    for (int i=0;i<pattern.Length;i++) {
        //        dict1[pattern[i]] = words[i];
        //        dict2[words[i]] = pattern[i];
        //        if (dict1[pattern[i]] != words[i]) return false;
        //        if (dict2[words[i]] != pattern[i]) return false;
        //    }
        //    return true;
        //}

        public static bool WordPattern(string pattern, string s)
        {
            var dict1 = new Dictionary<char, string>();
            var dict2 = new Dictionary<string, char>();
            var sList = s.Split(' ');

            if (pattern.Length != sList.Count()) return false;
            for (int i = 0; i
                
                < sList.Count(); i++)
            {
                if (!dict1.ContainsKey(pattern[i]) && !dict2.ContainsKey(sList[i])) {
                    dict1.Add(pattern[i], sList[i]);
                    dict2.Add(sList[i], pattern[i]);

                }
                    if (dict1[pattern[i]] != sList[i]) return false;
                if (dict2[sList[i]] != pattern[i]) return false;
            }
            return true;
        }

    }
}