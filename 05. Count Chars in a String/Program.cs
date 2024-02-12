namespace _05._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    continue;
                }

                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map.Add(c, 1);
                }
            }


            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}