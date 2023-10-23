using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTrain
{
    class Loops
    {
        public static void patterns() {

            Console.WriteLine("-----Diamond Pattern-----\n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i * 2; k >= 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("-----Pattern A-----\n");

            for (int i = 0; i < 7; i++)
            {
                Console.Write((i != 0) ? "     *" : "      ");
                if (i == 0 || i == 3)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("   ");
                }
                Console.WriteLine((i != 0) ? "*" : "");
            }

            Console.WriteLine("\n-----Pattern B-----\n");

            for (int i = 0; i < 7; i++)
            {
                Console.Write("     *");
                if (i == 3 || i == 0 || i == 6)
                {
                    Console.Write("***");
                }
                else
                    Console.Write("   *");
                Console.WriteLine();
            }
        }

    }
}
