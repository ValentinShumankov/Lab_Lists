using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = ReadListSingleLine();
            Console.WriteLine(string.Join(" ", SumPairs(nums)));

        }

        static List<int> SumPairs(List<int> nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count / 2; i++)
            {
                result.Add(nums[i] + nums[nums.Count - i - 1]);
            }
            if (nums.Count % 2 == 1)
            {
                result.Add(nums[nums.Count/2]);
            }

            return result;
        }

        static List<int> ReadListSingleLine()
        {
            List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            return numbers;
        }

    }
}
