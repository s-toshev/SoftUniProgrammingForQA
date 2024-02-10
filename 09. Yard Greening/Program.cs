namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sqMtoBeGreened = double.Parse(Console.ReadLine());
            double singleSqMprice = 7.61;

            double priceWithoutDiscount = sqMtoBeGreened * singleSqMprice;
            double finalPrice = priceWithoutDiscount - (priceWithoutDiscount * 0.18);
            double priceWithDiscount = priceWithoutDiscount - finalPrice;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {priceWithDiscount} lv.");

        }
    }
}
