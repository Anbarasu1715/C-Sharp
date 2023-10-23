using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTrain
{
    class RomanToInteger
    {
        public static void FindInt()
        {
            Console.WriteLine("Enter the Roman Number");
            String s = (Console.ReadLine()).ToUpper();
            //Console.WriteLine(s);
            Dictionary<String, int> romanList = new Dictionary<String, int>();
            romanList.Add("I", 1);
            romanList.Add("V", 5);
            romanList.Add("X", 10);
            romanList.Add("L", 50);
            romanList.Add("C", 100);
            romanList.Add("D", 500);
            romanList.Add("M", 1000);
            int output = 0, flag = 0, res;
            string sub = "";
            int len = s.Length, index;
            for (int i = 0; i < len; i++)
            {
                index = i;
                while (romanList[s[index] + ""] < romanList[s[(index != len - 1) ? index + 1 : index] + ""])
                {
                    sub += s[index];
                    flag = 1;
                    index++;
                }
                if (flag == 1)
                {
                    sub += s[index];
                    //Console.WriteLine("sub=" + sub);
                    res = romanList[sub[0] + ""];
                    //Console.WriteLine("res==" + res + "");
                    for (int j = sub.Length - 1; j > 0; j--)
                    {
                        res -= romanList[sub[j] + ""];
                        res = Math.Abs(res);
                    }
                    flag = 0;
                }
                else
                {
                    res = romanList[s[i] + ""];
                    //Console.WriteLine("rl==" + s[i] + "  res====" + res);
                }
                //Console.WriteLine(res);
                output += res;
                //Console.WriteLine("output==" + output + "\n");
                sub = "";
                i = index;

            }
            Console.WriteLine("\nNumber == "+output);
            //Console.ReadLine();
        }
    }
}
