namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogFood = 2.50;
            int catFood = 4;
            int dfNum = int.Parse(Console.ReadLine());
            int cfNum = int.Parse(Console.ReadLine());
            double dogFoodTotal = dogFood * dfNum;
            int catFoodTotal = catFood * cfNum;
            double totalResult = dogFoodTotal + catFoodTotal;
            Console.WriteLine(totalResult + " lv.");
        }
    }
}
