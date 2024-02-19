namespace taskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ").Select(s => s.ToLower()).ToArray();

            Dictionary<string, int> kvp = new Dictionary<string, int>();

            foreach (string s in strings)
            {
                if (kvp.ContainsKey(s))
                {
                    kvp[s] += 1;
                }
                else
                {
                    kvp.Add(s, 1);
                }

            }

            foreach (var item in kvp)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}