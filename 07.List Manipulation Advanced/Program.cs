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
            List<int> initial = numbers;

            List<int> result = new List<int>();
            List<string> command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                    case "Remove":
                    case "RemoveAt":
                    case "Insert":

                        result = ListManipulator(command, numbers);

                        break;

                    case "Contains":
                    case "PrintEven":
                    case "PrintOdd":
                    case "GetSum":
                    case "Filter":

                        ListManipulationAdvanced(numbers, command);

                        break;

                    default:
                        break;

                }

                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            }

            if (initial.SequenceEqual(numbers))
            {
                Console.WriteLine(string.Join(" ", result));
            }

        }




        static void ListManipulationAdvanced(List<int> numbers, List<string> commandLine)
        {


            switch (commandLine[0])
            {
                case "Contains":
                    bool yes = false;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == int.Parse(commandLine[1]))
                        {
                            yes = true;
                        }

                    }
                    if (yes)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;

                case "PrintEven":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();

                    break;

                case "PrintOdd":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();

                    break;

                case "GetSum":

                    Console.WriteLine(numbers.Sum());

                    break;

                case "Filter":
                    switch (commandLine[1])
                    {
                        case "<":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < int.Parse(commandLine[2]))
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case ">":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > int.Parse(commandLine[2]))
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case ">=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= int.Parse(commandLine[2]))
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case "<=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= int.Parse(commandLine[2]))
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();
                            break;


                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }


        }

        static List<int> ListManipulator(List<string> commandLine, List<int> numbers)
        {

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
