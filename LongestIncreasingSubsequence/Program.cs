using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 0, 3, 2, 3 };
            Console.WriteLine(LengthOfLIS(arr));
            Console.ReadLine();
        }

        public static int LengthOfLIS(int[] nums)
        {
            int flag = 0, maxCount = 0;
            List<List<int>> sequences = new List<List<int>>();
            sequences.Add(new List<int> { nums[0] });
            for (int i = 1; i < nums.Length; i++)
            {
                int count = sequences.Count;
                for (int j = 0; j < count; j++)
                {
                    if (sequences[j].Last() < nums[i])
                    {
                        sequences[j].Add(nums[i]);
                        flag = 1;
                    }
                    if (flag == 0)
                    {
                        sequences.Add(new List<int> { nums[i] });
                    }
                    flag = 0;
                }
            }
            for (int i = 0; i < sequences.Count; i++)
            {
                if (maxCount < sequences[i].Count)
                    maxCount = sequences[i].Count;
            }
            return maxCount;
        }
    }
}
