namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string input;
            double total = 0.0;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double insertMoney = double.Parse(input);
                if (insertMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += insertMoney;
                Console.WriteLine($"Increase: {insertMoney:F2}");
            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}