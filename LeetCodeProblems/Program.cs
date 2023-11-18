using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Program
    {

        public static bool IsPalindrome(string s)
        {
            string perfectString = "";
            int output;
            for (int i = 0; i < s.Length; i++)
            {
                if (int.TryParse(s[i] + "", out output))
                {
                    perfectString += output;
                }
                else if ((s[i] >= 65 && s[i] <= 90) || (s[i] >= 97 && s[i] <= 122) || (s[i] >= 0 && s[i] <= 9))
                {
                    perfectString += s[i];
                }
            }
            Console.WriteLine(perfectString);
            char[] c = perfectString.ToCharArray();
            Array.Reverse(c);
            Console.WriteLine(new String(c));
            if (new String(c).ToLower() == perfectString.ToLower())
                return true;
            else return false;
        }

        static void Main(string[] args)
        {
            string s = "0P";
            Console.WriteLine(IsPalindrome(s));
            Console.Read();
        }
    }
}
