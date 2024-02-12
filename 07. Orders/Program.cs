namespace _07._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<double>> kvp = new Dictionary<string, List<double>>();

            while (input != "buy")
            {
                string[] data = input.Split(" ");
                string product = data[0];
                double price = double.Parse(data[1]);
                double qty = double.Parse(data[2]);

                if (!kvp.ContainsKey(product))
                {
                    kvp.Add(product, new List<double>());
                    kvp[product].Add(price);
                    kvp[product].Add(qty);
                }
                else
                {
                    kvp[product][0] = (price);
                    kvp[product][1] += (qty);
                }


                input = Console.ReadLine();
            }

            foreach (var item in kvp)
            {
                string product = item.Key;
                double price = item.Value[0];
                double qty = item.Value[1];
                double amount = price * qty;

                Console.WriteLine($"{product} -> {amount:F2}");
            }

        }
    }
}