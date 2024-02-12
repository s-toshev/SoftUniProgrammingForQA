namespace _10._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Dictionary<string, List<string>> kvp =
                new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] data = input.Split(" -> ");
                string company = data[0];
                string empId = data[1];

                if (!kvp.ContainsKey(company))
                {

                    kvp.Add(company, new List<string>());

                }

                if (!kvp[company].Contains(empId))
                {
                    kvp[company].Add(empId);
                }


                input = Console.ReadLine();
            }


            foreach (var item in kvp)
            {
                Console.WriteLine(item.Key);

                foreach (string employeeId in item.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }

        }
    }
}