namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> kvp = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!kvp.ContainsKey(continent))
                {
                    kvp.Add(continent, new Dictionary<string, List<string>>());

                    //kvp[continent] = new Dictionary<string, List<string>>();
                }

                if (!kvp[continent].ContainsKey(country))
                {
                    kvp[continent].Add(country, new List<string>());

                    // kvp[continent][country] = new List<string>();
                }

                kvp[continent][country].Add(city);
            }



            foreach (var item in kvp)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item2.Key} -> {String.Join(", ", item2.Value)}");
                }
            }

        }
    }
}