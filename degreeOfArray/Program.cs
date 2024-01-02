using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degreeOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 1 };
            Console.WriteLine(FindShortestSubArray(arr));
            Console.Read();
        }

        public static int FindShortestSubArray(int[] nums)
        {
            int num = 0, value = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int n in nums) {
                int count = nums.Count(x=>x==n);
                //int count = arr.Count(x => x == arr[arr.IndexOf(x)]);
                if (num<=count) {
                    num = count;
                    value = n;
                }
            }
            for (int i=0,j=nums.Length-1;i<nums.Length;i++,j--) {                                                
                if (nums[i] == value)
                    return nums.Length - i;
                else if (nums[j] == num)
                    return nums.Length - i;
            }
            return 0;
        }

    }
}
