namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string destination = "";
            double savedMoney = 0;

            while (destination != "End")
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double neededMoney = double.Parse(Console.ReadLine());


                while (neededMoney > savedMoney)
                {
                    double inputMoney = double.Parse(Console.ReadLine());
                    savedMoney = savedMoney + inputMoney;

                }

                if (savedMoney >= neededMoney)
                {
                    Console.WriteLine($"Going to {destination}!");
                    savedMoney = 0;
                }

            }




        }
    }
}