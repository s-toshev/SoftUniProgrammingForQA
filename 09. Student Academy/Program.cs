namespace _09._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> kvp = new Dictionary<string, List<double>>();

            for (int i = 0; i < rows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!kvp.ContainsKey(name))
                {
                    kvp.Add(name, new List<double>());
                    kvp[name].Add(grade);
                }
                else
                {
                    kvp[name].Add(grade);
                }

            }

            foreach (var item in kvp)
            {
                string student = item.Key;
                double avgGrade = item.Value.Average();

                if (avgGrade >= 4.50)
                {
                    Console.WriteLine($"{student} -> {avgGrade:f2}");

                }
            }
        }
    }
}