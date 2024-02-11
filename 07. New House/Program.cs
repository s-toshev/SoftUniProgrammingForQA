namespace _07._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
      

            String typeOfFlowers = Console.ReadLine();
            int flowerNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double result = 0.0;
            if (typeOfFlowers == "Roses")
            {
                if (flowerNumber > 80)
                {
                    result = (flowerNumber * 5) - ((flowerNumber * 5) * 0.10);
                }
                else
                {
                    result = flowerNumber * 5;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (flowerNumber > 90)
                {
                    result = (flowerNumber * 3.80) - ((flowerNumber * 3.80) * 0.15);
                }
                else
                {
                    result = flowerNumber * 3.80;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (flowerNumber > 80)
                {
                    result = (flowerNumber * 2.80) - ((flowerNumber * 2.80) * 0.15);
                }
                else
                {
                    result = flowerNumber * 2.80;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (flowerNumber < 120)
                {
                    result = (flowerNumber * 3) + ((flowerNumber * 3) * 0.15);
                }
                else
                {
                    result = flowerNumber * 3;
                }
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                if (flowerNumber < 80)
                {
                    result = (flowerNumber * 2.5) + ((flowerNumber * 2.5) * 0.20);
                }
                else
                {
                    result = flowerNumber * 2.5;
                }
            }
            double leftOverSum = Math.Abs(budget - result);
            if (budget >= result)
            {
                Console.WriteLine($"Hey, you have a great garden " +
                    $"with {flowerNumber} {typeOfFlowers} and " +
                    $"{leftOverSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need " +
                    $"{leftOverSum:F2} leva more.");
            }

        }
    }
}
