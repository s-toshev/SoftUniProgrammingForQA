namespace _05._Cinema
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

              } */

            string typeOfMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0.0;
            if (typeOfMovie == "Premiere")
            {
                income = rows * columns * 12.00;
                Console.WriteLine($"{income:F2} leva");
            }
            else if (typeOfMovie == "Normal")
            {
                income = rows * columns * 7.50;
                Console.WriteLine($"{income:F2} leva");
            }
            else if (typeOfMovie == "Discount")
            {
                income = rows * columns * 5.00;
                Console.WriteLine($"{income:F2} leva");
            }
        }
    }
}
