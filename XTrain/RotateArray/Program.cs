using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {

        public static void Rotate(int[] nums, int k)
        {
            int len = nums.Length;
            if (len > 1)
            {
                
                int[] arr1 = new int[len - k];
                int[] arr2 = new int[k];
                Array.Copy(nums, 0, arr1, 0, len - k);
                Array.Copy(nums, len - k, arr2, 0, k);
                Console.WriteLine(nums.GetLowerBound(0));
                /*Array.Reverse(arr1);
                Array.Reverse(srr2);*/
                int index = 0;
                foreach (int i in arr2)
                {
                    nums[index++] = i;
                    Console.WriteLine(i);
                }
                foreach (int i in arr1)
                {
                    nums[index++] = i;
                    Console.WriteLine(i);
                }
            }

        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int k =3;
            Rotate(a,k);
            Console.Read();
        }
    }
}
