namespace taskThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (map.ContainsKey(word))
                {
                    map[word].Add(synonym);
                }
                else
                {
                    map[word] = [synonym];
                }
            }

            foreach(var item in map)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");

            }





        }
    }
}
