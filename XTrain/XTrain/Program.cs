using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do {
                Console.WriteLine("\n-----Welcome-----\n1.LoopPatterns\n2.Arrays\n3.Roman To Integer\n4.Integer to Roman\n5.ValidParentheses\n6.3Sum\n7.Lamda Expressions");
                choice = int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        Loops.patterns();
                        break;
                    case 2:
                        break;
                    case 3:
                        RomanToInteger.FindInt();
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        ValidParentheses.validity();
                        break;
                    case 6:
                        _3sum.checkSum();
                        break;
                    case 67:
                        LamdaExpressions.practice();
                        break;
                }
            } while (choice<8);

            Console.ReadKey();
        }
    }
}