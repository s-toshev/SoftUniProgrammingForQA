namespace _06._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int num = int.Parse(Console.ReadLine());
              bool isValid = num == 0 || num >=100 & num <=200;

              if(!isValid)
              {
                  Console.WriteLine("invalid");

              } 

              string typeOfMovie = Console.ReadLine();
              int rows = int.Parse(Console.ReadLine());
              int columns = int.Parse(Console.ReadLine());
              double income = 0.0;
              if(typeOfMovie == "Premiere")
              {
                  income = rows * columns * 12.00;
                  Console.WriteLine($"{income:F2} leva");
              }else if (typeOfMovie == "Normal")
              {
                  income = rows * columns * 7.50;
                  Console.WriteLine($"{income:F2} leva");
              }else if(typeOfMovie == "Discount")
              {
                  income = rows * columns * 5.00;
                  Console.WriteLine($"{income:F2} leva");
              }

              */

            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (timeOfDay == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    Console.WriteLine($"It's {degrees} degrees, get your" +
                        $" {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your" +
                        $" {outfit} and {shoes}.");
                }
                else if (degrees >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your" +
                        $" {outfit} and {shoes}.");
                }
            }
            else if (timeOfDay == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your" +
                        $" {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your" +
                        $" {outfit} and {shoes}.");
                }
                else if (degrees >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine($"It's {degrees} degrees, get your" +
                        $" {outfit} and {shoes}.");
                }
            }
            else if (timeOfDay == "Evening")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your" +
                        $" {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your" +
                        $" {outfit} and {shoes}.");
                }
                else if (degrees >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your" +
                        $" {outfit} and {shoes}.");
                }
            }


        }
    }
}
