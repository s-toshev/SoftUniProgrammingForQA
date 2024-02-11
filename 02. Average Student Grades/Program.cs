using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> kvp = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (kvp.ContainsKey(name))
                {
                    kvp[name].Add(grade);
                }
                else
                {
                    kvp.Add(name, new List<decimal>());
                    kvp[name].Add(grade);
                }

            }

            PrintStudentGrades(kvp);

        }

        static void PrintStudentGrades(Dictionary<string, List<decimal>> kvp)
        {
            foreach (var item in kvp)
            {
                string name = item.Key;
                List<decimal> grades = item.Value;
                decimal average = grades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {average:F2})");

                Console.WriteLine();
            }
        }
    }
}