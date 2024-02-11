namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            int nNumbers = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            for (int i = 1; i <= nNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber;
                }

                if (currentNumber < minNum)
                {
                    minNum = currentNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
