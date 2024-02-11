namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(num), GetSumOfOddDigits(num)));

        }

        static int GetSumOfEvenDigits(int num)
        {
            int evenSum = 0;
            int currentNum = 0;
            while (num != 0)
            {
                currentNum = num % 10;

                if (currentNum % 2 == 0)
                {
                    evenSum += Math.Abs(currentNum);
                }
                num = num / 10;
            }

            return evenSum;

        }
        static int GetSumOfOddDigits(int num)
        {
            int oddSum = 0;
            int currentNum = 0;
            while (num != 0)
            {
                currentNum = num % 10;

                if (currentNum % 2 != 0)
                {
                    oddSum += Math.Abs(currentNum);
                }
                num = num / 10;
            }

            return oddSum;

        }

        static int GetMultipleOfEvenAndOdds(int oddSum, int evenSum)
        {
            return Math.Abs(oddSum * evenSum);
        }

    }
}