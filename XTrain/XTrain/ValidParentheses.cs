using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTrain
{
    class ValidParentheses
    {
        public static void validity() {
            int countForAdd = 0,countForRemove=0,index=-1;
            List<char> sc = new List<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add(')','(');
            dict.Add(']', '[');
            dict.Add('}', '{');
            Console.Write("Enter the Input:");
            String input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("i================" + i);
                //Console.WriteLine(dict['']);
                try
                {
                    if (sc.Contains(dict[input[i]]))
                    {
                        Console.WriteLine("Hello");
                        do
                        {
                            Console.WriteLine("input at eq ==" + sc[index] + "index==" + index + "  i==" + i);
                            sc.RemoveAt(index);
                            countForRemove++;
                            Console.WriteLine("cr=" + countForRemove);
                        } while ((sc.Count==0)?sc.Count!=0:dict[input[i]] != input[index--]);
                        index=index+((sc.Count == 0) ? -1 : 0);
                        Console.WriteLine("index=="+index);
                        Console.WriteLine("-----list-----" + sc.Count);
                        for (int k = 0; k < sc.Count; k++)
                        {
                            Console.Write("hi  " + sc[k] + "  ");
                        }
                    }
                    else
                    {
                        sc.Add(input[i]);
                        countForAdd++;
                        index++;
                        Console.WriteLine("input=" + input[i] + "   c=" + countForAdd);
                        Console.WriteLine("-----list        in c-----" + sc.Count);
                        for (int k = 0; k < sc.Count; k++)
                        {
                            Console.Write("hello  " + sc[k] + "  ");
                        }
                    }
                
                }
                catch
                {
                    {
                        sc.Add(input[i]);
                        countForAdd++;
                        index++;
                        Console.WriteLine("input=" + input[i] + "   c=" + countForAdd);
                        Console.WriteLine("-----list        in c-----" + sc.Count);
                        for (int k = 0; k < sc.Count; k++)
                        {
                            Console.Write("hello  " + sc[k] + "  ");
                        }
                    }
                }
            }
            if (countForAdd == countForRemove)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
