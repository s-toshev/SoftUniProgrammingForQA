﻿namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] textArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length % 2 == 0)
                .ToArray();

            foreach (string word in textArr)
            {
                Console.WriteLine(word);
            }

        }
    }
}