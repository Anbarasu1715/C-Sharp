using System;

namespace LeetCodeProblems
{
    internal class BuySellStock
    {

        public static int MaxProfit(int[] prices)
        {
            int buy = prices[0], sell = buy, result = 0,flag=0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (buy > prices[i] && flag==0) {
                    buy = prices[i];
                    sell = buy;
                    Console.WriteLine(buy);
                }
                else if (sell < prices[i]) { 
                    sell= prices[i];
                    flag = 1;
                }
            }
            result = sell - buy;
            return result;
        }

        static void Main()
        {
            int[] arr = { 2,4,1 };
            Console.WriteLine(MaxProfit(arr));
            Console.Read();
        }
    }
}
