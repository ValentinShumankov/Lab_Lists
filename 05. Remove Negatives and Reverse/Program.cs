using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveNegativAndReverse();
        }

        /// <summary>
        /// Removes all negative numbers,the rest is printed reversed.
        /// </summary>
        static void RemoveNegativAndReverse()
        {
            List<int> result = new List<int>();
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
           
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > 0)
                {
                    result.Add(input[i]);

                }
            }
          
            result.Reverse();
           
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
