namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> kvp = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (kvp.ContainsKey(word))
                {
                    kvp[word].Add(synonym);
                }
                else
                {
                    kvp.Add(word, new List<string>() { synonym });
                }
            }

            foreach (var item in kvp)
            {
                Console.WriteLine($"{item.Key} - {String.Join(", ", item.Value)}");
            }

        }
    }
}