namespace firstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Dictionary<int, int> kvp = new Dictionary<int, int>();

            foreach (int num in list)
            {
                if (kvp.ContainsKey(num))
                {
                    kvp[num] += 1;
                }
                else
                {
                    kvp.Add(num, 1);
                }
            }

            kvp = kvp.OrderBy(x => x.Key).ToDictionary();

            foreach(var item in kvp)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
