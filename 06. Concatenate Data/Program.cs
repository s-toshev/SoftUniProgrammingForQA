﻿namespace _06._Concatenate_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string familyName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {name} {familyName}, a" +
                $" {age}-years old person" +
                $" from {town}.");

        }
    }
}
