using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputOne = ReadListSingleLine();
            List<int> inputTwo = ReadListSingleLine();

            Console.WriteLine(string.Join(" ",MergList(inputOne,inputTwo)));
        }

        static List<int> ReadListSingleLine()
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            return numbers;
        }

        static List<int> MergList(List<int> one, List<int> two)
        {
            int largest = Math.Max(one.Count, two.Count);
            List<int> result = new List<int>();
            for (int i = 0; i < largest; i++)
            {
                if (one.Count > i)
                {
                    result.Add(one[i]);
                }
                if (two.Count > i)
                {
                    result.Add(two[i]);
                }

            }
            return result;

        }
    }
}
