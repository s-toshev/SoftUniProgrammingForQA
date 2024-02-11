namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double gradeSum = 0;
            int exclCounter = 0;
            for (int i = 1; i <= 12; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    exclCounter++;
                }

                if (exclCounter > 1)
                {
                    Console.WriteLine($"{name} has been excluded" +
                        $" at {i - 1} grade");
                    break;
                }

                gradeSum += grade;

                if (i == 12)
                {
                    double avgGrade = gradeSum / 12;
                    Console.WriteLine($"{name} graduated. Average " +
                        $"grade: {avgGrade:F2}");
                }
            }

        }
    }
}
