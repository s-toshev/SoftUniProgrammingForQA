namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubles = Console.ReadLine().Split(" ")
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> kvp = new Dictionary<double, int>();


            foreach (double num in doubles)
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


            foreach (var item in kvp)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }


        }
    }
}