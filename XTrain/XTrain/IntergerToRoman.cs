using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTrain
{
    class IntergerToRoman
    {
        static Dictionary<int, char> dict = new Dictionary<int, char>();
        public static void FindRoman() {
            dict.Add(1,'I');
            dict.Add(5,'V');
            dict.Add(10,'X');
            dict.Add(50,'L');
            dict.Add(100,'C');
            dict.Add(500,'D');
            dict.Add(1000,'M');
            Console.Write("Enter the Number to Convert into Roman:");
            int n = int.Parse(Console.ReadLine());
                
        }
    }
}
