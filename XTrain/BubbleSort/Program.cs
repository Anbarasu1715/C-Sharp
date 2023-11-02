using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {

        public static int[] sort(int[] arr) {
            int len = arr.Length,temp;
            bool swap;
            for (int i=0; i<len-1;i++) {
                swap = false;
                for (int j=0;j<len-i-1;j++) {
                    if (arr[j]>arr[j+1]) {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swap = true;
                    }
                }
                if (swap==false) {
                    break ;
                }
            }

            return arr;
        }


        static void Main(string[] args)
        {
            int[] arr = {6,3,42,8,4,17,54,28,93,23 };
            sort(arr);
            foreach (int i in arr) {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
