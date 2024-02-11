namespace _09._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeOfAccomodation = "";
            double budgedUsed = 0.0;
            if (season == "summer")
            {
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    typeOfAccomodation = "Camp";
                    budgedUsed = budget * 0.30;
                }
                else if (budget <= 1000)
                {
                    destination = "Balkans";
                    typeOfAccomodation = "Camp";
                    budgedUsed = budget * 0.40;
                }
                else if (budget > 1000)
                {
                    destination = "Europe";
                    typeOfAccomodation = "Hotel";
                    budgedUsed = budget * 0.90;
                }
            }
            else if (season == "winter")
            {
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    typeOfAccomodation = "Hotel";
                    budgedUsed = budget * 0.70;
                }
                else if (budget <= 1000)
                {
                    destination = "Balkans";
                    typeOfAccomodation = "Hotel";
                    budgedUsed = budget * 0.80;
                }
                else if (budget > 1000)
                {
                    destination = "Europe";
                    typeOfAccomodation = "Hotel";
                    budgedUsed = budget * 0.90;
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfAccomodation} - {budgedUsed:F2}");
        }
    }
}
