using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateFromTheSortedArray
{
    class Program
    {

        public static int RemoveDuplicates(int[] nums)
        {
            List<int> list = new List<int>();
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!(list.Contains(nums[i])))
                {
                    list.Add(nums[i]);
                    Console.WriteLine(list[index++]);
                }
            }
            return list.Count();
        }

        static void Main(string[] args)
        {
            int[] arr = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(arr));
            Console.ReadLine();
        }
    }
}
