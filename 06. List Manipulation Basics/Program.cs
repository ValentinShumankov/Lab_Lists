using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadListSingleLine();
            
            List<int> result = new List<int>();
            while(true)
            {
                string command = Console.ReadLine();
                if(command == "end")
                {
                    break;
                }
                result = ListManipulator(command,numbers);
            }
            
            Console.WriteLine(string.Join(" ",result));

        }



        static List<int> ListManipulator(string command,List<int> numbers)
        {
           string[] commandLine = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            

            switch (commandLine[0])
            {
                case "Add":
                    int numberToAdd = int.Parse(commandLine[1]);
                    numbers.Add(numberToAdd);
                    break;
                case "Remove":
                    int numberToRemove = int.Parse(commandLine[1]);
                    numbers.Remove(numberToRemove);

                    break;
                case "RemoveAt":
                    int numberToRemoveAtIndex = int.Parse(commandLine[1]);
                    numbers.RemoveAt(numberToRemoveAtIndex);
                    break;
                case "Insert":
                    int numberToInsert = int.Parse(commandLine[1]);
                    int indexToInsert = int.Parse(commandLine[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    break;
                default: 
                    break;
            }
            return numbers;
        }


        static List<int> ReadListSingleLine()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            return numbers;
        }
    }
}
