using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindandReplacePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
            string pattern = "abb";
            foreach (var i in FindAndReplacePattern(words,pattern)) {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            Dictionary<char, char> dict1 = new Dictionary<char, char>();
            Dictionary<char, char> dict2 = new Dictionary<char, char>();
            IList<string> list = new List<string>();
            int flag = 0;
            for (int i = 0; i < words.Length; i++)
            {
                flag = 1;
                if (words[i].Length == pattern.Length)
                {
                    for (int j = 0; j < pattern.Length; j++)
                    {
                        if (!dict1.ContainsKey(words[i][j]))
                        {
                            dict1.Add(words[i][j], pattern[j]);
                        }
                        if (!dict2.ContainsKey(pattern[j]))
                        {
                            dict2.Add(pattern[j], words[i][j]);
                        }
                        if (dict1[words[i][j]] != pattern[j] || dict2[pattern[j]] != words[i][j])
                        {
                            flag = 0; break;
                        }
                    }
                    if (flag == 1)
                    {
                        list.Add(words[i]);
                    }
                    dict1.Clear();
                    dict2.Clear();
                }
            }
            return list;
        }

    }
}
