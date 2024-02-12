namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> kvp = new Dictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string[] input = command.Split(", ");

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (kvp.ContainsKey(shop))
                {
                    kvp[shop].Add(product, price);
                }
                else
                {
                    kvp.Add(shop, new Dictionary<string, double>());
                    kvp[shop].Add(product, price);
                }

                command = Console.ReadLine();
            }


            var sortedDictionary = kvp.OrderBy(kvp => kvp.Key)
                .ToDictionary(key => key.Key, key => key.Value);



            foreach (var item in sortedDictionary)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var subItem in item.Value)
                {
                    Console.WriteLine($"Product: {subItem.Key}, Price: {subItem.Value}");
                }
            }


        }
    }
}