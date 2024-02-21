using System.Collections.Generic;
using System.Diagnostics;

namespace _04.Students
{
    public class Run
    {
        static void Main(string[] args)
        {
            int countOfStudent = int.Parse(Console.ReadLine());

            List<Students> list = new List<Students>();

            for (int i = 0; i < countOfStudent; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Students currentStudent = new(firstName, lastName, grade);

                list.Add(currentStudent);

            }


            foreach (Students student in list.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
