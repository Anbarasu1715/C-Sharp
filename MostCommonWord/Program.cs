using System;
using System.Linq;

namespace MostCommonWord
{
    internal class Program
    {

        private static string RemoveSpecialChar(string para) {
            string result="";
            for (int i=0;i<para.Length; i++) {
                if (char.IsLetterOrDigit(para[i]) || para[i]==' ') { 
                    result+= para[i]; 
                }
            }
            return result;
        }

        public static string MostCommonWord(string paragraph, string[] banned)
        {
            int max = 0, count = 1,index=0;
            var words = paragraph.ToLower().Split(" !?',;.".ToCharArray(), StringSplitOptions.None | StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            for (int i=0;i<words.Length;i++) {
                //words[i] = words[i].Trim();
                if ((i+1)<words.Length-1 && words[i] == words[i + 1] && !banned.Contains(words[i]))
                {
                    count++;
                }
                else {
                    if (max <= count) { 
                        max=count;
                        if (!banned.Contains(words[i]))
                            index = i;
                        i += (count>1)?1:0;
                        count = 1;
                    }
                }
            }
            return words[index];
        }

        static void Main(string[] args)
        {
            string para = "Bob. hIt, baLl";
            para = para.ToLower();
            string[] arr = { "bob", "hit" };
            //para= RemoveSpecialChar(para);
            Console.WriteLine(MostCommonWord(para,arr));
            Console.ReadLine();
        }
    }
}
