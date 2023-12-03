using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FirstNonRepeatingChar
{
    internal class Program
    {

        public static int FirstUniqChar(string s)
        {
            int result = 0;
            Dictionary<string,int> list=new Dictionary<string, int> ();
            for (int i=0;i<s.Length;i++) {
                if (!list.ContainsKey(s[i]+""))
                {
                    list[s[i] + ""] = i;
                }
                else {
                    list.Remove(s[i]+"");
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("dddccdbba"));
            Console.Read();
        }
    }
}
