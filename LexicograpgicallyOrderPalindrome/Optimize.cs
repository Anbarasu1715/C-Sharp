using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicograpgicallyOrderPalindrome
{
    internal class Optimize
    {
        public static string MakeSmallestPalindrome(string s)
        {
            char[] chars = s.ToCharArray();
            for (int i=0,j=s.Length-1; i<s.Length/2;i++,j--) {
                if (s[i] != s[j]) {
                    if (s[i] < s[j])
                    {
                        chars[j]= s[i];
                        continue;
                    }
                    chars[i] = s[j];
                }
            }
            return chars.ToString();
        }

        static void main() {
            string s = "abcd";
            Console.WriteLine(MakeSmallestPalindrome(s));
            Console.ReadKey();
        }

    }
}
