namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            bool isFound = false;
            int combiCounter = 0;
            int d1 = 0;
            int d2 = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {

                    combiCounter++;

                    if ((i + j) == magicNumber)
                    {

                        d1 = i;
                        d2 = j;
                        isFound = true;
                        break;
                    }

                }

                if (isFound)
                {
                    break;
                }

            }

            if (isFound)
            {
                Console.WriteLine($"Combination N:{combiCounter} ({d1} + {d2} = {d1 + d2})");
            }
            else
            {
                Console.WriteLine($"{combiCounter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
