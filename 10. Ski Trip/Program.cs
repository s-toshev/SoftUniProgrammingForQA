namespace _10._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int daysOfAccomodation = int.Parse(Console.ReadLine());
            string typeOfAccomodation = Console.ReadLine();
            string grade = Console.ReadLine();

            int nightsStay = daysOfAccomodation - 1;
            double priceNoDiscounts = 0.0;
            double finalPrice = 0.0;


            if (typeOfAccomodation == "room for one person")
            {
                double pricePerNight = 18.00;

                if (nightsStay < 10)
                {
                    priceNoDiscounts = pricePerNight * nightsStay;
                    if (grade == "positive")
                    {
                        finalPrice = priceNoDiscounts + (priceNoDiscounts * 0.25);
                    }
                    else if (grade == "negative")
                    {
                        finalPrice = priceNoDiscounts - (priceNoDiscounts * 0.10);
                    }
                }
                else if (nightsStay >= 10 && nightsStay <= 15)
                {
                    priceNoDiscounts = pricePerNight * nightsStay;
                    if (grade == "positive")
                    {
                        finalPrice = priceNoDiscounts + (priceNoDiscounts * 0.25);
                    }
                    else if (grade == "negative")
                    {
                        finalPrice = priceNoDiscounts - (priceNoDiscounts * 0.10);
                    }
                }
                else if (nightsStay > 15)
                {
                    priceNoDiscounts = pricePerNight * nightsStay;
                    if (grade == "positive")
                    {
                        finalPrice = priceNoDiscounts + (priceNoDiscounts * 0.25);
                    }
                    else if (grade == "negative")
                    {
                        finalPrice = priceNoDiscounts - (priceNoDiscounts * 0.10);
                    }
                }
            }
            else if (typeOfAccomodation == "apartment")
            {
                double pricePerNight = 25.00;

                if (nightsStay < 10)
                {
                    priceNoDiscounts = (pricePerNight * nightsStay) - ((pricePerNight * nightsStay) * 0.30);
                    if (grade == "positive")
                    {
                        finalPrice = priceNoDiscounts + (priceNoDiscounts * 0.25);
                    }
                    else if (grade == "negative")
                    {
                        finalPrice = priceNoDiscounts - (priceNoDiscounts * 0.10);
                    }
                }
                else if (nightsStay >= 10 && nightsStay <= 15)
                {
                    priceNoDiscounts = (pricePerNight * nightsStay) - ((pricePerNight * nightsStay) * 0.35);
                    if (grade == "positive")
                    {
                        finalPrice = priceNoDiscounts + (priceNoDiscounts * 0.25);
                    }
                    else if (grade == "negative")
                    {
                        finalPrice = priceNoDiscounts - (priceNoDiscounts * 0.10);
                    }
                }
                else if (nightsStay > 15)
                {
                    priceNoDiscounts = (pricePerNight * nightsStay) - ((pricePerNight * nightsStay) * 0.50);
                    if (grade == "positive")
                    {
                        finalPrice = priceNoDiscounts + (priceNoDiscounts * 0.25);
                    }
                    else if (grade == "negative")
                    {
                        finalPrice = priceNoDiscounts - (priceNoDiscounts * 0.10);
                    }
                }
            }
            else if (typeOfAccomodation == "president apartment")
            {
                double pricePerNight = 35.00;

                if (nightsStay < 10)
                {
                    priceNoDiscounts = (pricePerNight * nightsStay) - ((pricePerNight * nightsStay) * 0.10);
                    if (grade == "positive")
                    {
                        finalPrice = priceNoDiscounts + (priceNoDiscounts * 0.25);
                    }
                    else if (grade == "negative")
                    {
                        finalPrice = priceNoDiscounts - (priceNoDiscounts * 0.10);
                    }
                }
                else if (nightsStay >= 10 && nightsStay <= 15)
                {
                    priceNoDiscounts = (pricePerNight * nightsStay) - ((pricePerNight * nightsStay) * 0.15);
                    if (grade == "positive")
                    {
                        finalPrice = priceNoDiscounts + (priceNoDiscounts * 0.25);
                    }
                    else if (grade == "negative")
                    {
                        finalPrice = priceNoDiscounts - (priceNoDiscounts * 0.10);
                    }
                }
                else if (nightsStay > 15)
                {
                    priceNoDiscounts = (pricePerNight * nightsStay) - ((pricePerNight * nightsStay) * 0.20);
                    if (grade == "positive")
                    {
                        finalPrice = priceNoDiscounts + (priceNoDiscounts * 0.25);
                    }
                    else if (grade == "negative")
                    {
                        finalPrice = priceNoDiscounts - (priceNoDiscounts * 0.10);
                    }
                }
            }

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
