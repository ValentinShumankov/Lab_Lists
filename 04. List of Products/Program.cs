using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
             ProductSort();
           
        }

        static void ProductSort()
        {
            int num = int.Parse(Console.ReadLine());
            List<string> inputs = new List<string>();
            for (int i = 0; i < num; i++)
            {
                inputs.Add(Console.ReadLine());
            }

            inputs.Sort();

            for (int j = 0; j < num; j++)
            {
                Console.WriteLine($"{j+1}.{inputs[j]}");
            }
        }
    }
}
