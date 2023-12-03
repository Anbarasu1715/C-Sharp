using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    internal class Program
    {

        private static bool IsVowel(char c) {
            c =(c<97)?(char)(c+ 32):c;
            if (c=='a' || c=='e' || c=='i' || c=='o' || c=='u') {
                return true;
            }
            return false;
        }

        public static string ToGoatLatin(string sentence)
        {
            string result = "";
            string[] arr=sentence.Split(' ');
            for (int i=0;i<arr.Length;i++) {
                if (IsVowel(arr[i][0]))
                {
                    arr[i] += "ma" + new string('a', i + 1);
                }
                else
                {
                    arr[i] = arr[i].Substring(1, arr[i].Length - 1) + arr[i][0] + "ma" + new string('a',i+1);
                }
            }
            return string.Join(" ", arr);   
        }

        static void Main(string[] args)
        {
            string s = "I speak Goat Latin";
            Console.WriteLine(ToGoatLatin(s));
            Console.ReadLine();
        }
    }
}
