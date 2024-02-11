namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            SortedDictionary<int, int> occurences = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if (occurences.ContainsKey(number))
                {
                    occurences[number] += 1;
                }
                else
                {
                    occurences.Add(number, 1);
                }
            }

            foreach (var item in occurences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}