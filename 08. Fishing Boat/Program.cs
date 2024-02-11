namespace _08._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double numOfFishermen = double.Parse(Console.ReadLine());
            double result = 0.0;
            double priceForBoatRent = 0;

            if (season == "Spring")
            {
                priceForBoatRent = 3000;
                if (numOfFishermen <= 6)
                {
                    result = priceForBoatRent - (priceForBoatRent * 0.10);
                    if (numOfFishermen % 2 == 0)
                    {
                        result = result - (result * 0.05);
                    }
                }
                if (numOfFishermen >= 7 && numOfFishermen <= 11)
                {
                    result = priceForBoatRent - (priceForBoatRent * 0.15);
                    if (numOfFishermen % 2 == 0)
                    {
                        result = result - (result * 0.05);
                    }
                }
                if (numOfFishermen >= 12)
                {
                    result = (priceForBoatRent - (priceForBoatRent * 0.20));
                    if (numOfFishermen % 2 == 0)
                    {
                        result = result - (result * 0.05);
                    }
                }
            }
            else if (season == "Summer")
            {
                priceForBoatRent = 4200;
                if (numOfFishermen <= 6)
                {
                    result = priceForBoatRent - (priceForBoatRent * 0.10);
                    if (numOfFishermen % 2 == 0)
                    {
                        result = result - (result * 0.05);
                    }
                }
                if (numOfFishermen >= 7 && numOfFishermen <= 11)
                {
                    result = priceForBoatRent - (priceForBoatRent * 0.15);
                    if (numOfFishermen % 2 == 0)
                    {
                        result = result - (result * 0.05);
                    }
                }
                if (numOfFishermen >= 12)
                {
                    result = (priceForBoatRent - (priceForBoatRent * 0.25));
                    if (numOfFishermen % 2 == 0)
                    {
                        result = result - (result * 0.05);
                    }
                }
            }
            else if (season == "Autumn")
            {
                priceForBoatRent = 4200;
                if (numOfFishermen <= 6)
                {
                    result = priceForBoatRent - (priceForBoatRent * 0.10);

                }
                if (numOfFishermen >= 7 && numOfFishermen <= 11)
                {
                    result = priceForBoatRent - (priceForBoatRent * 0.15);

                }
                if (numOfFishermen >= 12)
                {
                    result = (priceForBoatRent - (priceForBoatRent * 0.25));

                }
            }
            else if (season == "Winter")
            {
                priceForBoatRent = 2600;
                if (numOfFishermen <= 6)
                {
                    result = priceForBoatRent - (priceForBoatRent * 0.10);
                    if (numOfFishermen % 2 == 0)
                    {
                        result = result - (result * 0.05);
                    }
                }
                if (numOfFishermen >= 7 && numOfFishermen <= 11)
                {
                    result = priceForBoatRent - (priceForBoatRent * 0.15);
                    if (numOfFishermen % 2 == 0)
                    {
                        result = result - (result * 0.05);
                    }
                }
                if (numOfFishermen >= 12)
                {
                    result = (priceForBoatRent - (priceForBoatRent * 0.25));
                    if (numOfFishermen % 2 == 0)
                    {
                        result = result - (result * 0.05);
                    }
                }
            }





            double leftOverSum = Math.Abs(budget - result);
            if (budget >= result)
            {
                Console.WriteLine($"Yes! You have {leftOverSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You" +
                    $" need {leftOverSum:F2} leva.");
            }

        }
    }
}