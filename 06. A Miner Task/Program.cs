namespace _06._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            Dictionary<string, int> kvp = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int qty = int.Parse(Console.ReadLine());

                if (kvp.ContainsKey(resource))
                {
                    kvp[resource] += qty;
                }
                else
                {
                    kvp.Add(resource, qty);
                }

                resource = Console.ReadLine();
            }

            foreach (var item in kvp)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}