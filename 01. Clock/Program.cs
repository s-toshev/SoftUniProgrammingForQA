namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        for (int i = 0; i <=23; i++)
                        {
                            for (int j = 0; j <=59; j++)
                            {
                                Console.WriteLine($"{i}:{j}");
                            }
                        }


            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.WriteLine($"{i} * {j} = {result}"); 
                }

            }



            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool foundCombination = false;
            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    counter++;
                    if ((i + j) == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} " +
                            $"({i} + {j} = " +
                            $"{magicNum})");
                        foundCombination = true;
                        break;

                    }

                }
                if (foundCombination)
                {
                    break;
                }
            }

            if (!foundCombination)
            {
                Console.WriteLine($"{counter} combinations - neither" +
                    $" equals {magicNum}");
            }


            string destination;

            while ((destination = Console.ReadLine()) != "End")
            {
                int totalSavings = 0;
                int savings = int.Parse(Console.ReadLine());

                while (totalSavings < savings)
                {
                    totalSavings += int.Parse(Console.ReadLine());

                }

                Console.WriteLine($"Going to {destination}!");
            }*/

            /*
            
            string destination = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            double amount = 0;
            double budget = 0;
            while (destination != "End")
            {
                while (budget < price)
                {
                    amount = double.Parse(Console.ReadLine());
                    budget += amount;
                }
                Console.WriteLine("Going to {0}!", destination);
                destination = Console.ReadLine();
                if (destination != "End")
                {
                    price = double.Parse(Console.ReadLine());
                    budget = 0;
                }
                else
                {
                    break;
                }
            }




            // mysolution:

            String destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double totalSavings = 0;
                while (totalSavings < budget)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    totalSavings = totalSavings + savedMoney;
                }

                if (totalSavings >= budget)
                {
                    Console.WriteLine($"Going to {destination}!");
                }
                else
                {
                    break;
                }

                destination = Console.ReadLine();
            }*/

            //int floors = int.Parse(Console.ReadLine());
            //int rooms = int.Parse(Console.ReadLine());

            //for (int i = floors; i > 0; i--)
            //{
            //    for (int j = rooms-1; j >= 0; j--)
            //    {
            //        Console.Write($"{i}{j} ");
            //        Console.WriteLine("");
            //    }
            //}

            for (int i = 0; i <= 23; i++)
            {
                for (int j = 0; j <= 59; j++)
                {
                    Console.WriteLine($"{i}:{j}");
                }
            }

        }
    }
}
