using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicograpgicallyOrderPalindrome
{
    internal class Program
    {

        public static bool isPalindrome(string s) { 
            string reverse=new string(s.Reverse().ToArray());
            if (reverse==s) { 
                return true;
            }
            else
                return false;
        }


        public static string MakeSmallestPalindrome(string s)
        {
            int len = s.Length;
            for (int k=0;k<len;k++) {
                char c= s[k];   
                do
                {
                    for (int i = 0; i < len; i++)
                    {
                        char originalChar = s[i];
                        s = s.Substring(0, i) + (char)((s[i] - 'a' + 1) % 26 + 'a') + s.Substring(i + 1, len - i - 1);
                        while (s[i] != originalChar)
                        {
                            // Console.WriteLine(s);
                            if (isPalindrome(s))
                            {
                                return s;
                            }
                            s = s.Substring(0, i) + (char)((s[i] - 'a' + 1) % 26 + 'a') + s.Substring(i + 1, len - i - 1);

                        }
                    }
                    s = s.Substring(0, k) + (char)((s[k] - 'a' + 1) % 26 + 'a') + s.Substring(k + 1, len - k - 1);
                } while (s[k] !=c);
            }
            return null;
        }

        static void Main(string[] args)
        {
            string s = "abcd";
            Console.WriteLine(MakeSmallestPalindrome(s));
            Console.ReadKey();
        }
    }
}
