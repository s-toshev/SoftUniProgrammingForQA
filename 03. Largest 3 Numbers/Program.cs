namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToArray();

            int[] sortedArr = numbers.OrderByDescending(x => x).ToArray();


            if (sortedArr.Length == 1)
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.Write(sortedArr[i] + " ");
                }
            }

            if (sortedArr.Length == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(sortedArr[i] + " ");
                }
            }

            if (sortedArr.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sortedArr[i] + " ");
                }
            }

        }
    }
}