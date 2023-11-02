using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class Program
    {


        public static void findCombination(int index,int amt,int[] coins,List<List<int>> AllCombinations,List<int> Combination) {
            if (amt==0) {
                AllCombinations.Add(new List<int>(Combination));
                return;
            }
            for (int i=index;i<coins.Length;i++) {
                if (amt >= coins[i])
                {
                    Combination.Add(coins[i]);
                    findCombination(i,amt - coins[i], coins, AllCombinations, Combination);
                    Combination.RemoveAt(Combination.Count - 1);
                }
            }
        }

        public static List<List<int>> combinations(int[] arr, int amt)
        {
            List<List<int>> AllCombinations = new List<List<int>>();
            List<int> Combination = new List<int>();
            findCombination(0,amt, arr, AllCombinations, Combination);
            return AllCombinations;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter no of Coins:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Available Coins:");
                int[] coins = new int[n];
                for (int i = 0; i < n; i++)
                {
                    coins[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Enter the Total:");
                int amt = int.Parse(Console.ReadLine());
                if (amt > 0)
                {
                    Array.Sort(coins);
                    List<List<int>> output = combinations(coins, amt);
                    foreach (var i in output)
                    {
                        foreach (var j in i)
                        {
                            Console.Write(j + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("----------------------------------------------------------");
                }
                else {
                    Console.WriteLine("No Combinations for the given Value.....");
                }
            }
            Console.ReadKey();
        }
    }
}
