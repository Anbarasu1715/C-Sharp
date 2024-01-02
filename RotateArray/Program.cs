using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6, 7, 8 },
            new int[] { 9, 10, 11, 12 },
            new int[] { 13, 14, 15, 16 }
        };

            Rotate(arr);
            Console.ReadKey();
        }

        public static void Rotate(int[][] matrix)
        {
            for (int k = 0; k < 2; k++)
            {
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int j = i + 1; j < matrix[i].Length; j++)
                    {
                        int temp = matrix[i][j];
                        matrix[i][j] = matrix[j][i];
                        matrix[j][i] = temp;
                    }
                }


                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int start = 0;
                    int end = matrix[i].Length - 1;
                    while (start < end)
                    {
                        int temp = matrix[i][start];
                        matrix[i][start] = matrix[i][end];
                        matrix[i][end] = temp;
                        start++;
                        end--;
                    }
                }
            }

            foreach (var i in matrix) {
                foreach (var j in i) {
                    Console.Write(j+" " );
                }
                Console.WriteLine();
            }
        }

    }
}
