namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meal = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            OrderMeal(meal, qty);

        }

        static void OrderMeal(string meal, double qty)
        {
            double price = 0;

            if (meal == "coffee")
            {
                price = 1.50;
            }
            else if (meal == "water")
            {
                price = 1.00;
            }
            else if (meal == "coke")
            {
                price = 1.40;
            }
            else if (meal == "snacks")
            {
                price = 2.00;
            }

            double result = price * qty;
            Console.WriteLine($"{result:F2}");
        }
    }
}